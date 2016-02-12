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
    public class UserBOTests
    {
        #region Private Variables
        DataAccessLayer dataAccessLayer = new DataAccessLayer();
        IUROCareEntities dataContext;
        #endregion

        #region Test Attributes
        [TestInitialize]
        public void Setup()
        {
            TestObjectFactory.SetFakedDataContext();
            dataContext = DataAccessLayer.GetDataContext();
        }
        #endregion

        #region Test Methods

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FillByIdGivenUserIDNullThrowsArgumentNullException()
        {
            UserBO user = new UserBO();
            user.FillById(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FillByIdGivenUserIDEmptyStringhrowsArgumentNullException()
        {
            UserBO user = new UserBO();
            user.FillById("");
        }

        [TestMethod]
        public void FillByIdGivenValidUserReturnsSameUser()
        {
            dataContext.User_Master.Add(GetTestUser());
            UserBO testUser = new UserBO();
            testUser.FillById("abc");
            Assert.AreEqual("abc", testUser.UserId);
        }

        [TestMethod]
        [ExpectedException(typeof(NoRecordFoundException))]
        public void FillByIdGivenUserIDDoNotExistsReturnsEmptyUser()
        {
            dataContext.User_Master.Add(GetTestUser());
            UserBO testUser = new UserBO();
            testUser.FillById("nilesh");
            Assert.IsNull(testUser.UserId);
        }

        [TestMethod]
        public void IsExistsGivenInvalidUserIDReturnsFalse()
        {
            dataContext.User_Master.Add(GetTestUser());
            UserBO userBusinessObject = new UserBO();
            Assert.IsFalse(userBusinessObject.IsExists("nilesh"));
        }

        [TestMethod]
        public void IsExistsGivenValidUserIDReturnsTrue()
        {
          
            IUROCareEntities dataContext = DataAccessLayer.GetDataContext();
            dataContext.User_Master.Add(GetTestUser());

            UserBO userBusinessObject = new UserBO();
            Assert.IsTrue(userBusinessObject.IsExists("abc"));
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Get test user object
        /// </summary>
        /// <returns>User master object</returns>
        private User_Master GetTestUser()
         {
            User_Master testUser = new User_Master();
            testUser.User_Id = "abc";
            testUser.User_Name = "afd fs f sdfs aads";
            return testUser;
         }

        #endregion
    }
}
