using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class IMAXTicket : Ticket
    {
        //2. Create three child classes that inherit from Ticket:
        //c.IMAXTicket — adds Is3D(bool). If true, the price increases by 30 EGP.
        //Each child class should override ToString() to include its own extra info.

        public bool Is3D { get; set; }

        public IMAXTicket(string movieName, decimal price, bool is3D)
            : base(movieName, is3D ? price + 30m : price)
        {
            Is3D = is3D;
        }

        public override string ToString()
        {
            string type = Is3D ? "Yes" : "No";
            return base.ToString() + $" | IMAX 3D: {type}";
        }
    }
}
