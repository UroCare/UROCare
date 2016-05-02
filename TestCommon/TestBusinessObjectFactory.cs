using SHC.UROCare.UROCareBusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHC.UROCare.TestObjects
{
    public class TestBusinessObjectFactory
    {
        #region Public Methods

        /// <summary>
        /// Get test patient
        /// </summary>
        /// <returns>Returns patient info object</returns>
        public static PatientBO GetTestPatient()
        {
            PatientBO testPatient = new PatientBO();
            testPatient.RegistrationDate = DateTime.Today;
            testPatient.GUNo = TestDataModelObjects.GetRandomNumber(2);
            testPatient.GUYear = TestDataModelObjects.GetRandomNumber(4);
            testPatient.Salutation = "Mr";
            testPatient.PatientName = TestDataModelObjects.GetRandomString(8);
            testPatient.AtPost = TestDataModelObjects.GetRandomString(15);
            testPatient.Town = TestDataModelObjects.GetRandomString(4);
            testPatient.District = TestDataModelObjects.GetRandomString(4);
            testPatient.State = TestDataModelObjects.GetRandomString(8);
            testPatient.PhoneNumber= TestDataModelObjects.GetRandomNumber(4).ToString();
            testPatient.Mobile = TestDataModelObjects.GetRandomNumber(4).ToString();
            testPatient.AgeYear = 33;
            testPatient.AgeMonths = 11;
            testPatient.Sex = 0;
            testPatient.Occupation = TestDataModelObjects.GetRandomString(4);
            testPatient.ReferenceDoctor = GetTestDoctor();

            testPatient.OPDDiagnosis = TestDataModelObjects.GetRandomString(14);

            testPatient.CreatedBy = "created user";
            testPatient.CreatedDate = DateTime.Today;
            testPatient.ModifiedBy = "modified user";
            testPatient.ModifiedDate = DateTime.Today;

            return testPatient;
        }

        /// <summary>
        /// Get test doctor
        /// </summary>
        /// <returns>Returns patient info object</returns>
        public static DoctorsListBO GetTestDoctor()
        {
            DoctorsListBO testDoctor = new DoctorsListBO();
            testDoctor.DoctorId = TestDataModelObjects.GetRandomNumber(2);
            testDoctor.DoctorName = TestDataModelObjects.GetRandomString(8);
            testDoctor.AtPost = TestDataModelObjects.GetRandomString(15);
            testDoctor.Taluka = TestDataModelObjects.GetRandomString(10);
            testDoctor.District = TestDataModelObjects.GetRandomString(4);
            testDoctor.PhoneNumber = TestDataModelObjects.GetRandomNumber(4).ToString();
            testDoctor.MobileNumber = TestDataModelObjects.GetRandomNumber(4).ToString();
            testDoctor.BirthDate = DateTime.Today;
            testDoctor.Email = string.Format("{0}@aaaa.com", TestDataModelObjects.GetRandomString(4));

            testDoctor.CreatedBy = "created user";
            testDoctor.CreatedDate = DateTime.Today;
            testDoctor.ModifiedBy = "modified user";
            testDoctor.ModifiedDate = DateTime.Today;

            return testDoctor;
        }

        public static UrologyHistoryBO GetUrologyHistory()
        {
            UrologyHistoryBO urologyHistory = new UrologyHistoryBO();

            urologyHistory.HistoryId = TestDataModelObjects.GetRandomNumber(2);
            urologyHistory.PatientId = TestDataModelObjects.GetRandomNumber(2);
            urologyHistory.GUNo = TestDataModelObjects.GetRandomNumber(2);
            urologyHistory.GUYear = TestDataModelObjects.GetRandomNumber(4);
            urologyHistory.ChiefComplaints = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Frequency = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Hesitancy = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Nocturia = TestDataModelObjects.GetRandomString(4);
            urologyHistory.PoorStream = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Urgency = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Intermittency = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Dysuria = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Straining = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Pyuria = TestDataModelObjects.GetRandomString(4);
            urologyHistory.SenseIncomplVoid = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Lithiuria = TestDataModelObjects.GetRandomString(4);
            urologyHistory.TerminalDribbling = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Chyluria = TestDataModelObjects.GetRandomString(4);
            urologyHistory.UrgeInc = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Fever = TestDataModelObjects.GetRandomString(4);
            urologyHistory.StressInc = TestDataModelObjects.GetRandomString(4);
            urologyHistory.IPSS = TestDataModelObjects.GetRandomString(4);
            urologyHistory.BPI = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Pain = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Others = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Medication = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Personal = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Surgery = TestDataModelObjects.GetRandomString(4);
            urologyHistory.MH = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Allergies = TestDataModelObjects.GetRandomString(4);
            urologyHistory.OBGY = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Past = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Family = TestDataModelObjects.GetRandomString(4);
            urologyHistory.Hematuria = TestDataModelObjects.GetRandomString(4);

            urologyHistory.CreatedBy = "created user";
            urologyHistory.CreatedDate = DateTime.Today;
            urologyHistory.ModifiedBy = "modified user";
            urologyHistory.ModifiedDate = DateTime.Today;

            return urologyHistory;

        }
        #endregion
    }
}
