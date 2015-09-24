using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using E_ATM.Library;

namespace E_ATM.Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IATMServer" in both code and config file together.
    [ServiceContract]
    public interface IATMServer
    {
        [OperationContract]
        bool ValidateCard(string BIN);

        [OperationContract]
        bool AuthorizeCard(string BIN, int pin);
    }
}
