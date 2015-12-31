using System;
using System.Runtime.Serialization;

namespace SHC.UROCare.Utilities
{
    public class LicenseKeyExcpetion : Exception
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="T:System.Exception" /> class.
        /// </summary>
        public LicenseKeyExcpetion()
        {
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message.
        /// </summary>
        /// <param name="message"> The message that describes the error. </param>
        public LicenseKeyExcpetion(string message) : base(message)
        {
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message"> The error message that explains the reason for the exception. </param>
        /// <param name="innerException"> The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public LicenseKeyExcpetion(string message, Exception innerException) : base(message, innerException)
        {
        }

      
    }

    public class InvalidLicenseKeyException : LicenseKeyExcpetion
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="T:System.Exception" /> class.
        /// </summary>
        public InvalidLicenseKeyException()
        {
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message.
        /// </summary>
        /// <param name="message"> The message that describes the error. </param>
        public InvalidLicenseKeyException(string message) : base(message)
        {
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message"> The error message that explains the reason for the exception. </param>
        /// <param name="innerException"> The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public InvalidLicenseKeyException(string message, Exception innerException) : base(message, innerException)
        {
        }

      
    }

    public class TrialPeriodExpiredException : LicenseKeyExcpetion
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="T:System.Exception" /> class.
        /// </summary>
        public TrialPeriodExpiredException()
        {
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message.
        /// </summary>
        /// <param name="message"> The message that describes the error. </param>
        public TrialPeriodExpiredException(string message) : base(message)
        {
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message"> The error message that explains the reason for the exception. </param>
        /// <param name="innerException"> The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public TrialPeriodExpiredException(string message, Exception innerException) : base(message, innerException)
        {
        }

      
    }
}