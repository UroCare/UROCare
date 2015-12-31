namespace SHC.UROCare.UICommonControls
{
    partial class SHCPLDatePicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this._dropButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _maskedTextBox
            // 
            this._maskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._maskedTextBox.Location = new System.Drawing.Point(0, 0);
            this._maskedTextBox.Mask = "00/00/0000";
            this._maskedTextBox.Name = "_maskedTextBox";
            this._maskedTextBox.Size = new System.Drawing.Size(62, 20);
            this._maskedTextBox.TabIndex = 0;
            this._maskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // _dropButton
            // 
            this._dropButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dropButton.BackgroundImage = global::SHC.UROCare.UICommonControls.Strings.calendar_icon;
            this._dropButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._dropButton.Location = new System.Drawing.Point(64, -1);
            this._dropButton.Name = "_dropButton";
            this._dropButton.Size = new System.Drawing.Size(25, 22);
            this._dropButton.TabIndex = 1;
            this._dropButton.UseVisualStyleBackColor = true;
            this._dropButton.Click += new System.EventHandler(this.OnDropDownButtonClick);
            // 
            // CustomDatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this._dropButton);
            this.Controls.Add(this._maskedTextBox);
            this.Name = "CustomDatePicker";
            this.Size = new System.Drawing.Size(89, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox _maskedTextBox;
        private System.Windows.Forms.Button _dropButton;
    }
}
