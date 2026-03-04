using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal sealed class VIPTicket : Ticket
    {
        //2. Create three child classes that inherit from Ticket:
        //b.VIPTicket — adds LoungeAccess(bool) and ServiceFee(decimal) = 50.
        //Each child class should override ToString() to include its own extra info.

        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50m;

        public VIPTicket(string movieName, decimal price, bool loungeAccess)
            : base(movieName, price + 50m)
        {
            LoungeAccess = loungeAccess;
        }

        public override string ToString()
        {
            string lounge = LoungeAccess ? "Yes" : "No";
            return base.ToString() + $" | Lounge: {lounge} | Service Fee: {ServiceFee} EGP";
        }
    }
}
