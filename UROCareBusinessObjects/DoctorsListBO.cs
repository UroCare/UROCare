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

        public void MapDatabaseValueToObject(Doctors_List databaseObject)
        {
            this.DoctorId = databaseObject.ID;
            this.DoctorName = databaseObject.Doctor_Name;
            this.AtPost = databaseObject.At_Post;
            this.Taluka = databaseObject.Taluka;
            this.District = databaseObject.District;
            this.PhoneNumber = databaseObject.Phone;
            this.MobileNumber = databaseObject.Mobile;
            this.BirthDate = databaseObject.Birth_Dte.GetValueOrDefault();
            this.Email = databaseObject.Dr_Email;
           
            this.CreatedBy = databaseObject.Created_By;
            this.CreatedDate = databaseObject.Create_Dte;
            this.ModifiedBy = databaseObject.Modify_By;
            this.ModifiedDate = databaseObject.Modify_Dte;
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
