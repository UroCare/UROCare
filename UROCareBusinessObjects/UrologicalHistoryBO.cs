﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SHC.UROCare.Utilities;
using SHC.UROCare.UROCareDataModel;

namespace SHC.UROCare.UROCareBusinessObjects
{
    /// <summary>
    /// Business object for urological history
    /// </summary>
    /// <typeparam name="Urology_History">Urology History</typeparam>
    public class UrologicalHistoryBO : IPersistable<Urology_History>
    {
        
        #region Public Properties

        /// <summary>
        /// Get or Set History Id
        /// </summary>
        public int HistoryId { get; set; }

        /// <summary>
        /// Get or Set GUNo
        /// </summary>
        public int GUNo { get; set; }

        /// <summary>
        /// Get or set GUYear
        /// </summary>
        public int GUYear { get; set; }

        /// <summary>
        /// Get or set chief complaints
        /// </summary>
        public string ChiefComplaints { get; set; }

        /// <summary>
        /// Get or set frequency
        /// </summary>
        public string Frequency { get; set; }

        /// <summary>
        /// Get or set hesitancy
        /// </summary>
        public string Hesitancy { get; set; }

        /// <summary>
        /// Get or set nocturia
        /// </summary>
        public string Nocturia { get; set; }

        /// <summary>
        /// Get or set poor stream
        /// </summary>
        public string PoorStream { get; set; }

        /// <summary>
        /// Get or set urgency
        /// </summary>
        public string Urgency { get; set; }

        /// <summary>
        /// Get or set intermittency
        /// </summary>
        public string Intermittency {get; set;}

        /// <summary>
        /// Get or set dysuria
        /// </summary>
        public string Dysuria { get; set; }

        /// <summary>
        /// Get or set straining 
        /// </summary>
        public string Straining {get; set;}

        /// <summary>
        /// Get or set pyuria
        /// </summary>
        public string Pyuria { get; set; }

        /// <summary>
        /// Get or set sense incomplete void
        /// </summary>
        public string SenseIncomplVoid { get; set; }

        /// <summary>
        /// Get or Set lithuria
        /// </summary>
        public string Lithiuria { get; set; }

        /// <summary>
        /// Get or Set terminal dribbling
        /// </summary>
        public string TerminalDribbling { get; set; }

        /// <summary>
        /// Get or Set chyluria
        /// </summary>
        public string Chyluria { get; set; }

        /// <summary>
        /// Get or Set urge inc
        /// </summary>
        public string UrgeInc { get; set; }

        /// <summary>
        /// Get or set fever
        /// </summary>
        public string Fever { get; set; }

        /// <summary>
        /// Get or set stress inc
        /// </summary>
        public string StressInc { get; set; }

        /// <summary>
        /// Get or set IPSS
        /// </summary>
        public string IPSS { get; set; }

        /// <summary>
        /// Get or Set BPI
        /// </summary>
        public string BPI { get; set; }

        /// <summary>
        /// Get or Set pain
        /// </summary>
        public string Pain { get; set; }

        /// <summary>
        /// Get or set others
        /// </summary>
        public string Others { get; set; }

        /// <summary>
        /// Get or set medication
        /// </summary>
        public string Medication { get; set; }

        /// <summary>
        /// Get or set personal
        /// </summary>
        public string Personal { get; set; }

        /// <summary>
        /// Get or Set Surgery
        /// </summary>
        public string Surgery { get; set; }

        /// <summary>
        /// Get or set MH
        /// </summary>
        public string MH { get; set; }

        /// <summary>
        /// Get or set allergies
        /// </summary>
        public string Allergies { get; set; }

        /// <summary>
        /// Get or Set OBGY
        /// </summary>
        public string OBGY { get; set; }

        /// <summary>
        /// Get or Set past
        /// </summary>
        public string Past { get; set; }

        /// <summary>
        /// Get or set family
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        /// Get or set hematuria
        /// </summary>
        public string Hematuria { get; set; }

        /// <summary>
        /// Get or set created by
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Get or set modified by
        /// </summary>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Get or set modified data
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
        
        #endregion

        #region IPersistable Imlementation

        /// <summary>
        /// Maps object value to database entity object
        /// </summary>
        /// <param name="databaseObject">Database object</param>
        public void MapFromObjectToDatabaseEntity(Urology_History databaseObject)
        {

        }

        public int Save(IUROCareEntities dataContext)
        {
            return 0;
        }

        public int Save()
        {
            int result = -1;
            using (var dataContext = DataAccessLayer.GetDataContext())
            {
                Save(dataContext);
                result = dataContext.SaveChanges();
            }
            return result;
        }

        public void MapDatabaseValueToObject(Urology_History urologyHistory)
        {
            if (urologyHistory == null)
            {
                throw (new ArgumentNullException("urologyHistory"));
            }
         

            CreatedBy = urologyHistory.Created_By;
            CreatedDate = urologyHistory.Create_Dte;
            ModifiedBy = urologyHistory.Modify_By;
            ModifiedDate = urologyHistory.Modify_Dte;
        }

        #endregion
    }
}
