using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DockerWcf.Host
{
    [ServiceContract]
    public interface IStringService
    {
        [OperationContract]
        string Upper(string str);
        [OperationContract]
        int Length(string str);
    }

}
