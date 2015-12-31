namespace SHC.UROCare.UIFramework
{
    /// <summary>
    ///   Represents the context of current node. Can be used to maintain the state of nodes and message passing.
    /// </summary>
    public interface INodeContext
    {
        INode CurrentNode { get; }
    }
}