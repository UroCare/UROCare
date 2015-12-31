//using PureComponents.NicePanel;

namespace MigrateData
{
    partial class DataMigrationForm
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
            VisibleChanged -= OnVisibleChangedEvent;
            _timer.Tick -= OnTimerTick;
            _dataMigrationHelper.Cleanup();
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
            //PureComponents.NicePanel.ContainerImage containerImage1 = new PureComponents.NicePanel.ContainerImage();
            //PureComponents.NicePanel.HeaderImage headerImage1 = new PureComponents.NicePanel.HeaderImage();
            //PureComponents.NicePanel.HeaderImage headerImage2 = new PureComponents.NicePanel.HeaderImage();
            //PureComponents.NicePanel.PanelStyle panelStyle1 = new PureComponents.NicePanel.PanelStyle();
            //PureComponents.NicePanel.ContainerStyle containerStyle1 = new PureComponents.NicePanel.ContainerStyle();
            //PureComponents.NicePanel.PanelHeaderStyle panelHeaderStyle1 = new PureComponents.NicePanel.PanelHeaderStyle();
            //PureComponents.NicePanel.PanelHeaderStyle panelHeaderStyle2 = new PureComponents.NicePanel.PanelHeaderStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataMigrationForm));
          //  this._parentPanel = new PureComponents.NicePanel.NicePanel();
            this._createScript = new System.Windows.Forms.CheckBox();
            this._availableSQLServers = new System.Windows.Forms.ComboBox();
            this._browseButton = new System.Windows.Forms.Button();
            this._dataSourceTextBox = new System.Windows.Forms.TextBox();
            this._destinationServerLabel = new System.Windows.Forms.Label();
            this._dataSourceLabel = new System.Windows.Forms.Label();
            this._cancelButton = new System.Windows.Forms.Button();
            this._migrateButton = new System.Windows.Forms.Button();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
           // this._parentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _parentPanel
            // 
            //this._parentPanel.BackColor = System.Drawing.Color.Transparent;
            //this._parentPanel.CloseButton = true;
            //this._parentPanel.CollapseButton = false;
            //containerImage1.Alignment = System.Drawing.ContentAlignment.BottomRight;
            //containerImage1.ClipArt = PureComponents.NicePanel.ImageClipArt.None;
            //containerImage1.Image = null;
            //containerImage1.Size = PureComponents.NicePanel.ContainerImageSize.Small;
            //containerImage1.Transparency = 50;
            //this._parentPanel.ContainerImage = containerImage1;
            //this._parentPanel.ContextMenuButton = false;
            //this._parentPanel.Controls.Add(this._createScript);
            //this._parentPanel.Controls.Add(this._availableSQLServers);
            //this._parentPanel.Controls.Add(this._browseButton);
            //this._parentPanel.Controls.Add(this._dataSourceTextBox);
            //this._parentPanel.Controls.Add(this._destinationServerLabel);
            //this._parentPanel.Controls.Add(this._dataSourceLabel);
            //this._parentPanel.Controls.Add(this._cancelButton);
            //this._parentPanel.Controls.Add(this._migrateButton);
            //this._parentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            //headerImage1.ClipArt = PureComponents.NicePanel.ImageClipArt.None;
            //headerImage1.Image = null;
            //this._parentPanel.FooterImage = headerImage1;
            //this._parentPanel.FooterText = "Sharma Health Care Pvt. Ltd.";
            //this._parentPanel.ForeColor = System.Drawing.Color.Black;
            //headerImage2.ClipArt = PureComponents.NicePanel.ImageClipArt.Applications;
            //headerImage2.Image = null;
            //this._parentPanel.HeaderImage = headerImage2;
            //this._parentPanel.HeaderText = "Data migration utility";
            //this._parentPanel.IsExpanded = true;
            //this._parentPanel.Location = new System.Drawing.Point(0, 0);
            //this._parentPanel.Name = "_parentPanel";
            //this._parentPanel.OriginalFooterVisible = true;
            //this._parentPanel.OriginalHeight = 200;
            //this._parentPanel.Resizable = false;
            //this._parentPanel.Size = new System.Drawing.Size(393, 159);
            //containerStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            //containerStyle1.BaseColor = System.Drawing.Color.Transparent;
            //containerStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            //containerStyle1.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid;
            //containerStyle1.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left;
            //containerStyle1.FadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            //containerStyle1.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward;
            //containerStyle1.FlashItemBackColor = System.Drawing.Color.Red;
            //containerStyle1.FocusItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            //containerStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //containerStyle1.ForeColor = System.Drawing.Color.Black;
            //containerStyle1.Shape = PureComponents.NicePanel.Shape.Squared;
            //panelStyle1.ContainerStyle = containerStyle1;
            //panelHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(127)))));
            //panelHeaderStyle1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            //panelHeaderStyle1.FadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(215)))));
            //panelHeaderStyle1.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading;
            //panelHeaderStyle1.FlashBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(122)))), ((int)(((byte)(1)))));
            //panelHeaderStyle1.FlashFadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(159)))));
            //panelHeaderStyle1.FlashForeColor = System.Drawing.Color.White;
            //panelHeaderStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            //panelHeaderStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(198)))), ((int)(((byte)(237)))));
            //panelHeaderStyle1.Size = PureComponents.NicePanel.PanelHeaderSize.Small;
            //panelStyle1.FooterStyle = panelHeaderStyle1;
            //panelHeaderStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(215)))));
            //panelHeaderStyle2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            //panelHeaderStyle2.FadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(127)))));
            //panelHeaderStyle2.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading;
            //panelHeaderStyle2.FlashBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(122)))), ((int)(((byte)(1)))));
            //panelHeaderStyle2.FlashFadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(159)))));
            //panelHeaderStyle2.FlashForeColor = System.Drawing.Color.White;
            //panelHeaderStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            //panelHeaderStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            //panelHeaderStyle2.Size = PureComponents.NicePanel.PanelHeaderSize.Medium;
            //panelStyle1.HeaderStyle = panelHeaderStyle2;
            //this._parentPanel.Style = panelStyle1;
            //this._parentPanel.TabIndex = 4;
            // 
            // _createScript
            // 
            this._createScript.AutoSize = true;
            this._createScript.Location = new System.Drawing.Point(115, 89);
            this._createScript.Name = "_createScript";
            this._createScript.Size = new System.Drawing.Size(190, 17);
            this._createScript.TabIndex = 14;
            this._createScript.Text = "Create database from database file";
            this._createScript.UseVisualStyleBackColor = true;
            // 
            // _availableSQLServers
            // 
            this._availableSQLServers.FormattingEnabled = true;
            this._availableSQLServers.Location = new System.Drawing.Point(115, 62);
            this._availableSQLServers.Name = "_availableSQLServers";
            this._availableSQLServers.Size = new System.Drawing.Size(182, 21);
            this._availableSQLServers.TabIndex = 13;
            // 
            // _browseButton
            // 
            this._browseButton.Location = new System.Drawing.Point(316, 32);
            this._browseButton.Name = "_browseButton";
            this._browseButton.Size = new System.Drawing.Size(27, 23);
            this._browseButton.TabIndex = 12;
            this._browseButton.Text = "...";
            this._browseButton.UseVisualStyleBackColor = true;
            this._browseButton.Click += new System.EventHandler(this.OnBrowseButtonClick);
            // 
            // _dataSourceTextBox
            // 
            this._dataSourceTextBox.Location = new System.Drawing.Point(115, 33);
            this._dataSourceTextBox.Name = "_dataSourceTextBox";
            this._dataSourceTextBox.Size = new System.Drawing.Size(182, 20);
            this._dataSourceTextBox.TabIndex = 11;
            // 
            // _destinationServerLabel
            // 
            this._destinationServerLabel.AutoSize = true;
            this._destinationServerLabel.Location = new System.Drawing.Point(14, 67);
            this._destinationServerLabel.Name = "_destinationServerLabel";
            this._destinationServerLabel.Size = new System.Drawing.Size(95, 13);
            this._destinationServerLabel.TabIndex = 6;
            this._destinationServerLabel.Text = "Destination server:";
            this._destinationServerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _dataSourceLabel
            // 
            this._dataSourceLabel.AutoSize = true;
            this._dataSourceLabel.Location = new System.Drawing.Point(41, 37);
            this._dataSourceLabel.Name = "_dataSourceLabel";
            this._dataSourceLabel.Size = new System.Drawing.Size(68, 13);
            this._dataSourceLabel.TabIndex = 7;
            this._dataSourceLabel.Text = "Data source:";
            this._dataSourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancelButton.Location = new System.Drawing.Point(201, 114);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 4;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this.OnCancelButtonClick);
            // 
            // _migrateButton
            // 
            this._migrateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._migrateButton.Location = new System.Drawing.Point(120, 114);
            this._migrateButton.Name = "_migrateButton";
            this._migrateButton.Size = new System.Drawing.Size(75, 23);
            this._migrateButton.TabIndex = 5;
            this._migrateButton.Text = "Migrate";
            this._migrateButton.UseVisualStyleBackColor = true;
            this._migrateButton.Click += new System.EventHandler(this.OnMigrateButtonClick);
            // 
            // _timer
            // 
            this._timer.Interval = 50;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // DataMigrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(393, 159);
           // this.Controls.Add(this._parentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataMigrationForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data migration utility";
            //this._parentPanel.ResumeLayout(false);
            //this._parentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       // private NicePanel _parentPanel;
        private System.Windows.Forms.Button _browseButton;
        private System.Windows.Forms.TextBox _dataSourceTextBox;
        private System.Windows.Forms.Label _destinationServerLabel;
        private System.Windows.Forms.Label _dataSourceLabel;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _migrateButton;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        private System.Windows.Forms.ComboBox _availableSQLServers;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.CheckBox _createScript;
    }
}

