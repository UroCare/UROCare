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

        #endregion
    }
}
