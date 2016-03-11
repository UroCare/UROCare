using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using UROCareServices.DataContracts;
using System.ServiceModel.Web;

namespace UROCareServices.ServiceContracts
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        [WebGet(UriTemplate="users",ResponseFormat=WebMessageFormat.Json)]
        List<User> getUsers();
        
        [OperationContract]
        [WebGet(UriTemplate = "users/{userId}", ResponseFormat = WebMessageFormat.Json)]
        User getUserById(String userId);
    }
}
