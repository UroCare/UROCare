using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SHC.UROCare.UIFramework;
using SHC.UROCare.UROCareBusinessObjects;

namespace SHC.UROCare.UI
{
    public partial class PatientInformationControl : ChildControl, IPatientInformationView
    {
        #region Private fields

        private readonly PatientInformationPresenter _patientInformationPresenter;

        #endregion

        #region Public constructor

        /// <summary>
        /// Constructor to create instance of control.
        /// </summary>
        public PatientInformationControl()
        {
            _patientInformationPresenter = new PatientInformationPresenter(this);
            InitializeComponent();            
            ProcessRecommendedColors();
            InitializeControl();
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets GUID of patient.
        /// </summary>
        public string GUId
        {
            get
            {
                return _guNoTextBox.Text;
            }
            set
            {
                _guNoTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets Registration date of the patient.
        /// </summary>
        public string RegisterationDate
        {
            get
            {
                return _registrationDate.Text;
            }
            set
            {
                _registrationDate.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets patient image.
        /// </summary>
        public Image PatientImage
        {
            get
            {
                return _patientPicture.Image;
            }
            set
            {
                _patientPicture.Image = value;
            }
        }
        
        /// <summary>
        /// Gets or
        /// </summary>
        public string Salutation
        {
            get
            {
                return _salutation.SelectedItem.ToString();
            }
            set
            {
                _salutation.SelectedItem = value;
            }
        }

        /// <summary>
        /// Gets or sets patient name.
        /// </summary>
        public string PatientName
        {
            get
            {
                return _patientName.Text;
            }
            set
            {
                _patientName.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets AtPost of the patient.
        /// </summary>
        public string AtPost
        {
            get
            {
                return _atPost.Text;
            }
            set
            {
                _atPost.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets town name of patient
        /// </summary>
        public string Town
        {
            get
            {
                return _town.Text;
            }
            set
            {
                _town.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets District  of the patient.
        /// </summary>
        public string District
        {
            get
            {
                return _district.Text;
            }
            set
            {
                _district.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets State of the patient.
        /// </summary>
        public string State
        {
            get
            {
                return _state.SelectedText;
            }
            set
            {
                _state.SelectedItem = value;
            }
        }

        /// <summary>
        /// Gets or sets Phone of the patient.
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone.Text;
            }
            set
            {
                _phone.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets mobile number of patient.
        /// </summary>
        public string Mobile
        {
            get
            {
                return _mobile.Text;
            }
            set
            {
                _mobile.Text = value;
            }
        }

        /// <summary>
        /// Gets age years of the patient.
        /// </summary>
        public int AgeYears
        {
            get
            {
                return (int)_years.Value;
            }
            set
            {
                _years.Value = value;
            }
        }

        /// <summary>
        /// Gets or sets AgeMonths of the patient.
        /// </summary>
        public int AgeMonths
        {
            get
            {
                return (int)_months.Value;
            }
            set
            {
                _months.Value = value;
            }
        }

        /// <summary>
        /// Gets or sets Sex of the patient 
        /// </summary>
        public SexEnum Sex
        {
            get
            {
                return (SexEnum) Enum.Parse(typeof (SexEnum), _sexComboBox.SelectedItem.ToString());
            }
            set
            {
                _sexComboBox.SelectedItem = value;
            }
        }

        /// <summary>
        /// Gets or sets Occupation of the patient.
        /// </summary>
        public string Ocupation
        {
            get
            {
                return _occupation.Text;
            }
            set
            {
                _occupation.Text = value;
            }
        }
        
        /// <summary>
        /// Gets or sets Referal doctor.
        /// </summary>
        public string ReferalDoctor
        {
            get
            {
                return _referalDoctorComboBox.SelectedValue.ToString();
            }
            set
            {
                _referalDoctorComboBox.SelectedItem = value;
            }
        }

        /// <summary>
        /// Get or Set OPD Diagnosis.
        /// </summary>
        public string OPDDiagnosis
        {
            get
            {
                return _opdDiagnosis.Text;
            }
            set
            {
                _opdDiagnosis.Text = value;
            }
        }
                
        public List<SexEnum> SexCombo
        {
            //get
            //{
            //    return _sexComboBox.DataSource as List<SexEnum>;
            //}
            set
            {
                _sexComboBox.DataSource = value;
            }
        }

        #endregion

        #region Public Methods

        
        #endregion
     
        #region Private methods

        /// <summary>
        /// Process recommended colors
        /// </summary>
        private void ProcessRecommendedColors()
        {
            RecommendedColors colors = UIFrameWorkClass.Instance.GetRecommendedColors();
            BackColor = colors.BackColor;
            _mainPanel.BackColor = BackColor;
            _registrationDetails.BackColor = BackColor;
            _contactGroup.BackColor = BackColor;
        }

        /// <summary>
        /// Initialize controls
        /// </summary>
        private void InitializeControl()
        {
            _registrationDate.Focus();
            InitializeReferalDoctorsList();
            _patientInformationPresenter.InitializeView();

        }

        /// <summary>
        /// Initialized referal doctors list.
        /// </summary>
        private void InitializeReferalDoctorsList()
        {

        }

        #endregion

        #region Protected overrides

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.SystemColorsChanged"/> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
        protected override void OnSystemColorsChanged(EventArgs e)
        {
            base.OnSystemColorsChanged(e);
            ProcessRecommendedColors();
        }

        #endregion

        #region Child Control Implementation

        /// <summary>
        /// Populates patient information control
        /// </summary>
        /// <param name="patient">Patient</param>
        public override void PopulateControl(PatientBO patient)
        {
            _patientInformationPresenter.PopulateData(patient);
        }

        #endregion
        
    }
}