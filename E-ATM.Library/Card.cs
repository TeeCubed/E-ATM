using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace E_ATM.Library
{
    [DataContract]
    public class Card : ICard
    {
        public string BIN { get; set; }
    }
}
