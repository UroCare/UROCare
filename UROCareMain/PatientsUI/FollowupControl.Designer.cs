namespace SHC.UROCare.UI
{
    partial class FollowupControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FollowupControl));
            this._followupDetailGroupBox = new System.Windows.Forms.GroupBox();
            this._nextDay = new System.Windows.Forms.Label();
            this._nextDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this._nextDateLabel = new System.Windows.Forms.Label();
            this._treatmentTextBox = new System.Windows.Forms.TextBox();
            this._treatmentsLabel = new System.Windows.Forms.Label();
            this._evaluationTextBox = new System.Windows.Forms.TextBox();
            this._evaluationLabel = new System.Windows.Forms.Label();
            this._dateTextBox = new System.Windows.Forms.MaskedTextBox();
            this._eswlList = new System.Windows.Forms.ListView();
            this._eswlDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._sizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._complaintsTextBox = new System.Windows.Forms.TextBox();
            this._complaintsLabel = new System.Windows.Forms.Label();
            this._dateLabel = new System.Windows.Forms.Label();
            this._patientGroup = new System.Windows.Forms.GroupBox();
            this._patientNameText = new System.Windows.Forms.Label();
            this._patientNameLabel = new System.Windows.Forms.Label();
            this._guNoTextBox = new System.Windows.Forms.Label();
            this._guNumberLabel = new System.Windows.Forms.Label();
            this._followupDetailGroupBox.SuspendLayout();
            this._patientGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // _followupDetailGroupBox
            // 
            this._followupDetailGroupBox.Controls.Add(this._nextDay);
            this._followupDetailGroupBox.Controls.Add(this._nextDateTextBox);
            this._followupDetailGroupBox.Controls.Add(this._nextDateLabel);
            this._followupDetailGroupBox.Controls.Add(this._treatmentTextBox);
            this._followupDetailGroupBox.Controls.Add(this._treatmentsLabel);
            this._followupDetailGroupBox.Controls.Add(this._evaluationTextBox);
            this._followupDetailGroupBox.Controls.Add(this._evaluationLabel);
            this._followupDetailGroupBox.Controls.Add(this._dateTextBox);
            this._followupDetailGroupBox.Controls.Add(this._eswlList);
            this._followupDetailGroupBox.Controls.Add(this._complaintsTextBox);
            this._followupDetailGroupBox.Controls.Add(this._complaintsLabel);
            this._followupDetailGroupBox.Controls.Add(this._dateLabel);
            this._followupDetailGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this._followupDetailGroupBox, "_followupDetailGroupBox");
            this._followupDetailGroupBox.Name = "_followupDetailGroupBox";
            this._followupDetailGroupBox.TabStop = false;
            // 
            // _nextDay
            // 
            this._nextDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._nextDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._nextDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this._nextDay, "_nextDay");
            this._nextDay.Name = "_nextDay";
            // 
            // _nextDateTextBox
            // 
            resources.ApplyResources(this._nextDateTextBox, "_nextDateTextBox");
            this._nextDateTextBox.Name = "_nextDateTextBox";
            this._nextDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // _nextDateLabel
            // 
            resources.ApplyResources(this._nextDateLabel, "_nextDateLabel");
            this._nextDateLabel.Name = "_nextDateLabel";
            // 
            // _treatmentTextBox
            // 
            resources.ApplyResources(this._treatmentTextBox, "_treatmentTextBox");
            this._treatmentTextBox.Name = "_treatmentTextBox";
            // 
            // _treatmentsLabel
            // 
            resources.ApplyResources(this._treatmentsLabel, "_treatmentsLabel");
            this._treatmentsLabel.Name = "_treatmentsLabel";
            // 
            // _evaluationTextBox
            // 
            resources.ApplyResources(this._evaluationTextBox, "_evaluationTextBox");
            this._evaluationTextBox.Name = "_evaluationTextBox";
            // 
            // _evaluationLabel
            // 
            resources.ApplyResources(this._evaluationLabel, "_evaluationLabel");
            this._evaluationLabel.Name = "_evaluationLabel";
            // 
            // _dateTextBox
            // 
            resources.ApplyResources(this._dateTextBox, "_dateTextBox");
            this._dateTextBox.Name = "_dateTextBox";
            this._dateTextBox.ValidatingType = typeof(System.DateTime);
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
            // _complaintsTextBox
            // 
            resources.ApplyResources(this._complaintsTextBox, "_complaintsTextBox");
            this._complaintsTextBox.Name = "_complaintsTextBox";
            // 
            // _complaintsLabel
            // 
            resources.ApplyResources(this._complaintsLabel, "_complaintsLabel");
            this._complaintsLabel.Name = "_complaintsLabel";
            // 
            // _dateLabel
            // 
            resources.ApplyResources(this._dateLabel, "_dateLabel");
            this._dateLabel.Name = "_dateLabel";
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
            // FollowupControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._patientGroup);
            this.Controls.Add(this._followupDetailGroupBox);
            this.Name = "FollowupControl";
            this._followupDetailGroupBox.ResumeLayout(false);
            this._followupDetailGroupBox.PerformLayout();
            this._patientGroup.ResumeLayout(false);
            this._patientGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _followupDetailGroupBox;
        private System.Windows.Forms.Label _complaintsLabel;
        private System.Windows.Forms.TextBox _complaintsTextBox;
        private System.Windows.Forms.GroupBox _patientGroup;
        private System.Windows.Forms.Label _patientNameText;
        private System.Windows.Forms.Label _patientNameLabel;
        private System.Windows.Forms.Label _guNoTextBox;
        private System.Windows.Forms.Label _guNumberLabel;
        private System.Windows.Forms.Label _dateLabel;
        private System.Windows.Forms.ListView _eswlList;
        private System.Windows.Forms.ColumnHeader _eswlDateColumn;
        private System.Windows.Forms.ColumnHeader _sizeColumn;
        private System.Windows.Forms.MaskedTextBox _dateTextBox;
        private System.Windows.Forms.TextBox _treatmentTextBox;
        private System.Windows.Forms.Label _treatmentsLabel;
        private System.Windows.Forms.TextBox _evaluationTextBox;
        private System.Windows.Forms.Label _evaluationLabel;
        private System.Windows.Forms.Label _nextDay;
        private System.Windows.Forms.MaskedTextBox _nextDateTextBox;
        private System.Windows.Forms.Label _nextDateLabel;
    }
}
