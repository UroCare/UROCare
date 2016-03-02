using System;
using System.Windows.Forms;

namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    /// Customized combo box.
    /// </summary>
    public class CustomComboBox : ComboBox
    {
        #region Private fields

        private string _defaultText = Strings.PleaseSelectOne;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public CustomComboBox()
        {
            SuspendLayout();
            DefaultText = Strings.PleaseSelectOne;
            ResumeLayout(true);
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets Default text of combo box
        /// </summary>
        public string DefaultText
        {
            get
            {
                return _defaultText;
            }
            set
            {
                _defaultText = value;
                Text = _defaultText;
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ComboBox.SelectedIndexChanged"/> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            if (SelectedIndex == -1)
            {
                Text = DefaultText;
            }
        }

        #endregion
    }   
}