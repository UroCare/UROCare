namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    ///   Base class for commands used for Undo - Redo
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// This function is used to make Undo operation.
        /// It makes action opposite to the original command.
        /// </summary>
        /// <param name="list">Graphics list</param>
        void Undo(GraphicsList list);

        /// <summary>
        /// This command is used to make Redo operation.
        /// It makes original command again.
        /// </summary>
        /// <param name="list">Graphics list</param>
        void Redo(GraphicsList list);

        // Derived classes have members which contain enough information
        // to make Undo and Redo operations for every specific command.
    }
}