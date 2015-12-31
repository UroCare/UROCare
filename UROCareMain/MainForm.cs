using System;
using System.Windows.Forms;
using SHC.UROCare.UIFramework;
using SHC.UROCare.UI;

namespace SHC.UROCare.UI
{
    public partial class MainForm : Form, IMainWindow
    {
        /// <summary>
        ///   Constructor to create the instnace of the form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            UIFrameWorkClass.Instance.NodeChangedEvent += OnNodeChangedEvent;
            UIFrameWorkClass.Instance.NavigationEvent += OnNavigationEvent;
            UIFrameWorkClass.Instance.Navigate(HomeNodeFactory.Instance, new HomeNodeContext());
        }

        #region IMainWindow Members

        /// <summary>
        ///   Sets the current control to main window.
        /// </summary>
        /// <param name="userControl"> Current user control to be added to Main form. </param>
        public void SetCurrentControl(UserControl userControl)
        {
            bool alreadyAdded = false;
            foreach (object control in _parentContainerPanel.Controls)
            {
                if (control.Equals(userControl))
                {
                    userControl.BringToFront();
                    alreadyAdded = true;
                }
            }
            if (!alreadyAdded)
            {
                _parentContainerPanel.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
                userControl.BringToFront();
            }
            _parentContainerPanel.Refresh();
        }

        /// <summary>
        ///   Gets the menu bar of the main window.
        /// </summary>
        public Menu MenuBar
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Private methods

        /// <summary>
        ///   Event handler to handle the node changed event.
        /// </summary>
        private void OnNodeChangedEvent(object sender, NodeChangedEventArgs eventArgs)
        {
            INode node = eventArgs.Node;
            Text = string.Format("{0} - {1}", Strings.UroCareTitle, node.TitleText);
            node.PlugIn(this);
        }

        /// <summary>
        ///   Click event handler for back button.
        /// </summary>
        /// <param name="sender"> Sender of event. </param>
        /// <param name="e"> Event arguments </param>
        private void OnBackButtonClick(object sender, EventArgs e)
        {
            UIFrameWorkClass.Instance.NavigateBack();
        }

        /// <summary>
        ///   Click event handler for next button.
        /// </summary>
        /// <param name="sender"> Sender of event. </param>
        /// <param name="e"> Event arguments </param>
        private void OnNextButtonClick(object sender, EventArgs e)
        {
            UIFrameWorkClass.Instance.NavigateNext();
        }

        /// <summary>
        ///   Click event handler for home button.
        /// </summary>
        /// <param name="sender"> Sender of event. </param>
        /// <param name="e"> Event arguments. </param>
        private void OnHomeButtonClick(object sender, EventArgs e)
        {
            UIFrameWorkClass.Instance.Navigate(HomeNodeFactory.Instance, new HomeNodeContext());
        }

        /// <summary>
        ///   Click event handler for patient button.
        /// </summary>
        /// <param name="sender"> Sender of event. </param>
        /// <param name="e"> Event arguments. </param>
        private void OnPatientButtonClick(object sender, EventArgs e)
        {
            UIFrameWorkClass.Instance.Navigate(PatientNodeFactory.Instance, new PatientNodeContext());
        }

        /// <summary>
        ///   Click event handler for report button.
        /// </summary>
        /// <param name="sender"> Sender of event. </param>
        /// <param name="e"> Event arguments. </param>
        private void OnReportsButtonClick(object sender, EventArgs e)
        {
            UIFrameWorkClass.Instance.Navigate(ReportNodeFactory.Instance, new ReportNodeContext());
        }

        /// <summary>
        ///   Click event handler for letter button.
        /// </summary>
        /// <param name="sender"> Sender of event. </param>
        /// <param name="e"> Event arguments. </param>
        private void OnLettersButtonClick(object sender, EventArgs e)
        {
            UIFrameWorkClass.Instance.Navigate(LetterNodeFactory.Instance, new LettersNodeContext());
        }

        /// <summary>
        ///   Click event handler for setup button.
        /// </summary>
        /// <param name="sender"> Sender of event. </param>
        /// <param name="e"> Event arguments. </param>
        private void OnSetupButtonClick(object sender, EventArgs e)
        {
            UIFrameWorkClass.Instance.Navigate(SetupNodeFactory.Instance, new SetupNodeContext());
        }

        /// <summary>
        /// Event handler to handle click event of about menu.
        /// </summary>
        /// <param name="sender">Sender of event.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutButtonClick(object sender, EventArgs e)
        {
            var aboutUroCare = new AboutUroCare();
            aboutUroCare.ShowDialog(this);
        }

        /// <summary>
        /// Event handler to handle navigation event.
        /// </summary>
        /// <param name="sender">Sender of event.</param>
        /// <param name="eventargs">Event arguments</param>
        private void OnNavigationEvent(object sender, NavigationEventArgs eventargs)
        {
            NavigationPosition navigationPosition = eventargs.NavigationPosition;

            bool enabledState = navigationPosition != NavigationPosition.None;

            _backButton.Enabled = enabledState;
            _nextButton.Enabled = enabledState;

            if (navigationPosition == NavigationPosition.First)
            {
                _backButton.Enabled = false;
            }
            if (navigationPosition == NavigationPosition.Last)
            {
                _nextButton.Enabled = false;
            }
        }

        #endregion

       
    }
}