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
        #region Private Members
        
        DoctorsListBO _referenceDoctor = new DoctorsListBO();
        UrologicalHistoryBO _urologyHistory = new UrologicalHistoryBO();
        UrologicalHistoryObjectCollection _urologicalHistories=new UrologicalHistoryObjectCollection();
        

        #endregion

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
        public DoctorsListBO ReferenceDoctor 
        { 
            get
            {
                return _referenceDoctor;
            }
            set
            {
                _referenceDoctor = value;
            }
        }

        /// <summary>
        /// Get or set urology history.
        /// </summary>
        public UrologicalHistoryBO UrologyHistory
        {
            get
            {
                return _urologyHistory;
            }
            set
            {
                _urologyHistory = value;
            }
        }

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
                
                var result = dataContext.Patient_Info.FirstOrDefault(patient => patient.Gu_No.Equals(guNo) && patient.Gu_Year.Equals(guYear));
                
                if (result == null)
                {
                    ExceptionManager.Throw(new NoRecordFoundException());
                }
                MapDatabaseValueToObject(result);
            }
        }

        /// <summary>
        /// Copies value from patient buisness object.
        /// </summary>
        /// <param name="patientCopy">Patient object to copy</param>
        public void Copy(PatientBO patientCopy )
        {
            if (this.Equals(patientCopy))
            {
                return;
            }
            this.GUNo = patientCopy.GUNo;
            this.GUYear = patientCopy.GUYear;
            this.RegistrationDate = patientCopy.RegistrationDate;
            this.Salutation = patientCopy.Salutation;
            this.PatientName = patientCopy.PatientName;
            this.AgeYear = patientCopy.AgeYear;
            this.AgeMonths = patientCopy.AgeMonths;
            this.Sex = patientCopy.Sex;
            this.Occupation = patientCopy.Occupation;
            this.AtPost = patientCopy.AtPost;
            this.Town = patientCopy.Town;
            this.District = patientCopy.District;
            this.State = patientCopy.State;
            this.PhoneNumber = patientCopy.PhoneNumber;
            this.Mobile = patientCopy.Mobile;
            this.OPDDiagnosis = patientCopy.OPDDiagnosis;

            this.ReferenceDoctor = patientCopy.ReferenceDoctor;
            this.UrologyHistory = patientCopy.UrologyHistory;

            this.CreatedBy = patientCopy.CreatedBy;
            this.CreatedDate = patientCopy.CreatedDate;
            this.ModifiedBy = patientCopy.ModifiedBy;
            this.ModifiedDate = patientCopy.ModifiedDate;           
        }

        #endregion

        #region IPersistable Imlementation

        /// <summary>
        /// Map values from busiess object to data base entity
        /// </summary>
        /// <param name="databaseObject">Database object</param>
        public void MapFromObjectToDatabaseEntity(Patient_Info databaseObject)
        {

        }

        /// <summary>
        /// Save object
        /// </summary>
        /// <param name="dataContext">Data context</param>
        /// <returns>Count of record saved</returns>
        public int Save(IUROCareEntities dataContext)
        {
            return 0;
        }

        /// <summary>
        /// Save
        /// </summary>
        /// <returns>Count of record saved</returns>
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

        /// <summary>
        /// Maps database values to business object
        /// </summary>
        /// <param name="databaseObject">DB object</param>
        public void MapDatabaseValueToObject(Patient_Info databaseObject)
        {
            GUNo = databaseObject.Gu_No;
            GUYear = databaseObject.Gu_Year;
            RegistrationDate = databaseObject.Reg_Date;
            Salutation = databaseObject.Salutation;
            PatientName = databaseObject.Patient_Name;
            AgeYear = databaseObject.Age_Yr.GetValueOrDefault(0);
            AgeMonths = databaseObject.Age_Mnth.GetValueOrDefault(0);
            Sex = (SexEnum)databaseObject.Sex;
            Occupation = databaseObject.Occupation;
            AtPost = databaseObject.At_Post;
            Town = databaseObject.Town;
            District = databaseObject.District;
            State = databaseObject.State;
            PhoneNumber = databaseObject.Phone;
            Mobile = databaseObject.Mobile;
            OPDDiagnosis = databaseObject.OPD_Diagnosis;

            ReferenceDoctor = (databaseObject.Doctors_List!=null)? GetReferenceDoctor(databaseObject.Doctors_List):new DoctorsListBO();
            UrologyHistory = GetUrologyHistory(databaseObject.Urology_History);

            CreatedBy = databaseObject.Created_By;
            CreatedDate = databaseObject.Create_Dte;
            ModifiedBy = databaseObject.Modify_By;
            ModifiedDate = databaseObject.Modify_Dte;           
        }    

        #endregion

        #region Private Methods

        /// <summary>
        /// Get reference doctors business object
        /// </summary>
        /// <returns>ReferenceDoctor</returns>
        private DoctorsListBO GetReferenceDoctor(Doctors_List doctor)
        {
            DoctorsListBO referenceDoctor = new DoctorsListBO();
            referenceDoctor.MapDatabaseValueToObject(doctor);
            return referenceDoctor;
        }

        private UrologicalHistoryBO GetUrologyHistory(ICollection<Urology_History> urologyHistory)
        {
            var resultData = new UrologicalHistoryBO();

            if (urologyHistory == null || urologyHistory.Count != 1)
            {
                throw (new ArgumentException("urologyHistory"));
            }

            resultData.MapDatabaseValueToObject(urologyHistory.First());

            return resultData;
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