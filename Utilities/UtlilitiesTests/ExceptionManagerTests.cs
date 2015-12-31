// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SHCPL.Utilities;

namespace SHCPL.UtlilitiesTests
{
    [TestClass]
    public class ExceptionManagerTests
    {
        [ExpectedException(typeof (ArgumentNullException))]
        [TestMethod]
        public void Throw_GivenNull_ThrowsArgumentNullException()
        {
            ExceptionManager.Throw(null);
        }

        [ExpectedException(typeof (ArgumentException))]
        [TestMethod]
        public void Throw_GiveArgumentException_ThrowsArgumentException()
        {
            var argumentException = new ArgumentException();
            ExceptionManager.Throw(argumentException);
        }

        [ExpectedException(typeof (ArgumentNullException))]
        [TestMethod]
        public void Show_GiveNull_ThrowsArgumentNullException()
        {
            ExceptionManager.Show(null);
        }
    }
}