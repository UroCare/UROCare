// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    ///   List of graphic objects
    /// </summary>
    [Serializable]
    public class GraphicsList : ISerializable
    {
        #region Members

        private const string _entryCount = "Count";
        private const string _entryType = "Type";
        private readonly List<DrawObject> _graphicsList;

        #endregion

        #region Constructor

        public GraphicsList()
        {
            _graphicsList = new List<DrawObject>();
        }

        #endregion

        #region Serialization Support

        protected GraphicsList(SerializationInfo info, StreamingContext context)
        {
            _graphicsList = new List<DrawObject>();

            int n = info.GetInt32(_entryCount);

            for (int i = 0; i < n; i++)
            {
                string typeName = info.GetString(
                    String.Format(CultureInfo.InvariantCulture,
                                  "{0}{1}",
                                  _entryType, i));

                var drawObject = (DrawObject) Assembly.GetExecutingAssembly().CreateInstance(
                    typeName);

                if (drawObject != null)
                {
                    drawObject.LoadFromStream(info, i);

                    _graphicsList.Add(drawObject);
                }
            }
        }

        /// <summary>
        ///   Save object to serialization stream
        /// </summary>
        /// <param name="info"> </param>
        /// <param name="context"> </param>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(_entryCount, _graphicsList.Count);

            int i = 0;

            foreach (DrawObject o in _graphicsList)
            {
                info.AddValue(String.Format(CultureInfo.InvariantCulture, "{0}{1}", _entryType, i), o.GetType().FullName);

                o.SaveToStream(info, i);

                i++;
            }
        }

        #endregion

        #region Other functions

        /// <summary>
        ///   Count and this [nIndex] allow to read all graphics objects from GraphicsList in the loop.
        /// </summary>
        public int Count
        {
            get
            {
                return _graphicsList.Count;
            }
        }

        public DrawObject this[int index]
        {
            get
            {
                if (index < 0 || index >= _graphicsList.Count)
                {
                    return null;
                }

                return _graphicsList[index];
            }
        }

        /// <summary>
        ///   SelectedCount and GetSelectedObject allow to read selected objects in the loop
        /// </summary>
        public int SelectionCount
        {
            get
            {
                return Selection.Count();
            }
        }

        /// <summary>
        ///   Returns INumerable object which may be used for enumeration of selected objects. Note: returning IEnumerable <DrawObject>breaks CLS-compliance</DrawObject>
        /// </summary>
        /// <value> </value>
        public IEnumerable<DrawObject> Selection
        {
            get
            {
                return _graphicsList.Where(o => o.Selected);
            }
        }

        public void Draw(Graphics g)
        {
            int n = _graphicsList.Count;

            // Enumerate list in reverse order to get first
            // object on the top of Z-order.
            for (int i = n - 1; i >= 0; i--)
            {
                DrawObject o = _graphicsList[i];

                o.Draw(g);

                if (o.Selected)
                {
                    o.DrawTracker(g);
                }
            }
        }

        /// <summary>
        ///   Dump (for debugging)
        /// </summary>
        public void Dump()
        {
            Trace.WriteLine(string.Empty);

            foreach (DrawObject o in _graphicsList)
            {
                o.Dump();
            }
        }

        /// <summary>
        ///   Clear all objects in the list
        /// </summary>
        /// <returns> true if at least one object is deleted </returns>
        public bool Clear()
        {
            bool result = (_graphicsList.Count > 0);
            _graphicsList.Clear();
            return result;
        }

        public void Add(DrawObject obj)
        {
            // insert to the top of z-order
            _graphicsList.Insert(0, obj);
        }

        /// <summary>
        ///   Insert object to specified place. Used for Undo.
        /// </summary>
        public void Insert(int index, DrawObject obj)
        {
            if (index >= 0 && index < _graphicsList.Count)
            {
                _graphicsList.Insert(index, obj);
            }
        }

        /// <summary>
        ///   Replace object in specified place. Used for Undo.
        /// </summary>
        public void Replace(int index, DrawObject obj)
        {
            if (index >= 0 && index < _graphicsList.Count)
            {
                _graphicsList.RemoveAt(index);
                _graphicsList.Insert(index, obj);
            }
        }

        /// <summary>
        ///   Remove object by index. Used for Undo.
        /// </summary>
        public void RemoveAt(int index)
        {
            _graphicsList.RemoveAt(index);
        }

        /// <summary>
        ///   Delete last added object from the list (used for Undo operation).
        /// </summary>
        public void DeleteLastAddedObject()
        {
            if (_graphicsList.Count > 0)
            {
                _graphicsList.RemoveAt(0);
            }
        }

        public void SelectInRectangle(Rectangle rectangle)
        {
            UnselectAll();

            foreach (DrawObject o in _graphicsList)
            {
                if (o.IntersectsWith(rectangle))
                {
                    o.Selected = true;
                }
            }
        }

        public void UnselectAll()
        {
            foreach (DrawObject o in _graphicsList)
            {
                o.Selected = false;
            }
        }

        public void SelectAll()
        {
            foreach (DrawObject o in _graphicsList)
            {
                o.Selected = true;
            }
        }

        /// <summary>
        ///   Delete selected items
        /// </summary>
        /// <returns> true if at least one object is deleted </returns>
        public bool DeleteSelection()
        {
            bool result = false;

            int n = _graphicsList.Count;

            for (int i = n - 1; i >= 0; i--)
            {
                if ((_graphicsList[i]).Selected)
                {
                    _graphicsList.RemoveAt(i);
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        ///   Move selected items to front (beginning of the list)
        /// </summary>
        /// <returns> true if at least one object is moved </returns>
        public bool MoveSelectionToFront()
        {
            int i;

            var tempList = new List<DrawObject>();
            int n = _graphicsList.Count;

            // Read source list in reverse order, add every selected item
            // to temporary list and remove it from source list
            for (i = n - 1; i >= 0; i--)
            {
                if ((_graphicsList[i]).Selected)
                {
                    tempList.Add(_graphicsList[i]);
                    _graphicsList.RemoveAt(i);
                }
            }

            // Read temporary list in direct order and insert every item
            // to the beginning of the source list
            n = tempList.Count;

            for (i = 0; i < n; i++)
            {
                _graphicsList.Insert(0, tempList[i]);
            }

            return (n > 0);
        }

        /// <summary>
        ///   Move selected items to back (end of the list)
        /// </summary>
        /// <returns> true if at least one object is moved </returns>
        public bool MoveSelectionToBack()
        {
            int i;

            var tempList = new List<DrawObject>();
            int n = _graphicsList.Count;

            // Read source list in reverse order, add every selected item
            // to temporary list and remove it from source list
            for (i = n - 1; i >= 0; i--)
            {
                if ((_graphicsList[i]).Selected)
                {
                    tempList.Add(_graphicsList[i]);
                    _graphicsList.RemoveAt(i);
                }
            }

            // Read temporary list in reverse order and add every item
            // to the end of the source list
            n = tempList.Count;

            for (i = n - 1; i >= 0; i--)
            {
                _graphicsList.Add(tempList[i]);
            }

            return (n > 0);
        }

        /// <summary>
        ///   Get properties from selected objects and fill GraphicsProperties instance
        /// </summary>
        /// <returns> </returns>
        private GraphicsProperties GetProperties()
        {
            var properties = new GraphicsProperties();

            bool bFirst = true;

            int firstColor = 0;
            int firstPenWidth = 1;

            bool allColorsAreEqual = true;
            bool allWidthAreEqual = true;

            foreach (DrawObject o in Selection)
            {
                if (bFirst)
                {
                    firstColor = o.Color.ToArgb();
                    firstPenWidth = o.PenWidth;
                    bFirst = false;
                }
                else
                {
                    if (o.Color.ToArgb() != firstColor)
                    {
                        allColorsAreEqual = false;
                    }

                    if (o.PenWidth != firstPenWidth)
                    {
                        allWidthAreEqual = false;
                    }
                }
            }

            if (allColorsAreEqual)
            {
                properties.Color = Color.FromArgb(firstColor);
            }

            if (allWidthAreEqual)
            {
                properties.PenWidth = firstPenWidth;
            }

            return properties;
        }

        /// <summary>
        ///   Apply properties for all selected objects. Returns TRue if at least one property is changed.
        /// </summary>
        private bool ApplyProperties(GraphicsProperties properties)
        {
            bool changed = false;

            foreach (DrawObject o in _graphicsList)
            {
                if (o.Selected)
                {
                    if (properties.Color.HasValue)
                    {
                        if (o.Color != properties.Color.Value)
                        {
                            o.Color = properties.Color.Value;
                            DrawObject.LastUsedColor = properties.Color.Value;
                            changed = true;
                        }
                    }

                    if (properties.PenWidth.HasValue)
                    {
                        if (o.PenWidth != properties.PenWidth.Value)
                        {
                            o.PenWidth = properties.PenWidth.Value;
                            DrawObject.LastUsedPenWidth = properties.PenWidth.Value;
                            changed = true;
                        }
                    }
                }
            }

            return changed;
        }

        /// <summary>
        ///   Show Properties dialog. Return true if list is changed
        /// </summary>
        /// <param name="parent"> </param>
        /// <returns> </returns>
        public bool ShowPropertiesDialog(TransparentCanvas parent)
        {
            if (SelectionCount < 1)
            {
                return false;
            }

            GraphicsProperties properties = GetProperties();
//            var dlg = new PropertiesDialog();
//            dlg.Properties = properties;
//
            var c = new CommandChangeState(this);
//
//            if (dlg.ShowDialog(parent) != DialogResult.OK)
//            {
//                return false;
//            }

            if (ApplyProperties(properties))
            {
                c.NewState(this);
                parent.AddCommandToHistory(c);
            }

            return true;
        }

        #endregion
    }
}