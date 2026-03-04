using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Ticket
    { 
        // one
            //1. Create a base class Ticket with:
        
        
            //a.MovieName(string), Price(decimal, must be > 0), TicketId(int, read-only, auto-incremented).
        // Fields
        private string movieName;
        public string MovieName
        {
            get { return movieName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    movieName = value;
            }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public SeatLocation Seat { get; set; }
        
        // Ticket ID
        public int TicketId { get; }
        
        // Static counter
        private static int ticketCounter = 0;

        // Constructor
        //public Ticket(string movieName,  SeatLocation seat, decimal price)
        //{
        //    ticketCounter++;
        //    TicketId = ticketCounter;

        //    MovieName = movieName;
        //    
        //    Seat = seat;
        //    Price = price;
        //}
            
        //b.A constructor that takes movieName and price.
        
        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;

            ticketCounter++;
            TicketId = ticketCounter;
        }

            //c.A computed property PriceAfterTax that returns the price with 14% tax.
        public decimal PriceAfterTax
        {
            get
            {
                return Price * 1.14m;
            }
        }

            //e.A static int GetTotalTickets() method that returns the total number of tickets created.
        public static int GetTotalTickets()
        {
            return ticketCounter;
        }

            //d.Override ToString() to return the ticket info.
        //public override string ToString()
        //{
        //    return $"Ticket #{TicketId} | {MovieName} | Seat: {Seat} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        //}

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        }

    }

}
