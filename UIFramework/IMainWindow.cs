using System.Windows.Forms;

namespace SHC.UROCare.UIFramework
{
    public interface IMainWindow
    {
        /// <summary>
        ///   Gets the menu bar of the main window.
        /// </summary>
        Menu MenuBar { get; }

        /// <summary>
        ///   Sets the current control to main window.
        /// </summary>
        /// <param name="userControl"> Current user control to be added to Main form. </param>
        void SetCurrentControl(UserControl userControl);
    }
}