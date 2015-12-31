// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SHCPL.Utilities;

namespace SHCPL.UtlilitiesTests
{
    [TestClass]
    public class StringValidationTests
    {
        [ExpectedException(typeof (ArgumentNullException))]
        [TestMethod]
        public void Validate_WhenGivenNullName_ThrowsArgumentNullException()
        {
            StringValidation.Validate(null, StringType.Name);
        }

        [ExpectedException(typeof (InvalidLengthException))]
        [TestMethod]
        public void Validate_WhenGivenEmptyString_ReturnsFalse()
        {
            Assert.IsFalse(StringValidation.Validate(string.Empty, StringType.Name));
        }

        [ExpectedException(typeof (TooLongStringException))]
        [TestMethod]
        public void Validate_WhenGivenLongString_ReturnsFalse()
        {
            Assert.IsFalse(StringValidation.Validate("asdjklqwrwerewrwerwrdfdsfdfsfw", StringType.Name));
        }

        [TestMethod]
        public void Validate_WhenGivenCorrectName_ReturnsTrue()
        {
            Assert.IsTrue(StringValidation.Validate("Test Name", StringType.Name));
        }

        [TestMethod]
        public void Validate_WhenGivenNameWithNumber_ReturnsFalse()
        {
            Assert.IsFalse(StringValidation.Validate("Test Name45", StringType.Name));
        }

        [TestMethod]
        public void Validate_WhenGiveNameWithSymbols_ReturnsFalse()
        {
            Assert.IsFalse(StringValidation.Validate("$!%#^", StringType.Name));
        }
    }
}