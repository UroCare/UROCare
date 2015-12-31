namespace SHC.UROCare.UI
{
    partial class TreatmentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreatmentControl));
            this._treatmentlGroupBox = new System.Windows.Forms.GroupBox();
            this._treatmentGivenTextBox = new System.Windows.Forms.TextBox();
            this._treatmentGivenLabel = new System.Windows.Forms.Label();
            this._treatmentDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this._eswlList = new System.Windows.Forms.ListView();
            this._treatmentDateLabel = new System.Windows.Forms.Label();
            this._patientGroup = new System.Windows.Forms.GroupBox();
            this._patientNameText = new System.Windows.Forms.Label();
            this._patientNameLabel = new System.Windows.Forms.Label();
            this._guNoTextBox = new System.Windows.Forms.Label();
            this._guNumberLabel = new System.Windows.Forms.Label();
            this._treatmentlGroupBox.SuspendLayout();
            this._patientGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // _treatmentlGroupBox
            // 
            this._treatmentlGroupBox.Controls.Add(this._treatmentGivenTextBox);
            this._treatmentlGroupBox.Controls.Add(this._treatmentGivenLabel);
            this._treatmentlGroupBox.Controls.Add(this._treatmentDateTextBox);
            this._treatmentlGroupBox.Controls.Add(this._eswlList);
            this._treatmentlGroupBox.Controls.Add(this._treatmentDateLabel);
            this._treatmentlGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this._treatmentlGroupBox, "_treatmentlGroupBox");
            this._treatmentlGroupBox.Name = "_treatmentlGroupBox";
            this._treatmentlGroupBox.TabStop = false;
            // 
            // _treatmentGivenTextBox
            // 
            resources.ApplyResources(this._treatmentGivenTextBox, "_treatmentGivenTextBox");
            this._treatmentGivenTextBox.Name = "_treatmentGivenTextBox";
            // 
            // _treatmentGivenLabel
            // 
            resources.ApplyResources(this._treatmentGivenLabel, "_treatmentGivenLabel");
            this._treatmentGivenLabel.Name = "_treatmentGivenLabel";
            // 
            // _treatmentDateTextBox
            // 
            resources.ApplyResources(this._treatmentDateTextBox, "_treatmentDateTextBox");
            this._treatmentDateTextBox.Name = "_treatmentDateTextBox";
            this._treatmentDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // _eswlList
            // 
            resources.ApplyResources(this._eswlList, "_eswlList");
            this._eswlList.GridLines = true;
            this._eswlList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("_eswlList.Items")))});
            this._eswlList.Name = "_eswlList";
            this._eswlList.UseCompatibleStateImageBehavior = false;
            // 
            // _treatmentDateLabel
            // 
            resources.ApplyResources(this._treatmentDateLabel, "_treatmentDateLabel");
            this._treatmentDateLabel.Name = "_treatmentDateLabel";
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
            // TreatmentControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._patientGroup);
            this.Controls.Add(this._treatmentlGroupBox);
            this.Name = "TreatmentControl";
            this._treatmentlGroupBox.ResumeLayout(false);
            this._treatmentlGroupBox.PerformLayout();
            this._patientGroup.ResumeLayout(false);
            this._patientGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _treatmentlGroupBox;
        private System.Windows.Forms.GroupBox _patientGroup;
        private System.Windows.Forms.Label _patientNameText;
        private System.Windows.Forms.Label _patientNameLabel;
        private System.Windows.Forms.Label _guNoTextBox;
        private System.Windows.Forms.Label _guNumberLabel;
        private System.Windows.Forms.Label _treatmentDateLabel;
        private System.Windows.Forms.ListView _eswlList;
        private System.Windows.Forms.MaskedTextBox _treatmentDateTextBox;
        private System.Windows.Forms.TextBox _treatmentGivenTextBox;
        private System.Windows.Forms.Label _treatmentGivenLabel;
    }
}
