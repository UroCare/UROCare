using System;
using SHC.UROCare.UI;
using SHC.UROCare.Utilities;
using SHC.UROCare.UIFramework;

namespace SHC.UROCare.UI
{
    public class PatientNodeFactory : INodeFactory
    {
        #region Private fields

        private static PatientNodeFactory _instance;
        private static readonly object _padLock = new object();
        private PatientNodeControl _currentNode;

        #endregion

        #region Private constructor

        private PatientNodeFactory()
        {
        }

        #endregion

        #region Public properties

        /// <summary>
        ///   Instance property to return the instance of the class.
        /// </summary>
        public static INodeFactory Instance
        {
            get
            {
                lock (_padLock)
                {
                    if (null == _instance)
                    {
                        _instance = new PatientNodeFactory();
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        ///   Gets the current node of the factory.
        /// </summary>
        public INode CurrentNode
        {
            get
            {
                return _currentNode;
            }
        }

        #endregion

        #region Public methods

        #endregion

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
            return _currentNode ?? (_currentNode = new PatientNodeControl(this));
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
    }
}