using System;
using System.Collections.Generic;
using SHC.UROCare.Utilities;

namespace SHC.UROCare.UIFramework
{
    /// <summary>
    /// Class to manage the navigation between nodes.
    /// </summary>
    internal class NavigationManager
    {
        #region Private fields

        private readonly List<INode> _nodes = new List<INode>();
        private int _nodeIndex = -1;

        #endregion

        #region Private methods

        /// <summary>
        /// Increases index to get the next node.
        /// </summary>
        private void IncreaseIndex()
        {
            if (_nodeIndex < _nodes.Count - 1)
            {
                _nodeIndex++;
            }
        }

        /// <summary>
        /// Decreases index to get the previous node
        /// </summary>
        private void DecreaseIndex()
        {
            if (_nodeIndex > 0)
            {
                _nodeIndex--;
            }
        }

        /// <summary>
        /// Gets current navigation poistion.
        /// </summary>
        /// <returns>Navigation position</returns>
        private NavigationPosition GetNavigationPosition()
        {
            NavigationPosition position = NavigationPosition.None;
            if (_nodes.Count > 1)
            {
                if (_nodeIndex == 0)
                {
                    position = NavigationPosition.First;
                }
                else if (_nodeIndex == _nodes.Count - 1)
                {
                    position = NavigationPosition.Last;
                }
                else
                {
                    position = NavigationPosition.Middle;
                }
            }
            return position;
        }

        #endregion

        #region Internal methods

        internal void NavigateNext()
        {
            IncreaseIndex();
        }

        internal void NavigateBack()
        {
            DecreaseIndex();
        }

        /// <summary>
        /// Get current node
        /// </summary>
        /// <returns>Node from the list</returns>
        internal INode GetCurrentNode()
        {
            INode node = null;
            if (_nodeIndex >= 0 && _nodeIndex < _nodes.Count)
            {
                node = _nodes[_nodeIndex];
            }
            return node;
        }

        #endregion

        #region Internal properties

        internal NavigationPosition NavigationPosition
        {
            get
            {
                return GetNavigationPosition();
            }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Adds the node to the nodes collection of Naviagtion manager.
        /// </summary>
        /// <param name="node">Node to be added.</param>
        public void Add(INode node)
        {
            if (node == null)
            {
                ExceptionManager.Throw(new ArgumentNullException("node"));
            }
            if (_nodes.Contains(node))
            {
                _nodeIndex = _nodes.IndexOf(node);
            }
            else
            {
                _nodes.Add(node);
                _nodeIndex = _nodes.Count - 1;
            }
        }

        #endregion
    }

    /// <summary>
    /// Enumerates the navigation position.
    /// </summary>
    public enum NavigationPosition
    {
        None,
        First,
        Last,
        Middle
    }
}