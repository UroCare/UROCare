using System;
using System.Drawing;
using SHC.UROCare.Utilities;

namespace SHC.UROCare.UIFramework
{
    public class UIFrameWorkClass
    {
        #region Private fields

        private static UIFrameWorkClass _instance;
        private static readonly object _padLock = new object();
        private readonly NavigationManager _navigationManager;

        private INode _currentNode;

        #endregion

        #region Public events

        /// <summary>
        /// Event to be raised after node change.
        /// </summary>
        public event NodeChangedEventHandler NodeChangedEvent;

        /// <summary>
        /// Event to be raised before node change.
        /// </summary>
        public event NodeChangingEventHandler NodeChangingEvent;

        /// <summary>
        /// Event to be raise on navigation.
        /// </summary>
        public event NavigationEventHandler NavigationEvent;

        #endregion

        #region Private constructor

        /// <summary>
        ///   Private constructor to avoid creation of instance.
        /// </summary>
        private UIFrameWorkClass()
        {
            _navigationManager = new NavigationManager();
        }

        #endregion

        #region Public properties

        /// <summary>
        ///   Gets the instance of the class.
        /// </summary>
        public static UIFrameWorkClass Instance
        {
            get
            {
                if (null == _instance)
                {
                    lock (_padLock)
                    {
                        _instance = new UIFrameWorkClass();
                    }
                }
                return _instance;
            }
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Navigates to current node.
        /// </summary>
        /// <param name="currentNode">Node to be navigated on</param>
        private void NavigateToNode(INode currentNode)
        {
            if (!ReferenceEquals(_currentNode, currentNode))
            {
                RaiseNodeChangingEvent(currentNode);
                _navigationManager.Add(currentNode);
                RaiseNodeChangedEvent(currentNode);
            }
            RaiseNavigationEvent();
        }

        /// <summary>
        /// Raise node changed event.
        /// </summary>
        /// <param name="node">New node to be changed.</param>
        private void RaiseNodeChangedEvent(INode node)
        {
            if (null != NodeChangedEvent)
            {
                NodeChangedEvent(this, new NodeChangedEventArgs(node));
            }
        }

        /// <summary>
        /// Raises node changing event.
        /// </summary>
        /// <param name="node">New node.</param>
        private void RaiseNodeChangingEvent(INode node)
        {
            if (null != NodeChangingEvent)
            {
                NodeChangingEvent(this, new NodeChangingEventArgs(node));
            }
        }

        /// <summary>
        /// Raises navigation event.
        /// </summary>
        private void RaiseNavigationEvent()
        {
            if (null != NavigationEvent)
            {
                NavigationEvent(this, new NavigationEventArgs(_navigationManager.NavigationPosition));
            }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Navigates to the given node.
        /// </summary>
        /// <param name="nodeFactory">Node factory class to create the node for the</param>
        /// <param name="nodeContext"></param>
        public void Navigate(INodeFactory nodeFactory, INodeContext nodeContext)
        {
            if (nodeFactory == null)
            {
                ExceptionManager.Throw(new ArgumentNullException("nodeFactory"));
            }
            if (nodeContext == null)
            {
                ExceptionManager.Throw(new ArgumentNullException("nodeContext"));
            }

            _currentNode = _navigationManager.GetCurrentNode();

            INode currentNode = nodeFactory.CreateNode(nodeContext);

            NavigateToNode(currentNode);
        }

        /// <summary>
        /// Navigates UI to next node.
        /// </summary>
        public void NavigateNext()
        {
            _navigationManager.NavigateNext();
            INode node = _navigationManager.GetCurrentNode();
            if (null != node && !ReferenceEquals(_currentNode, node))
            {
                RaiseNodeChangingEvent(node);
                _currentNode = node;
                RaiseNodeChangedEvent(node);
            }
            RaiseNavigationEvent();
        }

        /// <summary>
        /// Navigates UI to previous node.
        /// </summary>
        public void NavigateBack()
        {
            _navigationManager.NavigateBack();
            INode node = _navigationManager.GetCurrentNode();
            if (null != node && !ReferenceEquals(_currentNode, node))
            {
                RaiseNodeChangingEvent(node);
                _currentNode = node;
                RaiseNodeChangedEvent(node);
            }
            RaiseNavigationEvent();
        }

        public RecommendedColors GetRecommendedColors()
        {
            var recommendedColors = new RecommendedColors {BackColor = SystemColors.Window, LightColor = SystemColors.ControlLight, DarkColor=SystemColors.ControlDark, BorderColor = SystemColors.ActiveBorder};
            return recommendedColors;
        }

        #endregion
    }

    public class RecommendedColors
    {
        public Color BackColor { get; set; }
        public Color BorderColor { get; set; }
        public Color LightColor { get; set; }
        public Color DarkColor { get; set; }
    }
}