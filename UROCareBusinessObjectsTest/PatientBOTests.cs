using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SHC.UROCare.UROCareBusinessObjects;
using SHC.UROCare.UROCareDataModel;
using SHC.UROCare.Utilities;

namespace SHC.UROCare.TestObjects
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
             TestObjectFactory.SetFakedDataContext();
             dataContext = DataAccessLayer.GetDataContext();
         }
        
        #endregion

        #region Test Methods

        [TestMethod]
        [ExpectedException(typeof(NoRecordFoundException))]
        public void FillByGivenGuNoGUYearReturnsNoRecordException()
        {
            dataContext.Patient_Info.Add(TestDataModelObjects.GetTestPatient());
            PatientBO patient = new PatientBO();
            patient.FillBy(0,2015);            
        }

        [TestMethod]
        public void FillByGivenGuNoGUYearReturnsCorrectPatientObject()
        {
            Patient_Info dbPatient = TestDataModelObjects.GetTestPatient();
            dataContext.Patient_Info.Add(dbPatient);

            PatientBO patient = new PatientBO();
            patient.FillBy(dbPatient.Gu_No, dbPatient.Gu_Year);

            Assert.IsTrue(patient.GUNo == dbPatient.Gu_No);
            Assert.IsTrue(patient.GUYear == dbPatient.Gu_Year);           
        }

        [TestMethod]
        public void MapDatabaseValueToObjectGivenPatientInfoObjectMapsValueCorrectly()
        {
            Patient_Info actualData = TestDataModelObjects.GetTestPatient();

            PatientBO resultData = new PatientBO();            
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
            Assert.AreEqual(actualData.Doctors_List.ID, resultData.ReferenceDoctor.DoctorId);
            Assert.AreEqual(actualData.Urology_History.First().History_ID, resultData.UrologyHistory.HistoryId);

            Assert.AreEqual(actualData.Create_Dte, resultData.CreatedDate);
            Assert.AreEqual(actualData.Created_By, resultData.CreatedBy);
            Assert.AreEqual(actualData.Modify_By, resultData.ModifiedBy);
            Assert.AreEqual(actualData.Modify_Dte, resultData.ModifiedDate);

        }

        [TestMethod]
        public void CopyGivenPatientInfoToOtherObjectSuccessfully()
        {
            PatientBO originalData = new PatientBO();
            originalData.MapDatabaseValueToObject(TestDataModelObjects.GetTestPatient());

            PatientBO resultObject = new PatientBO();            
            resultObject.Copy(originalData);

            Assert.AreEqual(originalData.GUNo, resultObject.GUNo);
            Assert.AreEqual(originalData.GUYear, resultObject.GUYear);
            Assert.AreEqual(originalData.Salutation, resultObject.Salutation);
            Assert.AreEqual(originalData.PatientName, resultObject.PatientName);
            Assert.AreEqual(originalData.AtPost, resultObject.AtPost);
            Assert.AreEqual(originalData.Town, resultObject.Town);
            Assert.AreEqual(originalData.District, resultObject.District);
            Assert.AreEqual(originalData.State, resultObject.State);
            Assert.AreEqual(originalData.PhoneNumber, resultObject.PhoneNumber);
            Assert.AreEqual(originalData.Mobile, resultObject.Mobile);
            Assert.AreEqual(originalData.AgeYear, resultObject.AgeYear);
            Assert.AreEqual(originalData.AgeMonths, resultObject.AgeMonths);
            Assert.AreEqual(originalData.Sex, resultObject.Sex);
            Assert.AreEqual(originalData.Occupation, resultObject.Occupation);
            Assert.AreEqual(originalData.ReferenceDoctor.DoctorId, resultObject.ReferenceDoctor.DoctorId);
            Assert.AreEqual(originalData.UrologyHistory.HistoryId, resultObject.UrologyHistory.HistoryId);

            Assert.AreEqual(originalData.CreatedBy, resultObject.CreatedBy);
            Assert.AreEqual(originalData.CreatedDate, resultObject.CreatedDate);
            Assert.AreEqual(originalData.ModifiedBy, resultObject.ModifiedBy);
            Assert.AreEqual(originalData.ModifiedDate, resultObject.ModifiedDate);

        }

        [TestMethod]
        public void UrologyHistoryPropertyGivenNoValueReturnsNewObject()
        {
            PatientBO resultObject = new PatientBO();
            Assert.AreEqual(resultObject.UrologyHistory.HistoryId, 0);
        }

        [TestMethod]
        public void UrologyHistoryPropertyGivenHistoryObjectReturnsValueCorrectly()
        {
            Patient_Info dbPatient = TestDataModelObjects.GetTestPatient();

            PatientBO originalData = new PatientBO();
            originalData.MapDatabaseValueToObject(dbPatient);

            Assert.AreEqual(originalData.UrologyHistory.HistoryId, dbPatient.Urology_History.First().History_ID);
        }

        [TestMethod]
        public void UrologyHistoryPropertyGivenHistoryObjectSetValueToZeroIndexOnly()
        {
            Patient_Info dbPatient = TestDataModelObjects.GetTestPatient();
            
            PatientBO originalData = new PatientBO();
            originalData.MapDatabaseValueToObject(dbPatient);

            Assert.AreEqual(originalData.UrologyHistory.HistoryId, dbPatient.Urology_History.First().History_ID);

            UrologyHistoryBO secondObject = TestBusinessObjectFactory.GetUrologyHistory();
            
            originalData.UrologyHistory = secondObject;

            Assert.AreEqual(originalData.UrologyHistory.HistoryId, secondObject.HistoryId);
        }

        #endregion        
    }    
}
