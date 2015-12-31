namespace SHC.UROCare.UI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this._loginButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._userName = new System.Windows.Forms.TextBox();
            this._password = new System.Windows.Forms.TextBox();
            this._userNameLabel = new System.Windows.Forms.Label();
            this._errorProviderControl = new System.Windows.Forms.ErrorProvider(this.components);
            this._passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._errorProviderControl)).BeginInit();
            this.SuspendLayout();
            // 
            // _loginButton
            // 
            resources.ApplyResources(this._loginButton, "_loginButton");
            this._loginButton.Name = "_loginButton";
            this._loginButton.UseVisualStyleBackColor = true;
            this._loginButton.Click += new System.EventHandler(this.OnLoginButtonClicked);
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this._cancelButton, "_cancelButton");
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this.OnCancelButtonClick);
            // 
            // _userName
            // 
            resources.ApplyResources(this._userName, "_userName");
            this._userName.Name = "_userName";
            // 
            // _password
            // 
            resources.ApplyResources(this._password, "_password");
            this._password.Name = "_password";
            this._password.UseSystemPasswordChar = true;
            // 
            // _userNameLabel
            // 
            resources.ApplyResources(this._userNameLabel, "_userNameLabel");
            this._userNameLabel.Name = "_userNameLabel";
            // 
            // _errorProviderControl
            // 
            this._errorProviderControl.ContainerControl = this;
            // 
            // _passwordLabel
            // 
            resources.ApplyResources(this._passwordLabel, "_passwordLabel");
            this._passwordLabel.Name = "_passwordLabel";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._userNameLabel);
            this.Controls.Add(this._password);
            this.Controls.Add(this._userName);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._loginButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this._errorProviderControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _loginButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.TextBox _userName;
        private System.Windows.Forms.TextBox _password;
        private System.Windows.Forms.Label _userNameLabel;
        private System.Windows.Forms.ErrorProvider _errorProviderControl;
        private System.Windows.Forms.Label _passwordLabel;
    }
}