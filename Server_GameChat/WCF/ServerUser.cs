using System.ServiceModel;

namespace WCF
{
    internal class ServerUser
    {
        public string user_name { get; set; }
        public OperationContext operationContext { get; set; }
    }
}
