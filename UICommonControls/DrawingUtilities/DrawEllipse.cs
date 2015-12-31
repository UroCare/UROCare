// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System.Drawing;

namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    ///   Ellipse graphic object
    /// </summary>
    internal class DrawEllipse : DrawRectangle
    {
        public DrawEllipse() : this(0, 0, 1, 1)
        {
        }

        public DrawEllipse(int x, int y, int width, int height)
        {
            Rectangle = new Rectangle(x, y, width, height);
            Initialize();
        }

        /// <summary>
        ///   Clone this instance
        /// </summary>
        public override DrawObject Clone()
        {
            var drawEllipse = new DrawEllipse {Rectangle = Rectangle};

            FillDrawObjectFields(drawEllipse);
            return drawEllipse;
        }

        /// <summary>
        ///   Draw rectangle
        /// </summary>
        /// <param name="graphics"> </param>
        public override void Draw(Graphics graphics)
        {
            var pen = new Pen(Color, PenWidth);

            graphics.DrawEllipse(pen, GetNormalizedRectangle(Rectangle));

            pen.Dispose();
        }
    }
}