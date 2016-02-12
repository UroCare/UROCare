using System;
using System.Windows.Forms;
using SHC.UROCare.UIFramework;
using SHC.UROCare.UROCareBusinessObjects;

namespace SHC.UROCare.UI
{
    public partial class FollowupControl : ChildControl
    {
        #region Private fields

        private UrologyHistoryPresenter _urologyHistoryPresenter;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to create the instance of control. 
        /// </summary>
        public FollowupControl()
        {
            InitializeComponent();
            ProcessRecommendedColors();
            InitializeControl();

            //_followupPresenter = new FollowupPresenter(this);
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
            this.Focus();
            _dateTextBox.Select();
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or set follow up date value.
        /// </summary>
        public DateTime FollowupDate 
        {
            get
            {
                return Convert.ToDateTime(_dateTextBox.Text);
            }
            set
            {
                _dateTextBox.Text = value.ToShortDateString();
            }
        }

        /// <summary>
        /// Gets or set Complaints given.
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
        /// Get or set Evaluation.
        /// </summary>
        public string Evaluation
        {
            get
            {
                return _evaluationTextBox.Text;
            }
            set
            {
                _evaluationTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get or Set treatment.
        /// </summary>
        public string Treatment
        {
            get
            {
                return _treatmentTextBox.Text;
            }
            set
            {
                _treatmentTextBox.Text = value;
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