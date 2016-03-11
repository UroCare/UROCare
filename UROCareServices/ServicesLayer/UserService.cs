using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UROCareServices.DataContracts;
using UROCareServices.ServiceContracts;

namespace UROCareServices.ServicesLayer
{
    public class UserService:IUserService
    {
        public List<DataContracts.User> getUsers()
        {
            return new List<User>(){
                new User{Name="TestUser"}
            };
        }

        public User getUserById(string userId)
        {
            return new User() { Name = "TestUser2" };
        }

    }
}
