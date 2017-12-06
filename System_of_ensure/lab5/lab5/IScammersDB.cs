using System.ServiceModel;

namespace lab5
{
    [ServiceContract]
    public interface IScammersDB
    {
        /// <summary>
        /// Checks for scammers in the database
        /// </summary>
        /// <param name="user">Series and  number of passport</param>
        /// <returns>if exists, returns true</returns>
        [OperationContract]
        bool CheckUser(string user);
    }
    
}
