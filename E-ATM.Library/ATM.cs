using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_ATM.Library.ATMServer;

namespace E_ATM.Library
{
    public class ATM : IATM
    {
        private CardDetails card;
        private ATMServerClient atmServer;

        public ATM()
        {
            atmServer = new ATMServerClient();
        }

        /// <summary>
        /// Validate card when inserted.
        /// </summary>
        /// <param name="insertedCard"></param>
        /// <returns></returns>
        public bool ValidateCard(ICard insertedCard)
        {
            if (insertedCard != null)
            {
                return atmServer.ValidateCard(insertedCard.BIN);
            }

            return false;
        }

        public bool AuthorizeLogin(int pin)
        {
            if (card.PIN == pin)
                return true;

            return false;
        }

        public void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
