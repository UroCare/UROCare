using System;
using System.Windows.Forms;
using SHC.UROCare.UIFramework;
using SHC.UROCare.UROCareBusinessObjects;

namespace SHC.UROCare.UI
{
    public partial class TreatmentControl : ChildControl, ITreatmentView
    {
        #region Private fields

        private UrologyHistoryPresenter _urologyHistoryPresenter;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to create the instance of control. 
        /// </summary>
        public TreatmentControl()
        {
            InitializeComponent();
            ProcessRecommendedColors();
            InitializeControl();

            //_treatmentPresenter = new TreatmentPresenter(this);
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
            _treatmentDateTextBox.Focus();
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or set treatment date value.
        /// </summary>
        public DateTime TreatmentDate 
        {
            get
            {
                return Convert.ToDateTime(_treatmentDateTextBox.Text);
            }
            set
            {
                _treatmentDateTextBox.Text = value.ToShortDateString();
            }
        }

        /// <summary>
        /// Gets or set treatment given.
        /// </summary>
        public string TreatmentGiven 
        {
            get
            {
                return _treatmentGivenTextBox.Text;
            }
            set
            {
                _treatmentGivenTextBox.Text = value;
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