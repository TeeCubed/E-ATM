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
        bool ValidateCard(ICard insertedCard);
        bool AuthorizeLogin(ICard insertedCard, int pin);
        void Withdraw(decimal amount);
    }
}
