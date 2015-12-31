using System;
using System.Text.RegularExpressions;

namespace SHC.UROCare.Utilities
{
    /// <summary>
    ///   Enumerates the length of string types.
    /// </summary>
    public enum StringLength
    {
        Name = 20,
        Password = 10,
        Other = -1
    }

    /// <summary>
    ///   Enumerates the type of strings.
    /// </summary>
    public enum StringType
    {
        Name,
        EmailAddress,
        Password,
        Address,
    }

    public class StringValidation
    {
        #region Public methods

        /// <summary>
        ///   Validates given string for the given type.
        /// </summary>
        /// <param name="stringToValidate"> string to be validated. </param>
        /// <param name="type"> Type of the string. </param>
        /// <returns> True if string validates the required parameter </returns>
        public static bool Validate(string stringToValidate, StringType type)
        {
            if (null == stringToValidate)
            {
                ExceptionManager.Throw(new ArgumentNullException("stringToValidate"));
            }

            bool result = false;
            switch (type)
            {
                case StringType.Name:
                    result = ValidateName(stringToValidate);
                    break;
                case StringType.EmailAddress:
                    result = ValidateEmailAddress(stringToValidate);
                    break;
                case StringType.Address:
                    break;
                case StringType.Password:
                    result = ValidatePassword(stringToValidate);
                    break;
                default:
                    ExceptionManager.Throw(new ArgumentOutOfRangeException("type"));
                    break;
            }
            return result;
        }

        /// <summary>
        ///   Validates the length of the given string for the given type.
        /// </summary>
        /// <param name="stringToValidate"> String to be validated. </param>
        /// <param name="stringTypeLength"> Length type of the string. </param>
        /// <returns> True if the string length of the given string is valid for given type length. </returns>
        public static bool ValidateLength(string stringToValidate, StringLength stringTypeLength)
        {
            if (null == stringToValidate)
            {
                ExceptionManager.Throw(new ArgumentNullException());
            }

            int length = stringToValidate.Length;

            if (stringTypeLength != StringLength.Other)
            {
                if (length == 0)
                {
                    ExceptionManager.Throw(new InvalidLengthException());
                }
                else if (length > (int) stringTypeLength)
                {
                    ExceptionManager.Throw(new TooLongStringException());
                }
            }
            return true;
        }

        #endregion

        #region Private methods

        private static bool ValidateEmailAddress(string stringToValidate)
        {
            bool result = ValidateLength(stringToValidate, StringLength.Other);
            if (result)
            {
                const string matchEmailPattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                                                 +
                                                 @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                                                 +
                                                 @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                                                 + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
                result = Regex.IsMatch(stringToValidate, matchEmailPattern);
            }
            return result;
        }

        private static bool ValidateName(string stringToValidate)
        {
            bool result = ValidateLength(stringToValidate, StringLength.Name);
            if (result)
            {
                string name = stringToValidate.Trim();
                result = Regex.IsMatch(name, @"^[\p{L}\p{M}' \.\-]+$");
                if (result)
                {
                    name = name.Replace("'", "&#39;");
                }
            }
            return result;
        }

        private static bool ValidatePassword(string stringToValidate)
        {
            bool result = ValidateLength(stringToValidate, StringLength.Password);
            if (result)
            {
                const string passwordPattern = "((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})";
                result = Regex.IsMatch(stringToValidate, passwordPattern);
            }
            return result;
        }

        #endregion
    }
}