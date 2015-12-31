using System;
using SHC.UROCare.Utilities;

namespace SHC.UROCare.UIFramework
{
    /// <summary>
    /// Delegate for node changing event.
    /// </summary>
    /// <param name="sender">Sender of event.</param>
    /// <param name="eventArgs">Event arguments</param>
    public delegate void NodeChangingEventHandler(object sender, NodeChangingEventArgs eventArgs);

    /// <summary>
    /// Delegate for node changed event.
    /// </summary>
    /// <param name="sender">Sender of the event.</param>
    /// <param name="eventArgs">Event arguments.</param>
    public delegate void NodeChangedEventHandler(object sender, NodeChangedEventArgs eventArgs);

    /// <summary>
    /// Delegate for Navigatioin event.
    /// </summary>
    /// <param name="sender">Sender of the event.</param>
    /// <param name="eventArgs">Event arguments</param>
    public delegate void NavigationEventHandler(object sender, NavigationEventArgs eventArgs);

    /// <summary>
    /// Event arguments class for node changing node.
    /// </summary>
    public class NodeChangingEventArgs : UIFrameworkNodeEventsArgs
    {
        public NodeChangingEventArgs(INode node)
            : base(node)
        {
        }
    }

    /// <summary>
    /// Event argument class to be used with node changed event.
    /// </summary>
    public class NodeChangedEventArgs : UIFrameworkNodeEventsArgs
    {
        /// <summary>
        /// Constructor to create the instance of the class.
        /// </summary>
        public NodeChangedEventArgs(INode node)
            : base(node)
        {
        }
    }

    /// <summary>
    /// Event arguments class for navigation e
    /// </summary>
    public class NavigationEventArgs : EventArgs
    {
        private readonly NavigationPosition _navigationPosition;

        /// <summary>
        /// Constructor to create instance of
        /// </summary>
        /// <param name="navigationPosition">Navigation position</param>
        public NavigationEventArgs(NavigationPosition navigationPosition)
        {
            _navigationPosition = navigationPosition;
        }

        /// <summary>
        /// Gets navigation position.
        /// </summary>
        public NavigationPosition NavigationPosition
        {
            get
            {
                return _navigationPosition;
            }
        }
    }

    /// <summary>
    /// Base class for the node changed and node changing event arguments.
    /// </summary>
    public class UIFrameworkNodeEventsArgs : EventArgs
    {
        #region Private fields

        private readonly INode _node;

        #endregion

        /// <summary>
        /// Constructor to create the instance of the class.
        /// </summary>
        public UIFrameworkNodeEventsArgs(INode node)
        {
            if (null == node)
            {
                ExceptionManager.Throw(new ArgumentNullException("node"));
            }
            _node = node;
        }

        /// <summary>
        /// Gets the node.
        /// </summary>
        public INode Node
        {
            get
            {
                return _node;
            }
        }
    }
}