namespace SHC.UROCare.UI
{
    partial class OperationControl
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F));
            this._operationDetails = new System.Windows.Forms.GroupBox();
            this._eswlList = new System.Windows.Forms.ListView();
            this._eswlDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._sizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._anaesthesia = new System.Windows.Forms.TextBox();
            this._anaesthesiaLabel = new System.Windows.Forms.Label();
            this._referalDoctorComboBox = new SHC.UROCare.UICommonControls.AutoCompleteComboBox();
            this._anaesthesiologistLabel = new System.Windows.Forms.Label();
            this._remarksLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._eswlDate = new System.Windows.Forms.MaskedTextBox();
            this._eswlDateLabel = new System.Windows.Forms.Label();
            this._details = new System.Windows.Forms.TextBox();
            this._detailsLabel = new System.Windows.Forms.Label();
            this._procedure = new System.Windows.Forms.TextBox();
            this._procedureLabel = new System.Windows.Forms.Label();
            this._patientGroup = new System.Windows.Forms.GroupBox();
            this._patientNameText = new System.Windows.Forms.Label();
            this._patientNameLabel = new System.Windows.Forms.Label();
            this._guNoTextBox = new System.Windows.Forms.Label();
            this._guNumberLabel = new System.Windows.Forms.Label();
            this._addReferalDoctor = new System.Windows.Forms.Button();
            this._operationDetails.SuspendLayout();
            this._patientGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // _operationDetails
            // 
            this._operationDetails.Controls.Add(this._addReferalDoctor);
            this._operationDetails.Controls.Add(this._eswlList);
            this._operationDetails.Controls.Add(this._anaesthesia);
            this._operationDetails.Controls.Add(this._anaesthesiaLabel);
            this._operationDetails.Controls.Add(this._referalDoctorComboBox);
            this._operationDetails.Controls.Add(this._anaesthesiologistLabel);
            this._operationDetails.Controls.Add(this._remarksLabel);
            this._operationDetails.Controls.Add(this.textBox1);
            this._operationDetails.Controls.Add(this._eswlDate);
            this._operationDetails.Controls.Add(this._eswlDateLabel);
            this._operationDetails.Controls.Add(this._details);
            this._operationDetails.Controls.Add(this._detailsLabel);
            this._operationDetails.Controls.Add(this._procedure);
            this._operationDetails.Controls.Add(this._procedureLabel);
            this._operationDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._operationDetails.Location = new System.Drawing.Point(29, 90);
            this._operationDetails.Name = "_operationDetails";
            this._operationDetails.Size = new System.Drawing.Size(990, 690);
            this._operationDetails.TabIndex = 0;
            this._operationDetails.TabStop = false;
            this._operationDetails.Text = "Operation Details";
            // 
            // _eswlList
            // 
            this._eswlList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._eswlList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._eswlDateColumn,
            this._sizeColumn});
            this._eswlList.GridLines = true;
            this._eswlList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this._eswlList.Location = new System.Drawing.Point(15, 425);
            this._eswlList.Name = "_eswlList";
            this._eswlList.Size = new System.Drawing.Size(961, 246);
            this._eswlList.TabIndex = 37;
            this._eswlList.UseCompatibleStateImageBehavior = false;
            // 
            // _eswlDateColumn
            // 
            this._eswlDateColumn.Text = "Date";
            this._eswlDateColumn.Width = 30;
            // 
            // _sizeColumn
            // 
            this._sizeColumn.Text = "Size";
            this._sizeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _anaesthesia
            // 
            this._anaesthesia.Location = new System.Drawing.Point(124, 81);
            this._anaesthesia.Multiline = true;
            this._anaesthesia.Name = "_anaesthesia";
            this._anaesthesia.Size = new System.Drawing.Size(836, 20);
            this._anaesthesia.TabIndex = 35;
            // 
            // _anaesthesiaLabel
            // 
            this._anaesthesiaLabel.AutoSize = true;
            this._anaesthesiaLabel.Location = new System.Drawing.Point(16, 84);
            this._anaesthesiaLabel.Name = "_anaesthesiaLabel";
            this._anaesthesiaLabel.Size = new System.Drawing.Size(65, 13);
            this._anaesthesiaLabel.TabIndex = 36;
            this._anaesthesiaLabel.Text = "Anaesthesia";
            // 
            // _referalDoctorComboBox
            // 
            this._referalDoctorComboBox.DefaultText = "Please select one...";
            this._referalDoctorComboBox.FormattingEnabled = true;
            this._referalDoctorComboBox.Items.AddRange(new object[] {
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chattishgarh",
            "Goa",
            "Gujrat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu & Kashmir",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttar Pradesh",
            "Uttarakhand",
            "West Bangal",
            "",
            ""});
            this._referalDoctorComboBox.LimitToList = true;
            this._referalDoctorComboBox.Location = new System.Drawing.Point(124, 54);
            this._referalDoctorComboBox.Name = "_referalDoctorComboBox";
            this._referalDoctorComboBox.Size = new System.Drawing.Size(325, 21);
            this._referalDoctorComboBox.TabIndex = 34;
            this._referalDoctorComboBox.Text = "Please select one...";
            // 
            // _anaesthesiologistLabel
            // 
            this._anaesthesiologistLabel.AutoSize = true;
            this._anaesthesiologistLabel.Location = new System.Drawing.Point(16, 60);
            this._anaesthesiologistLabel.Name = "_anaesthesiologistLabel";
            this._anaesthesiologistLabel.Size = new System.Drawing.Size(89, 13);
            this._anaesthesiologistLabel.TabIndex = 33;
            this._anaesthesiologistLabel.Text = "Anaesthesiologist";
            // 
            // _remarksLabel
            // 
            this._remarksLabel.AutoSize = true;
            this._remarksLabel.Location = new System.Drawing.Point(19, 317);
            this._remarksLabel.Name = "_remarksLabel";
            this._remarksLabel.Size = new System.Drawing.Size(49, 13);
            this._remarksLabel.TabIndex = 2;
            this._remarksLabel.Text = "Remarks";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 314);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(836, 97);
            this.textBox1.TabIndex = 32;
            // 
            // _eswlDate
            // 
            this._eswlDate.Location = new System.Drawing.Point(124, 28);
            this._eswlDate.Mask = "00/00/0000";
            this._eswlDate.Name = "_eswlDate";
            this._eswlDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._eswlDate.Size = new System.Drawing.Size(79, 20);
            this._eswlDate.TabIndex = 0;
            this._eswlDate.ValidatingType = typeof(System.DateTime);
            // 
            // _eswlDateLabel
            // 
            this._eswlDateLabel.AutoSize = true;
            this._eswlDateLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._eswlDateLabel.Location = new System.Drawing.Point(19, 31);
            this._eswlDateLabel.Name = "_eswlDateLabel";
            this._eswlDateLabel.Size = new System.Drawing.Size(30, 13);
            this._eswlDateLabel.TabIndex = 29;
            this._eswlDateLabel.Text = "Date";
            this._eswlDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _details
            // 
            this._details.Location = new System.Drawing.Point(124, 211);
            this._details.Multiline = true;
            this._details.Name = "_details";
            this._details.Size = new System.Drawing.Size(836, 97);
            this._details.TabIndex = 3;
            // 
            // _detailsLabel
            // 
            this._detailsLabel.AutoSize = true;
            this._detailsLabel.Location = new System.Drawing.Point(17, 214);
            this._detailsLabel.Name = "_detailsLabel";
            this._detailsLabel.Size = new System.Drawing.Size(39, 13);
            this._detailsLabel.TabIndex = 2;
            this._detailsLabel.Text = "Details";
            // 
            // _procedure
            // 
            this._procedure.Location = new System.Drawing.Point(124, 108);
            this._procedure.Multiline = true;
            this._procedure.Name = "_procedure";
            this._procedure.Size = new System.Drawing.Size(836, 97);
            this._procedure.TabIndex = 1;
            // 
            // _procedureLabel
            // 
            this._procedureLabel.AutoSize = true;
            this._procedureLabel.Location = new System.Drawing.Point(16, 111);
            this._procedureLabel.Name = "_procedureLabel";
            this._procedureLabel.Size = new System.Drawing.Size(56, 13);
            this._procedureLabel.TabIndex = 0;
            this._procedureLabel.Text = "Procedure";
            // 
            // _patientGroup
            // 
            this._patientGroup.Controls.Add(this._patientNameText);
            this._patientGroup.Controls.Add(this._patientNameLabel);
            this._patientGroup.Controls.Add(this._guNoTextBox);
            this._patientGroup.Controls.Add(this._guNumberLabel);
            this._patientGroup.Location = new System.Drawing.Point(29, 18);
            this._patientGroup.Name = "_patientGroup";
            this._patientGroup.Size = new System.Drawing.Size(627, 56);
            this._patientGroup.TabIndex = 4;
            this._patientGroup.TabStop = false;
            this._patientGroup.Text = "Patient";
            // 
            // _patientNameText
            // 
            this._patientNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._patientNameText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._patientNameText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._patientNameText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._patientNameText.Location = new System.Drawing.Point(339, 23);
            this._patientNameText.Name = "_patientNameText";
            this._patientNameText.Size = new System.Drawing.Size(271, 20);
            this._patientNameText.TabIndex = 56;
            // 
            // _patientNameLabel
            // 
            this._patientNameLabel.AutoSize = true;
            this._patientNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._patientNameLabel.Location = new System.Drawing.Point(254, 25);
            this._patientNameLabel.Name = "_patientNameLabel";
            this._patientNameLabel.Size = new System.Drawing.Size(71, 13);
            this._patientNameLabel.TabIndex = 55;
            this._patientNameLabel.Text = "Patient Name";
            // 
            // _guNoTextBox
            // 
            this._guNoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._guNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._guNoTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._guNoTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._guNoTextBox.Location = new System.Drawing.Point(103, 23);
            this._guNoTextBox.Name = "_guNoTextBox";
            this._guNoTextBox.Size = new System.Drawing.Size(101, 20);
            this._guNoTextBox.TabIndex = 54;
            // 
            // _guNumberLabel
            // 
            this._guNumberLabel.AutoSize = true;
            this._guNumberLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._guNumberLabel.Location = new System.Drawing.Point(19, 25);
            this._guNumberLabel.Name = "_guNumberLabel";
            this._guNumberLabel.Size = new System.Drawing.Size(69, 13);
            this._guNumberLabel.TabIndex = 53;
            this._guNumberLabel.Text = "G.U. Number";
            // 
            // _addReferalDoctor
            // 
            this._addReferalDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this._addReferalDoctor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._addReferalDoctor.Location = new System.Drawing.Point(454, 54);
            this._addReferalDoctor.Name = "_addReferalDoctor";
            this._addReferalDoctor.Size = new System.Drawing.Size(30, 23);
            this._addReferalDoctor.TabIndex = 48;
            this._addReferalDoctor.Text = "+";
            this._addReferalDoctor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._addReferalDoctor.UseVisualStyleBackColor = true;
            // 
            // OperationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._patientGroup);
            this.Controls.Add(this._operationDetails);
            this.Location = new System.Drawing.Point(102, 87);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "OperationControl";
            this.Size = new System.Drawing.Size(1039, 790);
            this._operationDetails.ResumeLayout(false);
            this._operationDetails.PerformLayout();
            this._patientGroup.ResumeLayout(false);
            this._patientGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _operationDetails;
        private System.Windows.Forms.Label _procedureLabel;
        private System.Windows.Forms.TextBox _procedure;
        private System.Windows.Forms.TextBox _details;
        private System.Windows.Forms.Label _detailsLabel;
        private System.Windows.Forms.Label _remarksLabel;
        private System.Windows.Forms.GroupBox _patientGroup;
        private System.Windows.Forms.Label _patientNameText;
        private System.Windows.Forms.Label _patientNameLabel;
        private System.Windows.Forms.Label _guNoTextBox;
        private System.Windows.Forms.Label _guNumberLabel;
        private System.Windows.Forms.MaskedTextBox _eswlDate;
        private System.Windows.Forms.Label _eswlDateLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label _anaesthesiologistLabel;
        private System.Windows.Forms.TextBox _anaesthesia;
        private System.Windows.Forms.Label _anaesthesiaLabel;
        private UICommonControls.AutoCompleteComboBox _referalDoctorComboBox;
        private System.Windows.Forms.ListView _eswlList;
        private System.Windows.Forms.ColumnHeader _eswlDateColumn;
        private System.Windows.Forms.ColumnHeader _sizeColumn;
        private System.Windows.Forms.Button _addReferalDoctor;
    }
}
