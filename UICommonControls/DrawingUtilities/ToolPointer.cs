using System.Drawing;
using System.Windows.Forms;

namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    ///   Pointer tool
    /// </summary>
    internal class ToolPointer : Tool
    {
        // Object which is currently resized:
        private CommandChangeState _commandChangeState;
        private Point _lastPoint = new Point(0, 0);
        private DrawObject _resizedObject;
        private int _resizedObjectHandle;
        private SelectionMode _selectMode = SelectionMode.None;

        // Keep state about last and current point (used to move and resize objects)
        private Point _startPoint = new Point(0, 0);

        private bool _wasMove;

        public ToolPointer()
        {
        }

        /// <summary>
        ///   Left mouse button is pressed
        /// </summary>
        /// <param name="drawArea"> </param>
        /// <param name="e"> </param>
        public override void OnMouseDown(TransparentCanvas drawArea, MouseEventArgs e)
        {
            _commandChangeState = null;
            _wasMove = false;

            _selectMode = SelectionMode.None;
            Point point = new Point(e.X, e.Y);

            // Test for resizing (only if control is selected, cursor is on the handle)
            foreach (DrawObject o in drawArea.GraphicsList.Selection)
            {
                int handleNumber = o.HitTest(point);

                if (handleNumber > 0)
                {
                    _selectMode = SelectionMode.Size;

                    // keep resized object in class member
                    _resizedObject = o;
                    _resizedObjectHandle = handleNumber;

                    // Since we want to resize only one object, unselect all other objects
                    drawArea.GraphicsList.UnselectAll();
                    o.Selected = true;

                    _commandChangeState = new CommandChangeState(drawArea.GraphicsList);

                    break;
                }
            }

            // Test for move (cursor is on the object)
            if (_selectMode == SelectionMode.None)
            {
                int n1 = drawArea.GraphicsList.Count;
                DrawObject o = null;

                for (int i = 0; i < n1; i++)
                {
                    if (drawArea.GraphicsList[i].HitTest(point) == 0)
                    {
                        o = drawArea.GraphicsList[i];
                        break;
                    }
                }

                if (o != null)
                {
                    _selectMode = SelectionMode.Move;

                    // Unselect all if Ctrl is not pressed and clicked object is not selected yet
                    if ((Control.ModifierKeys & Keys.Control) == 0 && !o.Selected)
                    {
                        drawArea.GraphicsList.UnselectAll();
                    }

                    // Select clicked object
                    o.Selected = true;

                    _commandChangeState = new CommandChangeState(drawArea.GraphicsList);

                    drawArea.Cursor = Cursors.SizeAll;
                }
            }

            // Net selection
            if (_selectMode == SelectionMode.None)
            {
                // click on background
                if ((Control.ModifierKeys & Keys.Control) == 0)
                {
                    drawArea.GraphicsList.UnselectAll();
                }

                _selectMode = SelectionMode.NetSelection;
            }

            _lastPoint.X = e.X;
            _lastPoint.Y = e.Y;
            _startPoint.X = e.X;
            _startPoint.Y = e.Y;

            drawArea.Capture = true;

            drawArea.Refresh();

            if (_selectMode == SelectionMode.NetSelection)
            {
                // Draw selection rectangle in initial position
                ControlPaint.DrawReversibleFrame(
                    drawArea.RectangleToScreen(DrawRectangle.GetNormalizedRectangle(_startPoint, _lastPoint)),
                    Color.Black,
                    FrameStyle.Dashed);
            }
        }

        /// <summary>
        ///   Mouse is moved. None button is pressed, or left button is pressed.
        /// </summary>
        /// <param name="drawArea"> </param>
        /// <param name="e"> </param>
        public override void OnMouseMove(TransparentCanvas drawArea, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            Point oldPoint = _lastPoint;

            _wasMove = true;

            // set cursor when mouse button is not pressed
            if (e.Button == MouseButtons.None)
            {
                Cursor cursor = null;

                for (int i = 0; i < drawArea.GraphicsList.Count; i++)
                {
                    int n = drawArea.GraphicsList[i].HitTest(point);

                    if (n > 0)
                    {
                        cursor = drawArea.GraphicsList[i].GetHandleCursor(n);
                        break;
                    }
                }

                if (cursor == null)
                {
                    cursor = Cursors.Default;
                }

                drawArea.Cursor = cursor;

                return;
            }

            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            // Find difference between previous and current position
            int dx = e.X - _lastPoint.X;
            int dy = e.Y - _lastPoint.Y;

            _lastPoint.X = e.X;
            _lastPoint.Y = e.Y;

            // resize
            if (_selectMode == SelectionMode.Size)
            {
                if (_resizedObject != null)
                {
                    _resizedObject.MoveHandleTo(point, _resizedObjectHandle);
                    drawArea.SetDirty();
                    drawArea.Refresh();
                }
            }

            // move
            if (_selectMode == SelectionMode.Move)
            {
                foreach (DrawObject o in drawArea.GraphicsList.Selection)
                {
                    o.Move(dx, dy);
                }

                drawArea.Cursor = Cursors.SizeAll;
                drawArea.SetDirty();
                drawArea.Refresh();
            }

            if (_selectMode == SelectionMode.NetSelection)
            {
                // Remove old selection rectangle
                ControlPaint.DrawReversibleFrame(
                    drawArea.RectangleToScreen(DrawRectangle.GetNormalizedRectangle(_startPoint, oldPoint)),
                    Color.Black,
                    FrameStyle.Dashed);

                // Draw new selection rectangle
                ControlPaint.DrawReversibleFrame(
                    drawArea.RectangleToScreen(DrawRectangle.GetNormalizedRectangle(_startPoint, point)),
                    Color.Black,
                    FrameStyle.Dashed);
            }
        }

        /// <summary>
        ///   Right mouse button is released
        /// </summary>
        /// <param name="drawArea"> </param>
        /// <param name="e"> </param>
        public override void OnMouseUp(TransparentCanvas drawArea, MouseEventArgs e)
        {
            if (_selectMode == SelectionMode.NetSelection)
            {
                // Remove old selection rectangle
                ControlPaint.DrawReversibleFrame(
                    drawArea.RectangleToScreen(DrawRectangle.GetNormalizedRectangle(_startPoint, _lastPoint)),
                    Color.Black,
                    FrameStyle.Dashed);

                // Make group selection
                drawArea.GraphicsList.SelectInRectangle(
                    DrawRectangle.GetNormalizedRectangle(_startPoint, _lastPoint));

                _selectMode = SelectionMode.None;
            }

            if (_resizedObject != null)
            {
                // after resizing
                _resizedObject.Normalize();
                _resizedObject = null;
            }

            drawArea.Capture = false;
            drawArea.Refresh();

            if (_commandChangeState != null && _wasMove)
            {
                // Keep state after moving/resizing and add command to history
                _commandChangeState.NewState(drawArea.GraphicsList);
                drawArea.AddCommandToHistory(_commandChangeState);
                _commandChangeState = null;
            }
        }

        #region Nested type: SelectionMode

        private enum SelectionMode
        {
            None,
            NetSelection, // group selection is active
            Move, // object(s) are moves
            Size // object is resized
        }

        #endregion
    }
}