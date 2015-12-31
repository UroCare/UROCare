using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHC.UROCare.UROCareBusinessObjects
{
    public enum URORoles
    {
        None = 0,
        Admin = 1,
        Owner = 2,
        Data = 3
    }

    public class UserRole
    {
        public static URORoles GetRole(int roleId)
        {
            URORoles role = URORoles.None;
            switch(roleId)
            {
            case 1:
                role = URORoles.Admin;
                break;
            case 2:
                role = URORoles.Owner;
                break;
            case 3:
                role = URORoles.Data;
                break;
            }
            return role;
        }

        public static string GetRoleString(URORoles role)
        {
            string roleString = "None";
            switch (role)
            {
            case URORoles.Admin:
                roleString = "Admin";
                break;
            case URORoles.Owner:
                roleString = "Project Owner";
                break;
            case URORoles.Data:
                roleString = "Data Entry";
                break;
            }
            return roleString;
        }

        public static int GetRoleInteger(URORoles role)
        {
            int roleInteger = 0;
            switch (role)
            {
            case URORoles.Admin:
                roleInteger = 1;
                break;
            case URORoles.Owner:
                roleInteger = 2;
                break;
            case URORoles.Data:
                roleInteger = 3;
                break;
            }
            return roleInteger;
        }
    }
}
