using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHC.UROCare.UROCareDataModel;

namespace SHC.UROCare.TestObjects
{
    public static class TestDataModelObjects
    {
        /// <summary>
        /// Get test patient
        /// </summary>
        /// <returns>Returns patient info object</returns>
        public static Patient_Info GetTestPatient()
        {
            Patient_Info testPatient = new Patient_Info();
            testPatient.Gu_No = 1;
            testPatient.Gu_Year = 2015;
            testPatient.Salutation = "Mr";
            testPatient.Patient_Name = "nilesh";
            testPatient.At_Post = "Atul Nagar";
            testPatient.Town = "Pune";
            testPatient.District = "Pune";
            testPatient.State = "Maharashtra";
            testPatient.Phone = "66425646";
            testPatient.Mobile = "9881230729";
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
            testDoctor.ID = 1;
            testDoctor.Doctor_Name = "testDoctor";
            testDoctor.At_Post = "Ganesh Vihar";
            testDoctor.Taluka = "Amravati";
            testDoctor.District = "Amravati";
            testDoctor.Phone = "66425646";
            testDoctor.Mobile = "9881230729";
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
