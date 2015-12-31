// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SHCPL.UROCare.PatientsUI;
using UnitTestUtilities;

namespace UroCareTests.PatientUITests
{
    [TestClass]
    public class PatientNodePresenterTest
    {
        #region Private fields

        private const int _zeroCount = 0;
        private const int _oneCount = 1;

        #endregion

        [ExpectedException(typeof (ArgumentNullException))]
        [TestMethod]
        public void Constructor_GivenNullNodeView_ThrowsArgumentNullException()
        {
            new PatientNodePresenter(null);
        }

        [TestMethod]
        public void Constructor_GivenPatientNodeView_InitializesView()
        {
            var mockPatientNodeView = new Mock<IPatientNodeView>();
            PatientNodePresenter patientNodePresenter = GetPresenter(mockPatientNodeView.Object);
            Assert.IsNotNull(patientNodePresenter.PatientNodeView);
            Assert.AreEqual(mockPatientNodeView.Object, patientNodePresenter.PatientNodeView);
        }

        [ExpectedException(typeof (ArgumentNullException))]
        [TestMethod]
        public void AddContext_GivenNull_ThrowsArgumentNullException()
        {
            PatientNodePresenter presenter = GetPresenter();
            presenter.AddContext(null);
        }

        [TestMethod]
        public void AddContext_GivenContext_AddsContextToCollection()
        {
            PatientNodePresenter presenter = GetPresenter();
            presenter.AddContext(TestUtilities.GetPatientContext());
            Assert.AreNotEqual(_zeroCount, presenter.Contexts.Count);
        }

        [TestMethod]
        public void AddContext_GivenSameContextTwice_AddsOnlyOne()
        {
            PatientNodePresenter presenter = GetPresenter();
            var patientContext = TestUtilities.GetPatientContext();
            presenter.AddContext(patientContext);
            presenter.AddContext(patientContext);
            Assert.AreEqual(_oneCount, presenter.Contexts.Count);
        }

        [ExpectedException(typeof (ArgumentNullException))]
        [TestMethod]
        public void RemoveContext_GivenNull_ThrowsArgumentNullException()
        {
            PatientNodePresenter presenter = GetPresenter();
            presenter.RemoveContext(null);
        }

        [TestMethod]
        public void RemoveContext_GivenContext_RemovesFromContextCollection()
        {
            PatientNodePresenter presenter = GetPresenter();
            PatientContext context = TestUtilities.GetPatientContext();
            presenter.AddContext(context);
            Assert.AreEqual(_oneCount, presenter.Contexts.Count);
            presenter.RemoveContext(context);
            Assert.AreEqual(_zeroCount, presenter.Contexts.Count);
        }

        #region Private methods

        private PatientNodePresenter GetPresenter()
        {
            var mockPatientNodeView = new Mock<IPatientNodeView>();
            return GetPresenter(mockPatientNodeView.Object);
        }

        private static PatientNodePresenter GetPresenter(IPatientNodeView mockPatientNodeView)
        {
            var patientNodePresenter = new PatientNodePresenter(mockPatientNodeView);
            return patientNodePresenter;
        }

        #endregion
    }
}