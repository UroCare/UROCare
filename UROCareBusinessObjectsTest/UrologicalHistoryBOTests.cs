using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SHC.UROCare.UROCareBusinessObjects;
using SHC.UROCare.UROCareDataModel;
using SHC.UROCare.Utilities;
using System.Collections.Generic;

namespace SHC.UROCare.TestObjects
{
    [TestClass]
    public class UrologicalHistoryBOTests
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
        [ExpectedException(typeof(ArgumentNullException))]
        public void MapDatabaseValueToObjectGivenUrologicalHistoryNullThrowsArgementNullException()
        {
            UrologyHistoryBO resultData = new UrologyHistoryBO();
            resultData.MapDatabaseValueToObject(null);
        }

        [TestMethod]
        public void MapDatabaseValueToObjectGivenUrologicalHistoryMapsValueCorrectly()
        {
            List<Urology_History> urologicalHistoryData = TestDataModelObjects.GetTestUrologyHistory();
            Urology_History expectedData = urologicalHistoryData[0];

            UrologyHistoryBO actualData = new UrologyHistoryBO();
            actualData.MapDatabaseValueToObject(expectedData);

            Assert.AreEqual(expectedData.History_ID, actualData.HistoryId);
            Assert.AreEqual(expectedData.Patient_ID, actualData.PatientId);
            Assert.AreEqual(expectedData.Gu_No, actualData.GUNo);
            Assert.AreEqual(expectedData.Gu_Year, actualData.GUYear);
            Assert.AreEqual(expectedData.Chief_Compl, actualData.ChiefComplaints);
            Assert.AreEqual(expectedData.Frequency, actualData.Frequency);
            Assert.AreEqual(expectedData.Hesitancy, actualData.Hesitancy);
            Assert.AreEqual(expectedData.Nocturia, actualData.Nocturia);
            Assert.AreEqual(expectedData.Poor_Stream, actualData.PoorStream);
            Assert.AreEqual(expectedData.Nocturia, actualData.Nocturia);
            Assert.AreEqual(expectedData.Poor_Stream, actualData.PoorStream);
            Assert.AreEqual(expectedData.Urgency, actualData.Urgency);
            Assert.AreEqual(expectedData.Intermittency, actualData.Intermittency);
            Assert.AreEqual(expectedData.Dysuria, actualData.Dysuria);
            Assert.AreEqual(expectedData.Straining, actualData.Straining);
            Assert.AreEqual(expectedData.Pyuria, actualData.Pyuria);
            Assert.AreEqual(expectedData.Sense_Incompl_Void, actualData.SenseIncomplVoid);
            Assert.AreEqual(expectedData.Lithiuria, actualData.Lithiuria);
            Assert.AreEqual(expectedData.Terminal_Dribbling, actualData.TerminalDribbling);
            Assert.AreEqual(expectedData.Chyluria, actualData.Chyluria);
            Assert.AreEqual(expectedData.Urge_Inc, actualData.UrgeInc);
            Assert.AreEqual(expectedData.Fever, actualData.Fever);
            Assert.AreEqual(expectedData.Stress_Inc, actualData.StressInc);
            Assert.AreEqual(expectedData.IPSS, actualData.IPSS);
            Assert.AreEqual(expectedData.BPI, actualData.BPI);
            Assert.AreEqual(expectedData.Pain, actualData.Pain);
            Assert.AreEqual(expectedData.Others, actualData.Others);
            Assert.AreEqual(expectedData.Medication, actualData.Medication);
            Assert.AreEqual(expectedData.Personal, actualData.Personal);
            Assert.AreEqual(expectedData.Surgery, actualData.Surgery);
            Assert.AreEqual(expectedData.MH, actualData.MH);
            Assert.AreEqual(expectedData.Allergies, actualData.Allergies);
            Assert.AreEqual(expectedData.OB_GY, actualData.OBGY);
            Assert.AreEqual(expectedData.Past, actualData.Past);
            Assert.AreEqual(expectedData.Family, actualData.Family);
            Assert.AreEqual(expectedData.Hematuria, actualData.Hematuria);
            Assert.AreEqual(expectedData.Created_By, actualData.CreatedBy);
            Assert.AreEqual(expectedData.Create_Dte, actualData.CreatedDate);
            Assert.AreEqual(expectedData.Modify_By, actualData.ModifiedBy);
            Assert.AreEqual(expectedData.Modify_Dte, actualData.ModifiedDate);
        }

        #endregion
    }
}
