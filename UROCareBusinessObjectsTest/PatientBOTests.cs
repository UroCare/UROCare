using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SHC.UROCare.UROCareBusinessObjects;
using SHC.UROCare.UROCareDataModel;
using SHC.UROCare.Utilities;

namespace SHC.UROCare.URCareBusinessObjectsTest
{
    /// <summary>
    /// test method for Patient business object
    /// </summary>
    [TestClass]
    public class PatientBOTests
    {
        #region Private Variables
        DataAccessLayer dataAccessLayer = new DataAccessLayer();
        IUROCareEntities dataContext;
        #endregion

        #region Test attributes

        [TestInitialize()]
         public void Setup()
         {
             dataAccessLayer.SetTestDataContext(TestObjectFactory.GetMockedDataContext());
             dataContext = DataAccessLayer.GetDataContext();
         }
        
        #endregion

        #region Test Methods
        [TestMethod]
        [ExpectedException(typeof(NoRecordFoundException))]
        public void FillByGivenGuNoGUYearReturnsNoRecordException()
        {
            dataContext.Patient_Info.AddObject(GetTestPatient());
            PatientBO patient = new PatientBO();
            patient.FillBy(0,2015);            
        }

        [TestMethod]
        public void FillByGivenGuNoGUYearReturnsPatientNotNull()
        {
            dataContext.Patient_Info.AddObject(GetTestPatient());
            PatientBO patient = new PatientBO();
            patient.FillBy(1, 2015);
            Assert.IsNotNull(patient);
        }

        [TestMethod]
        public void MapDatabaseValueToObjectGivenPatientInfoObjectMapsValueCorrectly()
        {
            PatientBO resultData = new PatientBO();
            Patient_Info actualData = GetTestPatient();
            resultData.MapDatabaseValueToObject(actualData);
            Assert.AreEqual(actualData.Gu_No, resultData.GUNo);
            Assert.AreEqual(actualData.Gu_Year, resultData.GUYear);
            Assert.AreEqual(actualData.Salutation, resultData.Salutation);
            Assert.AreEqual(actualData.Patient_Name, resultData.PatientName);
            Assert.AreEqual(actualData.At_Post, resultData.AtPost);
            Assert.AreEqual(actualData.Town, resultData.Town);
            Assert.AreEqual(actualData.District, resultData.District);
            Assert.AreEqual(actualData.State, resultData.State);
            Assert.AreEqual(actualData.Phone, resultData.PhoneNumber);
            Assert.AreEqual(actualData.Mobile, resultData.Mobile);
            Assert.AreEqual(actualData.Age_Yr, resultData.AgeYear);
            Assert.AreEqual(actualData.Age_Mnth, resultData.AgeMonths);
            Assert.AreEqual((SexEnum)actualData.Sex, resultData.Sex);
            Assert.AreEqual(actualData.Occupation, resultData.Occupation);


        }

        #endregion 

        #region Private Methods

        /// <summary>
        /// Get test patient
        /// </summary>
        /// <returns>Returns patient info object</returns>
        private Patient_Info GetTestPatient()
        {
            Patient_Info testPatient = new Patient_Info();
            testPatient.Gu_No = 1;
            testPatient.Gu_Year = 2015;
            testPatient.Salutation = "Mr";
            testPatient.Patient_Name = "nilesh";
            testPatient.At_Post = "Atul Nagar";
            testPatient.Town = "Pune";
            testPatient.District ="Pune";
            testPatient.State = "Maharashtra";
            testPatient.Phone = "66425646";
            testPatient.Mobile = "9881230729";
            testPatient.Age_Yr = 33;
            testPatient.Age_Mnth = 11;
            testPatient.Sex = 0;
            testPatient.Occupation= "service";
            testPatient.Doctors_List = new Doctors_List();

            return testPatient;
        }

        #endregion        
    }    
}
