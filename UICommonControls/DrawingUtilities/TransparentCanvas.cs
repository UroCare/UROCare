using System.Drawing;
using System.Windows.Forms;

namespace SHC.UROCare.UICommonControls
{
    public partial class TransparentCanvas : UserControl
    {
        #region Constructor

        public TransparentCanvas()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Enumerations

        public enum DrawToolType
        {
            Pointer,
            Rectangle,
            Ellipse,
            Line,
            Polygon,
            NumberOfDrawTools
        };

        #endregion

        #region Members

        // (instances of DrawObject-derived classes)

        private DrawToolType _activeTool; // active drawing tool

        // Information about owner form
        //private MainForm owner;
        //private DocManager docManager;

        private ContextMenuStrip _contextMenu;
        private GraphicsList _graphicsList; // list of draw objects
        private Tool[] _tools; // array of tools

        private UndoManager _undoManager;

        #endregion

        #region Properties

        ///// <summary>
        ///// Reference to the owner form
        ///// </summary>
        //public MainForm Owner
        //{
        //    get
        //    {
        //        return owner;
        //    }
        //    set
        //    {
        //        owner = value;
        //    }
        //}

        ///// <summary>
        ///// Reference to DocManager
        ///// </summary>
        //public DocManager DocManager
        //{
        //    get
        //    {
        //        return docManager;
        //    }
        //    set
        //    {
        //        docManager = value;
        //    }
        //}

        /// <summary>
        ///   Active drawing tool.
        /// </summary>
        public DrawToolType ActiveTool
        {
            get
            {
                return _activeTool;
            }
            set
            {
                _activeTool = value;
            }
        }

        /// <summary>
        ///   List of graphics objects.
        /// </summary>
        public GraphicsList GraphicsList
        {
            get
            {
                return _graphicsList;
            }
            set
            {
                _graphicsList = value;
            }
        }

        /// <summary>
        ///   Return True if Undo operation is possible
        /// </summary>
        public bool CanUndo
        {
            get
            {
                if (_undoManager != null)
                {
                    return _undoManager.CanUndo;
                }

                return false;
            }
        }

        /// <summary>
        ///   Return True if Redo operation is possible
        /// </summary>
        public bool CanRedo
        {
            get
            {
                if (_undoManager != null)
                {
                    return _undoManager.CanRedo;
                }

                return false;
            }
        }

        #endregion

        #region Other Functions

        /// <summary>
        ///   Initialization
        /// </summary>
        /// <param name="owner"> </param>
        /// <param name="docManager"> </param>
        public void Initialize(MainForm owner, DocManager docManager)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            // Keep reference to owner form
//            this.Owner = owner;
//            this.DocManager = docManager;

            // set default tool
            _activeTool = DrawToolType.Pointer;

            // create list of graphic objects
            _graphicsList = new GraphicsList();

            // Create undo manager
            _undoManager = new UndoManager(_graphicsList);

            // create array of drawing tools
            _tools = new Tool[(int) DrawToolType.NumberOfDrawTools];
            _tools[(int) DrawToolType.Pointer] = new ToolPointer();
            _tools[(int) DrawToolType.Rectangle] = new ToolRectangle();
            _tools[(int) DrawToolType.Ellipse] = new ToolEllipse();
            _tools[(int) DrawToolType.Line] = new ToolLine();
            _tools[(int) DrawToolType.Polygon] = new ToolPolygon();
        }

        /// <summary>
        ///   Add command to history.
        /// </summary>
        public void AddCommandToHistory(ICommand command)
        {
            _undoManager.AddCommandToHistory(command);
        }

        /// <summary>
        ///   Clear Undo history.
        /// </summary>
        public void ClearHistory()
        {
            _undoManager.ClearHistory();
        }

        /// <summary>
        ///   Undo
        /// </summary>
        public void Undo()
        {
            _undoManager.Undo();
            Refresh();
        }

        /// <summary>
        ///   Redo
        /// </summary>
        public void Redo()
        {
            _undoManager.Redo();
            Refresh();
        }

        /// <summary>
        ///   Set dirty flag (file is changed after last save operation)
        /// </summary>
        public void SetDirty()
        {
            //DocManager.Dirty = true;
        }

        /// <summary>
        ///   Right-click handler
        /// </summary>
        /// <param name="e"> </param>
        private void OnContextMenu(MouseEventArgs e)
        {
            // Change current selection if necessary

            var point = new Point(e.X, e.Y);

            int n = GraphicsList.Count;
            DrawObject o = null;

            for (int i = 0; i < n; i++)
            {
                if (GraphicsList[i].HitTest(point) == 0)
                {
                    o = GraphicsList[i];
                    break;
                }
            }

            if (o != null)
            {
                if (!o.Selected)
                {
                    GraphicsList.UnselectAll();
                }

                // Select clicked object
                o.Selected = true;
            }
            else
            {
                GraphicsList.UnselectAll();
            }

            Refresh(); // in the case selection was changed

            // Show context menu.
            // Context menu items are filled from owner form Edit menu items.
            _contextMenu = new ContextMenuStrip();

//            int nItems = owner.ContextParent.DropDownItems.Count;

            // Read Edit items and move them to context menu.
            // Since every move reduces number of items, read them in reverse order.
            // To get items in direct order, insert each of them to beginning.
//            for (int i = nItems - 1; i >= 0; i--)
//            {
//                m_ContextMenu.Items.Insert(0, owner.ContextParent.DropDownItems[i]);
//            }

            // Show context menu for owner form, so that it handles items selection.
            // Convert point from this window coordinates to owner's coordinates.
            point.X += Left;
            point.Y += Top;

            //m_ContextMenu.Show(owner, point);

            //Owner.SetStateOfControls();  // enable/disable menu items

            // Context menu is shown, but owner's Edit menu is now empty.
            // Subscribe to context menu Closed event and restore items there.
            _contextMenu.Closed += delegate
                                       {
                                           if (_contextMenu != null) // precaution
                                           {
//                    nItems = m_ContextMenu.Items.Count;

//                    for (int k = nItems - 1; k >= 0; k--)
//                    {
//                        owner.ContextParent.DropDownItems.Insert(0, m_ContextMenu.Items[k]);
//                    }
                                           }
                                       };
        }

        #endregion

        #region Event Handlers

        /// <summary>
        ///   Draw graphic objects and group selection rectangle (optionally)
        /// </summary>
        private void DrawArea_Paint(object sender, PaintEventArgs e)
        {
            var brush = new SolidBrush(Color.FromArgb(255, 255, 255));
            e.Graphics.FillRectangle(brush,
                                     ClientRectangle);

            if (_graphicsList != null)
            {
                _graphicsList.Draw(e.Graphics);
            }

            //DrawNetSelection(e.Graphics);

            brush.Dispose();
        }

        /// <summary>
        ///   Mouse down. Left button down event is passed to active tool. Right button down event is handled in this class.
        /// </summary>
        private void DrawArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _tools[(int) _activeTool].OnMouseDown(this, e);
            }
            else if (e.Button == MouseButtons.Right)
            {
                OnContextMenu(e);
            }
        }

        /// <summary>
        ///   Mouse move. Moving without button pressed or with left button pressed is passed to active tool.
        /// </summary>
        private void DrawArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.None)
            {
                _tools[(int) _activeTool].OnMouseMove(this, e);
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        ///   Mouse up event. Left button up event is passed to active tool.
        /// </summary>
        private void DrawArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _tools[(int) _activeTool].OnMouseUp(this, e);
            }
        }

        #endregion Event Handlers
    }

    public class DocManager
    {
    }

    public class MainForm
    {
    }
}