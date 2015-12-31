using System.Globalization;
using System.Windows.Forms;
using SHC.UROCare.UIFramework;

namespace SHC.UROCare.UI
{
    public partial class PatientExaminationControl : ChildControl, IPatientExaminationView
    {
        #region Private fields

        private PatientExaminationPresenter _patientsExaminationPresenter;

        #endregion

        #region Public constructor

        /// <summary>
        /// Constructor to create the instance of control.
        /// </summary>
        public PatientExaminationControl()
        {
            InitializeComponent();
            ProcessRecommendedColors();
            InitializeControl();
            //_patientsExaminationPresenter = new PatientExaminationPresenter(this);
        }

        #endregion

        #region Private Methods

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
            _generalExaminationTextBox.Focus();
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets blood pressure value.
        /// </summary>
        public string BloodPressure
        {
            get
            {
                return _bloodPressureTextBox.Text;
            }
            set
            {
                _bloodPressureTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets weight vlaue.
        /// </summary>
        public string Weight
        {
            get
            {
                return _weightTextBox.Text;
            }
            set
            {
                _weightTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets general examination value.
        /// </summary>
        public string GeneralExamination
        {
            get
            {
                return _generalExaminationTextBox.Text;
            }
            set
            {
                _generalExaminationTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets pulse.
        /// </summary>
        public int Pulse
        {
            get
            {
                return int.Parse(_pulseTextBox.Text);
            }
            set
            {
                _pulseTextBox.Text = value.ToString(CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Gets or sets abdomen value.
        /// </summary>
        public string Abdomen
        {
            get
            {
                return _abdomenTextBox.Text;
            }
            set
            {
                _abdomenTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets Genitalia value.
        /// </summary>
        public string Genitalia
        {
            get
            {
                return _genitaliaTextBox.Text;
            }
            set
            {
                _genitaliaTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets Anal tone.
        /// </summary>
        public string AnalTone
        {
            get
            {
                return _analToneTextBox.Text;
            }
            set
            {
                _analToneTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets BCR.
        /// </summary>
        public string BCR
        {
            get
            {
                return _bcrTextBox.Text;
            }
            set
            {
                _bcrTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets Prostate.
        /// </summary>
        public string Prostate
        {
            get
            {
                return _prostateTextBox.Text;
            }
            set
            {
                _prostateTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets others.
        /// </summary>
        public string PROthers
        {
            get
            {
                return _othersTextBox.Text;
            }
            set
            {
                _othersTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets PS.
        /// </summary>
        public string PS
        {
            get
            {
                return _psTextBox.Text;
            }
            set
            {
                _psTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets PV.
        /// </summary>
        public string PV
        {
            get
            {
                return _psTextBox.Text;
            }
            set
            {
                _pvTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or set CNS.
        /// </summary>
        public string CNS
        {
            get
            {
                return _cnsTextBox.Text;
            }
            set
            {
                _cnsTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets CVS.
        /// </summary>
        public string CVS
        {
            get
            {
                return _cvsTextBox.Text;
            }
            set
            {
                _cvsTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets RS.
        /// </summary>
        public string RS
        {
            get
            {
                return _rsTextBox.Text;
            }
            set
            {
                _rsTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets Remarks.
        /// </summary>
        public string Remarks
        {
            get
            {
                return _remarksTextBox.Text;
            }
            set
            {
                _remarksTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets others examination.
        /// </summary>
        public string OthersExamination
        {
            get
            {
                return _othersExaminationTextBox.Text;
            }
            set
            {
                _othersExaminationTextBox.Text = value;
            }
        }

        #endregion

        #region Child Control Implementation

        /// <summary>
        /// Populates patient information control
        /// </summary>
        /// <param name="guNo">GU No</param>
        /// <param name="guYear">GU Year</param>
        public override void PopulateControl(int guNo, int guYear)
        {

        }

        #endregion
    }
}