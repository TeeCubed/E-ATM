using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ATM.Library
{
    public class ATM : IATM
    {
        private CardDetails card;

        /// <summary>
        /// Pull card details from database based on provided BIN.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        private void PullCardDetails(ICard insertedCard)
        {
            // Pull from Database
            var details = new CardDetails();
            details.BIN = insertedCard.BIN;

            // Test data <<< To be populated in the Database once created - shouldn't be here!!! >>>
            switch (details.BIN)
            {
                case "1234123412341234":
                    details.Status = CardStatus.Active;
                    break;
                case "1234123412341235":
                    details.Status = CardStatus.Blocked;
                    break;
                case "1234123412341236":
                    details.Status = CardStatus.Cancelled;
                    break;
                case "1234123412341237":
                    details.Status = CardStatus.Expired;
                    break;
                default:
                    break;
            }

            // Set ATM's current card
            card = details;
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
                PullCardDetails(insertedCard);
                if (card != null)
                {
                    if (card.BIN != "0000000000000000" && card.BIN.Length == 16 && card.Status == CardStatus.Active)
                        return true;
                }

                return false;
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
