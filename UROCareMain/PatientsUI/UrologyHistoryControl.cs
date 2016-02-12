using System.Windows.Forms;
using SHC.UROCare.UIFramework;
using SHC.UROCare.UROCareBusinessObjects;

namespace SHC.UROCare.UI
{
    public partial class UrologyHistoryControl : ChildControl, IUrologyHistoryView
    {
        #region Private fields

        private UrologyHistoryPresenter _urologyHistoryPresenter;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to create the instance of control. 
        /// </summary>
        public UrologyHistoryControl()
        {
            InitializeComponent();
            ProcessRecommendedColors();
            InitializeControl();
            //_urologyHistoryPresenter = new UrologyHistoryPresenter(this);
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
            _chiefComplaintTextBox.Focus();           
        }
        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets Chief complaint.
        /// </summary>
        public string ChiefComplaints
        {
            get
            {
                return _chiefComplaintTextBox.Text;
            }
            set
            {
                _chiefComplaintTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or set frequency value.
        /// </summary>
        public string Frequency
        {
            get
            {
                return _frequencyTextBox.Text;
            }
            set
            {
                _frequencyTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets hesitancy value.
        /// </summary>
        public string Hesitancy
        {
            get
            {
                return _hesitancyTextBox.Text;
            }
            set
            {
                _hesitancyTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets nocturia.
        /// </summary>
        public string Nocturia
        {
            get
            {
                return _nocturiaTextBox.Text;
            }
            set
            {
                _nocturiaTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets poor stream.
        /// </summary>
        public string PoorStream
        {
            get
            {
                return _poorStreamTextBox.Text;
            }
            set
            {
                _poorStreamTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets urgency value.
        /// </summary>
        public string Urgency
        {
            get
            {
                return _urgencyTextBox.Text;
            }
            set
            {
                _urgencyTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets intermittency value.
        /// </summary>
        public string Intermittency
        {
            get
            {
                return _intermittencyTextBox.Text;
            }
            set
            {
                _intermittencyTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets dysuria value.
        /// </summary>
        public string Dysuria
        {
            get
            {
                return _dysuriaTextBox.Text;
            }
            set
            {
                _dysuriaTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets straining.
        /// </summary>
        public string Straining
        {
            get
            {
                return _strainingTextBox.Text;
            }
            set
            {
                _strainingTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets pyuria value.
        /// </summary>
        public string Pyuria
        {
            get
            {
                return _pyUriaTextBox.Text;
            }
            set
            {
                _pyUriaTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets sesn of inc void value.
        /// </summary>
        public string SenseOfIncVoid
        {
            get
            {
                return _sensOfIncVoidTextBox.Text;
            }
            set
            {
                _sensOfIncVoidTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or set lythuria value.
        /// </summary>
        public string Lythuria
        {
            get
            {
                return _lythiUriaTextBox.Text;
            }
            set
            {
                _lythiUriaTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets terminal dibling.
        /// </summary>
        public string TerminalDibling
        {
            get
            {
                return _terminalDiblingTextBox.Text;
            }
            set
            {
                _terminalDiblingTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets Chyluria value.
        /// </summary>
        public string Chyluria
        {
            get
            {
                return _chyluriaTextBox.Text;
            }
            set
            {
                _chyluriaTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets urge incontinence value.
        /// </summary>
        public string UrgeIncontinence
        {
            get
            {
                return _urgeIncontinenceTextBox.Text;
            }
            set
            {
                _urgeIncontinenceTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets Fever value.
        /// </summary>
        public string Fever
        {
            get
            {
                return _feverTextBox.Text;
            }
            set
            {
                _frequencyTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets stress incontinences value.
        /// </summary>
        public string StressIncontinence
        {
            get
            {
                return _stressIncontinenceTextBox.Text;
            }
            set
            {
                _stressIncontinenceTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets IPSS value.
        /// </summary>
        public string IPSS
        {
            get
            {
                return _ipssTextBox.Text;
            }
            set
            {
                _ipssTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets pain value.
        /// </summary>
        public string Pain
        {
            get
            {
                return _painTextBox.Text;
            }
            set
            {
                _painTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets hematuria value.
        /// </summary>
        public string Hematuria
        {
            get
            {
                return _hematuriaTextBox.Text;
            }
            set
            {
                _hematuriaTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or set bpi value.
        /// </summary>
        public string BPI
        {
            get
            {
                return _bpiTextBox.Text;
            }
            set
            {
                _bpiTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets others value.
        /// </summary>
        public string Others
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
        /// Gets or sets medication value.
        /// </summary>
        public string Medication
        {
            get
            {
                return _medicationTextBox.Text;
            }
            set
            {
                _medicationTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets personal value.
        /// </summary>
        public string Personal
        {
            get
            {
                return _personalTextBox.Text;
            }
            set
            {
                _personalTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets Surgery value.
        /// </summary>
        public string Surgery
        {
            get
            {
                return _surgeryTextBox.Text;
            }
            set
            {
                _surgeryTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets MH value.
        /// </summary>
        public string MH
        {
            get
            {
                return _mhTextBox.Text;
            }
            set
            {
                _mhTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets allergies value.
        /// </summary>
        public string Allergies
        {
            get
            {
                return _allergiesTextBox.Text;
            }
            set
            {
                _allergiesTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets allergies value.
        /// </summary>
        public string OBGY
        {
            get
            {
                return _obGyTextBox.Text;
            }
            set
            {
                _obGyTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets past text value.
        /// </summary>
        public string Past
        {
            get
            {
                return _pastTextBox.Text;
            }
            set
            {
                _pastTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets family value.
        /// </summary>
        public string Family
        {
            get
            {
                return _familyTextBox.Text;
            }
            set
            {
                _familyTextBox.Text = value;
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