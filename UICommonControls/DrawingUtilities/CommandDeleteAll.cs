// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System.Collections.Generic;

namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    ///   Delete All command
    /// </summary>
    internal class CommandDeleteAll : ICommand
    {
        private readonly List<DrawObject> _cloneList;

        // Create this command BEFORE applying Delete All function.
        public CommandDeleteAll(GraphicsList graphicsList)
        {
            _cloneList = new List<DrawObject>();

            // Make clone of the whole list.
            // Add objects in reverse order because GraphicsList.Add
            // insert every object to the beginning.
            int n = graphicsList.Count;

            for (int i = n - 1; i >= 0; i--)
            {
                _cloneList.Add(graphicsList[i].Clone());
            }
        }

        #region ICommand Members

        /// <summary>
        /// This function is used to make Undo operation.
        /// It makes action opposite to the original command.
        /// </summary>
        /// <param name="list">Graphics list</param>
        public void Undo(GraphicsList list)
        {
            // Add all objects from clone list to list -
            // opposite to DeleteAll
            foreach (DrawObject o in _cloneList)
            {
                list.Add(o);
            }
        }

        /// <summary>
        /// This command is used to make Redo operation.
        /// It makes original command again.
        /// </summary>
        /// <param name="list">Graphics list</param>
        public void Redo(GraphicsList list)
        {
            // Clear list - make DeleteAll again
            list.Clear();
        }

        #endregion
    }
}