using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UROCareServices.DataContracts
{
    [DataContract]
    public class User
    {
        [DataMember]
        public String Name { get; set; }
    }
}
