using System;
using SHC.UROCare.UIFramework;
using SHC.UROCare.Utilities;

namespace SHC.UROCare.UI
{
    public class HomeNodeFactory : INodeFactory
    {
        #region Private fields

        private static HomeNodeFactory _instance;
        private static readonly object _padLock = new object();
        private HomeNodeControl _currentNode;

        #endregion

        #region Implementation of INodeFactory

        /// <summary>
        ///   Gets the instance of the class.
        /// </summary>
        public static INodeFactory Instance
        {
            get
            {
                lock (_padLock)
                {
                    if (null == _instance)
                    {
                        _instance = new HomeNodeFactory();
                    }
                }
                return _instance;
            }
        }

        #region Implementation of INodeFactory

        /// <summary>
        /// Creates the node.
        /// </summary>
        /// <returns>Instance of INode</returns>
        public INode CreateNode(INodeContext nodeContext)
        {
            if (nodeContext == null)
            {
                ExceptionManager.Throw(new ArgumentNullException("nodeContext"));
            }
            return _currentNode ?? (_currentNode = new HomeNodeControl());
        }

        /// <summary>
        /// Gets the node type of the node.
        /// </summary>
        /// <returns>Type of the node.</returns>
        public Type GetNodeType()
        {
            return _currentNode.GetType();
        }

        #endregion

        #endregion
    }
}