using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHC.UROCare.UROCareDataModel;
using System.Security.Cryptography;

namespace SHC.UROCare.TestObjects
{
    public static class TestDataModelObjects
    {
        #region Public Methods

        /// <summary>
        /// Get random number
        /// </summary>
        /// <param name="max">Max</param>
        /// <returns>Number</returns>
        public static int GetRandomNumber(int max)
        {
            Random getrandom = new Random();
            object syncLock = new object();
            return getrandom.Next(1, max);
        }

        /// <summary>
        /// Get random string
        /// </summary>
        /// <param name="length">String length</param>
        /// <returns>String</returns>
        public static string GetRandomString(int length)
        {
            Byte[] seedBuffer = new Byte[4];
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rngCryptoServiceProvider.GetBytes(seedBuffer);
                string charString = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                Random random = new Random(BitConverter.ToInt32(seedBuffer, 0));
                return new string(Enumerable.Repeat(charString, length).Select(selectString => selectString[random.Next(selectString.Length)]).ToArray());
            }
        } 

        /// <summary>
        /// Get test patient
        /// </summary>
        /// <returns>Returns patient info object</returns>
        public static Patient_Info GetTestPatient()
        {
            Patient_Info testPatient = new Patient_Info();
            testPatient.Gu_No = GetRandomNumber(2);
            testPatient.Gu_Year = GetRandomNumber(4);
            testPatient.Salutation = "Mr";
            testPatient.Patient_Name = GetRandomString(8);
            testPatient.At_Post = GetRandomString(15);
            testPatient.Town = GetRandomString(4);
            testPatient.District = GetRandomString(4);
            testPatient.State = GetRandomString(8);
            testPatient.Phone = GetRandomNumber(4).ToString();
            testPatient.Mobile = GetRandomNumber(4).ToString();
            testPatient.Age_Yr = 33;
            testPatient.Age_Mnth = 11;
            testPatient.Sex = 0;
            testPatient.Occupation = GetRandomString(4);
            testPatient.Doctors_List = GetTestDoctor();

            testPatient.OPD_Diagnosis = GetRandomString(14);

            testPatient.Created_By = "created user";
            testPatient.Create_Dte = DateTime.Today;
            testPatient.Modify_By = "modified user";
            testPatient.Modify_Dte = DateTime.Today;

            return testPatient;
        }

        /// <summary>
        /// Get test doctor
        /// </summary>
        /// <returns>Returns patient info object</returns>
        public static Doctors_List GetTestDoctor()
        {
            Doctors_List testDoctor = new Doctors_List();
            testDoctor.ID = GetRandomNumber(2);
            testDoctor.Doctor_Name = GetRandomString(8);
            testDoctor.At_Post = GetRandomString(15);
            testDoctor.Taluka = GetRandomString(10);
            testDoctor.District = GetRandomString(4);
            testDoctor.Phone =  GetRandomNumber(4).ToString();
            testDoctor.Mobile = GetRandomNumber(4).ToString();
            testDoctor.Birth_Dte = DateTime.Today;
            testDoctor.Dr_Email = string.Format("{0}@aaaa.com",GetRandomString(4));
           
            testDoctor.Created_By = "created user";
            testDoctor.Create_Dte = DateTime.Today;
            testDoctor.Modify_By = "modified user";
            testDoctor.Modify_Dte = DateTime.Today;

            return testDoctor;
        }

        #endregion
    }
}
