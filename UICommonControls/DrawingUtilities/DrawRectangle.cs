// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    ///   Rectangle graphic object
    /// </summary>
    internal class DrawRectangle : DrawObject
    {
        #region Private fields

        private const string _entryRectangle = "Rect";
        private Rectangle _rectangle;

        #endregion

        public DrawRectangle()
            : this(0, 0, 1, 1)
        {
        }

        public DrawRectangle(int x, int y, int width, int height)
        {
            _rectangle.X = x;
            _rectangle.Y = y;
            _rectangle.Width = width;
            _rectangle.Height = height;
            Initialize();
        }

        protected Rectangle Rectangle
        {
            get
            {
                return _rectangle;
            }
            set
            {
                _rectangle = value;
            }
        }

        /// <summary>
        ///   Get number of handles
        /// </summary>
        public override int HandleCount
        {
            get
            {
                return 8;
            }
        }

        /// <summary>
        ///   Clone this instance
        /// </summary>
        public override DrawObject Clone()
        {
            var drawRectangle = new DrawRectangle {_rectangle = _rectangle};

            FillDrawObjectFields(drawRectangle);
            return drawRectangle;
        }

        /// <summary>
        ///   Draw rectangle
        /// </summary>
        /// <param name="graphics"> </param>
        public override void Draw(Graphics graphics)
        {
            var pen = new Pen(Color, PenWidth);

            graphics.DrawRectangle(pen, GetNormalizedRectangle(Rectangle));

            pen.Dispose();
        }

        protected void SetRectangle(int x, int y, int width, int height)
        {
            _rectangle.X = x;
            _rectangle.Y = y;
            _rectangle.Width = width;
            _rectangle.Height = height;
        }

        /// <summary>
        ///   Get handle point by 1-based number
        /// </summary>
        /// <param name="handleNumber"> </param>
        /// <returns> </returns>
        public override Point GetHandle(int handleNumber)
        {
            int xCenter = _rectangle.X + _rectangle.Width/2;
            int yCenter = _rectangle.Y + _rectangle.Height/2;
            int x = _rectangle.X;
            int y = _rectangle.Y;

            switch (handleNumber)
            {
                case 1:
                    x = _rectangle.X;
                    y = _rectangle.Y;
                    break;
                case 2:
                    x = xCenter;
                    y = _rectangle.Y;
                    break;
                case 3:
                    x = _rectangle.Right;
                    y = _rectangle.Y;
                    break;
                case 4:
                    x = _rectangle.Right;
                    y = yCenter;
                    break;
                case 5:
                    x = _rectangle.Right;
                    y = _rectangle.Bottom;
                    break;
                case 6:
                    x = xCenter;
                    y = _rectangle.Bottom;
                    break;
                case 7:
                    x = _rectangle.X;
                    y = _rectangle.Bottom;
                    break;
                case 8:
                    x = _rectangle.X;
                    y = yCenter;
                    break;
            }

            return new Point(x, y);
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

        protected override bool PointInObject(Point point)
        {
            return _rectangle.Contains(point);
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
                    return Cursors.SizeNWSE;
                case 2:
                    return Cursors.SizeNS;
                case 3:
                    return Cursors.SizeNESW;
                case 4:
                    return Cursors.SizeWE;
                case 5:
                    return Cursors.SizeNWSE;
                case 6:
                    return Cursors.SizeNS;
                case 7:
                    return Cursors.SizeNESW;
                case 8:
                    return Cursors.SizeWE;
                default:
                    return Cursors.Default;
            }
        }

        /// <summary>
        ///   Move handle to new point (resizing)
        /// </summary>
        /// <param name="point"> </param>
        /// <param name="handleNumber"> </param>
        public override void MoveHandleTo(Point point, int handleNumber)
        {
            int left = Rectangle.Left;
            int top = Rectangle.Top;
            int right = Rectangle.Right;
            int bottom = Rectangle.Bottom;

            switch (handleNumber)
            {
                case 1:
                    left = point.X;
                    top = point.Y;
                    break;
                case 2:
                    top = point.Y;
                    break;
                case 3:
                    right = point.X;
                    top = point.Y;
                    break;
                case 4:
                    right = point.X;
                    break;
                case 5:
                    right = point.X;
                    bottom = point.Y;
                    break;
                case 6:
                    bottom = point.Y;
                    break;
                case 7:
                    left = point.X;
                    bottom = point.Y;
                    break;
                case 8:
                    left = point.X;
                    break;
            }

            SetRectangle(left, top, right - left, bottom - top);
        }

        public override bool IntersectsWith(Rectangle rectangle)
        {
            return Rectangle.IntersectsWith(rectangle);
        }

        /// <summary>
        ///   Move object
        /// </summary>
        /// <param name="deltaX"> </param>
        /// <param name="deltaY"> </param>
        public override void Move(int deltaX, int deltaY)
        {
            _rectangle.X += deltaX;
            _rectangle.Y += deltaY;
        }

        public override void Dump()
        {
            base.Dump();

            Trace.WriteLine("rectangle.X = " + _rectangle.X.ToString(CultureInfo.InvariantCulture));
            Trace.WriteLine("rectangle.Y = " + _rectangle.Y.ToString(CultureInfo.InvariantCulture));
            Trace.WriteLine("rectangle.Width = " + _rectangle.Width.ToString(CultureInfo.InvariantCulture));
            Trace.WriteLine("rectangle.Height = " + _rectangle.Height.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        ///   Normalize rectangle
        /// </summary>
        public override void Normalize()
        {
            _rectangle = GetNormalizedRectangle(_rectangle);
        }

        /// <summary>
        ///   Save objevt to serialization stream
        /// </summary>
        /// <param name="info"> </param>
        /// <param name="orderNumber"> </param>
        public override void SaveToStream(SerializationInfo info, int orderNumber)
        {
            info.AddValue(String.Format(CultureInfo.InvariantCulture, "{0}{1}", _entryRectangle, orderNumber),
                          _rectangle);
            base.SaveToStream(info, orderNumber);
        }

        /// <summary>
        ///   LOad object from serialization stream
        /// </summary>
        /// <param name="info"> </param>
        /// <param name="orderNumber"> </param>
        public override void LoadFromStream(SerializationInfo info, int orderNumber)
        {
            _rectangle =
                (Rectangle)
                info.GetValue(String.Format(CultureInfo.InvariantCulture, "{0}{1}", _entryRectangle, orderNumber),
                              typeof (Rectangle));
            base.LoadFromStream(info, orderNumber);
        }

        #region Helper Functions

        public static Rectangle GetNormalizedRectangle(int x1, int y1, int x2, int y2)
        {
            if (x2 < x1)
            {
                int tmp = x2;
                x2 = x1;
                x1 = tmp;
            }

            if (y2 < y1)
            {
                int tmp = y2;
                y2 = y1;
                y1 = tmp;
            }

            return new Rectangle(x1, y1, x2 - x1, y2 - y1);
        }

        public static Rectangle GetNormalizedRectangle(Point p1, Point p2)
        {
            return GetNormalizedRectangle(p1.X, p1.Y, p2.X, p2.Y);
        }

        public static Rectangle GetNormalizedRectangle(Rectangle r)
        {
            return GetNormalizedRectangle(r.X, r.Y, r.X + r.Width, r.Y + r.Height);
        }

        #endregion
    }
}