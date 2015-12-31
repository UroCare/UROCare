using System.Collections.Generic;
using System.Linq;

namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    ///   Changing state of existing objects: move, resize, change properties.
    /// </summary>
    internal class CommandChangeState : ICommand
    {
        // Selected object(s) before operation
        private readonly List<DrawObject> _listBefore;

        // Selected object(s) after operation
        private List<DrawObject> _listAfter;

        // Create this command BEFORE operation.
        public CommandChangeState(GraphicsList graphicsList)
        {
            // Keep objects state before operation.
            FillList(graphicsList, ref _listBefore);
        }

        // Call this function AFTER operation.

        #region ICommand Members

        /// <summary>
        /// This function is used to make Undo operation.
        /// It makes action opposite to the original command.
        /// </summary>
        /// <param name="list">Graphics list</param>
        public void Undo(GraphicsList list)
        {
            // Replace all objects in the list with objects from listBefore
            ReplaceObjects(list, _listBefore);
        }

        /// <summary>
        /// This command is used to make Redo operation.
        /// It makes original command again.
        /// </summary>
        /// <param name="list">Graphics list</param>
        public void Redo(GraphicsList list)
        {
            // Replace all objects in the list with objects from listAfter
            ReplaceObjects(list, _listAfter);
        }

        #endregion

        public void NewState(GraphicsList graphicsList)
        {
            // Keep objects state after operation.
            FillList(graphicsList, ref _listAfter);
        }

        // Replace objects in graphicsList with objects from list
        private void ReplaceObjects(GraphicsList graphicsList, List<DrawObject> list)
        {
            for (int i = 0; i < graphicsList.Count; i++)
            {
                DrawObject replacement = list.FirstOrDefault(o => o.ID == graphicsList[i].ID);

                if (replacement != null)
                {
                    graphicsList.Replace(i, replacement);
                }
            }
        }

        // Fill list from selection
        private void FillList(GraphicsList graphicsList, ref List<DrawObject> listToFill)
        {
            listToFill = graphicsList.Selection.Select(o => o.Clone()).ToList();
        }
    }
}