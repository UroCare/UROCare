using System;
using SHC.UROCare.Utilities;

namespace SHC.UROCare.UI
{
    /// <summary>
    /// Class represents context of patient node.
    /// </summary>
    public class PatientContext
    {
        #region Private fields

        private readonly uint _guNumber;
        private readonly uint _guYear;
        private bool _isDirty;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor to creat instance.
        /// </summary>
        /// <param name="guYear">Year of the patient registeration.</param>
        /// <param name="guNumber">Number of the patient.</param>
        public PatientContext(uint guYear, uint guNumber) : this(guYear, guNumber, null)
        {
        }

        /// <summary>
        /// Constructor to create instance.
        /// </summary>
        /// <param name="guYear">Year of the patient registeration.</param>
        /// <param name="guNumber">Number of the patient.</param>
        /// <param name="description">Description of the context.</param>
        public PatientContext(uint guYear, uint guNumber, string description)
        {
            if (guYear == 0)
            {
                ExceptionManager.Throw(new ArgumentException("guNumber"));
            }
            if (guNumber == 0)
            {
                ExceptionManager.Throw(new ArgumentException("guNumber"));
            }
            _guYear = guYear;
            _guNumber = guNumber;
            Description = description;
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets GuYear of the context.
        /// </summary>
        public uint GuYear
        {
            get
            {
                return _guYear;
            }
        }

        /// <summary>
        /// Gets or sets GuNumber or the context.
        /// </summary>
        public uint GuNumber
        {
            get
            {
                return _guNumber;
            }
        }

        /// <summary>
        /// Gets or sets Description of context.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets if the context is dirty.
        /// </summary>
        public bool IsDirty
        {
            get
            {
                return _isDirty;
            }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Sets dirty flag for context.
        /// </summary>
        public void SetDirty()
        {
            _isDirty = true;
        }

        /// <summary>
        /// Checks equality for given context.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(PatientContext other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return (other.GuYear == GuYear && other.GuNumber == GuNumber && other.Description == Description);
        }

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
        /// </returns>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>. </param><filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != typeof (PatientContext))
            {
                return false;
            }
            return Equals((PatientContext) obj);
        }

        /// <summary>
        /// Serves as a hash function for a particular type. 
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            unchecked
            {
                var result = (int) GuYear;
                result = (result*397) ^ (int) GuNumber;
                result = (result*397) ^ (Description != null ? Description.GetHashCode() : 0);
                return result;
            }
        }

        public static bool operator ==(PatientContext left, PatientContext right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PatientContext left, PatientContext right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}