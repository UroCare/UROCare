using System.Drawing;
using System.Windows.Forms;

namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    ///   Rectangle tool
    /// </summary>
    internal class ToolRectangle : ToolObject
    {
        public ToolRectangle()
        {
            Cursor = new Cursor(GetType(), "Rectangle.cur");
        }

        /// <summary>
        ///   Left nous button is pressed
        /// </summary>
        /// <param name="drawArea"> </param>
        /// <param name="e"> </param>
        public override void OnMouseDown(TransparentCanvas drawArea, MouseEventArgs e)
        {
            AddNewObject(drawArea, new DrawRectangle(e.X, e.Y, 1, 1));
        }

        /// <summary>
        ///   Mouse is moved, left mouse button is pressed or none button is pressed
        /// </summary>
        /// <param name="drawArea"> </param>
        /// <param name="e"> </param>
        public override void OnMouseMove(TransparentCanvas drawArea, MouseEventArgs e)
        {
            drawArea.Cursor = Cursor;

            if (e.Button == MouseButtons.Left)
            {
                var point = new Point(e.X, e.Y);
                drawArea.GraphicsList[0].MoveHandleTo(point, 5);
                drawArea.Refresh();
            }
        }
    }
}