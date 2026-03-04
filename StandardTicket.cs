using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class StandardTicket : Ticket
    {
        //2. Create three child classes that inherit from Ticket:
        //a.StandardTicket — adds SeatNumber(string).
        //Each child class should override ToString() to include its own extra info.

        public string SeatNumber { get; set; }

        public StandardTicket(string movieName, decimal price, string seatNumber): base(movieName, price)
        {
            SeatNumber = seatNumber;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Seat: {SeatNumber}";
        }
    }
}
