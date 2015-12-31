

using System;
using System.Windows.Forms;
using SHC.UROCare.UIFramework;
using SHC.UROCare.Utilities;

namespace SHC.UROCare.UI
{
    public partial class SetupNodeControl : UserControl, INode
    {
        #region Private fields

        private readonly SetupNodeFactory _setupNodeFactory;

        #endregion

        /// <summary>
        /// Constructor to create the instance of the control. 
        /// </summary>
        public SetupNodeControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor to create the instance of the control.
        /// </summary>
        /// <param name="setupNodeFactory">Parent node factory</param>
        public SetupNodeControl(SetupNodeFactory setupNodeFactory) : this()
        {
            _setupNodeFactory = setupNodeFactory;
        }

        #region Implementation of INode

        /// <summary>
        ///   Gets if the node can commit change.
        /// </summary>
        public bool CanCommit
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Gets if the ndoe can close.
        /// </summary>
        public bool CanClose
        {
            get
            {
                return true;
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
                return _setupNodeFactory;
            }
        }

        /// <summary>
        /// Gets title text for the control.
        /// </summary>
        public string TitleText
        {
            get
            {
                return Strings.SetupText;
            }
        }

        #endregion
    }
}