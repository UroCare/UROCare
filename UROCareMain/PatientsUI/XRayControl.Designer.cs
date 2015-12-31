namespace SHC.UROCare.UI
{
    partial class XRayControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XRayControl));
            this._xrayImagelGroupBox = new System.Windows.Forms.GroupBox();
            this._imagePathTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this._imagePathLabel = new System.Windows.Forms.Label();
            this._imageList = new SHC.UROCare.UICommonControls.AutoCompleteComboBox();
            this._imageListLabel = new System.Windows.Forms.Label();
            this._xrayImage = new System.Windows.Forms.PictureBox();
            this._commentsTextBox = new System.Windows.Forms.TextBox();
            this._commentsLabel = new System.Windows.Forms.Label();
            this._imageDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this._eswlList = new System.Windows.Forms.ListView();
            this._imageDateLabel = new System.Windows.Forms.Label();
            this._patientGroup = new System.Windows.Forms.GroupBox();
            this._patientNameText = new System.Windows.Forms.Label();
            this._patientNameLabel = new System.Windows.Forms.Label();
            this._guNoTextBox = new System.Windows.Forms.Label();
            this._guNumberLabel = new System.Windows.Forms.Label();
            this._xrayImagelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._xrayImage)).BeginInit();
            this._patientGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // _xrayImagelGroupBox
            // 
            this._xrayImagelGroupBox.Controls.Add(this._imagePathTextBox);
            this._xrayImagelGroupBox.Controls.Add(this.button1);
            this._xrayImagelGroupBox.Controls.Add(this._imagePathLabel);
            this._xrayImagelGroupBox.Controls.Add(this._imageList);
            this._xrayImagelGroupBox.Controls.Add(this._imageListLabel);
            this._xrayImagelGroupBox.Controls.Add(this._xrayImage);
            this._xrayImagelGroupBox.Controls.Add(this._commentsTextBox);
            this._xrayImagelGroupBox.Controls.Add(this._commentsLabel);
            this._xrayImagelGroupBox.Controls.Add(this._imageDateTextBox);
            this._xrayImagelGroupBox.Controls.Add(this._eswlList);
            this._xrayImagelGroupBox.Controls.Add(this._imageDateLabel);
            this._xrayImagelGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this._xrayImagelGroupBox, "_xrayImagelGroupBox");
            this._xrayImagelGroupBox.Name = "_xrayImagelGroupBox";
            this._xrayImagelGroupBox.TabStop = false;
            // 
            // _imagePathTextBox
            // 
            resources.ApplyResources(this._imagePathTextBox, "_imagePathTextBox");
            this._imagePathTextBox.Name = "_imagePathTextBox";
            this._imagePathTextBox.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // _imagePathLabel
            // 
            resources.ApplyResources(this._imagePathLabel, "_imagePathLabel");
            this._imagePathLabel.Name = "_imagePathLabel";
            // 
            // _imageList
            // 
            this._imageList.DefaultText = "Please select one...";
            this._imageList.FormattingEnabled = true;
            this._imageList.LimitToList = true;
            resources.ApplyResources(this._imageList, "_imageList");
            this._imageList.Name = "_imageList";
            // 
            // _imageListLabel
            // 
            resources.ApplyResources(this._imageListLabel, "_imageListLabel");
            this._imageListLabel.Name = "_imageListLabel";
            // 
            // _xrayImage
            // 
            this._xrayImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this._xrayImage, "_xrayImage");
            this._xrayImage.Name = "_xrayImage";
            this._xrayImage.TabStop = false;
            // 
            // _commentsTextBox
            // 
            resources.ApplyResources(this._commentsTextBox, "_commentsTextBox");
            this._commentsTextBox.Name = "_commentsTextBox";
            // 
            // _commentsLabel
            // 
            resources.ApplyResources(this._commentsLabel, "_commentsLabel");
            this._commentsLabel.Name = "_commentsLabel";
            // 
            // _imageDateTextBox
            // 
            resources.ApplyResources(this._imageDateTextBox, "_imageDateTextBox");
            this._imageDateTextBox.Name = "_imageDateTextBox";
            this._imageDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // _eswlList
            // 
            this._eswlList.GridLines = true;
            this._eswlList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("_eswlList.Items")))});
            resources.ApplyResources(this._eswlList, "_eswlList");
            this._eswlList.Name = "_eswlList";
            this._eswlList.UseCompatibleStateImageBehavior = false;
            // 
            // _imageDateLabel
            // 
            resources.ApplyResources(this._imageDateLabel, "_imageDateLabel");
            this._imageDateLabel.Name = "_imageDateLabel";
            // 
            // _patientGroup
            // 
            this._patientGroup.Controls.Add(this._patientNameText);
            this._patientGroup.Controls.Add(this._patientNameLabel);
            this._patientGroup.Controls.Add(this._guNoTextBox);
            this._patientGroup.Controls.Add(this._guNumberLabel);
            resources.ApplyResources(this._patientGroup, "_patientGroup");
            this._patientGroup.Name = "_patientGroup";
            this._patientGroup.TabStop = false;
            // 
            // _patientNameText
            // 
            this._patientNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._patientNameText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._patientNameText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this._patientNameText, "_patientNameText");
            this._patientNameText.Name = "_patientNameText";
            // 
            // _patientNameLabel
            // 
            resources.ApplyResources(this._patientNameLabel, "_patientNameLabel");
            this._patientNameLabel.Name = "_patientNameLabel";
            // 
            // _guNoTextBox
            // 
            this._guNoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._guNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._guNoTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this._guNoTextBox, "_guNoTextBox");
            this._guNoTextBox.Name = "_guNoTextBox";
            // 
            // _guNumberLabel
            // 
            resources.ApplyResources(this._guNumberLabel, "_guNumberLabel");
            this._guNumberLabel.Name = "_guNumberLabel";
            // 
            // XRayControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._patientGroup);
            this.Controls.Add(this._xrayImagelGroupBox);
            this.Name = "XRayControl";
            this._xrayImagelGroupBox.ResumeLayout(false);
            this._xrayImagelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._xrayImage)).EndInit();
            this._patientGroup.ResumeLayout(false);
            this._patientGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _xrayImagelGroupBox;
        private System.Windows.Forms.GroupBox _patientGroup;
        private System.Windows.Forms.Label _patientNameText;
        private System.Windows.Forms.Label _patientNameLabel;
        private System.Windows.Forms.Label _guNoTextBox;
        private System.Windows.Forms.Label _guNumberLabel;
        private System.Windows.Forms.Label _imageDateLabel;
        private System.Windows.Forms.ListView _eswlList;
        private System.Windows.Forms.MaskedTextBox _imageDateTextBox;
        private System.Windows.Forms.TextBox _commentsTextBox;
        private System.Windows.Forms.Label _commentsLabel;
        private System.Windows.Forms.PictureBox _xrayImage;
        private UICommonControls.AutoCompleteComboBox _imageList;
        private System.Windows.Forms.Label _imageListLabel;
        private System.Windows.Forms.Label _imagePathLabel;
        private System.Windows.Forms.TextBox _imagePathTextBox;
        private System.Windows.Forms.Button button1;
    }
}
