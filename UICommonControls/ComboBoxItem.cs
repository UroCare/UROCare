using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHC.UROCare.UICommonControls
{
    /// <summary>
    /// Combo box item
    /// </summary>
    public class ComboBoxItem
    {
        #region Public Properties

        public int ID { get; set; }
        public string Text { get; set; }
        public object Value { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="textProperty">Text to display</param>
        /// <param name="objectValue">Object to store</param>
        public ComboBoxItem(int id, Func<String> textProperty, Object objectValue)
        {
            ID = id;
            Text = textProperty();
            Value = objectValue;
        }

        #endregion

        #region Public Method

        /// <summary>
        /// Override string to display
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return Text;
        }

        #endregion               
    } 
}
