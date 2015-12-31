using System;
using System.Drawing;
using System.Windows.Forms;
using SHC.UROCare.UIFramework;
using SHC.UROCare.UROCareBusinessObjects;
using SHC.UROCare.Utilities;

namespace SHC.UROCare.UI
{
    /// <summary>
    /// Node control for the all the Home's child control.
    /// </summary>
    public partial class HomeNodeControl : UserControl, INode
    {
        #region Private fields

        private readonly INodeFactory _nodeFactory;

        #endregion

        /// <summary>
        /// Constructor to create the instnace of the control.
        /// </summary>
        public HomeNodeControl()
        {
            InitializeComponent();
            ProcessRecommendedColors();
        }

        /// <summary>
        /// Constructor to create the instance of the node control.
        /// </summary>
        /// <param name="nodeFactory">Parent node factory</param>
        public HomeNodeControl(INodeFactory nodeFactory) : this()
        {
            _nodeFactory = nodeFactory;
        }

        #region Implementation of INode

        /// <summary>
        ///   Gets if the node can commit change.
        /// </summary>
        public bool CanCommit
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Gets if the ndoe can close.
        /// </summary>
        public bool CanClose
        {
            get
            {
                return false;
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
                ExceptionManager.Throw(new ArgumentNullException("mainForm"));
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
        /// Gets title text for the control.
        /// </summary>
        public string TitleText
        {
            get
            {
                return Strings.HomeText;
            }
        }

        #endregion

        #region Private methods

        private void ProcessRecommendedColors()
        {
            RecommendedColors colors = UIFrameWorkClass.Instance.GetRecommendedColors();
            BackColor = colors.BackColor;
            _masterPanel.BackColor = BackColor;
        }

        #endregion
    }
}