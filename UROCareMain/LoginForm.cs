using System;
using System.Windows.Forms;

namespace SHC.UROCare.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            //if (ValidateControl())
            //{
            //}
            Hide();
            DialogResult = DialogResult.OK;
        }

        private bool ValidateControl()
        {
            bool result = false;
            ClearError();

            if (string.IsNullOrEmpty(_userName.Text))
            {
                _errorProviderControl.SetError(_userName, Strings.PleaseEnterUserName);
            }
            else if (string.IsNullOrEmpty(_password.Text))
            {
                _errorProviderControl.SetError(_password, Strings.PleaseEnterPassword);
            }
            else
            {
                result = true;
            }
            return result;
        }

        private void ClearError()
        {
            _errorProviderControl.SetError(_userName, string.Empty);
            _errorProviderControl.SetError(_password, string.Empty);            
        }

        /// <summary>
        ///   Event handler ot handle the click event of the cancel button.
        /// </summary>
        /// <param name="sender"> Sender of the event. </param>
        /// <param name="e"> </param>
        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}