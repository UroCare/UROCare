// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace SHCPL.WPFCommonControls
{
    /// <summary>
    /// Actual gadget container class. 
    /// </summary>
    [TemplatePart(Name = "Part_Gadget", Type = typeof (ContentControl))]
    [TemplatePart(Name = "Part_ControlGrid", Type = typeof (Grid))]
    [TemplatePart(Name = "Part_CloseButton", Type = typeof (Button))]
    [TemplatePart(Name = "Part_OptionButton", Type = typeof (Button))]
    public class GadgetContainer : Control, IGadgetContainer
    {
        #region Private fields

        private Button _closeButton;
        private Grid _controlBarGrid;
        private Storyboard _fadeInStoryboard;
        private Storyboard _fadeOutStoryboard;
        private Button _optionButton;

        #endregion

        #region Routed events

        public static readonly RoutedEvent CloseEvent = EventManager.RegisterRoutedEvent("Close", RoutingStrategy.Bubble,
                                                                                         typeof (RoutedEventHandler),
                                                                                         typeof (GadgetContainer));

        public static readonly RoutedEvent GadgetChangedEvent = EventManager.RegisterRoutedEvent("GadgetChangedEvent",
                                                                                                 RoutingStrategy.Bubble,
                                                                                                 typeof (
                                                                                                     RoutedPropertyChangedEventHandler
                                                                                                     <IGadget>),
                                                                                                 typeof (GadgetContainer
                                                                                                     ));

        public static readonly RoutedEvent ShowOptionsEvent = EventManager.RegisterRoutedEvent("ShowOptionsEvent",
                                                                                               RoutingStrategy.Bubble,
                                                                                               typeof (
                                                                                                   RoutedEventHandler),
                                                                                               typeof (GadgetContainer));

        #endregion

        #region Dependency properties

        public static readonly DependencyProperty GadgetProperty =
            DependencyProperty.Register("Gadget", typeof (IGadget), typeof (GadgetContainer),
                                        new FrameworkPropertyMetadata(null, OnGadgetChanged));

        public static readonly DependencyProperty OptionButtonTypeProperty =
            DependencyProperty.Register("OptionButtonType", typeof (OptionButtonTypes), typeof (GadgetContainer),
                                        new FrameworkPropertyMetadata(OptionButtonTypes.Settings));

        #endregion

        #region Constructors

        static GadgetContainer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof (GadgetContainer),
                                                     new FrameworkPropertyMetadata(typeof (GadgetContainer)));
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets option ption buttton type
        /// </summary>
        public OptionButtonTypes OptionButtonType
        {
            get
            {
                return (OptionButtonTypes) GetValue(OptionButtonTypeProperty);
            }
            set
            {
                SetValue(OptionButtonTypeProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets gadget.
        /// </summary>
        public IGadget Gadget
        {
            get
            {
                return (IGadget) GetValue(GadgetProperty);
            }
            set
            {
                SetValue(GadgetProperty, value);
            }
        }

        #endregion

        #region Private methods

        private void OnOptionButtonClick(object sender, RoutedEventArgs e)
        {
            e.RoutedEvent = ShowOptionsEvent;
            e.Source = sender;
            e.Handled = false;
            OnShowOptions(e);
        }

        private void OnCloseButtonClick(object sender, RoutedEventArgs e)
        {
            e.RoutedEvent = CloseEvent;
            e.Source = sender;
            e.Handled = false;
            OnClose(e);
        }

        private void OnGadgetContainerPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _controlBarGrid.Opacity = 1;
        }

        private void OnGadgeContainerMouseLeave(object sender, MouseEventArgs e)
        {
            _fadeOutStoryboard.Begin(_controlBarGrid, true);
        }

        private void OnGadgetContainerMouseEnter(object sender, MouseEventArgs e)
        {
            _fadeOutStoryboard.Stop(_controlBarGrid);
            if (Math.Abs(_controlBarGrid.Opacity - 1.0) > 0.000000001)
            {
                _fadeInStoryboard.Begin(_controlBarGrid);
            }
        }

        private static void OnGadgetChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var control = (GadgetContainer) obj;

            var e = new RoutedPropertyChangedEventArgs<IGadget>(
                (IGadget) args.OldValue, (IGadget) args.NewValue, GadgetChangedEvent);
            control.OnGadgetChanged(e);
        }

        #endregion

        #region Protected methods

        protected virtual void OnShowOptions(RoutedEventArgs eventArgs)
        {
            Gadget.OnShowOptions(OptionButtonType);
        }

        protected virtual void OnClose(RoutedEventArgs eventArgs)
        {
            RaiseEvent(eventArgs);
        }

        protected virtual void OnGadgetChanged(RoutedPropertyChangedEventArgs<IGadget> args)
        {
            RaiseEvent(args);
        }

        #endregion

        #region Public Methods

        public override void OnApplyTemplate()
        {
            _controlBarGrid = Template.FindName("PART_ControlBarGrid", this) as Grid;
            _fadeInStoryboard = Template.Resources["FadeInStoryboard"] as Storyboard;
            _fadeOutStoryboard = Template.Resources["FadeOutStoryboard"] as Storyboard;

            MouseEnter += OnGadgetContainerMouseEnter;
            MouseLeave += OnGadgeContainerMouseLeave;
            PreviewMouseLeftButtonDown += OnGadgetContainerPreviewMouseLeftButtonDown;

            _closeButton = Template.FindName("PART_CloseButton", this) as Button;

            if (_closeButton != null)
            {
                _closeButton.AddHandler(MouseLeftButtonUpEvent, new RoutedEventHandler(OnCloseButtonClick), true);
            }

            _optionButton = Template.FindName("PART_OptionButton", this) as Button;

            if (_optionButton != null)
            {
                _optionButton.AddHandler(MouseLeftButtonUpEvent, new RoutedEventHandler(OnOptionButtonClick), true);
            }
        }

        #endregion

        #region Public event handler properties

        public event RoutedEventHandler ShowOptions
        {
            add
            {
                AddHandler(ShowOptionsEvent, value);
            }
            remove
            {
                RemoveHandler(ShowOptionsEvent, value);
            }
        }

        public event RoutedPropertyChangedEventHandler<IGadget> GadgetChanged
        {
            add
            {
                AddHandler(GadgetChangedEvent, value);
            }
            remove
            {
                RemoveHandler(GadgetChangedEvent, value);
            }
        }

        public event RoutedEventHandler Close
        {
            add
            {
                AddHandler(CloseEvent, value);
            }
            remove
            {
                RemoveHandler(CloseEvent, value);
            }
        }

        #endregion

        #region Implementation of IGadgetContainer

        /// <summary>
        /// Get or sets snap region for the current gadget container.
        /// </summary>
        public SnapRegions SnapRegion { get; set; }

        #endregion
    }
}