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
    interface IUserService
    {
        [OperationContract]
        [WebInvoke (Method="Get", UriTemplate="users")]
        List<User> getUsers();
    }
}
