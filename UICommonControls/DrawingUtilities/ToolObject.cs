using System.Windows.Forms;

namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    ///   Base class for all tools which create new graphic object
    /// </summary>
    internal abstract class ToolObject : Tool
    {
        /// <summary>
        ///   Tool cursor.
        /// </summary>
        protected Cursor Cursor { get; set; }

        /// <summary>
        ///   Left mouse is released. New object is created and resized.
        /// </summary>
        /// <param name="drawArea"> </param>
        /// <param name="e"> </param>
        public override void OnMouseUp(TransparentCanvas drawArea, MouseEventArgs e)
        {
            drawArea.GraphicsList[0].Normalize();
            drawArea.AddCommandToHistory(new CommandAdd(drawArea.GraphicsList[0]));
            drawArea.ActiveTool = TransparentCanvas.DrawToolType.Pointer;

            drawArea.Capture = false;
            drawArea.Refresh();
        }

        /// <summary>
        ///   Add new object to draw area. Function is called when user left-clicks draw area, and one of ToolObject-derived tools is active.
        /// </summary>
        /// <param name="drawArea"> </param>
        /// <param name="o"> </param>
        protected void AddNewObject(TransparentCanvas drawArea, DrawObject o)
        {
            drawArea.GraphicsList.UnselectAll();

            o.Selected = true;
            drawArea.GraphicsList.Add(o);

            drawArea.Capture = true;
            drawArea.Refresh();

            drawArea.SetDirty();
        }
    }
}