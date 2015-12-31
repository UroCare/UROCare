namespace SHC.UROCare.UI
{
    partial class PatientInformationControl : IPatientInformationView
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
            this._mainPanel = new System.Windows.Forms.Panel();
            this._photoGroup = new System.Windows.Forms.GroupBox();
            this._patientPicture = new System.Windows.Forms.PictureBox();
            this._cameraButton = new System.Windows.Forms.Button();
            this._operationDetails = new System.Windows.Forms.ListView();
            this._ipdDetailsGroup = new System.Windows.Forms.GroupBox();
            this._dischargeDate = new System.Windows.Forms.MaskedTextBox();
            this._admissionDate = new System.Windows.Forms.MaskedTextBox();
            this._dischargeDateLabel = new System.Windows.Forms.Label();
            this._admissionDateLabel = new System.Windows.Forms.Label();
            this._ipdNoLabel = new System.Windows.Forms.Label();
            this._ipdNumber = new System.Windows.Forms.MaskedTextBox();
            this._ipdDiagnosis = new System.Windows.Forms.TextBox();
            this._ipdDiagnosisLabel = new System.Windows.Forms.Label();
            this._personalDetailsGroup = new System.Windows.Forms.GroupBox();
            this._addReferalDoctor = new System.Windows.Forms.Button();
            this._referalDoctorComboBox = new SHC.UROCare.UICommonControls.AutoCompleteComboBox();
            this._refDoctorLabel = new System.Windows.Forms.Label();
            this._occupation = new System.Windows.Forms.TextBox();
            this._occupationLabel = new System.Windows.Forms.Label();
            this._monthsLabel = new System.Windows.Forms.Label();
            this._months = new System.Windows.Forms.NumericUpDown();
            this._yearLabel = new System.Windows.Forms.Label();
            this._years = new System.Windows.Forms.NumericUpDown();
            this._ageLabel = new System.Windows.Forms.Label();
            this._sexComboBox = new System.Windows.Forms.ComboBox();
            this._sexLabel = new System.Windows.Forms.Label();
            this._opdDiagnosisGroup = new System.Windows.Forms.GroupBox();
            this._opdDiagnosis = new System.Windows.Forms.TextBox();
            this._opdDiagnosisLabel = new System.Windows.Forms.Label();
            this._contactGroup = new System.Windows.Forms.GroupBox();
            this._mobile = new System.Windows.Forms.MaskedTextBox();
            this._state = new SHC.UROCare.UICommonControls.AutoCompleteComboBox();
            this._mobileLabel = new System.Windows.Forms.Label();
            this._phone = new System.Windows.Forms.TextBox();
            this._phoneLabel = new System.Windows.Forms.Label();
            this._stateLabel = new System.Windows.Forms.Label();
            this._district = new System.Windows.Forms.TextBox();
            this._districtLabel = new System.Windows.Forms.Label();
            this._town = new System.Windows.Forms.TextBox();
            this._townLabel = new System.Windows.Forms.Label();
            this._atPost = new System.Windows.Forms.TextBox();
            this._atPostLabel = new System.Windows.Forms.Label();
            this._registrationDetails = new System.Windows.Forms.GroupBox();
            this._registrationDate = new System.Windows.Forms.MaskedTextBox();
            this._guNoTextBox = new System.Windows.Forms.Label();
            this._patientName = new System.Windows.Forms.TextBox();
            this._patientNameLabel = new System.Windows.Forms.Label();
            this._salutation = new System.Windows.Forms.ComboBox();
            this._salutationLabel = new System.Windows.Forms.Label();
            this._registrationDateLabel = new System.Windows.Forms.Label();
            this._guNumberLabel = new System.Windows.Forms.Label();
            this._mainPanel.SuspendLayout();
            this._photoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._patientPicture)).BeginInit();
            this._ipdDetailsGroup.SuspendLayout();
            this._personalDetailsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._months)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._years)).BeginInit();
            this._opdDiagnosisGroup.SuspendLayout();
            this._contactGroup.SuspendLayout();
            this._registrationDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainPanel
            // 
            this._mainPanel.Controls.Add(this._photoGroup);
            this._mainPanel.Controls.Add(this._operationDetails);
            this._mainPanel.Controls.Add(this._ipdDetailsGroup);
            this._mainPanel.Controls.Add(this._personalDetailsGroup);
            this._mainPanel.Controls.Add(this._opdDiagnosisGroup);
            this._mainPanel.Controls.Add(this._contactGroup);
            this._mainPanel.Controls.Add(this._registrationDetails);
            this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPanel.Location = new System.Drawing.Point(0, 0);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Size = new System.Drawing.Size(1150, 856);
            this._mainPanel.TabIndex = 16;
            // 
            // _photoGroup
            // 
            this._photoGroup.Controls.Add(this._patientPicture);
            this._photoGroup.Controls.Add(this._cameraButton);
            this._photoGroup.Location = new System.Drawing.Point(14, 18);
            this._photoGroup.Name = "_photoGroup";
            this._photoGroup.Size = new System.Drawing.Size(208, 248);
            this._photoGroup.TabIndex = 30;
            this._photoGroup.TabStop = false;
            this._photoGroup.Text = "Patient Photo";
            // 
            // _patientPicture
            // 
            this._patientPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._patientPicture.Location = new System.Drawing.Point(14, 26);
            this._patientPicture.Name = "_patientPicture";
            this._patientPicture.Size = new System.Drawing.Size(180, 180);
            this._patientPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._patientPicture.TabIndex = 20;
            this._patientPicture.TabStop = false;
            // 
            // _cameraButton
            // 
            this._cameraButton.Location = new System.Drawing.Point(62, 215);
            this._cameraButton.Name = "_cameraButton";
            this._cameraButton.Size = new System.Drawing.Size(80, 21);
            this._cameraButton.TabIndex = 0;
            this._cameraButton.Text = "Camera";
            this._cameraButton.UseVisualStyleBackColor = true;
            // 
            // _operationDetails
            // 
            this._operationDetails.Location = new System.Drawing.Point(14, 580);
            this._operationDetails.Name = "_operationDetails";
            this._operationDetails.Size = new System.Drawing.Size(1012, 262);
            this._operationDetails.TabIndex = 23;
            this._operationDetails.UseCompatibleStateImageBehavior = false;
            // 
            // _ipdDetailsGroup
            // 
            this._ipdDetailsGroup.Controls.Add(this._dischargeDate);
            this._ipdDetailsGroup.Controls.Add(this._admissionDate);
            this._ipdDetailsGroup.Controls.Add(this._dischargeDateLabel);
            this._ipdDetailsGroup.Controls.Add(this._admissionDateLabel);
            this._ipdDetailsGroup.Controls.Add(this._ipdNoLabel);
            this._ipdDetailsGroup.Controls.Add(this._ipdNumber);
            this._ipdDetailsGroup.Controls.Add(this._ipdDiagnosis);
            this._ipdDetailsGroup.Controls.Add(this._ipdDiagnosisLabel);
            this._ipdDetailsGroup.Location = new System.Drawing.Point(14, 409);
            this._ipdDetailsGroup.Name = "_ipdDetailsGroup";
            this._ipdDetailsGroup.Size = new System.Drawing.Size(1012, 155);
            this._ipdDetailsGroup.TabIndex = 28;
            this._ipdDetailsGroup.TabStop = false;
            this._ipdDetailsGroup.Text = "I.P.D. Details";
            // 
            // _dischargeDate
            // 
            this._dischargeDate.Location = new System.Drawing.Point(484, 24);
            this._dischargeDate.Mask = "00/00/0000";
            this._dischargeDate.Name = "_dischargeDate";
            this._dischargeDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._dischargeDate.Size = new System.Drawing.Size(79, 20);
            this._dischargeDate.TabIndex = 20;
            this._dischargeDate.ValidatingType = typeof(System.DateTime);
            // 
            // _admissionDate
            // 
            this._admissionDate.Location = new System.Drawing.Point(287, 24);
            this._admissionDate.Mask = "00/00/0000";
            this._admissionDate.Name = "_admissionDate";
            this._admissionDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._admissionDate.Size = new System.Drawing.Size(79, 20);
            this._admissionDate.TabIndex = 19;
            this._admissionDate.ValidatingType = typeof(System.DateTime);
            // 
            // _dischargeDateLabel
            // 
            this._dischargeDateLabel.AutoSize = true;
            this._dischargeDateLabel.Location = new System.Drawing.Point(397, 27);
            this._dischargeDateLabel.Name = "_dischargeDateLabel";
            this._dischargeDateLabel.Size = new System.Drawing.Size(81, 13);
            this._dischargeDateLabel.TabIndex = 55;
            this._dischargeDateLabel.Text = "Discharge Date";
            // 
            // _admissionDateLabel
            // 
            this._admissionDateLabel.AutoSize = true;
            this._admissionDateLabel.Location = new System.Drawing.Point(204, 27);
            this._admissionDateLabel.Name = "_admissionDateLabel";
            this._admissionDateLabel.Size = new System.Drawing.Size(80, 13);
            this._admissionDateLabel.TabIndex = 54;
            this._admissionDateLabel.Text = "Admission Date";
            // 
            // _ipdNoLabel
            // 
            this._ipdNoLabel.AutoSize = true;
            this._ipdNoLabel.Location = new System.Drawing.Point(21, 27);
            this._ipdNoLabel.Name = "_ipdNoLabel";
            this._ipdNoLabel.Size = new System.Drawing.Size(74, 13);
            this._ipdNoLabel.TabIndex = 51;
            this._ipdNoLabel.Text = "I.P.D. Number";
            // 
            // _ipdNumber
            // 
            this._ipdNumber.Location = new System.Drawing.Point(101, 24);
            this._ipdNumber.Mask = "0000/0000";
            this._ipdNumber.Name = "_ipdNumber";
            this._ipdNumber.PromptChar = '0';
            this._ipdNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._ipdNumber.Size = new System.Drawing.Size(79, 20);
            this._ipdNumber.TabIndex = 18;
            // 
            // _ipdDiagnosis
            // 
            this._ipdDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._ipdDiagnosis.Location = new System.Drawing.Point(101, 54);
            this._ipdDiagnosis.MaxLength = 150;
            this._ipdDiagnosis.Multiline = true;
            this._ipdDiagnosis.Name = "_ipdDiagnosis";
            this._ipdDiagnosis.Size = new System.Drawing.Size(900, 85);
            this._ipdDiagnosis.TabIndex = 21;
            // 
            // _ipdDiagnosisLabel
            // 
            this._ipdDiagnosisLabel.AutoSize = true;
            this._ipdDiagnosisLabel.Location = new System.Drawing.Point(21, 57);
            this._ipdDiagnosisLabel.Name = "_ipdDiagnosisLabel";
            this._ipdDiagnosisLabel.Size = new System.Drawing.Size(53, 13);
            this._ipdDiagnosisLabel.TabIndex = 46;
            this._ipdDiagnosisLabel.Text = "Diagnosis";
            // 
            // _personalDetailsGroup
            // 
            this._personalDetailsGroup.Controls.Add(this._addReferalDoctor);
            this._personalDetailsGroup.Controls.Add(this._referalDoctorComboBox);
            this._personalDetailsGroup.Controls.Add(this._refDoctorLabel);
            this._personalDetailsGroup.Controls.Add(this._occupation);
            this._personalDetailsGroup.Controls.Add(this._occupationLabel);
            this._personalDetailsGroup.Controls.Add(this._monthsLabel);
            this._personalDetailsGroup.Controls.Add(this._months);
            this._personalDetailsGroup.Controls.Add(this._yearLabel);
            this._personalDetailsGroup.Controls.Add(this._years);
            this._personalDetailsGroup.Controls.Add(this._ageLabel);
            this._personalDetailsGroup.Controls.Add(this._sexComboBox);
            this._personalDetailsGroup.Controls.Add(this._sexLabel);
            this._personalDetailsGroup.Location = new System.Drawing.Point(667, 109);
            this._personalDetailsGroup.Name = "_personalDetailsGroup";
            this._personalDetailsGroup.Size = new System.Drawing.Size(359, 157);
            this._personalDetailsGroup.TabIndex = 27;
            this._personalDetailsGroup.TabStop = false;
            this._personalDetailsGroup.Text = "Personal Details";
            // 
            // _addReferalDoctor
            // 
            this._addReferalDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this._addReferalDoctor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._addReferalDoctor.Location = new System.Drawing.Point(308, 118);
            this._addReferalDoctor.Name = "_addReferalDoctor";
            this._addReferalDoctor.Size = new System.Drawing.Size(30, 23);
            this._addReferalDoctor.TabIndex = 47;
            this._addReferalDoctor.Text = "+";
            this._addReferalDoctor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._addReferalDoctor.UseVisualStyleBackColor = true;
            // 
            // _referalDoctorComboBox
            // 
            this._referalDoctorComboBox.DefaultText = "Please select one...";
            this._referalDoctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this._referalDoctorComboBox.Location = new System.Drawing.Point(93, 120);
            this._referalDoctorComboBox.Name = "_referalDoctorComboBox";
            this._referalDoctorComboBox.Size = new System.Drawing.Size(210, 21);
            this._referalDoctorComboBox.TabIndex = 15;
            // 
            // _refDoctorLabel
            // 
            this._refDoctorLabel.AutoSize = true;
            this._refDoctorLabel.Location = new System.Drawing.Point(12, 123);
            this._refDoctorLabel.Name = "_refDoctorLabel";
            this._refDoctorLabel.Size = new System.Drawing.Size(76, 13);
            this._refDoctorLabel.TabIndex = 46;
            this._refDoctorLabel.Text = "Referal Doctor";
            // 
            // _occupation
            // 
            this._occupation.Location = new System.Drawing.Point(93, 90);
            this._occupation.MaxLength = 49;
            this._occupation.Name = "_occupation";
            this._occupation.Size = new System.Drawing.Size(210, 20);
            this._occupation.TabIndex = 14;
            // 
            // _occupationLabel
            // 
            this._occupationLabel.AutoSize = true;
            this._occupationLabel.Location = new System.Drawing.Point(12, 93);
            this._occupationLabel.Name = "_occupationLabel";
            this._occupationLabel.Size = new System.Drawing.Size(62, 13);
            this._occupationLabel.TabIndex = 44;
            this._occupationLabel.Text = "Occupation";
            // 
            // _monthsLabel
            // 
            this._monthsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._monthsLabel.AutoSize = true;
            this._monthsLabel.Location = new System.Drawing.Point(258, 31);
            this._monthsLabel.Name = "_monthsLabel";
            this._monthsLabel.Size = new System.Drawing.Size(42, 13);
            this._monthsLabel.TabIndex = 43;
            this._monthsLabel.Text = "Months";
            // 
            // _months
            // 
            this._months.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._months.Location = new System.Drawing.Point(202, 27);
            this._months.Name = "_months";
            this._months.Size = new System.Drawing.Size(52, 20);
            this._months.TabIndex = 12;
            // 
            // _yearLabel
            // 
            this._yearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._yearLabel.AutoSize = true;
            this._yearLabel.Location = new System.Drawing.Point(141, 31);
            this._yearLabel.Name = "_yearLabel";
            this._yearLabel.Size = new System.Drawing.Size(34, 13);
            this._yearLabel.TabIndex = 41;
            this._yearLabel.Text = "Years";
            // 
            // _years
            // 
            this._years.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._years.Location = new System.Drawing.Point(93, 27);
            this._years.Name = "_years";
            this._years.Size = new System.Drawing.Size(47, 20);
            this._years.TabIndex = 11;
            // 
            // _ageLabel
            // 
            this._ageLabel.AutoSize = true;
            this._ageLabel.Location = new System.Drawing.Point(12, 31);
            this._ageLabel.Name = "_ageLabel";
            this._ageLabel.Size = new System.Drawing.Size(26, 13);
            this._ageLabel.TabIndex = 39;
            this._ageLabel.Text = "Age";
            // 
            // _sexComboBox
            // 
            this._sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._sexComboBox.FormattingEnabled = true;
            this._sexComboBox.Location = new System.Drawing.Point(93, 57);
            this._sexComboBox.Name = "_sexComboBox";
            this._sexComboBox.Size = new System.Drawing.Size(104, 21);
            this._sexComboBox.TabIndex = 13;
            // 
            // _sexLabel
            // 
            this._sexLabel.AutoSize = true;
            this._sexLabel.Location = new System.Drawing.Point(12, 61);
            this._sexLabel.Name = "_sexLabel";
            this._sexLabel.Size = new System.Drawing.Size(25, 13);
            this._sexLabel.TabIndex = 34;
            this._sexLabel.Text = "Sex";
            // 
            // _opdDiagnosisGroup
            // 
            this._opdDiagnosisGroup.Controls.Add(this._opdDiagnosis);
            this._opdDiagnosisGroup.Controls.Add(this._opdDiagnosisLabel);
            this._opdDiagnosisGroup.Location = new System.Drawing.Point(14, 280);
            this._opdDiagnosisGroup.Name = "_opdDiagnosisGroup";
            this._opdDiagnosisGroup.Size = new System.Drawing.Size(1012, 119);
            this._opdDiagnosisGroup.TabIndex = 26;
            this._opdDiagnosisGroup.TabStop = false;
            this._opdDiagnosisGroup.Text = "O.P.D. Diagnosis";
            // 
            // _opdDiagnosis
            // 
            this._opdDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._opdDiagnosis.Location = new System.Drawing.Point(101, 19);
            this._opdDiagnosis.MaxLength = 150;
            this._opdDiagnosis.Multiline = true;
            this._opdDiagnosis.Name = "_opdDiagnosis";
            this._opdDiagnosis.Size = new System.Drawing.Size(900, 85);
            this._opdDiagnosis.TabIndex = 16;
            // 
            // _opdDiagnosisLabel
            // 
            this._opdDiagnosisLabel.AutoSize = true;
            this._opdDiagnosisLabel.Location = new System.Drawing.Point(21, 22);
            this._opdDiagnosisLabel.Name = "_opdDiagnosisLabel";
            this._opdDiagnosisLabel.Size = new System.Drawing.Size(53, 13);
            this._opdDiagnosisLabel.TabIndex = 46;
            this._opdDiagnosisLabel.Text = "Diagnosis";
            // 
            // _contactGroup
            // 
            this._contactGroup.Controls.Add(this._mobile);
            this._contactGroup.Controls.Add(this._state);
            this._contactGroup.Controls.Add(this._mobileLabel);
            this._contactGroup.Controls.Add(this._phone);
            this._contactGroup.Controls.Add(this._phoneLabel);
            this._contactGroup.Controls.Add(this._stateLabel);
            this._contactGroup.Controls.Add(this._district);
            this._contactGroup.Controls.Add(this._districtLabel);
            this._contactGroup.Controls.Add(this._town);
            this._contactGroup.Controls.Add(this._townLabel);
            this._contactGroup.Controls.Add(this._atPost);
            this._contactGroup.Controls.Add(this._atPostLabel);
            this._contactGroup.Location = new System.Drawing.Point(229, 109);
            this._contactGroup.Name = "_contactGroup";
            this._contactGroup.Size = new System.Drawing.Size(430, 157);
            this._contactGroup.TabIndex = 25;
            this._contactGroup.TabStop = false;
            this._contactGroup.Text = "Contact Details";
            // 
            // _mobile
            // 
            this._mobile.Location = new System.Drawing.Point(272, 114);
            this._mobile.Mask = "0000000000";
            this._mobile.Name = "_mobile";
            this._mobile.PromptChar = '0';
            this._mobile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._mobile.Size = new System.Drawing.Size(135, 20);
            this._mobile.TabIndex = 9;
            // 
            // _state
            // 
            this._state.DefaultText = "Please select one...";
            this._state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._state.FormattingEnabled = true;
            this._state.Items.AddRange(new object[] {
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
            "West Bangal"});
            this._state.LimitToList = true;
            this._state.Location = new System.Drawing.Point(271, 84);
            this._state.Name = "_state";
            this._state.Size = new System.Drawing.Size(136, 21);
            this._state.TabIndex = 7;
            // 
            // _mobileLabel
            // 
            this._mobileLabel.AutoSize = true;
            this._mobileLabel.Location = new System.Drawing.Point(222, 117);
            this._mobileLabel.Name = "_mobileLabel";
            this._mobileLabel.Size = new System.Drawing.Size(38, 13);
            this._mobileLabel.TabIndex = 48;
            this._mobileLabel.Text = "Mobile";
            // 
            // _phone
            // 
            this._phone.Location = new System.Drawing.Point(67, 117);
            this._phone.MaxLength = 15;
            this._phone.Name = "_phone";
            this._phone.Size = new System.Drawing.Size(135, 20);
            this._phone.TabIndex = 8;
            // 
            // _phoneLabel
            // 
            this._phoneLabel.AutoSize = true;
            this._phoneLabel.Location = new System.Drawing.Point(7, 120);
            this._phoneLabel.Name = "_phoneLabel";
            this._phoneLabel.Size = new System.Drawing.Size(38, 13);
            this._phoneLabel.TabIndex = 46;
            this._phoneLabel.Text = "Phone";
            // 
            // _stateLabel
            // 
            this._stateLabel.AutoSize = true;
            this._stateLabel.Location = new System.Drawing.Point(222, 90);
            this._stateLabel.Name = "_stateLabel";
            this._stateLabel.Size = new System.Drawing.Size(32, 13);
            this._stateLabel.TabIndex = 44;
            this._stateLabel.Text = "State";
            // 
            // _district
            // 
            this._district.Location = new System.Drawing.Point(66, 87);
            this._district.MaxLength = 50;
            this._district.Name = "_district";
            this._district.Size = new System.Drawing.Size(135, 20);
            this._district.TabIndex = 6;
            // 
            // _districtLabel
            // 
            this._districtLabel.AutoSize = true;
            this._districtLabel.Location = new System.Drawing.Point(7, 90);
            this._districtLabel.Name = "_districtLabel";
            this._districtLabel.Size = new System.Drawing.Size(39, 13);
            this._districtLabel.TabIndex = 42;
            this._districtLabel.Text = "District";
            // 
            // _town
            // 
            this._town.Location = new System.Drawing.Point(66, 55);
            this._town.MaxLength = 50;
            this._town.Name = "_town";
            this._town.Size = new System.Drawing.Size(340, 20);
            this._town.TabIndex = 5;
            // 
            // _townLabel
            // 
            this._townLabel.AutoSize = true;
            this._townLabel.Location = new System.Drawing.Point(7, 58);
            this._townLabel.Name = "_townLabel";
            this._townLabel.Size = new System.Drawing.Size(34, 13);
            this._townLabel.TabIndex = 40;
            this._townLabel.Text = "Town";
            // 
            // _atPost
            // 
            this._atPost.Location = new System.Drawing.Point(66, 24);
            this._atPost.MaxLength = 80;
            this._atPost.Name = "_atPost";
            this._atPost.Size = new System.Drawing.Size(340, 20);
            this._atPost.TabIndex = 4;
            // 
            // _atPostLabel
            // 
            this._atPostLabel.AutoSize = true;
            this._atPostLabel.Location = new System.Drawing.Point(7, 28);
            this._atPostLabel.Name = "_atPostLabel";
            this._atPostLabel.Size = new System.Drawing.Size(41, 13);
            this._atPostLabel.TabIndex = 38;
            this._atPostLabel.Text = "At Post";
            // 
            // _registrationDetails
            // 
            this._registrationDetails.Controls.Add(this._registrationDate);
            this._registrationDetails.Controls.Add(this._guNoTextBox);
            this._registrationDetails.Controls.Add(this._patientName);
            this._registrationDetails.Controls.Add(this._patientNameLabel);
            this._registrationDetails.Controls.Add(this._salutation);
            this._registrationDetails.Controls.Add(this._salutationLabel);
            this._registrationDetails.Controls.Add(this._registrationDateLabel);
            this._registrationDetails.Controls.Add(this._guNumberLabel);
            this._registrationDetails.Location = new System.Drawing.Point(229, 18);
            this._registrationDetails.Name = "_registrationDetails";
            this._registrationDetails.Size = new System.Drawing.Size(595, 88);
            this._registrationDetails.TabIndex = 19;
            this._registrationDetails.TabStop = false;
            this._registrationDetails.Text = "Registration Details";
            // 
            // _registrationDate
            // 
            this._registrationDate.Location = new System.Drawing.Point(334, 23);
            this._registrationDate.Mask = "00/00/0000";
            this._registrationDate.Name = "_registrationDate";
            this._registrationDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._registrationDate.Size = new System.Drawing.Size(79, 20);
            this._registrationDate.TabIndex = 1;
            this._registrationDate.ValidatingType = typeof(System.DateTime);
            // 
            // _guNoTextBox
            // 
            this._guNoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._guNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._guNoTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._guNoTextBox.Location = new System.Drawing.Point(106, 25);
            this._guNoTextBox.Name = "_guNoTextBox";
            this._guNoTextBox.Size = new System.Drawing.Size(101, 21);
            this._guNoTextBox.TabIndex = 43;
            // 
            // _patientName
            // 
            this._patientName.Location = new System.Drawing.Point(334, 57);
            this._patientName.MaxLength = 80;
            this._patientName.Name = "_patientName";
            this._patientName.Size = new System.Drawing.Size(237, 20);
            this._patientName.TabIndex = 3;
            // 
            // _patientNameLabel
            // 
            this._patientNameLabel.AutoSize = true;
            this._patientNameLabel.Location = new System.Drawing.Point(241, 60);
            this._patientNameLabel.Name = "_patientNameLabel";
            this._patientNameLabel.Size = new System.Drawing.Size(71, 13);
            this._patientNameLabel.TabIndex = 30;
            this._patientNameLabel.Text = "Patient Name";
            // 
            // _salutation
            // 
            this._salutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._salutation.FormattingEnabled = true;
            this._salutation.ItemHeight = 13;
            this._salutation.Items.AddRange(new object[] {
            "Adv",
            "Baby",
            "Dr",
            "Mr",
            "Mrs",
            "Master",
            "Prof"});
            this._salutation.Location = new System.Drawing.Point(103, 57);
            this._salutation.Name = "_salutation";
            this._salutation.Size = new System.Drawing.Size(104, 21);
            this._salutation.TabIndex = 2;
            // 
            // _salutationLabel
            // 
            this._salutationLabel.AutoSize = true;
            this._salutationLabel.Location = new System.Drawing.Point(16, 60);
            this._salutationLabel.Name = "_salutationLabel";
            this._salutationLabel.Size = new System.Drawing.Size(54, 13);
            this._salutationLabel.TabIndex = 28;
            this._salutationLabel.Text = "Salutation";
            // 
            // _registrationDateLabel
            // 
            this._registrationDateLabel.AutoSize = true;
            this._registrationDateLabel.Location = new System.Drawing.Point(240, 28);
            this._registrationDateLabel.Name = "_registrationDateLabel";
            this._registrationDateLabel.Size = new System.Drawing.Size(89, 13);
            this._registrationDateLabel.TabIndex = 26;
            this._registrationDateLabel.Text = "Registration Date";
            // 
            // _guNumberLabel
            // 
            this._guNumberLabel.AutoSize = true;
            this._guNumberLabel.Location = new System.Drawing.Point(16, 29);
            this._guNumberLabel.Name = "_guNumberLabel";
            this._guNumberLabel.Size = new System.Drawing.Size(69, 13);
            this._guNumberLabel.TabIndex = 24;
            this._guNumberLabel.Text = "G.U. Number";
            // 
            // PatientInformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this._mainPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PatientInformationControl";
            this.Size = new System.Drawing.Size(1150, 856);
            this._mainPanel.ResumeLayout(false);
            this._photoGroup.ResumeLayout(false);
            this._photoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._patientPicture)).EndInit();
            this._ipdDetailsGroup.ResumeLayout(false);
            this._ipdDetailsGroup.PerformLayout();
            this._personalDetailsGroup.ResumeLayout(false);
            this._personalDetailsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._months)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._years)).EndInit();
            this._opdDiagnosisGroup.ResumeLayout(false);
            this._opdDiagnosisGroup.PerformLayout();
            this._contactGroup.ResumeLayout(false);
            this._contactGroup.PerformLayout();
            this._registrationDetails.ResumeLayout(false);
            this._registrationDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _mainPanel;
        private System.Windows.Forms.GroupBox _contactGroup;
        private System.Windows.Forms.Label _mobileLabel;
        private System.Windows.Forms.TextBox _phone;
        private System.Windows.Forms.Label _phoneLabel;
        private System.Windows.Forms.Label _stateLabel;
        private System.Windows.Forms.TextBox _district;
        private System.Windows.Forms.Label _districtLabel;
        private System.Windows.Forms.TextBox _town;
        private System.Windows.Forms.Label _townLabel;
        private System.Windows.Forms.TextBox _atPost;
        private System.Windows.Forms.Label _atPostLabel;
        private System.Windows.Forms.GroupBox _registrationDetails;
        private System.Windows.Forms.TextBox _patientName;
        private System.Windows.Forms.Label _patientNameLabel;
        private System.Windows.Forms.ComboBox _salutation;
        private System.Windows.Forms.Label _salutationLabel;
        private System.Windows.Forms.Label _registrationDateLabel;
        private System.Windows.Forms.Label _guNumberLabel;
        private System.Windows.Forms.Label _guNoTextBox;
        private System.Windows.Forms.GroupBox _opdDiagnosisGroup;
        private System.Windows.Forms.TextBox _opdDiagnosis;
        private System.Windows.Forms.Label _opdDiagnosisLabel;
        private System.Windows.Forms.GroupBox _personalDetailsGroup;
        private System.Windows.Forms.Label _refDoctorLabel;
        private System.Windows.Forms.TextBox _occupation;
        private System.Windows.Forms.Label _occupationLabel;
        private System.Windows.Forms.Label _monthsLabel;
        private System.Windows.Forms.NumericUpDown _months;
        private System.Windows.Forms.Label _yearLabel;
        private System.Windows.Forms.NumericUpDown _years;
        private System.Windows.Forms.Label _ageLabel;
        private System.Windows.Forms.ComboBox _sexComboBox;
        private System.Windows.Forms.Label _sexLabel;
        private System.Windows.Forms.GroupBox _ipdDetailsGroup;
        private System.Windows.Forms.TextBox _ipdDiagnosis;
        private System.Windows.Forms.Label _ipdDiagnosisLabel;
        private System.Windows.Forms.Label _ipdNoLabel;
        private System.Windows.Forms.MaskedTextBox _ipdNumber;
        private System.Windows.Forms.ListView _operationDetails;
        private System.Windows.Forms.GroupBox _photoGroup;
        private System.Windows.Forms.PictureBox _patientPicture;
        private System.Windows.Forms.Button _cameraButton;
        private System.Windows.Forms.Label _dischargeDateLabel;
        private System.Windows.Forms.Label _admissionDateLabel;
        private System.Windows.Forms.MaskedTextBox _registrationDate;
        private System.Windows.Forms.MaskedTextBox _dischargeDate;
        private System.Windows.Forms.MaskedTextBox _admissionDate;
        private UICommonControls.AutoCompleteComboBox _state;
        private UICommonControls.AutoCompleteComboBox _referalDoctorComboBox;
        private System.Windows.Forms.Button _addReferalDoctor;
        private System.Windows.Forms.MaskedTextBox _mobile;


    }
}
