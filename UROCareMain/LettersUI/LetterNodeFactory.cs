using System;
using SHC.UROCare.UIFramework;

namespace SHC.UROCare.UI
{
    public class LetterNodeFactory : INodeFactory
    {
        #region Private fields

        private static LetterNodeFactory _instance;
        private static readonly object _padLock = new object();
        private INode _currentNode;

        #endregion

        #region Private constructor.

        /// <summary>
        ///   Private constructor to avoid the direct instance creation of the class.
        /// </summary>
        private LetterNodeFactory()
        {
        }

        #endregion

        #region Public properties

        /// <summary>
        ///   Gets the instnace of the class.
        /// </summary>
        public static INodeFactory Instance
        {
            get
            {
                if (null == _instance)
                {
                    lock (_padLock)
                    {
                        _instance = new LetterNodeFactory();
                    }
                }
                return _instance;
            }
        }

        #endregion

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
            return _currentNode ?? (_currentNode = new LettersNodeControl());
        }

        /// <summary>
        /// Gets the node type of the node.
        /// </summary>
        /// <returns>Type of the node.</returns>
        public Type GetNodeType()
        {
            return typeof (LettersNodeControl);
        }

        #endregion
    }
}