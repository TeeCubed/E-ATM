using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ATM.Library
{
    public class ATM : IATM
    {
        public Double UserInput { get; set; }
        public String UserString { get; set; }
        public ATMState State { get; set; }

        public bool ValidateCard(ICard card)
        {
            if (card.Id != Guid.Empty && card.Status == CardStatus.Active && card.Bin.Length == 16)
                return true;

            return false;
        }

        public bool AuthorizeLogin(ICard card, int pin)
        {
            if (card.Pin == pin)
                return true;

            return false;
        }

        public void Withdraw(ICard card, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
