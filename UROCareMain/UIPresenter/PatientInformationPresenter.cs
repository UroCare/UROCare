using System;
using System.Collections.Generic;
using SHC.UROCare.UROCareBusinessObjects;
using SHC.UROCare.Utilities;
using System.Globalization;
using SHC.UROCare.UICommonControls;

namespace SHC.UROCare.UI
{
    public class PatientInformationPresenter : IPresenterBase<IPatientInformationView,PatientBO>
    {
        #region Private fields

        private readonly PatientBO _patient;
        private readonly IPatientInformationView _patientHeaderView;
      
        #endregion

        #region Constructors

        /// <summary>
        /// Constructor to create  instance of the presenter.
        /// </summary>
        /// <param name="patientHeaderView">View of presenter</param>
        public PatientInformationPresenter(IPatientInformationView patientHeaderView) : this(patientHeaderView, new PatientBO())
        {
        }

        /// <summary>
        /// Constructor to create instance of the presenter.
        /// </summary>
        /// <param name="patientHeaderView">View of the presenter associated with.</param>
        /// <param name="patient">Patient whose information would be populated.</param>
        public PatientInformationPresenter(IPatientInformationView patientHeaderView, PatientBO patient)
        {
            if (null == patientHeaderView)
            {
                ExceptionManager.Throw(new ArgumentNullException("patientHeaderView"));
            }

            if (null == patient)
            {
                ExceptionManager.Throw(new ArgumentNullException("patient"));
            }
            _patientHeaderView = patientHeaderView;
            _patient = patient;
        }

        /// <summary>
        /// Default contructor
        /// </summary>
        protected PatientInformationPresenter()
        {
        }

        #endregion

        #region Implementation of IPresenterBase

        /// <summary>
        /// Initializes view from the database 
        /// </summary>
        public void InitViewFromModel()
        {
            //_patientHeaderView.PatientImage = 
            _patientHeaderView.GUId = string.Format("{0}/{1}",_patient.GUNo,_patient.GUYear);
            _patientHeaderView.RegisterationDate = _patient.RegistrationDate.ToString("dd/MM/yyyy", CultureInfo.CurrentCulture);

            _patientHeaderView.Salutation = _patient.Salutation;
            _patientHeaderView.PatientName = _patient.PatientName;
            _patientHeaderView.AtPost = _patient.AtPost;
            _patientHeaderView.Town = _patient.Town;
            _patientHeaderView.District = _patient.District;
            _patientHeaderView.State = _patient.State;
            _patientHeaderView.Sex = _patient.Sex;
            _patientHeaderView.AgeMonths = _patient.AgeMonths;
            _patientHeaderView.AgeYears = _patient.AgeYear;
            _patientHeaderView.Phone = _patient.PhoneNumber;
            _patientHeaderView.Mobile = _patient.Mobile;
            _patientHeaderView.Ocupation = _patient.Occupation;
            _patientHeaderView.ReferalDoctor = _patient.ReferenceDoctor;
            _patientHeaderView.OPDDiagnosis = _patient.OPDDiagnosis;
        }

        /// <summary>
        /// Saves model object to the database.
        /// </summary>
        public void Save()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the model object of the presenter.
        /// </summary>
        public PatientBO ModelObject
        {
            get
            {
                return _patient;
            }
        }

        /// <summary>
        /// Gets view of the presenter.
        /// </summary>
        public IPatientInformationView View
        {
            get
            {
                return _patientHeaderView;
            }
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets sexes
        /// </summary>
        public List<SexEnum> Sexes
        {
            get
            {
                return new List<SexEnum>()
                           {
                               SexEnum.Male,
                               SexEnum.Female
                           };
            }
        }

        #endregion
             
        #region Public Methods

        /// <summary>
        /// Initializes view
        /// </summary>
        public void InitializeView()
        {
            _patientHeaderView.SexCombo = Sexes;
            _patientHeaderView.ReferalDoctorList = ReferalDoctors();
            InitializePatientInformation();            
        }

        /// <summary>
        /// Populates data
        /// </summary>
        /// <param name="patient">Patient to populate</param>
        public void PopulateData(PatientBO patient)
        {
            if (patient.GUNo == 0)
            {
                InitializeView();
            }
            else
            {
                _patient.Copy(patient);
                InitViewFromModel();
            }            
        }

        /// <summary>
        /// Clears Control Value
        /// </summary>
        public void ClearControls()
        {
        
        }

        /// <summary>
        /// Get referal doctors list
        /// </summary>
        /// <returns>List of combo items</returns>
        public List<ComboBoxItem> ReferalDoctors()
        {
            List<ComboBoxItem> referalDoctors = new List<ComboBoxItem>();
            DoctorsListObjectCollection doctorsListCollection = new DoctorsListObjectCollection();
            doctorsListCollection.Fill();

            referalDoctors.Add(new ComboBoxItem(0,() => Strings.PleaseSelectOne, new DoctorsListBO()));
            foreach (DoctorsListBO doctor in doctorsListCollection)
            {
                referalDoctors.Add(new ComboBoxItem(doctor.DoctorId,() => doctor.DoctorName, doctor));
            }
            return referalDoctors;
        }

        #endregion       

        #region Private Methods

        /// <summary>
        /// Initializes control
        /// </summary>
        private void InitializePatientInformation()
        {
            _patientHeaderView.Salutation = "Mr";
            _patientHeaderView.GUId = string.Format("0000/{0}", DateTime.Today.Year);
            _patientHeaderView.RegisterationDate = DateTime.Today.ToString("dd/MM/yyyy", CultureInfo.CurrentCulture);
            _patientHeaderView.State = "Maharashtra";
            _patientHeaderView.AgeMonths = 0;
            _patientHeaderView.AgeYears = 0;
            _patientHeaderView.AtPost = string.Empty;
            _patientHeaderView.District = string.Empty;
            _patientHeaderView.Mobile = string.Empty;
            _patientHeaderView.Ocupation = string.Empty;
            _patientHeaderView.PatientName = string.Empty;
            _patientHeaderView.Phone = string.Empty;
            _patientHeaderView.ReferalDoctor = new DoctorsListBO();
            _patientHeaderView.State = string.Empty;
            _patientHeaderView.Town = string.Empty;
        }
     
        #endregion
    }
}