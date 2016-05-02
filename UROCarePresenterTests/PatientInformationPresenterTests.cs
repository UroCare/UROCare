using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeItEasy;

using SHC.UROCare.TestObjects;
using SHC.UROCare.UROCareDataModel;
using SHC.UROCare.UICommonControls;
using SHC.UROCare.UROCareBusinessObjects;

namespace SHC.UROCare.UI.Presenter.Tests
{
    [TestClass]
    public class PatientInformationPresenterTests
    {
        #region Test Initiatilize

        [TestInitialize]
        public void TestSetup()
        {
            TestObjectFactory.SetFakedDataContext();             
        }

        #endregion

        #region Test Methods

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PatientInformationPresenterConstructorGivenPatientHeaderViewNullThrowsException()
        {
            PatientInformationPresenter patientInformationPresenter = new PatientInformationPresenter(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PatientInformationPresenterConstructorGivenPatientBONullThrowsException()
        {
            IPatientInformationView uroCareEntity = A.Fake<IPatientInformationView>();
            
            PatientBO patient = null;
            PatientInformationPresenter patientInformationView = new PatientInformationPresenter(uroCareEntity, patient);                 
        }

        [TestMethod]
        public void InitializeViewGivenPatientInformationSetsCorrectValueToPatientInformationPresenter()
        {
            IPatientInformationView patientInformationView = A.Fake<IPatientInformationView>();

            PatientBO testPatient = TestBusinessObjectFactory.GetTestPatient();
            PatientInformationPresenter patientInformationPresenter = new PatientInformationPresenter(patientInformationView, testPatient);
            patientInformationPresenter.InitViewFromModel();

            Assert.AreEqual(testPatient.RegistrationDate, patientInformationView.RegistrationDate);
            Assert.AreEqual(string.Format("{0}/{1}", testPatient.GUNo, testPatient.GUYear), patientInformationView.GUId);
            Assert.AreEqual(testPatient.Salutation, patientInformationView.Salutation);
            Assert.AreEqual(testPatient.PatientName, patientInformationView.PatientName);
            Assert.AreEqual(testPatient.AtPost, patientInformationView.AtPost);
            Assert.AreEqual(testPatient.Town, patientInformationView.Town);
            Assert.AreEqual(testPatient.District, patientInformationView.District);
            Assert.AreEqual(testPatient.State, patientInformationView.State);
            Assert.AreEqual(testPatient.PhoneNumber, patientInformationView.Phone);
            Assert.AreEqual(testPatient.Mobile, patientInformationView.Mobile);
            Assert.AreEqual(testPatient.Sex, patientInformationView.Sex);
            Assert.AreEqual(testPatient.Occupation, patientInformationView.Occupation);
            Assert.AreEqual(testPatient.AgeYear, patientInformationView.AgeYear);
            Assert.AreEqual(testPatient.AgeMonths, patientInformationView.AgeMonths);
            Assert.AreEqual(testPatient.ReferenceDoctor.DoctorId, patientInformationView.ReferalDoctor.DoctorId);

            Assert.AreEqual(testPatient.OPDDiagnosis, patientInformationView.OPDDiagnosis);
        }

        [TestMethod]
        public void PopulateDataGivenZeroGuNumberInitializeView()
        {
            IPatientInformationView patientInformationView = A.Fake<IPatientInformationView>();

            PatientBO testPatient = new PatientBO();
            PatientInformationPresenter patientInformationPresenter = new PatientInformationPresenter(patientInformationView, testPatient);
            patientInformationPresenter.PopulateData(testPatient);

            Assert.AreEqual(DateTime.Today, patientInformationView.RegistrationDate);
            Assert.AreEqual(string.Format("0000/{0}", DateTime.Today.Year), patientInformationView.GUId);
            Assert.AreEqual("Mr", patientInformationView.Salutation);
            Assert.AreEqual(string.Empty, patientInformationView.PatientName);
            Assert.AreEqual(string.Empty, patientInformationView.AtPost);
            Assert.AreEqual(string.Empty, patientInformationView.Town);
            Assert.AreEqual(string.Empty, patientInformationView.District);
            Assert.AreEqual("Maharashtra", patientInformationView.State);
            Assert.AreEqual(string.Empty, patientInformationView.Phone);
            Assert.AreEqual(string.Empty, patientInformationView.Mobile);
            Assert.AreEqual(SexEnum.Male, patientInformationView.Sex);
            Assert.AreEqual(string.Empty, patientInformationView.Occupation);
            Assert.AreEqual(0, patientInformationView.AgeYear);
            Assert.AreEqual(0, patientInformationView.AgeMonths);
            Assert.AreEqual(0, patientInformationView.ReferalDoctor.DoctorId);
            Assert.AreEqual(string.Empty, patientInformationView.OPDDiagnosis);
        }

        [TestMethod]
        public void PopulateDataGivenValidPatientGUNumberInitializeView()
        {
            IPatientInformationView patientInformationView = A.Fake<IPatientInformationView>();

            PatientBO testPatient = TestBusinessObjectFactory.GetTestPatient();
            PatientInformationPresenter patientInformationPresenter = new PatientInformationPresenter(patientInformationView);
            patientInformationPresenter.PopulateData(testPatient);

            Assert.AreEqual(testPatient.RegistrationDate, patientInformationView.RegistrationDate);
            Assert.AreEqual(string.Format("{0}/{1}", testPatient.GUNo, testPatient.GUYear), patientInformationView.GUId);
            Assert.AreEqual(testPatient.Salutation, patientInformationView.Salutation);
            Assert.AreEqual(testPatient.PatientName, patientInformationView.PatientName);
            Assert.AreEqual(testPatient.AtPost, patientInformationView.AtPost);
            Assert.AreEqual(testPatient.Town, patientInformationView.Town);
            Assert.AreEqual(testPatient.District, patientInformationView.District);
            Assert.AreEqual(testPatient.State, patientInformationView.State);
            Assert.AreEqual(testPatient.PhoneNumber, patientInformationView.Phone);
            Assert.AreEqual(testPatient.Mobile, patientInformationView.Mobile);
            Assert.AreEqual(testPatient.Sex, patientInformationView.Sex);
            Assert.AreEqual(testPatient.Occupation, patientInformationView.Occupation);
            Assert.AreEqual(testPatient.AgeYear, patientInformationView.AgeYear);
            Assert.AreEqual(testPatient.AgeMonths, patientInformationView.AgeMonths);
            Assert.AreEqual(testPatient.ReferenceDoctor.DoctorId, patientInformationView.ReferalDoctor.DoctorId);
            Assert.AreEqual(testPatient.OPDDiagnosis, patientInformationView.OPDDiagnosis);
        }

        [TestMethod]
        public void ReferalDoctorGivenNoRecordsReturnsOneRecordPleaseSelectOne()
        {
            IPatientInformationView patientInformationView = A.Fake<IPatientInformationView>();

            PatientInformationPresenter patientInformationPresenter = new PatientInformationPresenter(patientInformationView);
            List<ComboBoxItem> items = patientInformationPresenter.ReferalDoctors();

            Assert.IsTrue(1 == items.Count);
            Assert.AreEqual("Please select one...", items[0].Text);
            
        }

        [TestMethod]
        public void ReferalDoctorGivenValidRecordsReturnsValidList()
        {
            Doctors_List referalDoctor = TestDataModelObjects.GetTestDoctor();

            IUROCareEntities dataContext = DataAccessLayer.GetDataContext();
            dataContext.Doctors_List.Add(referalDoctor);
          
            IPatientInformationView patientInformationView = A.Fake<IPatientInformationView>();

            PatientInformationPresenter patientInformationPresenter = new PatientInformationPresenter(patientInformationView);
            List<ComboBoxItem> items = patientInformationPresenter.ReferalDoctors();

            Assert.IsTrue(2 == items.Count);
            Assert.AreEqual("Please select one...", items[0].Text);
            Assert.AreEqual(referalDoctor.ID, items[1].ID);
        }

        [TestMethod]
        public void SexListReturnsValidList()
        {
            IPatientInformationView patientInformationView = A.Fake<IPatientInformationView>();

            PatientInformationPresenter patientInformationPresenter = new PatientInformationPresenter(patientInformationView);
            List<SexEnum> items = patientInformationPresenter.SexList;

            Assert.IsTrue(2 == items.Count);
            Assert.AreEqual(SexEnum.Male, items[0]);
            Assert.AreEqual(SexEnum.Female, items[1]);
        }

        #endregion
    }
}
