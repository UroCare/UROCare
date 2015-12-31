using System.Windows.Forms;

namespace SHC.UROCare.UI
{
    public partial class OperationControl : ChildControl
    {
        public OperationControl()
        {
            InitializeComponent();
        }

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