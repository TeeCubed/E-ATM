using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ATM.Library
{
    public class Card : ICard
    {
        public Guid Id { get; set; }
        public int Pin { get; set; }
        public decimal Balance { get; set; }
        public CardStatus Status { get; set; }
        public String Bin { get; set; }
    }
}
