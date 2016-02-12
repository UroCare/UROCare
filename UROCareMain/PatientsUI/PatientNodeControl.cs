using System;
using System.Windows.Forms;
using SHC.UROCare.Utilities;
using SHC.UROCare.UIFramework;
using System.Collections.Generic;
using System.Linq;
using SHC.UROCare.UROCareBusinessObjects;

namespace SHC.UROCare.UI
{
    /// <summary>
    /// Node control to hold all the patient related controls.
    /// </summary>
    public partial class PatientNodeControl : UserControl, INode, IPatientNodeView
    {
        #region Private fields

        private readonly PatientNodePresenter _patientNodePresenter;
        private readonly INodeFactory _nodeFactory;
        private Dictionary<string, ChildControl> _childControls = new Dictionary<string, ChildControl>();
        private string _guNumber = "0000/0000";

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor to create the insance of the control.
        /// </summary>
        public PatientNodeControl()
        {
            _patientNodePresenter = new PatientNodePresenter(this);
            InitializeComponent();
            ProcessRecommendedColors();           
            InitializeControl();            
        }

        /// <summary>
        /// Constructor to create the instance of the control.
        /// </summary>
        /// <param name="nodeFactory">Node factory for the control.</param>
        public PatientNodeControl(INodeFactory nodeFactory) : this()
        {
            _nodeFactory = nodeFactory;
        }

        #endregion
        
        #region Protected overrides

        protected override void OnSystemColorsChanged(EventArgs e)
        {
            base.OnSystemColorsChanged(e);
            ProcessRecommendedColors();
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Processes the recommended colors for system.
        /// </summary>
        private void ProcessRecommendedColors()
        {
            RecommendedColors recommendedColors = UIFrameWorkClass.Instance.GetRecommendedColors();
            _masterContainerPanel.BackColor = recommendedColors.BackColor;
            _guNoSearch.Style.HeaderStyle.BackColor = recommendedColors.DarkColor;
            _guNoSearch.Style.ContainerStyle.BackColor = recommendedColors.BackColor;
            _patientsListPanel.Style.HeaderStyle.BackColor = recommendedColors.DarkColor;
            _patientsListPanel.Style.ContainerStyle.BackColor = recommendedColors.BackColor;
            _parentContainerPanel.BackColor = recommendedColors.BackColor;
        }

        /// <summary>
        /// Initializes control
        /// </summary>
        private void InitializeControl()
        {
            Cursor.Current = Cursors.WaitCursor;

            _patientNodePresenter.Initialize();
            FillPatientList();
            AddControlToParentContainerPanel("PatientInfo", () => new PatientInformationControl());

            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Adds control to parent container panel 
        /// </summary>
        /// <param name="controlToAdd"></param>
        private void AddControlToParentContainerPanel(string key, Func<ChildControl> methodToGetControl)
        {
            _parentContainerPanel.SuspendLayout();

            ChildControl controlToAdd = null;

            _childControls.TryGetValue(key, out controlToAdd);
            if (controlToAdd == null)
            {
                controlToAdd = methodToGetControl();
                _childControls.Add(key, controlToAdd);

                controlToAdd.PopulateControl(GetSelectedPatient());                
            }           
            if (_parentContainerPanel.Controls.Count > 0 && !(_parentContainerPanel.Controls[0] == controlToAdd))
            {
                _parentContainerPanel.Controls.RemoveAt(0);
            }
            if (_parentContainerPanel.Controls.Count == 0 )
            {
                controlToAdd.Dock = DockStyle.Fill;
                _parentContainerPanel.Controls.Add(controlToAdd);
            }
            _parentContainerPanel.ResumeLayout();
        }

        /// <summary>
        /// Fills the patient list.
        /// </summary>
        private void FillPatientList()
        {
            _patientsList.Items.Clear();
            PatientObjectCollection patientList = _patientNodePresenter.GetPatientList();
            foreach (var patient in patientList)
            {
                ListViewItem item = new ListViewItem(patient.GUId);
                item.ToolTipText = string.Format("{0} {1}Y {2}M\n{3}\n{4}", patient.Sex,patient.AgeYear,patient.AgeMonths, patient.AtPost, patient.Town);
                item.SubItems.Add(string.Format("{0} {1}", patient.Salutation, patient.PatientName));                
                item.Tag = patient;
                _patientsList.Items.Add(item);
            }
            
        }

        /// <summary>
        /// Loads patient information control
        /// </summary>
        private void LoadPatientInfoControl()
        {
            foreach (KeyValuePair<string, ChildControl> keyValuePair in _childControls)
            {
                keyValuePair.Value.PopulateControl(GetSelectedPatient());
            }
            AddControlToParentContainerPanel("PatientInfo", () => new PatientInformationControl());
        }

        /// <summary>
        /// Get selected patient object.
        /// </summary>
        /// <returns></returns>
        private PatientBO GetSelectedPatient()
        {
            PatientBO selectedPatient = new PatientBO();
            if(_patientsList.SelectedItems.Count != 0)
            {
                selectedPatient = _patientsList.SelectedItems[0].Tag as PatientBO;
            }

            return selectedPatient;
        }

        #endregion

        #region Events
        
        /// <summary>
        /// On Gu No Details button click event
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Event arguments</param>
        private void GUNoButttonClick(object sender, EventArgs e)
        {
            GUNumber = _guNumberSearch.Text;
            LoadPatientInfoControl();
        }

        /// <summary>
        /// Patient selection change
        /// </summary>
        /// <param name="sender">Patient List</param>
        /// <param name="e">Event argument</param>
        private void PatientSelectionChange(object sender, EventArgs e)
        {
            LoadPatientInfoControl();
        }

        /// <summary>
        /// On Gu No Details button click event
        /// </summary>
        /// <param name="sender">Tool Button</param>
        /// <param name="e">Event arguments</param>
        private void NewToolButtonClick(object sender, EventArgs e)
        {
            _patientsList.SelectedItems.Clear();
            _patientNodePresenter.Initialize();
            LoadPatientInfoControl();
        }

        /// <summary>
        /// On Gu No Details button click event
        /// </summary>
        /// <param name="sender">Tool Button</param>
        /// <param name="e">Event arguments</param>
        private void PatientInformationToolButtonClick(object sender, EventArgs e)
        {
            AddControlToParentContainerPanel("PatientInfo", () => new PatientInformationControl());
        }
                
        /// <summary>
        /// Patient examination tool button click event
        /// </summary>
        /// <param name="sender">Tool button</param>
        /// <param name="e">Event arguments</param>
        private void PatientExaminationToolButtonClick(object sender, EventArgs e)
        {
            AddControlToParentContainerPanel("Exam",()=> new PatientExaminationControl());
        }

        /// <summary>
        /// Urological History tool button click event
        /// </summary>
        /// <param name="sender">Tool button</param>
        /// <param name="e">Event arguments</param>
        private void UrologicalHistoryToolButtonClick(object sender, EventArgs e)
        {
            AddControlToParentContainerPanel("History",()=> new UrologyHistoryControl());
        }

        /// <summary>
        /// ESWL tool button click event
        /// </summary>
        /// <param name="sender">Tool button</param>
        /// <param name="e">Event arguments</param>
        private void ESWLToolButtonClick(object sender, EventArgs e)
        {
            AddControlToParentContainerPanel("ESWL", ()=>new ESWLControl());
        }

        /// <summary>
        /// UDS tool button click event
        /// </summary>
        /// <param name="sender">Tool button</param>
        /// <param name="e">Event arguments</param>
        private void UDSToolButtonClick(object sender, EventArgs e)
        {
            AddControlToParentContainerPanel("UDS", () => new UDSControl());
        }

        /// <summary>
        /// Investigation tool button click event
        /// </summary>
        /// <param name="sender">Tool button</param>
        /// <param name="e">Event arguments</param>
        private void InvestigationToolButtonClick(object sender, EventArgs e)
        {
            AddControlToParentContainerPanel("Investigation", () => new InvestigationControl());
        }

        /// <summary>
        /// Treatment tool button click event
        /// </summary>
        /// <param name="sender">Tool button</param>
        /// <param name="e">Event arguments</param>
        private void TreatmentToolButtonClick(object sender, EventArgs e)
        {
            AddControlToParentContainerPanel("Treatment",() => new TreatmentControl());
        }

        /// <summary>
        /// Operation tool button click event
        /// </summary>
        /// <param name="sender">Tool button</param>
        /// <param name="e">Event arguments</param>
        private void OperationToolButtonClick(object sender, EventArgs e)
        {
            AddControlToParentContainerPanel("Operation", () => new OperationControl());
        }

        /// <summary>
        /// Operation tool button click event
        /// </summary>
        /// <param name="sender">Tool button</param>
        /// <param name="e">Event arguments</param>
        private void FollowupToolButtonClick(object sender, EventArgs e)
        {
            AddControlToParentContainerPanel("Follow", () => new FollowupControl());
        }

        /// <summary>
        /// XRay/Image tool button click event
        /// </summary>
        /// <param name="sender">Tool button</param>
        /// <param name="e">Event arguments</param>
        private void XRayImageToolButtonClick(object sender, EventArgs e)
        {
            AddControlToParentContainerPanel("XRay", () => new XRayControl());
        }

        /// <summary>
        /// IPD tool button click event
        /// </summary>
        /// <param name="sender">Tool button</param>
        /// <param name="e">Event arguments</param>
        private void IPDToolButtonClick(object sender, EventArgs e)
        {
            AddControlToParentContainerPanel("IPD", () => new IPDControl());
        }

        /// <summary>
        /// Andrology tool button click event
        /// </summary>
        /// <param name="sender">Tool button</param>
        /// <param name="e">Event arguments</param>
        private void AndrologyToolButtonClick(object sender, EventArgs e)
        {
            AddControlToParentContainerPanel("Andrology", () => new AndrologyControl());
        }

        /// <summary>
        /// Andrology tool button click event
        /// </summary>
        /// <param name="sender">Tool button</param>
        /// <param name="e">Event arguments</param>
        private void PrescriptionToolButtonClick(object sender, EventArgs e)
        {
            AddControlToParentContainerPanel("Prescription", () => new PrescriptionControl());
        }

        /// <summary>
        /// List button click event
        /// </summary>
        /// <param name="sender">List Button</param>
        /// <param name="e">Event arguments</param>
        private void ListButtonClicked(object sender, EventArgs e)
        {
            FillPatientList();
            NewToolButtonClick(sender, e);
        }

        #endregion     

        #region Implementation of INode

        /// <summary>
        ///   Gets if the node can commit change.
        /// </summary>
        public bool CanCommit
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets if the ndoe can close.
        /// </summary>
        public bool CanClose
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        ///   Plugs in the current node to the main window.
        /// </summary>
        /// <param name="mainForm"> Main window on which the node will be plugged in. </param>
        public void PlugIn(IMainWindow mainForm)
        {
            if (null == mainForm)
            {
                ExceptionManager.Throw(new ArgumentNullException());
            }
            mainForm.SetCurrentControl(this);
        }

        /// <summary>
        /// Gets the node factory of the node.
        /// </summary>
        public INodeFactory NodeFactory
        {
            get
            {
                return _nodeFactory;
            }
        }

        /// <summary>
        /// Gets or sets title text of control
        /// </summary>
        public string TitleText
        {
            get
            {
                return Strings.PatientDetails;
            }
        }

        #endregion      

        #region Public Properties

        /// <summary>
        /// Get month calendar value
        /// </summary>
        public DateTime MonthCalendar
        {
            get
            {
                return _monthCalendar.Value;
            }
        }

        /// <summary>
        /// Get GU Number from search text box;
        /// </summary>
        public string GUNumberSearch
        {
            get
            {
                return _guNumberSearch.Text;
            }
            set
            {
                _guNumberSearch.Text = value;
            }
        }

        /// <summary>
        /// Get GU Number from search text box;
        /// </summary>
        public string GUNumber
        {
            get
            {
                return _guNumber;
            }
            set
            {
                _guNumber = value;
            }
        }
        #endregion       
    }
}