using System;
using System.Windows.Forms;

namespace MigrateData
{
    public partial class DataMigrationForm : Form
    {
        #region Private fields

        private readonly DataMigrationHelper _dataMigrationHelper;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor to create the instance.
        /// </summary>
        public DataMigrationForm()
        {
            InitializeComponent();
            _dataMigrationHelper = new DataMigrationHelper(ShowMessage);
            VisibleChanged += OnVisibleChangedEvent;
            _timer.Tick += OnTimerTick;
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// Event handler to handle the click event of browse button. 
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void OnBrowseButtonClick(object sender, EventArgs e)
        {
            _openFileDialog.Title = Strings.OpenSourceDataFile;
            _openFileDialog.Filter = Strings.FilterString;
            if (DialogResult.OK == _openFileDialog.ShowDialog())
            {
                _dataSourceTextBox.Text = _openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Event handler to handle the migrate button click event.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMigrateButtonClick(object sender, EventArgs e)
        {
            if (_dataSourceTextBox.Text.Length == 0)
            {
                _errorProvider.SetError(_dataSourceTextBox, string.Empty);
                _errorProvider.SetError(_dataSourceTextBox, "Please select data file to migrate");
                return;
            }
            _dataMigrationHelper.SelectedAccessFile = _dataSourceTextBox.Text;
            _dataMigrationHelper.SelectedServer = _availableSQLServers.Text;
            _dataMigrationHelper.MigrateData(_createScript.Checked);
            Close();
        }

        /// <summary>
        /// Event handler to handle the cancel button click event.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Event arguments</param>
        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            Close();
            Environment.Exit(0);
        }

        /// <summary>
        /// Event handler to handle tick event of  timer.
        /// </summary>
        /// <param name="sender">Sender of event.</param>
        /// <param name="e">Event arguments.</param>
        private void OnTimerTick(object sender, EventArgs e)
        {
            Cursor cursor = Cursor;
            Cursor = Cursors.WaitCursor;
            _timer.Enabled = false;
            _availableSQLServers.DataSource = _dataMigrationHelper.GetSqlServers();
            Cursor = cursor;
        }

        /// <summary>
        /// Event handler to handle the visible changed event.
        /// </summary>
        /// <param name="sender">Sender of event.</param>
        /// <param name="e">Event arguments.</param>
        private void OnVisibleChangedEvent(object sender, EventArgs e)
        {
            if (Visible)
            {
                _timer.Enabled = true;
            }
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Displays message box with the given message.
        /// </summary>
        /// <param name="messageToShow">Message to show in on message box.</param>
        private void ShowMessage(string messageToShow)
        {
            MessageBox.Show(messageToShow, Strings.UroCare, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        #endregion
    }
}