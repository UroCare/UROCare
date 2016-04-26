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
            testPatient.Reg_Date = DateTime.Today;
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
            testPatient.Urology_History.Add(GetTestUrologyHistory());

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
        /// <returns>Returns doctors list object</returns>
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

        /// <summary>
        /// Get test urology history object
        /// </summary>
        /// <returns>Returns urology history data object</returns>
        public static Urology_History GetTestUrologyHistory()
        {
            Urology_History urologyHistory = new Urology_History();
            urologyHistory.History_ID = GetRandomNumber(2);
            urologyHistory.Patient_ID = GetRandomNumber(2);
            urologyHistory.Gu_No = GetRandomNumber(2);
            urologyHistory.Gu_Year = GetRandomNumber(4);
            urologyHistory.Chief_Compl = GetRandomString(2);
            urologyHistory.Frequency = GetRandomString(2);
            urologyHistory.Hesitancy = GetRandomString(2);
            urologyHistory.Nocturia = GetRandomString(2);
            urologyHistory.Poor_Stream = GetRandomString(2);
            urologyHistory.Urgency = GetRandomString(2);
            urologyHistory.Intermittency = GetRandomString(2);
            urologyHistory.Dysuria = GetRandomString(2);
            urologyHistory.Straining = GetRandomString(2);
            urologyHistory.Pyuria = GetRandomString(2);
            urologyHistory.Sense_Incompl_Void = GetRandomString(2);
            urologyHistory.Lithiuria = GetRandomString(2);
            urologyHistory.Terminal_Dribbling = GetRandomString(2);
            urologyHistory.Chyluria = GetRandomString(2);
            urologyHistory.Urge_Inc = GetRandomString(2);
            urologyHistory.Fever = GetRandomString(2);
            urologyHistory.Stress_Inc = GetRandomString(2);
            urologyHistory.IPSS = GetRandomString(2);
            urologyHistory.BPI = GetRandomString(2);
            urologyHistory.Pain = GetRandomString(2);
            urologyHistory.Others = GetRandomString(2);
            urologyHistory.Medication = GetRandomString(2);
            urologyHistory.Personal = GetRandomString(2);
            urologyHistory.Surgery = GetRandomString(2);
            urologyHistory.MH = GetRandomString(2);
            urologyHistory.Allergies = GetRandomString(2);
            urologyHistory.OB_GY = GetRandomString(2);
            urologyHistory.Past = GetRandomString(2);
            urologyHistory.Family = GetRandomString(2);
            urologyHistory.Hematuria = GetRandomString(2);

            urologyHistory.Created_By = "created user";
            urologyHistory.Create_Dte = DateTime.Today;
            urologyHistory.Modify_By = "modified user";
            urologyHistory.Modify_Dte = DateTime.Today;

            return urologyHistory;
        }

        #endregion
    }
}
