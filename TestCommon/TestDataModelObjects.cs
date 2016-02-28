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
        #region Private Methods

        public static int GetRandomNumber(int max)
        {
            Random getrandom = new Random();
            object syncLock = new object();
            lock (syncLock)
            { // synchronize
                return getrandom.Next(1, max);
            }
        }


        private static string GetRandomString(int length)
        {
            System.Byte[] seedBuffer = new System.Byte[4];
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rngCryptoServiceProvider.GetBytes(seedBuffer);
                string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                Random random = new System.Random(System.BitConverter.ToInt32(seedBuffer, 0));
                return new System.String(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            }
        } 


        #endregion
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
            testPatient.Town = "Pune";
            testPatient.District = "Pune";
            testPatient.State = "Maharashtra";
            testPatient.Phone = GetRandomNumber(4).ToString();
            testPatient.Mobile = GetRandomNumber(4).ToString();
            testPatient.Age_Yr = 33;
            testPatient.Age_Mnth = 11;
            testPatient.Sex = 0;
            testPatient.Occupation = "service";
            testPatient.Doctors_List = GetTestDoctor();

            testPatient.OPD_Diagnosis = "test diagnosis";

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
            testDoctor.District = "Amravati";
            testDoctor.Phone =  GetRandomNumber(4).ToString();
            testDoctor.Mobile = GetRandomNumber(4).ToString();
            testDoctor.Birth_Dte = DateTime.Today;
            testDoctor.Dr_Email = "aaa@aaa.com";
           
            testDoctor.Created_By = "created user";
            testDoctor.Create_Dte = DateTime.Today;
            testDoctor.Modify_By = "modified user";
            testDoctor.Modify_Dte = DateTime.Today;

            return testDoctor;
        }
    }
}
