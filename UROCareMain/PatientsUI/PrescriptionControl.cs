using System;
using System.Windows.Forms;
using SHC.UROCare.UIFramework;

namespace SHC.UROCare.UI
{
    public partial class PrescriptionControl : ChildControl
    {
        #region Private fields

        private UrologyHistoryPresenter _urologyHistoryPresenter;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to create the instance of control. 
        /// </summary>
        public PrescriptionControl()
        {
            InitializeComponent();
            ProcessRecommendedColors();
            InitializeControl();

            //_operationPresenter = new OperationPresenter(this);
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
            _prescriptionDate.Focus();
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