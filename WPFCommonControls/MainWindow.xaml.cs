// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System.Windows;
using System.Windows.Controls;
using SHCPL.WPFCommonControls;
using SHCPL.WPFCommonControls.Gadgets;

namespace SHCPL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnbuttonClick(object sender, RoutedEventArgs e)
        {
            var gadgetContainer = new GadgetContainer();
            Canvas.SetTop(gadgetContainer, 100);
            Canvas.SetLeft(gadgetContainer, 100);
            gadgetContainer.OptionButtonType = OptionButtonTypes.Settings;
            gadgetContainer.Close += OnGadgetClose;

            var todaysAppointments = new TodayAppointments();
            gadgetContainer.Gadget = todaysAppointments;

            _snapCanvas.Children.Add(gadgetContainer);
        }

        private void OnGadgetClose(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}