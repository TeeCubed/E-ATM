using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ATM.Library
{
    public interface ICard
    {
        Guid Id { get; set; }
        int Pin { get; set; }
        Decimal Balance { get; set; }
        CardStatus Status { get; set; }
    }
}
