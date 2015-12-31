using System;
using SHC.UROCare.UIFramework;

namespace SHC.UROCare.UI
{
    public class SetupNodeFactory : INodeFactory
    {
        #region Private fields

        private static SetupNodeFactory _instance;
        private static readonly object _padLock = new object();
        private INode _currentNode;

        #endregion

        #region Private constructor

        /// <summary>
        /// Private constructor avoid direct instance creation.
        /// </summary>
        private SetupNodeFactory()
        {
        }

        #endregion

        #region Implementation of INodeFactory

        /// <summary>
        /// Gets the instance of the node factory class.
        /// </summary>
        public static INodeFactory Instance
        {
            get
            {
                lock (_padLock)
                {
                    if (null == _instance)
                    {
                        _instance = new SetupNodeFactory();
                    }
                }
                return _instance;
            }
        }

        #endregion

        #region Implementation of INodeFactory

        /// <summary>
        /// Creates the node.
        /// </summary>
        /// <returns>Instance of INode</returns>
        public INode CreateNode(INodeContext nodeContext)
        {
            return _currentNode ?? (_currentNode = new SetupNodeControl());
        }

        /// <summary>
        /// Gets the node type of the node.
        /// </summary>
        /// <returns>Type of the node.</returns>
        public Type GetNodeType()
        {
            return typeof (SetupNodeControl);
        }

        #endregion
    }
}