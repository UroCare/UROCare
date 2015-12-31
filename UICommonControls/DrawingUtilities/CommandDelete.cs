// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System.Collections.Generic;
using System.Linq;

namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    ///   Delete command
    /// </summary>
    internal class CommandDelete : ICommand
    {
        private readonly List<DrawObject> _cloneList; // contains selected items which are deleted

        // Create this command BEFORE applying Delete All function.
        public CommandDelete(GraphicsList graphicsList)
        {
            _cloneList = new List<DrawObject>();

            // Make clone of the list selection.

            foreach (DrawObject o in graphicsList.Selection)
            {
                _cloneList.Add(o.Clone());
            }
        }

        #region ICommand Members

        public void Undo(GraphicsList list)
        {
            list.UnselectAll();

            // Add all objects from cloneList to list.
            foreach (DrawObject o in _cloneList)
            {
                list.Add(o);
            }
        }

        public void Redo(GraphicsList list)
        {
            // Delete from list all objects kept in cloneList

            int n = list.Count;

            for (int i = n - 1; i >= 0; i--)
            {
                DrawObject objectToDelete = list[i];

                bool toDelete = _cloneList.Any(o => objectToDelete.ID == o.ID);

                if (toDelete)
                {
                    list.RemoveAt(i);
                }
            }
        }

        #endregion
    }
}