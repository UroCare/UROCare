// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using SHC.UROCare.Utilities;

namespace MigrateData
{
    /// <summary>
    /// Helper class having all the functions to migrate access database to sql server.
    /// </summary>
    public class DataMigrationHelper
    {
        #region Private fields

        private const string _tableName = "TABLE_NAME";
        private const int _batchSize = 25;
        private const string _tableColulmnName = "TABLE";
        private readonly Action<string> _messageAction;
        private OleDbConnection _accessDataConnection = new OleDbConnection();
        private SqlConnection _sqlServerConnection;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor to create the instance.
        /// </summary>
        /// <param name="messageAction">Action delegate for message passing.</param>
        public DataMigrationHelper(Action<string> messageAction)
        {
            _messageAction = messageAction;
        }

        #endregion

        /// <summary>
        /// Selected SQL server.
        /// </summary>
        public string SelectedServer { get; set; }

        /// <summary>
        /// Selected source file.
        /// </summary>
        public string SelectedAccessFile { get; set; }

        /// <summary>
        /// Cleans up the resource.
        /// </summary>
        public void Cleanup()
        {
            if (null != _sqlServerConnection)
            {
                _sqlServerConnection.Close();
            }
            if (null != _accessDataConnection)
            {
                _accessDataConnection.Close();
            }
        }

        /// <summary>
        /// Gets sql server instances.
        /// </summary>
        public IList<string> GetSqlServers()
        {
            DataTable data = SqlDataSourceEnumerator.Instance.GetDataSources();
            List<string> stringList =
                (from DataRow dataRow in data.Rows select String.Format("{0}\\{1}", dataRow[0], dataRow[1])).ToList();

            if (stringList.Count == 0)
            {
                ExceptionManager.Throw(new InvalidOperationException(Strings.SqlServerInstancesNotFound));
            }
            return stringList;
        }

        /// <summary>
        /// Performs actual migration of data.
        /// </summary>
        public void MigrateData(bool createScriptFromDatabase = true)
        {
            if (SelectedAccessFile.Length == 0 || SelectedServer.Length == 0)
            {
                ExceptionManager.Throw(new InvalidOperationException(Strings.InvalidSourceErrorMessage));
            }
            string databaseName = ConfigurationManager.AppSettings["DatabaseName"];
            using (_sqlServerConnection = GetConnection<SqlConnection>(GetSqlServerConnectionString()))
            {
                try
                {
                    CreateSqlServerDatabase(databaseName);
                    _accessDataConnection = GetConnection<OleDbConnection>(GetAccessDatabaseConnectionString());
                    _sqlServerConnection.ChangeDatabase(databaseName);

                    string scriptToExecute = createScriptFromDatabase
                                                 ? CreateTableScript()
                                                 : Strings.CreateDatabaseScript;
                    ExecuteScript(scriptToExecute, createScriptFromDatabase ? ";" : "GO");

                    using (IDbTransaction transaction = _sqlServerConnection.BeginTransaction())
                    {
                        TransferDataToSqlServer((SqlTransaction) transaction);
                        transaction.Commit();
                    }
                }
                catch (SqlException exception)
                {
                    ExceptionManager.Throw(exception);
                }
            }

            try
            {
                if (createScriptFromDatabase)
                {
                    using (_sqlServerConnection = GetConnection<SqlConnection>(GetSqlServerConnectionString()))
                    {
                        _sqlServerConnection.ChangeDatabase(databaseName);
                        ExecuteScript(CreatePrimaryKeysScript(), ";");
                        ExecuteScript(CreateForeignKeyScript(), ";");
                    }
                }
            }
            catch (SqlException exception)
            {
                ExceptionManager.Throw(exception);
            }
            ShowMessage(string.Format(Strings.DataMigrationSuccessFull, SelectedServer, databaseName));
        }

        private void ExecuteScript(string keyScript, string delimiter)
        {
            var exceptionMessage = new StringBuilder();
            using (IDbTransaction transaction = _sqlServerConnection.BeginTransaction())
            {
                string[] constraintArray = keyScript.Split(new[] {delimiter}, StringSplitOptions.RemoveEmptyEntries);
                Array.ForEach(constraintArray, item =>
                                                   {
                                                       IDbCommand command = _sqlServerConnection.CreateCommand();
                                                       command.CommandText = item;
                                                       command.Transaction = transaction;
                                                       try
                                                       {
                                                           command.ExecuteNonQuery();
                                                       }
                                                       catch (Exception exception)
                                                       {
                                                           exceptionMessage.Append(exception.Message);
                                                       }
                                                   });
                transaction.Commit();
            }
        }

        /// <summary>
        /// Creates primary key script.
        /// </summary>
        /// <returns>Script to add primary keys to database.</returns>
        private string CreatePrimaryKeysScript()
        {
            DataTable tablePrimaryKeys = _accessDataConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys,
                                                                                   null);
            if (tablePrimaryKeys == null)
            {
                return string.Empty;
            }
            var primaryKeyString = new StringBuilder();
            string currentTableName = string.Empty;
            const string query = "ALTER TABLE {0} ADD  CONSTRAINT [{1}] PRIMARY KEY CLUSTERED (";
            const string column = "[{0}] ASC,";
            Action<string> stringAction =
                tableName =>
                primaryKeyString.Append(string.Format(query, tableName, string.Format("{0}_$primarykey", tableName)));

            foreach (DataRow row in tablePrimaryKeys.Rows)
            {
                string tableName = row[_tableName].ToString();
                if (currentTableName.Length == 0)
                {
                    currentTableName = tableName;
                    stringAction(currentTableName);
                }
                if (!currentTableName.Equals(tableName))
                {
                    primaryKeyString.Remove(primaryKeyString.Length - 1, 1);
                    primaryKeyString.Append(");");

                    currentTableName = tableName;
                    stringAction(currentTableName);
                }
                primaryKeyString.Append(string.Format(column, row["COLUMN_NAME"]));
            }

            primaryKeyString.Remove(primaryKeyString.Length - 1, 1);
            primaryKeyString.Append(");");

            return primaryKeyString.ToString();
        }

        public string CreateForeignKeyScript()
        {
            DataTable tableForeignKeys = _accessDataConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Foreign_Keys, null);
            if (tableForeignKeys == null)
            {
                return string.Empty;
            }

            var foreignKeyInformation = new List<ForeignKey>();
            const string foreignKeyTableNameColumn = "FK_TABLE_NAME";
            const string foreignKeyColumnName = "FK_COLUMN_NAME";
            const string primaryKeyTableNameColumn = "PK_TABLE_NAME";
            const string primaryKeyColumnName = "PK_COLUMN_NAME";
            const string foreignKeyName = "FK_NAME";
            string name = string.Empty;
            ForeignKey foreignKey = null;
            foreach (DataRow row in tableForeignKeys.Rows)
            {
                string currentForeignKeyName = row[foreignKeyName].ToString();
                if (name != currentForeignKeyName)
                {
                    foreignKey = new ForeignKey {Name = currentForeignKeyName};
                    name = currentForeignKeyName;
                    foreignKeyInformation.Add(foreignKey);
                }
                if (null != foreignKey)
                {
                    string foreignKeyTable = row[foreignKeyTableNameColumn].ToString();
                    string foreignKeyColumn = row[foreignKeyColumnName].ToString();
                    string primaryKeyTable = row[primaryKeyTableNameColumn].ToString();
                    string primaryKeyColumn = row[primaryKeyColumnName].ToString();
                    if (!foreignKey.ForeignKeyColumns.ContainsKey(foreignKeyTable))
                    {
                        foreignKey.ForeignKeyColumns.Add(foreignKeyTable, new List<string>());
                    }
                    if (!foreignKey.References.ContainsKey(primaryKeyTable))
                    {
                        foreignKey.References.Add(primaryKeyTable, new List<string>());
                    }
                    foreignKey.ForeignKeyColumns[foreignKeyTable].Add(foreignKeyColumn);
                    foreignKey.References[primaryKeyTable].Add(primaryKeyColumn);
                }
            }

            const string queryConstant = "ALTER TABLE {0} ADD  CONSTRAINT [{1}] FOREIGN KEY (";
            var foreignKeyScript = new StringBuilder();
            foreach (ForeignKey key in foreignKeyInformation)
            {
                var foreignKeyString = new StringBuilder();
                string tableName = string.Empty;
                foreach (var foreignKeyInfo in key.ForeignKeyColumns)
                {
                    tableName = foreignKeyInfo.Key;
                    foreignKeyInfo.Value.ForEach(x => foreignKeyString.Append(string.Format("{0},", x)));
                }
                foreignKeyString = foreignKeyString.Remove(foreignKeyString.Length - 1, 1);
                foreignKeyString.Append(") ");
                const string referencesKey = "References {0}(";
                var references = new StringBuilder();
                string referenceTable = string.Empty;
                foreach (var referenceTableInfo in key.References)
                {
                    referenceTable = referenceTableInfo.Key;
                    referenceTableInfo.Value.ForEach(x => references.Append(string.Format("{0},", x)));
                }
                references = references.Remove(references.Length - 1, 1);
                references.Append(");");
                var referencesKeyScript = new StringBuilder();
                referencesKeyScript.Append(string.Format(referencesKey, referenceTable));
                referencesKeyScript.Append(references.ToString());
                foreignKeyScript.Append(string.Format(queryConstant, tableName, key.Name));
                foreignKeyScript.Append(foreignKeyString);
                foreignKeyScript.Append(referencesKeyScript);
            }

            return foreignKeyScript.ToString();
        }

        #region Private methods

        /// <summary>
        /// Creates script to create the table.
        /// </summary>
        /// <returns>Create table string.</returns>
        private string CreateTableScript()
        {
            DataTable tableColumns = (_accessDataConnection).GetOleDbSchemaTable(OleDbSchemaGuid.Columns, null);
            string currentTableName = String.Empty;
            const string createTableConstant = "CREATE TABLE {0}(";
            const string columnName = "COLUMN_NAME";
            var createTableScript = new StringBuilder();
            Action<StringBuilder> endCreateString = tableScript =>
                                                        {
                                                            createTableScript =
                                                                tableScript.Remove(tableScript.Length - 1, 1);
                                                            createTableScript.Append(");");
                                                        };

            if (tableColumns != null)
            {
                foreach (DataRow row in tableColumns.Rows)
                {
                    if (currentTableName.Length == 0)
                    {
                        currentTableName = row[_tableName].ToString();
                        createTableScript.Append(String.Format(createTableConstant, currentTableName));
                    }
                    if (currentTableName.Length > 0 &&
                        !currentTableName.Equals(row[_tableName].ToString(), StringComparison.InvariantCultureIgnoreCase))
                    {
                        endCreateString(createTableScript);
                        currentTableName = row[_tableName].ToString();
                        createTableScript.Append(String.Format(createTableConstant, currentTableName));
                    }
                    createTableScript.Append(String.Format("{0} {1},", row[columnName], GetColumnString(row)));
                }
            }
            endCreateString(createTableScript);
            return createTableScript.ToString();
        }

        /// <summary>
        /// Transfers data to sql server.
        /// </summary>
        /// <param name="transaction">Transaction instance</param>
        private void TransferDataToSqlServer(SqlTransaction transaction)
        {
            DataTable table = _accessDataConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            if (table == null)
            {
                ShowMessage(Strings.NoTablesFound);
                return;
            }
            foreach (DataRow dataTableRow in table.Rows)
            {
                if (!_tableColulmnName.Equals(dataTableRow["TABLE_TYPE"].ToString(),
                                              StringComparison.InvariantCultureIgnoreCase))
                {
                    continue;
                }

                string tableName = dataTableRow[_tableName].ToString();
                string selectStatement = string.Format(Strings.SelectString, tableName);
                IDbCommand accesssCommand = _accessDataConnection.CreateCommand();
                accesssCommand.CommandText = selectStatement;
                using (IDataReader reader = accesssCommand.ExecuteReader())
                {
                    using (
                        var sqlBulkCopy = new SqlBulkCopy(_sqlServerConnection, SqlBulkCopyOptions.Default, transaction)
                        )
                    {
                        try
                        {
                            var sourceDataTable = new DataTable();
                            sourceDataTable.Load(reader);
                            sqlBulkCopy.DestinationTableName = tableName;
                            sqlBulkCopy.BatchSize = _batchSize;
                            foreach (
                                string columnName in
                                    from DataColumn column in sourceDataTable.Columns select column.ColumnName)
                            {
                                sqlBulkCopy.ColumnMappings.Add(new SqlBulkCopyColumnMapping(columnName,
                                                                                            columnName));
                            }
                            sqlBulkCopy.WriteToServer(sourceDataTable);
                            sourceDataTable.Dispose();
                        }
                        catch (SqlException)
                        {
                            //ShowMessage(Strings.DataCopyFailedString);
                            //ExceptionManager.Throw(exception);
                        }
                    }
                }
            }
        }

        private void ShowMessage(string message)
        {
            if (null != _messageAction)
            {
                _messageAction(message);
            }
        }

        /// <summary>
        /// Convert given oledb type to sql db type.
        /// </summary>
        /// <param name="oleDbType">Oledb type</param>
        /// <returns>Equivalent to sql db type.</returns>
        private static SqlDbType GetDataSqlDataType(OleDbType oleDbType)
        {
            switch (oleDbType)
            {
                case OleDbType.BigInt:
                    return SqlDbType.BigInt;
                case OleDbType.Binary:
                    return SqlDbType.Image;
                case OleDbType.Boolean:
                    return SqlDbType.Bit;
                case OleDbType.BSTR:
                    return SqlDbType.NVarChar;
                case OleDbType.Char:
                    return SqlDbType.Char;
                case OleDbType.Currency:
                    return SqlDbType.Money;
                case OleDbType.Date:
                    return SqlDbType.DateTime2;
                case OleDbType.DBDate:
                    return SqlDbType.DateTime2;
                case OleDbType.DBTime:
                    return SqlDbType.Timestamp;
                case OleDbType.DBTimeStamp:
                    return SqlDbType.Timestamp;
                case OleDbType.Decimal:
                    return SqlDbType.Decimal;
                case OleDbType.Double:
                    return SqlDbType.Decimal;
                case OleDbType.Empty:
                    break;
                case OleDbType.Error:
                    break;
                case OleDbType.Filetime:
                    return SqlDbType.DateTime;
                case OleDbType.Guid:
                    return SqlDbType.UniqueIdentifier;
                case OleDbType.IDispatch:
                    break;
                case OleDbType.Integer:
                    return SqlDbType.Int;
                case OleDbType.IUnknown:
                    break;
                case OleDbType.LongVarBinary:
                    break;
                case OleDbType.LongVarChar:
                    break;
                case OleDbType.LongVarWChar:
                    break;
                case OleDbType.Numeric:
                    return SqlDbType.Decimal;
                case OleDbType.PropVariant:
                    break;
                case OleDbType.Single:
                    return SqlDbType.Decimal;
                case OleDbType.SmallInt:
                    return SqlDbType.SmallInt;
                case OleDbType.TinyInt:
                    return SqlDbType.TinyInt;
                case OleDbType.UnsignedBigInt:
                    break;
                case OleDbType.UnsignedInt:
                    break;
                case OleDbType.UnsignedSmallInt:
                    break;
                case OleDbType.UnsignedTinyInt:
                    break;
                case OleDbType.VarBinary:
                    return SqlDbType.VarBinary;
                case OleDbType.VarChar:
                    return SqlDbType.VarChar;
                case OleDbType.Variant:
                    return SqlDbType.Variant;
                case OleDbType.VarNumeric:
                    return SqlDbType.Decimal;
                case OleDbType.VarWChar:
                case OleDbType.WChar:
                    return SqlDbType.NVarChar;
                default:
                    throw new ArgumentOutOfRangeException("oleDbType");
            }
            return SqlDbType.Text;
        }

        /// <summary>
        /// Get column string.
        /// </summary>
        /// <param name="row">Datarow having column information.</param>
        /// <returns>Column string to be used in create table statemetn.</returns>
        private string GetColumnString(DataRow row)
        {
            SqlDbType sqlDbType = GetDataSqlDataType((OleDbType) row["Data_Type"]);
            string columnString;
            if (sqlDbType == SqlDbType.NVarChar || sqlDbType == SqlDbType.VarChar)
            {
                const string characterLengthColumn = "CHARACTER_MAXIMUM_LENGTH";
                long scaleValue = (row[characterLengthColumn] == DBNull.Value ||
                                   (((long) row[characterLengthColumn]) == 0)
                                       ? 50
                                       : (long) row[characterLengthColumn]);
                columnString = string.Format("{0}({1})", sqlDbType, scaleValue);
            }
            else if (sqlDbType == SqlDbType.Decimal || sqlDbType == SqlDbType.Float)
            {
                const string numericScale = "NUMERIC_SCALE";
                int scaleValue = row[numericScale] == DBNull.Value ? 2 : (int) row[numericScale];
                columnString = string.Format("{0}({1},{2})", sqlDbType, row["NUMERIC_PRECISION"], scaleValue);
            }
            else
            {
                columnString = sqlDbType.ToString();
            }
            if (!(bool) row["IS_NULLABLE"])
            {
                columnString = string.Format("{0} not null", columnString);
            }

            return columnString;
        }

        /// <summary>
        /// Gets connection sring for sql server connection string.
        /// </summary>
        /// <returns>Connection string for sql server.</returns>
        private string GetSqlServerConnectionString()
        {
            return
                string.Format("Data Source={0};Integrated Security=True;", SelectedServer);
        }

        /// <summary>
        /// Gets connection string for access database.
        /// </summary>
        /// <returns>Connection string for access database.</returns>
        private string GetAccessDatabaseConnectionString()
        {
            string mdbPassword = ConfigurationManager.AppSettings["mdbPassword"];
            return
                string.Format(
                    "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Persist Security Info=True;User id=admin;Jet OLEDB:Database Password ={1}",
                    SelectedAccessFile, mdbPassword);
        }

        /// <summary>
        /// Creates data base of the given name.
        /// </summary>
        /// <param name="databaseName">Database to be created.</param>
        private void CreateSqlServerDatabase(string databaseName)
        {
            IDbCommand sqlDataCommand = _sqlServerConnection.CreateCommand();
            sqlDataCommand.CommandText = string.Format(Strings.CreateDatabaseString, databaseName);
            sqlDataCommand.ExecuteNonQuery();
            _sqlServerConnection.ChangeDatabase(databaseName);
        }

        /// <summary>
        /// Gets connection object for the given connection string.
        /// </summary>
        /// <typeparam name="T">Type parameter for connection type.</typeparam>
        /// <param name="connectionString">Connection string for connection.</param>
        /// <returns>Connection instance.</returns>
        private T GetConnection<T>(string connectionString) where T : IDbConnection, new()
        {
            var connection = new T {ConnectionString = connectionString};
            connection.Open();
            return connection;
        }

        /// <summary>
        /// Inner class to handle the foreign key information.
        /// </summary>
        private class ForeignKey
        {
            #region Private fields

            private readonly Dictionary<string, List<string>> _foreignKeyColumns =
                new Dictionary<string, List<string>>();

            private readonly Dictionary<string, List<string>> _references = new Dictionary<string, List<string>>();
            private string _name = string.Empty;

            #endregion

            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    _name = value;
                }
            }

            public Dictionary<string, List<string>> ForeignKeyColumns
            {
                get
                {
                    return _foreignKeyColumns;
                }
            }

            public Dictionary<string, List<string>> References
            {
                get
                {
                    return _references;
                }
            }
        }

        #endregion
    }
}