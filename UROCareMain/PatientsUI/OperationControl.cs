using System.Windows.Forms;
using SHC.UROCare.UROCareBusinessObjects;

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
        /// Populates control
        /// </summary>
        /// <param name="patient">Patient</param>
        public override void PopulateControl(PatientBO patient)
        {

        }

        #endregion
    }
}