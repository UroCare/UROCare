using System.Collections.Generic;

namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    ///   Class is responsible for executing Undo - Redo operations
    /// </summary>
    internal class UndoManager
    {
        private readonly GraphicsList _graphicsList;

        private List<ICommand> _historyList;
        private int _nextUndo;

        #region Constructor

        public UndoManager(GraphicsList graphicsList)
        {
            _graphicsList = graphicsList;

            ClearHistory();
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        ///   Return true if Undo operation is available
        /// </summary>
        public bool CanUndo
        {
            get
            {
                // If the NextUndo pointer is -1, no commands to undo
                if (_nextUndo < 0 ||
                    _nextUndo > _historyList.Count - 1) // precaution
                {
                    return false;
                }

                return true;
            }
        }

        /// <summary>
        ///   Return true if Redo operation is available
        /// </summary>
        public bool CanRedo
        {
            get
            {
                // If the NextUndo pointer points to the last item, no commands to redo
                if (_nextUndo == _historyList.Count - 1)
                {
                    return false;
                }

                return true;
            }
        }

        #endregion Properties

        #region Public Functions

        /// <summary>
        ///   Clear History
        /// </summary>
        public void ClearHistory()
        {
            _historyList = new List<ICommand>();
            _nextUndo = -1;
        }

        /// <summary>
        ///   Add new command to history. Called by client after executing some action.
        /// </summary>
        /// <param name="command"> </param>
        public void AddCommandToHistory(ICommand command)
        {
            // Purge history list
            TrimHistoryList();

            // Add command and increment undo counter
            _historyList.Add(command);

            _nextUndo++;
        }

        /// <summary>
        ///   Undo
        /// </summary>
        public void Undo()
        {
            if (!CanUndo)
            {
                return;
            }

            // Get the ICommand object to be undone
            ICommand command = _historyList[_nextUndo];

            // Execute the ICommand object's undo method
            command.Undo(_graphicsList);

            // Move the pointer up one item
            _nextUndo--;
        }

        /// <summary>
        ///   Redo
        /// </summary>
        public void Redo()
        {
            if (!CanRedo)
            {
                return;
            }

            // Get the ICommand object to redo
            int itemToRedo = _nextUndo + 1;
            ICommand command = _historyList[itemToRedo];

            // Execute the ICommand object
            command.Redo(_graphicsList);

            // Move the undo pointer down one item
            _nextUndo++;
        }

        #endregion Public Functions

        #region Private Functions

        private void TrimHistoryList()
        {
            // We can redo any undone command until we execute a new 
            // command. The new command takes us off in a new direction,
            // which means we can no longer redo previously undone actions. 
            // So, we purge all undone commands from the history list.*/

            // Exit if no items in History list
            if (_historyList.Count == 0)
            {
                return;
            }

            // Exit if NextUndo points to last item on the list
            if (_nextUndo == _historyList.Count - 1)
            {
                return;
            }

            // Purge all items below the NextUndo pointer
            for (int i = _historyList.Count - 1; i > _nextUndo; i--)
            {
                _historyList.RemoveAt(i);
            }
        }

        #endregion
    }
}