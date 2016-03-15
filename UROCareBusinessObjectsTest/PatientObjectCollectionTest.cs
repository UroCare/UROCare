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
    /// Test for Patient object collection
    /// </summary>
    [TestClass]
    public class PatientObjectCollectionTest
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
        public void FillWhenNoPatientFoundReturnsCountZero()
        {
            PatientObjectCollection resultData = new PatientObjectCollection();
            resultData.Fill();
            Assert.IsTrue(resultData.Count == 0);
        }

        [TestMethod]
        public void FillWhenPatientExistsInDatabaseReturnsCorrectly()
        {
            dataContext.Patient_Info.Add(TestDataModelObjects.GetTestPatient());
            dataContext.Patient_Info.Add(TestDataModelObjects.GetTestPatient());

            PatientObjectCollection resultData = new PatientObjectCollection();
            resultData.Fill();
            Assert.IsTrue(resultData.Count == 2);
        }

        [TestMethod]
        public void FillByRegistrationMonthYearWhenGivenRegistrationDateMatchesReturnsCountCorrectly()
        {
            Patient_Info patient = TestDataModelObjects.GetTestPatient();            
            dataContext.Patient_Info.Add(patient);

            patient = TestDataModelObjects.GetTestPatient();
            patient.Reg_Date = DateTime.Today.AddMonths(2);
            dataContext.Patient_Info.Add(patient);   

            PatientObjectCollection resultData = new PatientObjectCollection();
            resultData.FillByRegistrationMonthYear(patient.Reg_Date.Month, patient.Reg_Date.Year);
            Assert.IsTrue(resultData.Count == 1);
        }

        [TestMethod]
        public void FillByRegistrationMonthYearWhenGivenRegistrationDateDoesNotMatchReturnsCountCorrectly()
        {
            dataContext.Patient_Info.Add(TestDataModelObjects.GetTestPatient());
            Patient_Info patient = TestDataModelObjects.GetTestPatient();
            patient.Reg_Date = DateTime.Today.AddMonths(2);
            dataContext.Patient_Info.Add(patient);

            PatientObjectCollection resultData = new PatientObjectCollection();
            resultData.FillByRegistrationMonthYear(patient.Reg_Date.Month+1, patient.Reg_Date.Year);
            Assert.IsTrue(resultData.Count == 0);

            resultData.FillByRegistrationMonthYear(patient.Reg_Date.Month, patient.Reg_Date.Year+1);
            Assert.IsTrue(resultData.Count == 0);
        }

        #endregion        
    }
}
