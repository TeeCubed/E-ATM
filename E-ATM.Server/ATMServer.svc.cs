using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using E_ATM.Library;

namespace E_ATM.Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ATMServer" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ATMServer.svc or ATMServer.svc.cs at the Solution Explorer and start debugging.
    public class ATMServer : IATMServer
    {
        private CardDetails GetCardByBIN(string BIN)
        {
            // Pull from Database
            var details = new CardDetails();
            details.BIN = BIN;

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

            return details;
        }

        public bool ValidateCard(string BIN)
        {
            var card = GetCardByBIN(BIN);

            if (card != null)
            {
                if (card.BIN != "0000000000000000" && card.BIN.Length == 16 && card.Status == CardStatus.Active)
                    return true;
            }

            return false;
        }

        public bool AuthorizeCard(string BIN, int pin)
        {
            // Pull from Database
            var details = new CardDetails();
            details.BIN = BIN;

            // Test data <<< To be populated in the Database once created - shouldn't be here!!! >>>
            switch (pin)
            {
                case 1234:
                    return true;
                default:
                    break;
            }

            return false;
        }

        public bool ChangePIN(string BIN, int pin)
        {
            // Pull from Database
            var details = new CardDetails();
            details.BIN = BIN;

            // if database update fails - return false

            details.PIN = pin;
            return true;
        }
    }
}
