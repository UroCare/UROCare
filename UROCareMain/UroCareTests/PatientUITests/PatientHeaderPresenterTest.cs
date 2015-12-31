// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SHCPL.UROCare.BusinessObjects;
using SHCPL.UROCare.PatientsUI;
using UnitTestUtilities;

namespace UroCareTests.PatientUITests
{
    [TestClass]
    public class PatientHeaderPresenterTest
    {
        [ExpectedException(typeof (ArgumentNullException))]
        [TestMethod]
        public void Constructor_GivenViewNull_ThrowsArgumentNullException()
        {
            new PatientNodePresenter(null);
        }

        [ExpectedException(typeof (ArgumentNullException))]
        [TestMethod]
        public void Constructor_GivenModeleNull_ThrowsArgumentNullException()
        {
            var mockHeaderView = new Mock<IPatientHeaderView>();
            new PatientHeaderPresenter(mockHeaderView.Object, null);
        }

        [TestMethod]
        public void Constructor_GivenPatientAndView_InitializesFieldCorrectly()
        {
            var mockHeaderView = new Mock<IPatientHeaderView>();
            var patient = new Patient();
            var patienthHeaderPresenter = new PatientHeaderPresenter(mockHeaderView.Object, patient);
            Assert.IsNotNull(patienthHeaderPresenter.ModelObject);
            Assert.IsNotNull(patienthHeaderPresenter.View);
            Assert.AreEqual(patient, patienthHeaderPresenter.ModelObject);
            Assert.AreEqual(mockHeaderView.Object, patienthHeaderPresenter.View);
        }

        [TestMethod]
        public void InitFromModel_WhenCalled_InitializesViewFromModelValue()
        {
            Mock<IPatientHeaderView> mockHeaderView = new Mock<IPatientHeaderView>();
            mockHeaderView.SetupAllProperties();
            var headerViewObject = mockHeaderView.Object;
            var patient = TestUtilities.GetPatient();
            var patientHeaderPresenter = new PatientHeaderPresenter(headerViewObject, patient);
            patientHeaderPresenter.InitViewFromModel();

            Assert.AreEqual(patient.AgeMonths,headerViewObject.AgeMonths);
            Assert.AreEqual(patient.AgeYear,headerViewObject.AgeYears);
            Assert.AreEqual(patient.AtPost,headerViewObject.AtPost);
            Assert.AreEqual(patient.District,headerViewObject.District);
            Assert.AreEqual(patient.Email, headerViewObject.Email);
            Assert.AreEqual(patient.GuNumber,headerViewObject.GUId);
            Assert.AreEqual(patient.Mobile, headerViewObject.Mobile);
            Assert.AreEqual(patient.Name, headerViewObject.PatientName);
            Assert.AreEqual(patient.Occupation.ToString(), headerViewObject.Ocupation);
            Assert.AreEqual(patient.PhoneNumber, headerViewObject.Phone);
            Assert.AreEqual(patient.ReferenceDoctor, headerViewObject.ReferalDoctor);
            Assert.AreEqual(patient.RegistrationDate, headerViewObject.RegisterationDate);
            Assert.AreEqual(patient.Salutation, headerViewObject.Salutation);
            Assert.AreEqual(patient.Sex, headerViewObject.Sex);
            Assert.AreEqual(patient.State, headerViewObject.State);
            Assert.AreEqual(patient.Town, headerViewObject.Town);
        }

        [TestMethod]
        public void InitializeView_WhenCalled_InitializesFieldsCorrectly()
        {
            var mockHeaderView = new Mock<IPatientHeaderView>();
            mockHeaderView.SetupAllProperties();
            var patient = new Patient();
            var patienthHeaderPresenter = new PatientHeaderPresenter(mockHeaderView.Object, patient);
            patienthHeaderPresenter.InitializeView();
            var headerViewObject = mockHeaderView.Object;
            Assert.IsNotNull(headerViewObject.Salutations);
            Assert.IsNotNull(headerViewObject.Sexes);
        }

        
    }
}