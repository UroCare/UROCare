namespace SHC.UROCare.UI
{
    partial class HomeNodeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeNodeControl));
            this._masterPanel = new System.Windows.Forms.Panel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            //this.gadgetContainerControl1 = new SHCPL.WPFCommonControls.GadgetContainerControl();
            this._masterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _masterPanel
            // 
            this._masterPanel.BackColor = System.Drawing.Color.Transparent;
            this._masterPanel.BackgroundImage = global::SHC.UROCare.UI.Properties.Resources.UROCare_png;
            resources.ApplyResources(this._masterPanel, "_masterPanel");
            this._masterPanel.Controls.Add(this.elementHost1);
            this._masterPanel.Name = "_masterPanel";
            // 
            // elementHost1
            // 
            resources.ApplyResources(this.elementHost1, "elementHost1");
            this.elementHost1.Name = "elementHost1";
           // this.elementHost1.Child = this.gadgetContainerControl1;
            // 
            // HomeNodeControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._masterPanel);
            this.Name = "HomeNodeControl";
            this._masterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _masterPanel;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
       // private SHCPL.WPFCommonControls.GadgetContainerControl gadgetContainerControl1;
    }
}
