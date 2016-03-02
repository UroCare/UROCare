using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SHC.UROCare.Utilities;
using SHC.UROCare.UROCareDataModel;

namespace SHC.UROCare.UROCareBusinessObjects
{
    /// <summary>
    /// Business object for doctor list.
    /// </summary>
    public class DoctorsListBO : IPersistable<Doctors_List>
    {
        #region Public Properties

        /// <summary>
        /// Get or set doctor id.
        /// </summary>
        public int DoctorId { get; set; }

        /// <summary>
        /// Get or set doctor name.
        /// </summary>
        public string DoctorName { get; set; }

        /// <summary>
        /// Get or Set At Post.
        /// </summary>
        public string AtPost { get; set; }

        /// <summary>
        /// Get or set Taluka.
        /// </summary>
        public string Taluka { get; set; }

        /// <summary>
        /// Get or Set district.
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// Get or Set Phone.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Get or Set Mobile Number.
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// Get or set Birth Date.
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Get or set Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the patient record created by.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets creation date of patient record.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the modified by information of patient record.
        /// </summary>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets modified date of the record.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        #endregion

        #region IPersistable Imlementation

        public void MapFromObjectToDatabaseEntity(Doctors_List databaseObject)
        {

        }

        public int Save(IUROCareEntities dataContext)
        {
            return 0;
        }

        public int Save()
        {
            int result = -1;
            using (var dataContext = DataAccessLayer.GetDataContext())
            {
                Save(dataContext);
                result = dataContext.SaveChanges();
            }
            return result;
        }

        public void MapDatabaseValueToObject(Doctors_List doctor)
        {
            if (doctor == null)
            {
                throw (new ArgumentNullException("doctor"));
            }
            DoctorId = doctor.ID;
            DoctorName = doctor.Doctor_Name;
            AtPost = doctor.At_Post;
            Taluka = doctor.Taluka;
            District = doctor.District;
            PhoneNumber = doctor.Phone;
            MobileNumber = doctor.Mobile;
            BirthDate = doctor.Birth_Dte.GetValueOrDefault();
            Email = doctor.Dr_Email;
           
            CreatedBy = doctor.Created_By;
            CreatedDate = doctor.Create_Dte;
            ModifiedBy = doctor.Modify_By;
            ModifiedDate = doctor.Modify_Dte;
        }

        public override string ToString()
        {
            return this.DoctorName;
        }

        #endregion
    }

    public class DoctorsListObjectCollection : BusinessObjectCollection<DoctorsListBO, Doctors_List>
    {
        #region Public Methods

        public override void Fill()
        {
            using (var dataContext = DataAccessLayer.GetDataContext())
            {
                FillCollection(dataContext.Doctors_List);
            }
        }

        #endregion
    }
}
