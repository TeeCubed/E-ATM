using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ATM.Library
{
    public class CardDetails
    {
        public string BIN { get; set; }
        public int PIN { get; set; }
        public CardStatus Status { get; set; }
    }
}
