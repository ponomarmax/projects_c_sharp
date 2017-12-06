using System;
using System.ServiceModel;

namespace Ensure_Agent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEnsure_Agent
    {
        [OperationContract]
        string AddClaim(int sum_of_ensure, DateTime start_data, DateTime end_data, int group, string passport, out decimal cost);
    }
}
