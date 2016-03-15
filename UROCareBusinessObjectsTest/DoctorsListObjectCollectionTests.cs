using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SHC.UROCare.UROCareBusinessObjects;
using SHC.UROCare.UROCareDataModel;
using SHC.UROCare.Utilities;
using FakeItEasy;

namespace SHC.UROCare.TestObjects
{
    /// <summary>
    /// Test for DoctorsListObjectCollection
    /// </summary>
    [TestClass]
    public class DoctorsListObjectCollectionTests
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
        public void FillWhenGivenDoctorsReturnsValueCorrectly()
        {
            dataContext.Doctors_List.Add(TestDataModelObjects.GetTestDoctor());
            dataContext.Doctors_List.Add(TestDataModelObjects.GetTestDoctor());   
           
            DoctorsListObjectCollection resultData = new DoctorsListObjectCollection();            
            resultData.Fill();
            Assert.IsTrue(resultData.Count == 2);
        }

        [TestMethod]
        public void FillWhenNoDoctorFoundReturnsCountZero()
        {
            DoctorsListObjectCollection resultData = new DoctorsListObjectCollection();
            resultData.Fill();
            Assert.IsTrue(resultData.Count == 0);
        }

        #endregion        
    }
}
