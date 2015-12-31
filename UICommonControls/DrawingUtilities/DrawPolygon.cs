// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    ///   Polygon graphic object
    /// </summary>
    internal class DrawPolygon : DrawLine
    {
        private const string _entryLength = "Length";
        private const string _entryPoint = "Point";
        private static readonly Cursor _handleCursor = new Cursor(typeof (DrawPolygon), "PolyHandle.cur");
        private readonly List<Point> _pointArray; // list of points

        public DrawPolygon()
        {
            _pointArray = new List<Point>();

            Initialize();
        }

        public DrawPolygon(int x1, int y1, int x2, int y2) : this()
        {
            _pointArray = new List<Point> {new Point(x1, y1), new Point(x2, y2)};

            Initialize();
        }

        /// <summary>
        ///   Number of handles
        /// </summary>
        public override int HandleCount
        {
            get
            {
                return _pointArray.Count;
            }
        }

        /// <summary>
        ///   Clone this instance
        /// </summary>
        public override DrawObject Clone()
        {
            var drawPolygon = new DrawPolygon();

            foreach (Point p in _pointArray)
            {
                drawPolygon._pointArray.Add(p);
            }

            FillDrawObjectFields(drawPolygon);
            return drawPolygon;
        }

        /// <summary>
        ///   Draw object
        /// </summary>
        /// <param name="graphics"> </param>
        public override void Draw(Graphics graphics)
        {
            int x1 = 0, y1 = 0; // previous point

            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var pen = new Pen(Color, PenWidth);

            IEnumerator<Point> enumerator = _pointArray.GetEnumerator();

            if (enumerator.MoveNext())
            {
                x1 = enumerator.Current.X;
                y1 = enumerator.Current.Y;
            }

            while (enumerator.MoveNext())
            {
                int x2 = enumerator.Current.X; // current point
                int y2 = enumerator.Current.Y; // current point

                graphics.DrawLine(pen, x1, y1, x2, y2);

                x1 = x2;
                y1 = y2;
            }

            pen.Dispose();
        }

        public void AddPoint(Point point)
        {
            _pointArray.Add(point);
        }

        /// <summary>
        ///   Get handle point by 1-based number
        /// </summary>
        /// <param name="handleNumber"> </param>
        /// <returns> </returns>
        public override Point GetHandle(int handleNumber)
        {
            if (handleNumber < 1)
            {
                handleNumber = 1;
            }

            if (handleNumber > _pointArray.Count)
            {
                handleNumber = _pointArray.Count;
            }

            return _pointArray[handleNumber - 1];
        }

        /// <summary>
        ///   Get cursor for the handle
        /// </summary>
        /// <param name="handleNumber"> </param>
        /// <returns> </returns>
        public override Cursor GetHandleCursor(int handleNumber)
        {
            return _handleCursor;
        }

        /// <summary>
        ///   Move handle to the point
        /// </summary>
        /// <param name="point"> </param>
        /// <param name="handleNumber"> </param>
        public override void MoveHandleTo(Point point, int handleNumber)
        {
            if (handleNumber < 1)
            {
                handleNumber = 1;
            }

            if (handleNumber > _pointArray.Count)
            {
                handleNumber = _pointArray.Count;
            }

            _pointArray[handleNumber - 1] = point;

            Invalidate();
        }

        /// <summary>
        ///   Move object
        /// </summary>
        /// <param name="deltaX"> </param>
        /// <param name="deltaY"> </param>
        public override void Move(int deltaX, int deltaY)
        {
            int n = _pointArray.Count;

            for (int i = 0; i < n; i++)
            {
                var point = new Point(_pointArray[i].X + deltaX, _pointArray[i].Y + deltaY);

                _pointArray[i] = point;
            }

            Invalidate();
        }

        /// <summary>
        ///   Save object to serialization stream
        /// </summary>
        /// <param name="info"> </param>
        /// <param name="orderNumber"> </param>
        public override void SaveToStream(SerializationInfo info, int orderNumber)
        {
            info.AddValue(String.Format(CultureInfo.InvariantCulture, "{0}{1}", _entryLength, orderNumber),
                          _pointArray.Count);

            int i = 0;
            foreach (Point p in _pointArray)
            {
                info.AddValue(String.Format(CultureInfo.InvariantCulture, "{0}{1}-{2}", _entryPoint, orderNumber, i++),
                              p);
            }

            base.SaveToStream(info, orderNumber); // ??
        }

        /// <summary>
        ///   Load object from serialization stream
        /// </summary>
        /// <param name="info"> </param>
        /// <param name="orderNumber"> </param>
        public override void LoadFromStream(SerializationInfo info, int orderNumber)
        {
            int n = info.GetInt32(String.Format(CultureInfo.InvariantCulture, "{0}{1}", _entryLength, orderNumber));

            for (int i = 0; i < n; i++)
            {
                var point = (Point)
                            info.GetValue(
                                String.Format(CultureInfo.InvariantCulture, "{0}{1}-{2}", _entryPoint, orderNumber, i),
                                typeof (Point));

                _pointArray.Add(point);
            }

            base.LoadFromStream(info, orderNumber);
        }

        /// <summary>
        ///   Create graphic object used for hit test
        /// </summary>
        protected override void CreateObjects()
        {
            if (AreaPath != null)
            {
                return;
            }

            // Create closed path which contains all polygon vertexes
            AreaPath = new GraphicsPath();

            int x1 = 0, y1 = 0; // previous point

            IEnumerator<Point> enumerator = _pointArray.GetEnumerator();

            if (enumerator.MoveNext())
            {
                x1 = enumerator.Current.X;
                y1 = enumerator.Current.Y;
            }

            while (enumerator.MoveNext())
            {
                int x2 = enumerator.Current.X; // current point
                int y2 = enumerator.Current.Y; // current point

                AreaPath.AddLine(x1, y1, x2, y2);

                x1 = x2;
                y1 = y2;
            }

            AreaPath.CloseFigure();

            // Create region from the path
            AreaRegion = new Region(AreaPath);
        }
    }
}