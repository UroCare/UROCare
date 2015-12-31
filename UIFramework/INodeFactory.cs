using System;

namespace SHC.UROCare.UIFramework
{
    public interface INodeFactory
    {
        /// <summary>
        /// Creates the node.
        /// </summary>
        /// <returns>Instance of INode</returns>
        INode CreateNode(INodeContext nodeContext);

        /// <summary>
        /// Gets the node type of the node.
        /// </summary>
        /// <returns>Type of the node.</returns>
        Type GetNodeType();
    }

    public enum NodeType
    {
        Patient,
        Reports,
        Letters
    }
}