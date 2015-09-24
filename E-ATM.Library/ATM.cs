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
		private ATMServerClient atmServer;
	
        public Double UserInput { get; set; }
        public String UserString { get; set; }
		public ATMState State { get; set; }

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

        public bool AuthorizeLogin(ICard insertedCard, int pin)
        {
            if (pin.ToString().Length == 4)
                return atmServer.AuthorizeCard(insertedCard.BIN, pin);

            return false;
        }

        public void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
