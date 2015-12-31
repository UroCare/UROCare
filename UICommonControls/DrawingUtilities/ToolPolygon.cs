using System.Drawing;
using System.Windows.Forms;

namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    ///   Polygon tool
    /// </summary>
    internal class ToolPolygon : ToolObject
    {
        private const int _minDistance = 15*15;
        private int _lastX;
        private int _lastY;
        private DrawPolygon _newPolygon;

        public ToolPolygon()
        {
            Cursor = new Cursor(GetType(), "Pencil.cur");
        }

        /// <summary>
        ///   Left nouse button is pressed
        /// </summary>
        /// <param name="drawArea"> </param>
        /// <param name="e"> </param>
        public override void OnMouseDown(TransparentCanvas drawArea, MouseEventArgs e)
        {
            // Create new polygon, add it to the list
            // and keep reference to it
            _newPolygon = new DrawPolygon(e.X, e.Y, e.X + 1, e.Y + 1);
            AddNewObject(drawArea, _newPolygon);
            _lastX = e.X;
            _lastY = e.Y;
        }

        /// <summary>
        ///   Mouse move - resize new polygon
        /// </summary>
        /// <param name="drawArea"> </param>
        /// <param name="e"> </param>
        public override void OnMouseMove(TransparentCanvas drawArea, MouseEventArgs e)
        {
            drawArea.Cursor = Cursor;

            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            if (_newPolygon == null)
            {
                return; // precaution
            }

            Point point = new Point(e.X, e.Y);
            int distance = (e.X - _lastX)*(e.X - _lastX) + (e.Y - _lastY)*(e.Y - _lastY);

            if (distance < _minDistance)
            {
                // Distance between last two points is less than minimum -
                // move last point
                _newPolygon.MoveHandleTo(point, _newPolygon.HandleCount);
            }
            else
            {
                // Add new point
                _newPolygon.AddPoint(point);
                _lastX = e.X;
                _lastY = e.Y;
            }

            drawArea.Refresh();
        }

        public override void OnMouseUp(TransparentCanvas drawArea, MouseEventArgs e)
        {
            _newPolygon = null;

            base.OnMouseUp(drawArea, e);
        }
    }
}