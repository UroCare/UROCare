using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace SHC.UROCare.UROCareBusinessObjects
{
    public abstract class BusinessObjectCollection<T, K> : List<T> where T : IPersistable<K>, new()
    {
        protected void FillCollection(IEnumerable<K> databaseEntitiesCollection)
        {
            foreach (var databaseEntity in databaseEntitiesCollection)
            {
                T businessObject = new T();
                businessObject.MapDatabaseValueToObject(databaseEntity);
                Add(businessObject);
            }
        }

        public void FillFromCollection(IEnumerable<K> databaseEntities)
        {
            FillCollection(databaseEntities);
        }

        public void Save()
        {
            using (var dataContext = DataAccessLayer.GetDataContext())
            {
                ForEach(item => item.Save(dataContext));

                dataContext.SaveChanges();
            }
        }

        public abstract void Fill();

        public DataTable ToDataTable()
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in this)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
}
