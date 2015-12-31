// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SHCPL.UROCare.PatientsUI;
using UnitTestUtilities;

namespace UroCareTests.PatientUITests
{
    [TestClass]
    public class PatientContextTest
    {
        #region Private fields

        private uint _guNumber = 1;
        private uint _guYear = 2012;

        #endregion

        [TestMethod]
        public void IsDirty_GivenNewObject_ReturnsFalse()
        {
            var patientContext = new PatientContext(_guYear, _guNumber);
            Assert.IsFalse(patientContext.IsDirty);
        }

        [TestMethod]
        public void SetDirty_WhenCalled_SetsIsDirtyToTrue()
        {
            var patientContext = new PatientContext(_guYear, _guNumber);
            Assert.IsFalse(patientContext.IsDirty);
            patientContext.SetDirty();
            Assert.IsTrue(patientContext.IsDirty);
        }

        [TestMethod]
        public void Equals_GivenSameObject_ReturnsTrue()
        {
            var patientContext = new PatientContext(_guYear, _guNumber);
            Assert.IsTrue(patientContext.Equals(patientContext));
        }

        [TestMethod]
        public void Equals_GivenDifferentObject_ReturnsFalse()
        {
            var patientContext = new PatientContext(_guYear, _guNumber);
            var patientContext1 = new PatientContext(_guYear, _guNumber + 1);
            Assert.IsFalse(patientContext.Equals(patientContext1));
        }

        [TestMethod]
        public void Equals_GivenNull_ReturnsFalse()
        {
            Assert.IsFalse(new PatientContext(_guYear, _guNumber) == null);
        }

        [TestMethod]
        public void Equals_GivenDifferentGuNumber_ReturnsFalse()
        {
            var patientContext = new PatientContext(_guYear, _guNumber);
            PatientContext patientContext1 = TestUtilities.GetPatientContext(_guYear, _guNumber + 1);
            Assert.IsFalse(patientContext == patientContext1);
        }

        [TestMethod]
        public void Equals_GivenDifferentGuYear_ReturnsFalse()
        {
            var patientContext = new PatientContext(_guYear, _guNumber);
            var patientContext1 = new PatientContext(_guYear + 1, _guNumber);
            Assert.IsFalse(patientContext == patientContext1);
        }

        [TestMethod]
        public void Equals_GivenSameGuYearAndGuNumber_ReturnsTrue()
        {
            var patientContext = new PatientContext(_guYear, _guNumber);
            var patientContext1 = new PatientContext(_guYear, _guNumber);
            Assert.IsTrue(patientContext == patientContext1);
        }

        [TestMethod]
        public void Equals_GivenStringObject_ReturnsFalse()
        {
            PatientContext patientContext = TestUtilities.GetPatientContext();
            Assert.IsFalse(patientContext.Equals("TestValue"));
        }

        [TestMethod]
        public void Equals_GivenNullObject_ReturnsFalse()
        {
            PatientContext patientContext = TestUtilities.GetPatientContext();
            Assert.IsFalse(patientContext.Equals(null));
            Assert.IsNotNull(patientContext);
        }

        [TestMethod]
        public void EqualityOperator_GivenDifferntObjects_ReturnsTrue()
        {
            PatientContext patientContext = TestUtilities.GetPatientContext();
            PatientContext pateintContext1 = TestUtilities.GetPatientContext(_guYear, _guNumber + 1);
            Assert.IsTrue(patientContext != pateintContext1);
        }

        [ExpectedException(typeof (ArgumentException))]
        [TestMethod]
        public void Constructor_GivenZeroGuNumber_ThrowsArgumentNullException()
        {
            new PatientContext(_guYear, 0);
        }

        [ExpectedException(typeof (ArgumentException))]
        [TestMethod]
        public void Constructor_GivenZeroGuYear_ThrowsArgumentException()
        {
            new PatientContext(0, _guNumber);
        }

        [TestMethod]
        public void GetHashCode_WhenCalled_ReturnsNonZero()
        {
            PatientContext patientContext = TestUtilities.GetPatientContext();
            int code = patientContext.GetHashCode();
            Assert.AreNotEqual(0, code);
        }

        [TestMethod]
        public void Constructor_GivenValues_InitializesValues()
        {
            const string testValue = "TestValue";
            var patientContext = new PatientContext(_guYear, _guNumber, testValue);
            Assert.AreEqual(_guYear, patientContext.GuYear);
            Assert.AreEqual(_guNumber, patientContext.GuNumber);
            Assert.AreEqual(testValue, patientContext.Description);


        }
    }
}