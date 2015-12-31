// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System.Windows;
using System.Windows.Controls;

namespace SHCPL.WPFCommonControls.Gadgets
{
    /// <summary>
    /// Interaction logic for TodayAppointments.xaml
    /// </summary>
    public partial class TodayAppointments : UserControl, IGadget
    {
        public TodayAppointments()
        {
            InitializeComponent();
            Unloaded += OnGadgetUnloaded;
        }

        private void OnGadgetUnloaded(object sender, RoutedEventArgs e)
        {
        }

        #region Implementation of IGadget

        public void OnShowOptions(OptionButtonTypes types)
        {
            if (types.Equals(OptionButtonTypes.Settings))
            {
                //TodayAppointMentsSettings settings = new TodayAppointMentsSettings();
                //settings.Show();
            }
        }

        #endregion
    }
}