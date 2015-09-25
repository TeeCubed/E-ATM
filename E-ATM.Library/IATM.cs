using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace E_ATM.Library
{
    public interface IATM
    {
        ATMState State { get; set; }
        bool ValidateCard(ICard card);
        bool AuthorizeLogin(ICard card, int pin);
        void Withdraw(ICard card, decimal amount);
        bool ChangePin(ICard card, int pin);
    }
}
