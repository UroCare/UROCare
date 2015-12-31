// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using SHC.UROCare.Utilities;

namespace SHCPL.WPFCommonControls
{
    public class SnapCanvas : Canvas
    {
        #region Private fields

        private Rect _bottomSnapRect;
        private UIElement _elementBeingDragged;

        private bool _isDragInProgress;
        private Rect _leftSnapRect;
        private bool _modifyLeftOffset;
        private bool _modifyTopOffset;
        private Point _originalCursorLocation;

        private double _originalHorizontalOffset;
        private double _originalVerticalOffset;
        private Rect _rightSnapRect;
        private Rect _topSnapRect;

        #endregion

        #region Dependency properties

        public static readonly DependencyProperty CanBeDraggedProperty;

        public static readonly DependencyProperty AllowDraggingProperty;
        public static readonly DependencyProperty AllowDragOutOfViewProperty;

        public static readonly DependencyProperty SnapThresholdProperty =
            DependencyProperty.Register("SnapThreshold", typeof (double), typeof (SnapCanvas),
                                        new FrameworkPropertyMetadata(20d,
                                                                      FrameworkPropertyMetadataOptions.AffectsRender));

        #endregion

        #region Constructors

        static SnapCanvas()
        {
            AllowDraggingProperty = DependencyProperty.Register("AllowDragging", typeof (bool), typeof (SnapCanvas),
                                                                new PropertyMetadata(true));
            AllowDragOutOfViewProperty = DependencyProperty.Register("AllowDragOutOfView", typeof (bool),
                                                                     typeof (SnapCanvas), new UIPropertyMetadata(false));
            CanBeDraggedProperty = DependencyProperty.Register("CanBeDragged", typeof (bool), typeof (SnapCanvas),
                                                               new UIPropertyMetadata(true));
        }

        public SnapCanvas()
        {
            SizeChanged += OnSizeChanged;
        }

        #endregion

        #region Public properties

        public double SnapThreshold
        {
            get
            {
                return (double) GetValue(SnapThresholdProperty);
            }
            set
            {
                SetValue(SnapThresholdProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets Allow dragging value.
        /// </summary>
        public bool AllowDragging
        {
            get
            {
                return (bool) GetValue(AllowDraggingProperty);
            }
            set
            {
                SetValue(AllowDraggingProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets allow drag out of view.
        /// </summary>
        public bool AllowDragOutOfView
        {
            get
            {
                return (bool) GetValue(AllowDragOutOfViewProperty);
            }
            set
            {
                SetValue(AllowDragOutOfViewProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets element being dragged.
        /// </summary>
        public UIElement ElementBeingDragged
        {
            get
            {
                if (!AllowDragging)
                {
                    return null;
                }
                return _elementBeingDragged;
            }
            protected set
            {
                if (_elementBeingDragged != null)
                {
                    _elementBeingDragged.ReleaseMouseCapture();
                }
                if (!AllowDragging)
                {
                    _elementBeingDragged = null;
                }
                else
                {
                    if (GetCanBeDragged(value))
                    {
                        _elementBeingDragged = value;
                        _elementBeingDragged.CaptureMouse();
                    }
                    else
                    {
                        _elementBeingDragged = null;
                    }
                }
            }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Finds child of canvas.
        /// </summary>
        /// <param name="dependencyObject">Dependency object</param>
        /// <returns>UIElement</returns>
        public UIElement FindCanvasChild(DependencyObject dependencyObject)
        {
            while (dependencyObject != null)
            {
                var element = dependencyObject as UIElement;
                if (element != null && Children.Contains(element))
                {
                    break;
                }

                if (dependencyObject is Visual || dependencyObject is Visual3D)
                {
                    dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
                }
                else
                {
                    dependencyObject = LogicalTreeHelper.GetParent(dependencyObject);
                }
            }
            return dependencyObject as UIElement;
        }

        /// <summary>
        /// Brings element to front.
        /// </summary>
        /// <param name="element">Element to be brought to front.</param>
        public void BrintToFront(UIElement element)
        {
            UpdateZOrder(element, true);
        }

        /// <summary>
        /// Sends element to back.
        /// </summary>
        /// <param name="element">Element to be sent to back.</param>
        public void SendToBack(UIElement element)
        {
            UpdateZOrder(element, false);
        }

        public static bool GetCanBeDragged(UIElement element)
        {
            if (null == element)
            {
                return false;
            }
            return (bool) element.GetValue(CanBeDraggedProperty);
        }

        public static void SetCanBeDragged(UIElement element, bool value)
        {
            if (null != element)
            {
                element.SetValue(CanBeDraggedProperty, value);
            }
        }

        #endregion

        #region Protected overrides

        /// <summary>
        /// Invoked when an unhandled <see cref="E:System.Windows.UIElement.PreviewMouseLeftButtonDown"/> routed event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
        /// </summary>
        /// <param name="e">The <see cref="T:System.Windows.Input.MouseButtonEventArgs"/> that contains the event data. The event data reports that the side1 mouse button was pressed.</param>
        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseLeftButtonDown(e);
            _isDragInProgress = false;
            _originalCursorLocation = e.GetPosition(this);

            ElementBeingDragged = FindCanvasChild(e.Source as DependencyObject);

            if (ElementBeingDragged == null)
            {
                return;
            }
            double left = GetLeft(ElementBeingDragged);
            double right = GetRight(ElementBeingDragged);
            double top = GetTop(ElementBeingDragged);
            double bottom = GetBottom(ElementBeingDragged);

            _originalHorizontalOffset = ResolveOffset(left, right, out _modifyLeftOffset);
            _originalVerticalOffset = ResolveOffset(top, bottom, out _modifyTopOffset);

            e.Handled = true;
            _isDragInProgress = true;
        }

        protected override void OnPreviewMouseMove(MouseEventArgs e)
        {
            base.OnPreviewMouseMove(e);
            if (ElementBeingDragged == null || !_isDragInProgress)
            {
                return;
            }
            Point cursorLocation = e.GetPosition(this);
            double newHorizontalOffset;
            double newVerticalOffset;

            if (_modifyLeftOffset)
            {
                newHorizontalOffset = _originalHorizontalOffset + (cursorLocation.X - _originalCursorLocation.X);
            }
            else
            {
                newHorizontalOffset = _originalHorizontalOffset - (cursorLocation.X - _originalCursorLocation.X);
            }
            if (_modifyTopOffset)
            {
                newVerticalOffset = _originalVerticalOffset + cursorLocation.Y - _originalCursorLocation.Y;
            }
            else
            {
                newVerticalOffset = _originalVerticalOffset - (cursorLocation.Y - _originalCursorLocation.Y);
            }

            if (!AllowDragOutOfView)
            {
                Rect elementRectangle = CalculateDragElementRectangle(newHorizontalOffset, newVerticalOffset);

                bool leftAlign = elementRectangle.Left < 0;
                bool rightAlign = elementRectangle.Right > ActualWidth;
                bool topAlign = elementRectangle.Top < 0;
                bool bottomAlign = elementRectangle.Bottom > ActualHeight;
                if (leftAlign)
                {
                    newHorizontalOffset = _modifyLeftOffset ? 0 : ActualWidth - elementRectangle.Width;
                }
                else if (rightAlign)
                {
                    newHorizontalOffset = _modifyLeftOffset ? ActualWidth - elementRectangle.Width : 0;
                }

                if (topAlign)
                {
                    newVerticalOffset = _modifyTopOffset ? 0 : ActualHeight - elementRectangle.Height;
                }
                else if (bottomAlign)
                {
                    newVerticalOffset = _modifyTopOffset ? ActualHeight - elementRectangle.Height : 0;
                }
            }

            if (_modifyLeftOffset)
            {
                SetLeft(ElementBeingDragged, newHorizontalOffset);
            }
            else
            {
                SetRight(ElementBeingDragged, newHorizontalOffset);
            }

            if (_modifyTopOffset)
            {
                SetTop(ElementBeingDragged, newVerticalOffset);
            }
            else
            {
                SetBottom(ElementBeingDragged, newVerticalOffset);
            }

            if (ElementBeingDragged is IGadgetContainer)
            {
                var gadgetContainer = ElementBeingDragged as IGadgetContainer;

                gadgetContainer.SnapRegion = SnapRegions.NotSet;
                SnapElement(gadgetContainer);
            }
        }

        /// <summary>
        /// Invoked when an unhandled attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
        /// </summary>
        /// <param name="e">The <see cref="T:System.Windows.Input.MouseButtonEventArgs"/> that contains the event data. The event data reports that one or more mouse buttons were released.</param>
        protected override void OnPreviewMouseUp(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseUp(e);
            ElementBeingDragged = null;
        }

        #endregion

        #region Private methods

        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            SetSnapRectangles(e.NewSize);
            RelocateSnappedContainer();
        }

        private void RelocateSnappedContainer()
        {
            foreach (object childElement in Children)
            {
                if (childElement is IGadgetContainer)
                {
                    var gadgetContainer = childElement as IGadgetContainer;
                    if (!gadgetContainer.SnapRegion.Equals(SnapRegions.NotSet))
                    {
                        SnapElement(gadgetContainer);
                    }
                }
            }
        }

        private void SetSnapRectangles(Size size)
        {
            if (size.Width > 0)
            {
                _leftSnapRect.Location = new Point(0, 0);
                _leftSnapRect.Size = new Size(SnapThreshold, size.Height);

                _rightSnapRect.Location = new Point(size.Width - SnapThreshold, 0);
                _rightSnapRect.Size = new Size(SnapThreshold, size.Height);

                _topSnapRect.Location = new Point(SnapThreshold, 0);
                _topSnapRect.Size = new Size(size.Width - (SnapThreshold*2), SnapThreshold);

                _bottomSnapRect.Location = new Point(SnapThreshold, size.Height - SnapThreshold);
                _bottomSnapRect.Size = new Size(size.Width - (SnapThreshold*2), SnapThreshold);
            }
        }

        private double ResolveOffset(double side1, double side2, out bool useSide1)
        {
            useSide1 = true;
            double result;
            if (Double.IsNaN(side1))
            {
                if (Double.IsNaN(side2))
                {
                    result = 0;
                }
                else
                {
                    result = side2;
                    useSide1 = false;
                }
            }
            else
            {
                result = side1;
            }
            return result;
        }

        /// <summary>
        /// Calcualtes rectangle for element being dragged.
        /// </summary>
        /// <param name="newHorizontalOffset">Horizontal offset for the element</param>
        /// <param name="newVerticalOffset">Vertical offset of element.</param>
        /// <returns>Rectangle for element being dragged.</returns>
        private Rect CalculateDragElementRectangle(double newHorizontalOffset, double newVerticalOffset)
        {
            if (ElementBeingDragged == null)
            {
                ExceptionManager.Throw(new InvalidOperationException("ElementBeingDragged is null"));
            }
            Size elementSize = ElementBeingDragged.RenderSize;
            double x;
            double y;

            if (_modifyLeftOffset)
            {
                x = newHorizontalOffset;
            }
            else
            {
                x = ActualWidth - elementSize.Width;
            }

            if (_modifyTopOffset)
            {
                y = newVerticalOffset;
            }
            else
            {
                y = ActualHeight - elementSize.Height;
            }
            var newLocation = new Point(x, y);
            return new Rect(newLocation, elementSize);
        }

        private void UpdateZOrder(UIElement element, bool bringToFront)
        {
            if (element == null)
            {
                ExceptionManager.Throw(new ArgumentNullException("element"));
            }

            if (!Children.Contains(element))
            {
                ExceptionManager.Throw(
                    new ArgumentException(Properties.Resources.InvalidChildElement, "element"));
            }

            int elementNewZIndex = -1;

            if (bringToFront)
            {
                foreach (UIElement childElement in Children)
                {
                    if (childElement.Visibility != Visibility.Collapsed)
                    {
                        ++elementNewZIndex;
                    }
                }
            }
            else
            {
                elementNewZIndex = 0;
            }

            // Determine if the other UIElements' Z-Index 
            // should be raised or lowered by one. 
            int offset = (elementNewZIndex == 0) ? +1 : -1;

            int elementCurrentZIndex = GetZIndex(element);

            // Update the Z-Index of every UIElement in the Canvas.
            foreach (UIElement childElement in Children)
            {
                if (childElement == element)
                {
                    SetZIndex(element, elementNewZIndex);
                }
                else
                {
                    int zIndex = GetZIndex(childElement);

                    // Only modify the z-index of an element if it is  
                    // in between the target element's old and new z-index.
                    if (bringToFront && elementCurrentZIndex < zIndex ||
                        !bringToFront && zIndex < elementCurrentZIndex)
                    {
                        SetZIndex(childElement, zIndex + offset);
                    }
                }
            }
        }

        private void SnapElement(IGadgetContainer container)
        {
            var gadgetContainerElement = container as UIElement;
            if (gadgetContainerElement == null)
            {
                return;
            }
            var elementRect = new Rect
                                  {
                                      X = GetLeft(gadgetContainerElement),
                                      Y = GetTop(gadgetContainerElement),
                                      Size = gadgetContainerElement.RenderSize
                                  };
            if (_leftSnapRect.IntersectsWith(elementRect) || container.SnapRegion.Equals(SnapRegions.Top))
            {
                SetLeft(gadgetContainerElement, 0);
                container.SnapRegion = SnapRegions.Left;
            }
            else if (_rightSnapRect.IntersectsWith(elementRect) || container.SnapRegion.Equals(SnapRegions.Right))
            {
                SetLeft(gadgetContainerElement, ActualWidth - elementRect.Width);
                container.SnapRegion = SnapRegions.Right;
            }
            else if (_topSnapRect.IntersectsWith(elementRect) || container.SnapRegion.Equals(SnapRegions.Top))
            {
                SetTop(gadgetContainerElement, 0);
                container.SnapRegion = SnapRegions.Top;
            }
            else if (_bottomSnapRect.IntersectsWith(elementRect) || container.SnapRegion.Equals(SnapRegions.Bottom))
            {
                SetTop(gadgetContainerElement, ActualHeight - elementRect.Height);
                container.SnapRegion = SnapRegions.Bottom;
            }
        }

        #endregion
    }
}