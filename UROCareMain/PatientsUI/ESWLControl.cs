using System;
using System.Windows.Forms;
using SHC.UROCare.UIFramework;
using SHC.UROCare.UROCareBusinessObjects;

namespace SHC.UROCare.UI
{
    public partial class ESWLControl : ChildControl, IESWLView
    {
        #region Private fields

        private UrologyHistoryPresenter _urologyHistoryPresenter;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to create the instance of control. 
        /// </summary>
        public ESWLControl()
        {
            InitializeComponent();
            ProcessRecommendedColors();
            InitializeControl();

            //_eswlPresenter = new ESWLPresenter(this);
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
            _eswlDate.Focus();
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or set ESWL date value.
        /// </summary>
        public DateTime ESWLDate 
        {
            get
            {
                return Convert.ToDateTime(_eswlDate.Text);
            }
            set
            {
                _eswlDate.Text = value.ToShortDateString();
            }
        }

        /// <summary>
        /// Gets or set ESWL Size value.
        /// </summary>
        public string ESWLSize 
        {
            get
            {
                return _eswlSizeTextBox.Text;
            }
            set
            {
                _eswlSizeTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets Side value.
        /// </summary>
        public string Side
        {
            get
            { 
                return _sideTextBox.Text; 
            }
            set
            {
                _sideTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets Site.
        /// </summary>
        public string ESWLSite
        {
            get
            {
                return _siteTextBox.Text;
            }
            set
            {
                _siteTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets Shock Waves.
        /// </summary>
        public string SockWaves 
        {
            get
            {
                return _shockWaves.Text;
            }
            set
            {
                _shockWaves.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets ESWL level.
        /// </summary>
        public string ESWLLevel 
        {
            get
            {
                return _levelTextBox.Text;
            }
            set
            {
                _levelTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets Fluroscopy value.
        /// </summary>
        public string Fluroscopy 
        { 
            get
            {
                return _fluroscopy.Text;
            }
            set
            {
                _fluroscopy.Text = value;
            }
         }

        /// <summary>
        /// Gets or sets Analgesic value.
        /// </summary>
        public string Analgesic 
        { 
            get
            {
                return _analgesicTextBox.Text;
            }
            set
            {
                _analgesicTextBox.Text = value;
            }
         }

        /// <summary>
        /// Gets or sets IV Fluids.
        /// </summary>
        public string IVFluids 
        {
            get
            {
                return _ivFluids.Text;
            }
            set
            {
                _ivFluids.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets Complications value.
        /// </summary>
        public string Complications
        {
            get
            {
                return _complicationsTextBox.Text;
            }
            set
            {
                _complicationsTextBox.Text = value;
            }
        }
        /// <summary>
        /// Gets or sets Comments value.
        /// </summary>
        public string Comments 
        {
            get
            {
                return _comments.Text;
            }
            set
            {
                _comments.Text = value;
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