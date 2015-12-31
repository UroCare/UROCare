using System;
using System.Windows.Forms;


namespace SHC.UROCare.UI
{
    public interface IChildControl
    {
        void PopulateControl(int guNo, int guYear);
    }
    public class ChildControl: UserControl, IChildControl
    {
        public virtual void PopulateControl(int guNo, int guYear)
            
        {
        
        }
    }

}