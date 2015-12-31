namespace SHC.UROCare.UI
{
    partial class PrescriptionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionControl));
            this._prescriptionDetailGroupBox = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this._printButton = new System.Windows.Forms.Button();
            this._clearGridButton = new System.Windows.Forms.Button();
            this._saveAsButton = new System.Windows.Forms.Button();
            this._clearButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this._timesPerDayForLabel = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this._daysLabel = new System.Windows.Forms.Label();
            this._dose = new System.Windows.Forms.TextBox();
            this._doseLabel = new System.Windows.Forms.Label();
            this._drugTypes = new SHC.UROCare.UICommonControls.AutoCompleteComboBox();
            this._drugTypeLabel = new System.Windows.Forms.Label();
            this._prescriptionTime = new System.Windows.Forms.Label();
            this._speicalInstructionLabel = new System.Windows.Forms.Label();
            this._templates = new SHC.UROCare.UICommonControls.AutoCompleteComboBox();
            this._templateLabel = new System.Windows.Forms.Label();
            this._prescriptionDate = new System.Windows.Forms.MaskedTextBox();
            this._eswlList = new System.Windows.Forms.ListView();
            this._eswlDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._sizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._anaesthesiaTextBox = new System.Windows.Forms.TextBox();
            this._drugLabel = new System.Windows.Forms.Label();
            this._dateLabel = new System.Windows.Forms.Label();
            this._patientGroup = new System.Windows.Forms.GroupBox();
            this._mobile = new System.Windows.Forms.Label();
            this._mobileLabel = new System.Windows.Forms.Label();
            this._phone = new System.Windows.Forms.Label();
            this._phoneLabel = new System.Windows.Forms.Label();
            this._address = new System.Windows.Forms.Label();
            this._addressLabel = new System.Windows.Forms.Label();
            this._sex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._sexLabel = new System.Windows.Forms.Label();
            this._ageLabel = new System.Windows.Forms.Label();
            this._patientNameText = new System.Windows.Forms.Label();
            this._patientNameLabel = new System.Windows.Forms.Label();
            this._guNoTextBox = new System.Windows.Forms.Label();
            this._guNumberLabel = new System.Windows.Forms.Label();
            this._prescriptionDetailGroupBox.SuspendLayout();
            this._patientGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // _prescriptionDetailGroupBox
            // 
            this._prescriptionDetailGroupBox.Controls.Add(this.checkedListBox1);
            this._prescriptionDetailGroupBox.Controls.Add(this._printButton);
            this._prescriptionDetailGroupBox.Controls.Add(this._clearGridButton);
            this._prescriptionDetailGroupBox.Controls.Add(this._saveAsButton);
            this._prescriptionDetailGroupBox.Controls.Add(this._clearButton);
            this._prescriptionDetailGroupBox.Controls.Add(this._addButton);
            this._prescriptionDetailGroupBox.Controls.Add(this.maskedTextBox2);
            this._prescriptionDetailGroupBox.Controls.Add(this._timesPerDayForLabel);
            this._prescriptionDetailGroupBox.Controls.Add(this.maskedTextBox1);
            this._prescriptionDetailGroupBox.Controls.Add(this._daysLabel);
            this._prescriptionDetailGroupBox.Controls.Add(this._dose);
            this._prescriptionDetailGroupBox.Controls.Add(this._doseLabel);
            this._prescriptionDetailGroupBox.Controls.Add(this._drugTypes);
            this._prescriptionDetailGroupBox.Controls.Add(this._drugTypeLabel);
            this._prescriptionDetailGroupBox.Controls.Add(this._prescriptionTime);
            this._prescriptionDetailGroupBox.Controls.Add(this._speicalInstructionLabel);
            this._prescriptionDetailGroupBox.Controls.Add(this._templates);
            this._prescriptionDetailGroupBox.Controls.Add(this._templateLabel);
            this._prescriptionDetailGroupBox.Controls.Add(this._prescriptionDate);
            this._prescriptionDetailGroupBox.Controls.Add(this._eswlList);
            this._prescriptionDetailGroupBox.Controls.Add(this._anaesthesiaTextBox);
            this._prescriptionDetailGroupBox.Controls.Add(this._drugLabel);
            this._prescriptionDetailGroupBox.Controls.Add(this._dateLabel);
            this._prescriptionDetailGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this._prescriptionDetailGroupBox, "_prescriptionDetailGroupBox");
            this._prescriptionDetailGroupBox.Name = "_prescriptionDetailGroupBox";
            this._prescriptionDetailGroupBox.TabStop = false;
            // 
            // checkedListBox1
            // 
            resources.ApplyResources(this.checkedListBox1, "checkedListBox1");
            this.checkedListBox1.Items.AddRange(new object[] {
            resources.GetString("checkedListBox1.Items"),
            resources.GetString("checkedListBox1.Items1"),
            resources.GetString("checkedListBox1.Items2"),
            resources.GetString("checkedListBox1.Items3"),
            resources.GetString("checkedListBox1.Items4"),
            resources.GetString("checkedListBox1.Items5"),
            resources.GetString("checkedListBox1.Items6"),
            resources.GetString("checkedListBox1.Items7"),
            resources.GetString("checkedListBox1.Items8"),
            resources.GetString("checkedListBox1.Items9"),
            resources.GetString("checkedListBox1.Items10"),
            resources.GetString("checkedListBox1.Items11")});
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            // 
            // _printButton
            // 
            resources.ApplyResources(this._printButton, "_printButton");
            this._printButton.Name = "_printButton";
            this._printButton.UseVisualStyleBackColor = true;
            // 
            // _clearGridButton
            // 
            resources.ApplyResources(this._clearGridButton, "_clearGridButton");
            this._clearGridButton.Name = "_clearGridButton";
            this._clearGridButton.UseVisualStyleBackColor = true;
            // 
            // _saveAsButton
            // 
            resources.ApplyResources(this._saveAsButton, "_saveAsButton");
            this._saveAsButton.Name = "_saveAsButton";
            this._saveAsButton.UseVisualStyleBackColor = true;
            // 
            // _clearButton
            // 
            resources.ApplyResources(this._clearButton, "_clearButton");
            this._clearButton.Name = "_clearButton";
            this._clearButton.UseVisualStyleBackColor = true;
            // 
            // _addButton
            // 
            resources.ApplyResources(this._addButton, "_addButton");
            this._addButton.Name = "_addButton";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            resources.ApplyResources(this.maskedTextBox2, "maskedTextBox2");
            this.maskedTextBox2.Name = "maskedTextBox2";
            // 
            // _timesPerDayForLabel
            // 
            resources.ApplyResources(this._timesPerDayForLabel, "_timesPerDayForLabel");
            this._timesPerDayForLabel.Name = "_timesPerDayForLabel";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            resources.ApplyResources(this.maskedTextBox1, "maskedTextBox1");
            this.maskedTextBox1.Name = "maskedTextBox1";
            // 
            // _daysLabel
            // 
            resources.ApplyResources(this._daysLabel, "_daysLabel");
            this._daysLabel.Name = "_daysLabel";
            // 
            // _dose
            // 
            resources.ApplyResources(this._dose, "_dose");
            this._dose.Name = "_dose";
            // 
            // _doseLabel
            // 
            resources.ApplyResources(this._doseLabel, "_doseLabel");
            this._doseLabel.Name = "_doseLabel";
            // 
            // _drugTypes
            // 
            this._drugTypes.DefaultText = "Please select one...";
            this._drugTypes.FormattingEnabled = true;
            this._drugTypes.Items.AddRange(new object[] {
            resources.GetString("_drugTypes.Items"),
            resources.GetString("_drugTypes.Items1"),
            resources.GetString("_drugTypes.Items2"),
            resources.GetString("_drugTypes.Items3"),
            resources.GetString("_drugTypes.Items4"),
            resources.GetString("_drugTypes.Items5"),
            resources.GetString("_drugTypes.Items6"),
            resources.GetString("_drugTypes.Items7"),
            resources.GetString("_drugTypes.Items8"),
            resources.GetString("_drugTypes.Items9")});
            this._drugTypes.LimitToList = true;
            resources.ApplyResources(this._drugTypes, "_drugTypes");
            this._drugTypes.Name = "_drugTypes";
            // 
            // _drugTypeLabel
            // 
            resources.ApplyResources(this._drugTypeLabel, "_drugTypeLabel");
            this._drugTypeLabel.Name = "_drugTypeLabel";
            // 
            // _prescriptionTime
            // 
            this._prescriptionTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._prescriptionTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._prescriptionTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this._prescriptionTime, "_prescriptionTime");
            this._prescriptionTime.Name = "_prescriptionTime";
            // 
            // _speicalInstructionLabel
            // 
            resources.ApplyResources(this._speicalInstructionLabel, "_speicalInstructionLabel");
            this._speicalInstructionLabel.Name = "_speicalInstructionLabel";
            // 
            // _templates
            // 
            this._templates.DefaultText = "Please select one...";
            this._templates.FormattingEnabled = true;
            this._templates.LimitToList = true;
            resources.ApplyResources(this._templates, "_templates");
            this._templates.Name = "_templates";
            // 
            // _templateLabel
            // 
            resources.ApplyResources(this._templateLabel, "_templateLabel");
            this._templateLabel.Name = "_templateLabel";
            // 
            // _prescriptionDate
            // 
            resources.ApplyResources(this._prescriptionDate, "_prescriptionDate");
            this._prescriptionDate.Name = "_prescriptionDate";
            this._prescriptionDate.ValidatingType = typeof(System.DateTime);
            // 
            // _eswlList
            // 
            resources.ApplyResources(this._eswlList, "_eswlList");
            this._eswlList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._eswlDateColumn,
            this._sizeColumn});
            this._eswlList.GridLines = true;
            this._eswlList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("_eswlList.Items")))});
            this._eswlList.Name = "_eswlList";
            this._eswlList.UseCompatibleStateImageBehavior = false;
            // 
            // _eswlDateColumn
            // 
            resources.ApplyResources(this._eswlDateColumn, "_eswlDateColumn");
            // 
            // _sizeColumn
            // 
            resources.ApplyResources(this._sizeColumn, "_sizeColumn");
            // 
            // _anaesthesiaTextBox
            // 
            resources.ApplyResources(this._anaesthesiaTextBox, "_anaesthesiaTextBox");
            this._anaesthesiaTextBox.Name = "_anaesthesiaTextBox";
            // 
            // _drugLabel
            // 
            resources.ApplyResources(this._drugLabel, "_drugLabel");
            this._drugLabel.Name = "_drugLabel";
            // 
            // _dateLabel
            // 
            resources.ApplyResources(this._dateLabel, "_dateLabel");
            this._dateLabel.Name = "_dateLabel";
            // 
            // _patientGroup
            // 
            this._patientGroup.Controls.Add(this._mobile);
            this._patientGroup.Controls.Add(this._mobileLabel);
            this._patientGroup.Controls.Add(this._phone);
            this._patientGroup.Controls.Add(this._phoneLabel);
            this._patientGroup.Controls.Add(this._address);
            this._patientGroup.Controls.Add(this._addressLabel);
            this._patientGroup.Controls.Add(this._sex);
            this._patientGroup.Controls.Add(this.label1);
            this._patientGroup.Controls.Add(this._sexLabel);
            this._patientGroup.Controls.Add(this._ageLabel);
            this._patientGroup.Controls.Add(this._patientNameText);
            this._patientGroup.Controls.Add(this._patientNameLabel);
            this._patientGroup.Controls.Add(this._guNoTextBox);
            this._patientGroup.Controls.Add(this._guNumberLabel);
            resources.ApplyResources(this._patientGroup, "_patientGroup");
            this._patientGroup.Name = "_patientGroup";
            this._patientGroup.TabStop = false;
            // 
            // _mobile
            // 
            this._mobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._mobile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._mobile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this._mobile, "_mobile");
            this._mobile.Name = "_mobile";
            // 
            // _mobileLabel
            // 
            resources.ApplyResources(this._mobileLabel, "_mobileLabel");
            this._mobileLabel.Name = "_mobileLabel";
            // 
            // _phone
            // 
            this._phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._phone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._phone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this._phone, "_phone");
            this._phone.Name = "_phone";
            // 
            // _phoneLabel
            // 
            resources.ApplyResources(this._phoneLabel, "_phoneLabel");
            this._phoneLabel.Name = "_phoneLabel";
            // 
            // _address
            // 
            this._address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._address.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._address.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this._address, "_address");
            this._address.Name = "_address";
            // 
            // _addressLabel
            // 
            resources.ApplyResources(this._addressLabel, "_addressLabel");
            this._addressLabel.Name = "_addressLabel";
            // 
            // _sex
            // 
            this._sex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._sex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._sex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this._sex, "_sex");
            this._sex.Name = "_sex";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // _sexLabel
            // 
            resources.ApplyResources(this._sexLabel, "_sexLabel");
            this._sexLabel.Name = "_sexLabel";
            // 
            // _ageLabel
            // 
            resources.ApplyResources(this._ageLabel, "_ageLabel");
            this._ageLabel.Name = "_ageLabel";
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
            // PrescriptionControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._patientGroup);
            this.Controls.Add(this._prescriptionDetailGroupBox);
            this.Name = "PrescriptionControl";
            this._prescriptionDetailGroupBox.ResumeLayout(false);
            this._prescriptionDetailGroupBox.PerformLayout();
            this._patientGroup.ResumeLayout(false);
            this._patientGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _prescriptionDetailGroupBox;
        private System.Windows.Forms.Label _drugLabel;
        private System.Windows.Forms.TextBox _anaesthesiaTextBox;
        private System.Windows.Forms.GroupBox _patientGroup;
        private System.Windows.Forms.Label _patientNameText;
        private System.Windows.Forms.Label _patientNameLabel;
        private System.Windows.Forms.Label _guNoTextBox;
        private System.Windows.Forms.Label _guNumberLabel;
        private System.Windows.Forms.Label _dateLabel;
        private System.Windows.Forms.ListView _eswlList;
        private System.Windows.Forms.ColumnHeader _eswlDateColumn;
        private System.Windows.Forms.ColumnHeader _sizeColumn;
        private System.Windows.Forms.MaskedTextBox _prescriptionDate;
        private UICommonControls.AutoCompleteComboBox _templates;
        private System.Windows.Forms.Label _templateLabel;
        private System.Windows.Forms.Label _speicalInstructionLabel;
        private System.Windows.Forms.Label _prescriptionTime;
        private UICommonControls.AutoCompleteComboBox _drugTypes;
        private System.Windows.Forms.Label _drugTypeLabel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label _timesPerDayForLabel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label _daysLabel;
        private System.Windows.Forms.TextBox _dose;
        private System.Windows.Forms.Label _doseLabel;
        private System.Windows.Forms.Label _mobile;
        private System.Windows.Forms.Label _mobileLabel;
        private System.Windows.Forms.Label _phone;
        private System.Windows.Forms.Label _phoneLabel;
        private System.Windows.Forms.Label _address;
        private System.Windows.Forms.Label _addressLabel;
        private System.Windows.Forms.Label _sex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _sexLabel;
        private System.Windows.Forms.Label _ageLabel;
        private System.Windows.Forms.Button _printButton;
        private System.Windows.Forms.Button _clearGridButton;
        private System.Windows.Forms.Button _saveAsButton;
        private System.Windows.Forms.Button _clearButton;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
