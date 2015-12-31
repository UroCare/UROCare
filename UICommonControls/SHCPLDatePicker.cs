using System;
using System.Drawing;
using System.Windows.Forms;

namespace SHC.UROCare.UICommonControls
{
    public partial class SHCPLDatePicker : UserControl
    {
        private MonthCalendar _monthCalendar;

        public SHCPLDatePicker()
        {
            InitializeComponent();
        }

        private void OnDropDownButtonClick(object sender, EventArgs e)
        {
            Parent.SuspendLayout();
            _monthCalendar = new MonthCalendar
                                 {
                                     Location =
                                         new Point(_dropButton.ClientRectangle.Left, _dropButton.ClientRectangle.Bottom)
                                 };
            _monthCalendar.DateSelected += OnDateSelected;
            _monthCalendar.Location = new Point(_maskedTextBox.Location.X,
                                                _maskedTextBox.Location.Y + _maskedTextBox.Height);
            _monthCalendar.BringToFront();
            Parent.Controls.Add(_monthCalendar);
            Parent.ResumeLayout();
        }

        private void OnDateSelected(object sender, DateRangeEventArgs eventArgs)
        {
            _maskedTextBox.Text = eventArgs.Start.ToShortDateString();
            Parent.Controls.Remove(_monthCalendar);
        }
    }
}