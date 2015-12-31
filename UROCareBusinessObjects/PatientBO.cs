using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SHC.UROCare.Utilities;
using SHC.UROCare.UROCareDataModel;

namespace SHC.UROCare.UROCareBusinessObjects
{
    /// <summary>
    ///   Enumerates sex types.
    /// </summary>
    public enum SexEnum
    {
        Male,
        Female,
    }

    /// <summary>
    ///   Business object for the patient.
    /// </summary>
    public class PatientBO : IPersistable<Patient_Info>
    {
        #region Public properties.

        /// <summary>
        ///   Gets GUId.
        /// </summary>
        public string GUId 
        {
            get
            {
                return string.Format("{0}/{1}", GUNo, GUYear);
            }
        }

        /// <summary>
        ///   Gets or sets the GUNo.
        /// </summary>
        public int GUNo { get; set; }

        /// <summary>
        ///   Gets or sets GU year.
        /// </summary>
        public int GUYear { get; set; }

        /// <summary>
        ///   Gets or sets the registration date of the patient.
        /// </summary>
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Gets or sets Salutaion for patient.
        /// </summary>
        public string Salutation { get; set; }

        /// <summary>
        ///   Gets or sets the name of the patient.
        /// </summary>
        public string PatientName { get; set; }

        /// <summary>
        ///   Gets or sets the age of the patient.
        /// </summary>
        public short AgeYear { get; set; }

        /// <summary>
        /// Gets or sets month of the patient's age
        /// </summary>
        public short AgeMonths { get; set; }
                
        /// <summary>
        ///   Gets or sets the sex of the patient.
        /// </summary>
        public SexEnum Sex { get; set; }

        /// <summary>
        ///   Gets or sets the occupation of the patient.
        /// </summary>
        public string Occupation { get; set; }

        /// <summary>
        ///   Gets or sets the doctor who referred this patient.
        /// </summary>
        public string ReferenceDoctor { get; set; }

        /// <summary>
        /// Gets or sets at post information of patient. 
        /// </summary>
        public string AtPost { get; set; }

        /// <summary>
        /// Gets or sets Town of the patient.
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets district information of patient.
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// Gets or sets State of the patient.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets Phone number of the patient.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets Mobile number of the patient.
        /// </summary>
        public string Mobile { get; set; }
        
        /// <summary>
        /// Gets or sets provisional diagnosis of patient.
        /// </summary>
        public string OPDDiagnosis { get; set; }

        /// <summary>
        /// Gets or sets the patient record created by.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets creation date of patient record.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the modified by information of patient record.
        /// </summary>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets modified date of the record.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Fill by Gu No, GU Year
        /// </summary>
        /// <param name="guNo">Gu Number</param>
        /// <param name="guYear">GU year</param>
        public void FillBy(int guNo, int guYear)
        {
            using (IUROCareEntities dataContext = DataAccessLayer.GetDataContext())
            {
                
                var restult = dataContext.Patient_Info.FirstOrDefault(patient => patient.Gu_No.Equals(guNo) && patient.Gu_Year.Equals(guYear));
                
                if (restult == null)
                {
                    ExceptionManager.Throw(new NoRecordFoundException());
                }
                MapDatabaseValueToObject(restult);
            }
        }

        #endregion

        #region IPersistable Imlementation

        public void MapFromObjectToDatabaseEntity(Patient_Info databaseObject)
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

        public void MapDatabaseValueToObject(Patient_Info databaseObject)
        {
            this.GUNo = databaseObject.Gu_No;
            this.GUYear = databaseObject.Gu_Year;
            this.RegistrationDate = databaseObject.Reg_Date;
            this.Salutation = databaseObject.Salutation;
            this.PatientName = databaseObject.Patient_Name;
            this.AgeYear = databaseObject.Age_Yr.GetValueOrDefault(0);
            this.AgeMonths = databaseObject.Age_Mnth.GetValueOrDefault(0);
            this.Sex = (SexEnum)databaseObject.Sex;
            this.Occupation = databaseObject.Occupation;
            this.ReferenceDoctor = (databaseObject.Doctors_List!=null)?databaseObject.Doctors_List.Doctor_Name:string.Empty;
            this.AtPost = databaseObject.At_Post;
            this.Town = databaseObject.Town;
            this.District = databaseObject.District;
            this.State = databaseObject.State;
            this.PhoneNumber = databaseObject.Phone;
            this.Mobile = databaseObject.Mobile;
            this.OPDDiagnosis = databaseObject.OPD_Diagnosis;            

            this.CreatedBy = databaseObject.Created_By;
            this.CreatedDate = databaseObject.Create_Dte;
            this.ModifiedBy = databaseObject.Modify_By;
            this.ModifiedDate = databaseObject.Modify_Dte;           
        }    

        #endregion
    }

    /// <summary>
    /// Collection object for patient object.
    /// </summary>
    public class PatientObjectCollection : BusinessObjectCollection<PatientBO, Patient_Info>
    {
        #region Public Methods

        public override void Fill()
        {
            using (var dataContext = DataAccessLayer.GetDataContext())
            {
                FillCollection(dataContext.Patient_Info);
            }
        }

        public void FillByRegistrationMonthYear(int month, int year)
        {
            using (IUROCareEntities dataContext = DataAccessLayer.GetDataContext())
            {
                FillCollection(dataContext.Patient_Info.Where(item => item.Reg_Date.Month.Equals(month) && item.Reg_Date.Year.Equals(year)));
            }
        }     

        #endregion
    }
}