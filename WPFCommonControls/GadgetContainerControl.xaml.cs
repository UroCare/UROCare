// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System.Windows;
using System.Windows.Controls;
using SHCPL.WPFCommonControls.Gadgets;

namespace SHCPL.WPFCommonControls
{
    /// <summary>
    /// Interaction logic for GadgetContainerControl.xaml
    /// </summary>
    public partial class GadgetContainerControl : UserControl
    {
        public GadgetContainerControl()
        {
            InitializeComponent();
            LoadGadgets();
        }

        private void LoadGadgets()
        {
            var gadgetContainer = new GadgetContainer();
            Canvas.SetTop(gadgetContainer, 100);
            Canvas.SetLeft(gadgetContainer, 100);
            gadgetContainer.OptionButtonType = OptionButtonTypes.Settings;
            gadgetContainer.Close += OnGadgetClose;

            gadgetContainer.Gadget = new TodayAppointments();
            _snapCanvas.Children.Add(gadgetContainer);
        }

        private void OnGadgetClose(object sender, RoutedEventArgs e)
        {
            var gadgetContainer = sender as GadgetContainer;

            if (gadgetContainer != null)
            {
                _snapCanvas.Children.Remove(gadgetContainer);
            }
        }
    }
}