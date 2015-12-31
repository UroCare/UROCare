using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SHC.UROCare.Utilities;
using SHC.UROCare.UROCareDataModel;


namespace SHC.UROCare.UROCareBusinessObjects
{
    public class UserBO : IPersistable<User_Master>
    {
        #region Private fields

        private URORoles _currentUserRole;

        #endregion

        #region Public properties

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool ActiveUser { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public URORoles Role
        {
            get
            {
                return _currentUserRole;
            }
            set
            {
                _currentUserRole = value;
            }
        }

        #endregion

        #region Public Methods


        public void FillById(string userId)
        {
            if (String.IsNullOrEmpty(userId))
            {
                ExceptionManager.Throw(new ArgumentNullException("userId"));
            }
            using (var dataContext = DataAccessLayer.GetDataContext())
            {
                var user = GetFromDatabase(userId, dataContext);
                if (user == null)
                {
                    ExceptionManager.Throw(new NoRecordFoundException(userId));
                }
                MapDatabaseValueToObject(user);
            }
        }

        public bool IsExists(string userId)
        {
            using (var dataContext = DataAccessLayer.GetDataContext())
            {
                return IsExists(userId,dataContext);
            }            
        }

        #endregion

        #region IPersistable Imlementation

        public void MapDatabaseValueToObject(User_Master databaseObject)
        {
            this.UserId = databaseObject.User_Id;
            this.UserName = databaseObject.User_Name;
            this.Password = databaseObject.User_Pwd;
            this.ActiveUser = (databaseObject.Active_User=="Y"? true:false);
            this.CreatedBy = databaseObject.Created_By;
            this.CreatedDate = databaseObject.Create_Dte;
            this.ModifiedBy = databaseObject.Modify_By;
            this.ModifiedDate = databaseObject.Modify_Dte;
            Role = (URORoles)databaseObject.Role;
        }

        public void MapFromObjectToDatabaseEntity(User_Master databaseObject)
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
                result=dataContext.SaveChanges();
            }
            return result;
        }

        #endregion


        private User_Master GetFromDatabase(string userId, IUROCareEntities dataContext)
        {
            return dataContext.User_Master.FirstOrDefault(user => user.User_Id.Equals(userId, StringComparison.OrdinalIgnoreCase));
        }

        private bool IsExists(string userId, IUROCareEntities dataContext)
        {
            return dataContext.User_Master.Any(userMaster => userMaster.User_Id.Equals(userId, StringComparison.OrdinalIgnoreCase));
        }            
    }
}
