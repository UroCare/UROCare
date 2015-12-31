using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SHC.UROCare.UICommonControls
{
    public class AutoCompleteComboBox : CustomComboBox
    {
        #region Private fields

        private bool _inEditMode;
        private bool _limitToList = true;

        #endregion

        #region Cancel event handler

        public CancelEventHandler NotInList;

        #endregion

        /// <summary>
        /// Gets or sets Limit to list.
        /// </summary>
        [Category("Behavior")]
        public bool LimitToList
        {
            get
            {
                return _limitToList;
            }
            set
            {
                _limitToList = value;
            }
        }

        #region Protected overrides

        protected virtual void OnNotInList(CancelEventArgs e)
        {
            if (NotInList != null)
            {
                NotInList(this, e);
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.TextChanged"/> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data.</param>
        protected override void OnTextChanged(EventArgs e)
        {
            if (_inEditMode)
            {
                string input = Text;
                int index = FindString(input);

                if (index >= 0)
                {
                    _inEditMode = false;
                    SelectedIndex = index;
                    _inEditMode = true;
                    Select(input.Length, Text.Length);
                }
            }

            base.OnTextChanged(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Validating"/> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.ComponentModel.CancelEventArgs"/> that contains the event data. </param>
        protected override void OnValidating(CancelEventArgs e)
        {
            if (LimitToList)
            {
                int pos = FindStringExact(Text);

                if (pos == -1)
                {
                    OnNotInList(e);
                }
                else
                {
                    SelectedIndex = pos;
                }
            }

            base.OnValidating(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.KeyDown"/> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.KeyEventArgs"/> that contains the event data. </param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            _inEditMode = (e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete);
            base.OnKeyDown(e);
        }

        #endregion
    }
}