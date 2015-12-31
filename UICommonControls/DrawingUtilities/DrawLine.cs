// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    ///   Line graphic object
    /// </summary>
    internal class DrawLine : DrawObject
    {
        private const string _entryStart = "Start";
        private const string _entryEnd = "End";

        private Point _endPoint;
        private Point _startPoint;

        public DrawLine()
            : this(0, 0, 1, 0)
        {
        }

        public DrawLine(int x1, int y1, int x2, int y2)
        {
            _startPoint.X = x1;
            _startPoint.Y = y1;
            _endPoint.X = x2;
            _endPoint.Y = y2;

            Initialize();
        }

        public override int HandleCount
        {
            get
            {
                return 2;
            }
        }

        protected GraphicsPath AreaPath { get; set; }

        protected Pen AreaPen { get; set; }

        protected Region AreaRegion { get; set; }

        /// <summary>
        ///   Clone this instance
        /// </summary>
        public override DrawObject Clone()
        {
            var drawLine = new DrawLine {_startPoint = _startPoint, _endPoint = _endPoint};

            FillDrawObjectFields(drawLine);
            return drawLine;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var pen = new Pen(Color, PenWidth);

            graphics.DrawLine(pen, _startPoint.X, _startPoint.Y, _endPoint.X, _endPoint.Y);

            pen.Dispose();
        }

        /// <summary>
        ///   Get handle point by 1-based number
        /// </summary>
        /// <param name="handleNumber"> </param>
        /// <returns> </returns>
        public override Point GetHandle(int handleNumber)
        {
            if (handleNumber == 1)
            {
                return _startPoint;
            }
            return _endPoint;
        }

        /// <summary>
        ///   Hit test. Return value: -1 - no hit 0 - hit anywhere > 1 - handle number
        /// </summary>
        /// <param name="point"> </param>
        /// <returns> </returns>
        public override int HitTest(Point point)
        {
            if (Selected)
            {
                for (int i = 1; i <= HandleCount; i++)
                {
                    if (GetHandleRectangle(i).Contains(point))
                    {
                        return i;
                    }
                }
            }

            if (PointInObject(point))
            {
                return 0;
            }

            return -1;
        }

        /// <summary>
        ///   Test whether point is inside of the object
        /// </summary>
        /// <param name="point"> </param>
        /// <returns> </returns>
        protected override bool PointInObject(Point point)
        {
            CreateObjects();

            return AreaRegion.IsVisible(point);
        }

        /// <summary>
        ///   Test whether object intersects with rectangle
        /// </summary>
        /// <param name="rectangle"> </param>
        /// <returns> </returns>
        public override bool IntersectsWith(Rectangle rectangle)
        {
            CreateObjects();

            return AreaRegion.IsVisible(rectangle);
        }

        /// <summary>
        ///   Get cursor for the handle
        /// </summary>
        /// <param name="handleNumber"> </param>
        /// <returns> </returns>
        public override Cursor GetHandleCursor(int handleNumber)
        {
            switch (handleNumber)
            {
                case 1:
                case 2:
                    return Cursors.SizeAll;
                default:
                    return Cursors.Default;
            }
        }

        /// <summary>
        ///   Move handle to the point
        /// </summary>
        /// <param name="point"> </param>
        /// <param name="handleNumber"> </param>
        public override void MoveHandleTo(Point point, int handleNumber)
        {
            if (handleNumber == 1)
            {
                _startPoint = point;
            }
            else
            {
                _endPoint = point;
            }

            Invalidate();
        }

        /// <summary>
        ///   Move object
        /// </summary>
        /// <param name="deltaX"> </param>
        /// <param name="deltaY"> </param>
        public override void Move(int deltaX, int deltaY)
        {
            _startPoint.X += deltaX;
            _startPoint.Y += deltaY;

            _endPoint.X += deltaX;
            _endPoint.Y += deltaY;

            Invalidate();
        }

        public override void SaveToStream(SerializationInfo info, int orderNumber)
        {
            info.AddValue(String.Format(CultureInfo.InvariantCulture, "{0}{1}", _entryStart, orderNumber), _startPoint);
            info.AddValue(String.Format(CultureInfo.InvariantCulture, "{0}{1}", _entryEnd, orderNumber), _endPoint);

            base.SaveToStream(info, orderNumber);
        }

        public override void LoadFromStream(SerializationInfo info, int orderNumber)
        {
            _startPoint =
                (Point)
                info.GetValue(String.Format(CultureInfo.InvariantCulture, "{0}{1}", _entryStart, orderNumber),
                              typeof (Point));
            _endPoint =
                (Point)
                info.GetValue(String.Format(CultureInfo.InvariantCulture, "{0}{1}", _entryEnd, orderNumber),
                              typeof (Point));

            base.LoadFromStream(info, orderNumber);
        }

        /// <summary>
        ///   Invalidate object. When object is invalidated, path used for hit test is released and should be created again.
        /// </summary>
        protected void Invalidate()
        {
            if (AreaPath != null)
            {
                AreaPath.Dispose();
                AreaPath = null;
            }

            if (AreaPen != null)
            {
                AreaPen.Dispose();
                AreaPen = null;
            }

            if (AreaRegion != null)
            {
                AreaRegion.Dispose();
                AreaRegion = null;
            }
        }

        /// <summary>
        ///   Create graphic objects used from hit test.
        /// </summary>
        protected virtual void CreateObjects()
        {
            if (AreaPath != null)
            {
                return;
            }

            // Create path which contains wide line
            // for easy mouse selection
            AreaPath = new GraphicsPath();
            AreaPen = new Pen(Color.Black, 7);
            AreaPath.AddLine(_startPoint.X, _startPoint.Y, _endPoint.X, _endPoint.Y);
            AreaPath.Widen(AreaPen);

            // Create region from the path
            AreaRegion = new Region(AreaPath);
        }
    }
}