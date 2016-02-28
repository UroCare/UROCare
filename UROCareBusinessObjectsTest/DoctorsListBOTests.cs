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
    [TestClass]
    public class DoctorsListBOTests
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

        [TestMethod]
        public void MapDatabaseValueToObjectGivenDoctorsListObjectMapsValueCorrectly()
        {
            DoctorsListBO resultData = new DoctorsListBO();
            Doctors_List actualData = TestDataModelObjects.GetTestDoctor();
            resultData.MapDatabaseValueToObject(actualData);

            Assert.AreEqual(actualData.ID, resultData.DoctorId);
            Assert.AreEqual(actualData.Doctor_Name, resultData.DoctorName);
            Assert.AreEqual(actualData.At_Post, resultData.AtPost);
            Assert.AreEqual(actualData.Taluka, resultData.Taluka);
            Assert.AreEqual(actualData.District, resultData.District);
            Assert.AreEqual(actualData.Phone, resultData.PhoneNumber);
            Assert.AreEqual(actualData.Mobile, resultData.MobileNumber);
            Assert.AreEqual(actualData.Dr_Email, resultData.Email);
            Assert.AreEqual(actualData.Birth_Dte, resultData.BirthDate);
           
            Assert.AreEqual(actualData.Create_Dte, resultData.CreatedDate);
            Assert.AreEqual(actualData.Created_By, resultData.CreatedBy);
            Assert.AreEqual(actualData.Modify_By, resultData.ModifiedBy);
            Assert.AreEqual(actualData.Modify_Dte, resultData.ModifiedDate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MapDatabaseValueToObjectGivenDoctorsListObjectNullThrowsArgementNullException()
        {
            DoctorsListBO resultData = new DoctorsListBO();
            resultData.MapDatabaseValueToObject(null);    
        }
    }
}
