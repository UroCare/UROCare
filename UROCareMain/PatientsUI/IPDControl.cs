using System;
using System.Windows.Forms;
using SHC.UROCare.UIFramework;
using SHC.UROCare.UROCareBusinessObjects;

namespace SHC.UROCare.UI
{
    public partial class IPDControl : ChildControl, IIPDView
    {
        #region Private fields

        private UrologyHistoryPresenter _urologyHistoryPresenter;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to create the instance of control. 
        /// </summary>
        public IPDControl()
        {
            InitializeComponent();
            ProcessRecommendedColors();
            InitializeControl();

            //_ipdPresenter = new IPDPresenter(this);
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Process recommended colors to control.
        /// </summary>
        private void ProcessRecommendedColors()
        {
            RecommendedColors colors = UIFrameWorkClass.Instance.GetRecommendedColors();
            BackColor = colors.BackColor;

        }

        /// <summary>
        /// Initializes control.
        /// </summary>
        private void InitializeControl()
        {
            _admissionDateTextBox.Focus();
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or set admission date value.
        /// </summary>
        public DateTime AdmissionDate 
        {
            get
            {
                return Convert.ToDateTime(_admissionDateTextBox.Text);
            }
            set
            {
                _admissionDateTextBox.Text = value.ToShortDateString();
            }
        }

        /// <summary>
        /// Gets or set discharge date value.
        /// </summary>
        public DateTime DischargeDate
        {
            get
            {
                return Convert.ToDateTime(_dischargeDateTextBox.Text);
            }
            set
            {
                _dischargeDateTextBox.Text = value.ToShortDateString();
            }
        }

        /// <summary>
        /// Gets or set follow up date value.
        /// </summary>
        public DateTime FollowupDate
        {
            get
            {
                return Convert.ToDateTime(_followupDateTextBox.Text);
            }
            set
            {
                _followupDateTextBox.Text = value.ToShortDateString();
            }
        }

        /// <summary>
        /// Gets or set Anaesthesiologist given.
        /// </summary>
        public string IPDNo
        {
            get
            {
                return _ipdNoTextBox.Text;
            }
            set
            {
                _ipdNoTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get or set Provisional Diagnosis.
        /// </summary>
        public string ProvisionalDiagnosis
        {
            get
            {
                return _provisionalDiagnosisTextBox.Text;
            }
            set
            {
                _provisionalDiagnosisTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get or Set Complaints.
        /// </summary>
        public string Complaints
        {
            get
            {
                return _complaintsTextBox.Text;
            }
            set
            {
                _complaintsTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get or set final diagnosis
        /// </summary>
        public string FinalDiagnosis
        {
            get
            {
                return _finalDiagnosisTextBox.Text;
            }
            set
            {
                _finalDiagnosisTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get or set advise.
        /// </summary>
        public string Advise
        {
            get
            {
                return _adviseTextBox.Text;
            }
            set
            {
                _adviseTextBox.Text = value;
            }
        }

        #endregion       

        #region Child Control Implementation

        /// <summary>
        /// Populates control
        /// </summary>
        /// <param name="patient">Patient</param>
        public override void PopulateControl(PatientBO patient)
        {

        }

        #endregion
    }
}