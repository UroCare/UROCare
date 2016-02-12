using System;
using System.Windows.Forms;
using SHC.UROCare.UROCareBusinessObjects;

namespace SHC.UROCare.UI
{
    public interface IChildControl
    {
        void PopulateControl(PatientBO patient);
    }
    public class ChildControl: UserControl, IChildControl
    {
        public virtual void PopulateControl(PatientBO patient)            
        {
        
        }
    }

}