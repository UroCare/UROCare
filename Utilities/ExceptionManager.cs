using System;

namespace SHC.UROCare.Utilities
{

    /// <summary>
    /// Provides static methods to assist with exception handling.
    /// </summary>
    public sealed class ExceptionManager
    {
        #region Public methods

        /// <summary>
        /// A static method to throw exceptions.
        /// </summary>
        /// <param name="exception">The exception to be thrown.</param>
        /// <remarks>
        /// Use this method to throw the exception with no logging.
        /// </remarks>
        /// <exception cref="ArgumentNullException">A null parameter was supplied.</exception>
        public static void Throw(Exception exception)
        {
            // Validate arguments
            if (null == exception)
            {
                Throw(new ArgumentNullException("Exception"));
            }
            else
            {
                throw exception;
            }
        }

        #endregion
    }

    public sealed class NoRecordFoundException : ApplicationException
    {
        public NoRecordFoundException()
            : base("No Records Found")
        {
        }

        public NoRecordFoundException(string value)
            : base(String.Format("{0}-{1}", "No Records Found", value))
        {
        }

        public NoRecordFoundException(Exception innerException)
            : base(string.Format("No Records Found"), innerException)
        {
            if (null == innerException)
            {
                ExceptionManager.Throw(new ArgumentNullException("innerException"));
            }
        }

    }
}