using System;
using System.Management;

namespace SHC.UROCare.Utilities
{
    public class LicenseManager
    {
        #region Private constants

        private const string _passPhrase = "{2DAD812D-0637-4b26-943F-8B28C088B14F}";
        private const string _initVector = "@1B2c3D4e5F6g7H8";
        private const string _trialLicenseProcessorId = "UROCare";
        private const string _trialUserName = "Trial_User";
        private static readonly Encryptor _encryptor = new Encryptor(_passPhrase, _initVector);

        #endregion

        /// <summary>
        ///   Validates the license key of the product.
        /// </summary>
        public static void ValidateLicneseKey()
        {
            string currentKey = ReadCurrentKey();

            if (IsTrialKey(currentKey) && !IsTrialPeriodValid())
            {
                ExceptionManager.Throw(new TrialPeriodExpiredException());
            }
            else if (!IsValidUserKey(currentKey))
            {
                ExceptionManager.Throw(new InvalidLicenseKeyException());
            }
        }

        #region Private methods

        /// <summary>
        ///   Is the current key for trial period.
        /// </summary>
        /// <param name="currentKey"> Current key stored in database. </param>
        /// <returns> True if the key is valid for the trial period. </returns>
        private static bool IsTrialKey(string currentKey)
        {
            string trialKey = _encryptor.Decrypt(currentKey);
            return trialKey.Equals(string.Format("{0}{1}", _trialUserName, _trialLicenseProcessorId),
                                   StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        ///   Validates if the trial period is valid.
        /// </summary>
        /// <returns> </returns>
        private static bool IsTrialPeriodValid()
        {
            return true;
        }

        /// <summary>
        /// </summary>
        /// <param name="currentKey"> </param>
        /// <returns> </returns>
        private static bool IsValidUserKey(string currentKey)
        {
            string userName = ReadUserName();
            string processerId = GetProcessorSerialNumber();
            string decryptor = _encryptor.Decrypt(currentKey);
            return decryptor.Equals(string.Format("{0}{1}", userName, processerId),
                                    StringComparison.InvariantCultureIgnoreCase);
        }

        private static string GetProcessorSerialNumber()
        {
            string sProcessorId = string.Empty;
            const string sQuery = "SELECT ProcessorId FROM Win32_Processor";
            var managementObjectSearcher = new ManagementObjectSearcher(sQuery);
            ManagementObjectCollection managementObjects = managementObjectSearcher.Get();
            foreach (ManagementObject managementObject in managementObjects)
            {
                sProcessorId = managementObject["ProcessorId"].ToString();
                break;
            }
            return sProcessorId;
        }

        private static string ReadCurrentKey()
        {
            const string currentKey = "qYgU62me8gdUXz5jwR1ycF39SlHVHSTeQWLZksZhso8=";
            return currentKey;
        }

        private static string ReadUserName()
        {
            const string userName = "UROCare";
            return userName;
        }

        #endregion
    }
}