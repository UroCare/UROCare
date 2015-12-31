namespace SHC.UROCare.UIFramework
{
    public interface INode
    {
        /// <summary>
        ///   Gets if the node can commit change.
        /// </summary>
        bool CanCommit { get; }

        /// <summary>
        /// Gets if the ndoe can close.
        /// </summary>
        bool CanClose { get; }

        /// <summary>
        /// Gets the node factory of the node.
        /// </summary>
        INodeFactory NodeFactory { get; }

        /// <summary>
        /// Gets title text for the control.
        /// </summary>
        string TitleText { get; }

        /// <summary>
        ///   Plugs in the current node to the main window.
        /// </summary>
        /// <param name="mainForm"> Main window on which the node will be plugged in. </param>
        void PlugIn(IMainWindow mainForm);
    }
}