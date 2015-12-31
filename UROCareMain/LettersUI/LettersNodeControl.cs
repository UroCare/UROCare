using System;
using System.Windows.Forms;
using SHC.UROCare.UIFramework;
using SHC.UROCare.Utilities;

namespace SHC.UROCare.UI
{
    public partial class LettersNodeControl : UserControl, INode
    {
        private readonly INodeFactory _parentNodeFactory;

        /// <summary>
        /// Default constructor to create instance of control.
        /// </summary>
        public LettersNodeControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Default constructor to create instance of control.
        /// </summary>
        /// <param name="parentNodeFactory">Parent node factory of the control.</param>
        public LettersNodeControl(INodeFactory parentNodeFactory) : this()
        {
            if (parentNodeFactory == null)
            {
                ExceptionManager.Throw(new ArgumentNullException("parentNodeFactory"));
            }
            _parentNodeFactory = parentNodeFactory;
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
            if (mainForm == null)
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
                return _parentNodeFactory;
            }
        }

        /// <summary>
        /// Gets title text for the control.
        /// </summary>
        public string TitleText
        {
            get
            {
                return Strings.Letters;
            }
        }

        #endregion
    }
}