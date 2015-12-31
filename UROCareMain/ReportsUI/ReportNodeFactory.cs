using System;
using SHC.UROCare.UIFramework;

namespace SHC.UROCare.UI
{
    public class ReportNodeFactory : INodeFactory
    {
        #region Private fields

        private static readonly object _padLock = new object();
        private static ReportNodeFactory _instance;
        private INode _currentNode;

        #endregion

        /// <summary>
        ///   Instance of the current node factory.
        /// </summary>
        public static INodeFactory Instance
        {
            get
            {
                lock (_padLock)
                {
                    if (null == _instance)
                    {
                        _instance = new ReportNodeFactory();
                    }
                }
                return _instance;
            }
        }

        #region Implementation of INodeFactory

        /// <summary>
        ///   Gets the current node of the factory.
        /// </summary>
        public INode CurrentNode
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public INode CreateNode()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Implementation of INodeFactory

        /// <summary>
        /// Creates the node.
        /// </summary>
        /// <returns>Instance of INode</returns>
        public INode CreateNode(INodeContext nodeContext)
        {
            return _currentNode ?? (_currentNode = new ReportNodeControl());
        }

        /// <summary>
        /// Gets the node type of the node.
        /// </summary>
        /// <returns>Type of the node.</returns>
        public Type GetNodeType()
        {
            return typeof (ReportNodeControl);
        }

        #endregion
    }
}