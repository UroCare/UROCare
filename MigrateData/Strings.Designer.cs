﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MigrateData {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MigrateData.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /****** Object:  Table [dbo].[Param_Master]    Script Date: 04/07/2012 20:23:52 ******/
        ///SET ANSI_NULLS ON
        ///GO
        ///SET QUOTED_IDENTIFIER ON
        ///GO
        ///CREATE TABLE [dbo].[Param_Master](
        ///	[Param_Id] [nvarchar](80) NULL,
        ///	[Param_Value] [nvarchar](50) NULL
        ///) ON [PRIMARY]
        ///GO
        ///EXEC sys.sp_addextendedproperty @name=N&apos;MS_SSMA_SOURCE&apos;, @value=N&apos;URO Care.[Param_Master].[Param_Id]&apos; , @level0type=N&apos;SCHEMA&apos;,@level0name=N&apos;dbo&apos;, @level1type=N&apos;TABLE&apos;,@level1name=N&apos;Param_Master&apos;, @level2type=N&apos;COLUMN&apos;,@level2name=N&apos;Param_Id&apos;
        ///G [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CreateDatabaseScript {
            get {
                return ResourceManager.GetString("CreateDatabaseScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE DATABASE {0}.
        /// </summary>
        internal static string CreateDatabaseString {
            get {
                return ResourceManager.GetString("CreateDatabaseString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created data base.
        /// </summary>
        internal static string CreatedDatabase {
            get {
                return ResourceManager.GetString("CreatedDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UROCareDatabase.
        /// </summary>
        internal static string DatabaseName {
            get {
                return ResourceManager.GetString("DatabaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data copy failed!.
        /// </summary>
        internal static string DataCopyFailedString {
            get {
                return ResourceManager.GetString("DataCopyFailedString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data migrated successfully to {0} database- {1}..
        /// </summary>
        internal static string DataMigrationSuccessFull {
            get {
                return ResourceManager.GetString("DataMigrationSuccessFull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DROP DATABASE {0}.
        /// </summary>
        internal static string DeleteDatabaseString {
            get {
                return ResourceManager.GetString("DeleteDatabaseString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access database|*.mdb.
        /// </summary>
        internal static string FilterString {
            get {
                return ResourceManager.GetString("FilterString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select appropriate source and destination.
        /// </summary>
        internal static string InvalidSourceErrorMessage {
            get {
                return ResourceManager.GetString("InvalidSourceErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no tables in source database..
        /// </summary>
        internal static string NoTablesFound {
            get {
                return ResourceManager.GetString("NoTablesFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open source data file.
        /// </summary>
        internal static string OpenSourceDataFile {
            get {
                return ResourceManager.GetString("OpenSourceDataFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select * from {0}.
        /// </summary>
        internal static string SelectString {
            get {
                return ResourceManager.GetString("SelectString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sql server instnaces not found, please start sql server browser service..
        /// </summary>
        internal static string SqlServerInstancesNotFound {
            get {
                return ResourceManager.GetString("SqlServerInstancesNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to URO Care.
        /// </summary>
        internal static string UroCare {
            get {
                return ResourceManager.GetString("UroCare", resourceCulture);
            }
        }
    }
}
