namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    ///   Add new object command
    /// </summary>
    internal class CommandAdd : ICommand
    {
        private readonly DrawObject _drawObject;

        // Create this command with DrawObject instance added to the list
        public CommandAdd(DrawObject drawObject)
        {
            // Keep copy of added object
            _drawObject = drawObject.Clone();
        }

        #region ICommand Members

        /// <summary>
        /// This function is used to make Undo operation.
        /// It makes action opposite to the original command.
        /// </summary>
        /// <param name="list">Graphics list</param>
        public void Undo(GraphicsList list)
        {
            list.DeleteLastAddedObject();
        }

        /// <summary>
        /// This command is used to make Redo operation.
        /// It makes original command again.
        /// </summary>
        /// <param name="list">Graphics list</param>
        public void Redo(GraphicsList list)
        {
            list.UnselectAll();
            list.Add(_drawObject);
        }

        #endregion
    }
}