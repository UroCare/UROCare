using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SHCPL.CommonControls;

namespace CommonControls
{
    public class DatePickerControl : UserControl
    {
        private Button _dropDownButton;
        private MaskedTextBox _maskedTextBox;
        private CustomCalendar _customCalendar;

        #region Constructor

        /// <summary>
        ///   Constructor to create the instance of the control.
        /// </summary>
        public DatePickerControl()
        {
            InitializeControl();
        }

        #endregion

        private void InitializeControl()
        {
            SuspendLayout();
            _maskedTextBox = new MaskedTextBox
                                 {
                                     Mask = "00/00/0000",
                                     Size = new Size(139, 20),
                                     Location = new Point(0, 0),
                                     TabIndex = 0,
                                     ValidatingType = typeof (DateTime),
                                 };

            _dropDownButton = new Button();
            _dropDownButton.Size = new Size(16, 16);
            _dropDownButton.FlatStyle = FlatStyle.Standard;
            _dropDownButton.BackColor = Color.White;
            _dropDownButton.Location = new Point(_maskedTextBox.Width - 20, 1);
            _dropDownButton.BackgroundImage = Strings.calendar_icon;
            _dropDownButton.Click += OnDropDownButtonClick;
            _dropDownButton.Cursor = Cursors.Arrow;
            _maskedTextBox.Controls.Add(_dropDownButton);
            AutoScaleMode=AutoScaleMode.Dpi;
            _maskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Controls.Add(_maskedTextBox);
            ResumeLayout(true);
        }

        private void OnDropDownButtonClick(object sender, EventArgs e)
        {
            var highlightedDates = new List<HighlightedDates>();
            highlightedDates.Add(new HighlightedDates(Convert.ToDateTime(_maskedTextBox.Text.Trim()),
                                                      Color.Red, Color.Blue, Color.Pink, true));
            _customCalendar = new CustomCalendar(highlightedDates);
            _customCalendar.CustomCalendarEvent += OnCustomCalendarEvent;
            _customCalendar.Location = new Point(0, 20);
            Controls.Add(_customCalendar);
        }

        private void OnCustomCalendarEvent(object sender, CustomCalendarEventArgs eventArgs)
        {
            _maskedTextBox.Text = eventArgs.SelectedDate;
            Controls.Remove(_customCalendar);
            _customCalendar = null;
        }

        internal class CustomCalendar : MonthCalendar
        {
            private readonly List<HighlightedDates> _highlightedDates;

            #region Private fields

            private readonly SelectionRange _range;
            private static int WM_PAINT = 0x000F;
            private Rectangle _dayBox;
            private int _dayTop;

            #endregion

            #region Public events and delegates

            public delegate void CustomCalendarEventHandler(object sender, CustomCalendarEventArgs eventArgs);

            public event CustomCalendarEventHandler CustomCalendarEvent;

            #endregion

            /// <summary>
            ///   Constructor to create the instance.
            /// </summary>
            /// <param name="highlightedDates"> Highlighted dates. </param>
            public CustomCalendar(List<HighlightedDates> highlightedDates)
            {
                ShowTodayCircle = true;
                _highlightedDates = highlightedDates;
                _range = GetDisplayRange(false);
                SetDayBoxSize();
                SetPosition(highlightedDates);
            }

            /// <summary>
            /// Overrides the <see cref="M:System.Windows.Forms.Control.WndProc(System.Windows.Forms.Message@)"/> method.
            /// </summary>
            /// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message"/> to process. </param>
            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);
                if (m.Msg == WM_PAINT)
                {
                    Graphics graphics = Graphics.FromHwnd(Handle);
                    var paintEventArgs = new PaintEventArgs(graphics, new Rectangle(0, 0, Width, Height));
                    OnPaint(paintEventArgs);
                }
            }

            /// <summary>
            /// Raises the <see cref="E:System.Windows.Forms.Control.Paint"/> event.
            /// </summary>
            /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs"/> that contains the event data. </param>
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                Graphics graphics = e.Graphics;
                _highlightedDates.ForEach(date =>
                                              {
                                                  var backgroundRect = new Rectangle(date.Position.Y*_dayBox.Width + 1,
                                                                                     date.Position.X*_dayBox.Height +                                                                                     _dayTop,
                                                                                     _dayBox.Width, _dayBox.Height);
                                                  if (date.BackgroundColor != Color.Empty)
                                                  {
                                                      using (Brush brush = new SolidBrush(date.BackgroundColor))
                                                      {
                                                          graphics.FillRectangle(brush, backgroundRect);
                                                      }
                                                      if (date.IsBold || date.DateColor != Color.Empty)
                                                      {
                                                          using (
                                                              var textFont = new Font(Font,
                                                                                      (date.IsBold
                                                                                           ? FontStyle.Bold
                                                                                           : FontStyle.Regular)))
                                                          {
                                                              TextRenderer.DrawText(graphics,
                                                                                    date.Date.Day.ToString( CultureInfo.InvariantCulture),textFont,
                                                                                    backgroundRect, date.DateColor,
                                                                                    TextFormatFlags.HorizontalCenter |
                                                                                    TextFormatFlags.VerticalCenter);
                                                          }
                                                      }

                                                      if (date.BoxColor != Color.Empty)
                                                      {
                                                          using (var pen = new Pen(date.BoxColor))
                                                          {
                                                              var boxRect = new Rectangle(
                                                                  date.Position.Y*_dayBox.Width + 1,
                                                                  date.Position.X*_dayBox.Height + _dayTop,
                                                                  _dayBox.Width, _dayBox.Height);
                                                              graphics.DrawRectangle(pen, boxRect);
                                                          }
                                                      }
                                                  }
                                              }
                    );
            }

            private void SetPosition(List<HighlightedDates> highlightedDates)
            {
                highlightedDates.ForEach(date =>
                                             {
                                                 if (date.Date > _range.Start && date.Date <= _range.End)
                                                 {
                                                     TimeSpan timeSpan = date.Date.Subtract(_range.Start);
                                                     int row = timeSpan.Days/7;
                                                     int col = timeSpan.Days%7;
                                                     date.Position = new Point(row, col);
                                                 }
                                             });
            }

            private void SetDayBoxSize()
            {
                int bottom = Height;
                HitArea dayTopHitArea = HitTest(1, _dayTop).HitArea;
                HitArea bottomHitArea = HitTest(1, bottom).HitArea;
                if (dayTopHitArea != HitArea.Nowhere)
                {
                    while (dayTopHitArea != HitArea.Date && dayTopHitArea != HitArea.PrevMonthDate)
                    {
                        _dayTop++;
                    }
                }

                if (bottomHitArea != HitArea.Nowhere)
                {
                    while (bottomHitArea != HitArea.Date && bottomHitArea != HitArea.NextMonthDate)
                    {
                        bottom--;
                    }
                }
                _dayBox = new Rectangle { Size = new Size((Width / 7), (bottom - _dayTop) / 6) };
            }

            /// <summary>
            ///   Raises the <see cref="E:System.Windows.Forms.MonthCalendar.DateSelected" /> event.
            /// </summary>
            /// <param name="drevent"> A <see cref="T:System.Windows.Forms.DateRangeEventArgs" /> that contains the event data. </param>
            protected override void OnDateSelected(DateRangeEventArgs drevent)
            {
                base.OnDateSelected(drevent);
                var eventArgs = new CustomCalendarEventArgs(drevent.Start);
                CustomCalendarEvent(this, eventArgs);
                Dispose();
            }

          
        }
    }

    /// <summary>
    /// Highlighted dates.
    /// </summary>
    public class HighlightedDates
    {
        #region Private fields

        private readonly DateTime _date;
        private Point _position = new Point(0, 0);
        private readonly Color _dateColor = Color.Empty;
        private readonly Color _boxColor = Color.Empty;
        private readonly Color _backgroundColor = Color.Empty;
        private readonly bool _isBold = true;

        #endregion

        /// <summary>
        ///   Constructor to create the instance of the date.
        /// </summary>
        /// <param name="date"> Date </param>
        public HighlightedDates(DateTime date)
        {
            _date = date;
        }

        /// <summary>
        ///   Constructor to create the instance.
        /// </summary>
        /// <param name="date"> Current date </param>
        /// <param name="dateColor"> Color of date. </param>
        /// <param name="isBold"> True if date should be bold else false. </param>
        public HighlightedDates(DateTime date, Color dateColor, bool isBold)
            : this(date)
        {
            _dateColor = dateColor;
            _isBold = isBold;
        }

        public HighlightedDates(DateTime date, Color dateColor, Color boxColor, Color backGroundColor, bool isBold)
            : this(date, dateColor, isBold)
        {
            _boxColor = boxColor;
            _backgroundColor = backGroundColor;
        }

        #region Public properties

        /// <summary>
        ///   Gets if the date is bold.
        /// </summary>
        public bool IsBold
        {
            get
            {
                return _isBold;
            }
        }

        /// <summary>
        ///   Gets the background color of the highlighted date.
        /// </summary>
        public Color BackgroundColor
        {
            get
            {
                return _backgroundColor;
            }
        }

        /// <summary>
        ///   Gets the box color of the highlighted date.
        /// </summary>
        public Color BoxColor
        {
            get
            {
                return _boxColor;
            }
        }

        /// <summary>
        ///   Gets the date color of highlighted date.
        /// </summary>
        public Color DateColor
        {
            get
            {
                return _dateColor;
            }
        }

        /// <summary>
        ///   Gets the date to be highlighted.
        /// </summary>
        public DateTime Date
        {
            get
            {
                return _date;
            }
        }

        /// <summary>
        ///   Gets or sets the position of the date.
        /// </summary>
        public Point Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }

        #endregion
    }

    /// <summary>
    ///   Custom event args class.
    /// </summary>
    public class CustomCalendarEventArgs : EventArgs
    {
        #region Private fields

        private DateTime _selectedDate;

        #endregion

        /// <summary>
        ///   Constructor to create the instance.
        /// </summary>
        /// <param name="selectedDate"> Selected date. </param>
        public CustomCalendarEventArgs(DateTime selectedDate)
        {
            _selectedDate = selectedDate;
        }

        /// <summary>
        ///   Gets the selected date for the event.
        /// </summary>
        public string SelectedDate
        {
            get
            {
                return _selectedDate.ToString("dd/MM/yyyy");
            }
        }
    }
}
