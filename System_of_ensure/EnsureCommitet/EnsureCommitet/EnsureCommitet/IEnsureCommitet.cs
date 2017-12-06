using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EnsureCommitet
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEnsureCommitet
    {

        [OperationContract]
        int Request(string id, int amount);

        [OperationContract]
        bool Is_Crime(string id);

        [OperationContract]
        bool Enought_Money(int amount);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    
}
