namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n" + new string('-', 70) + "\n");
            Console.WriteLine("Assignment 3 OOP");
            Console.WriteLine("\n" + new string('-',70) + "\n");

            #region  Part 01 : Theoretical Questions

            #region  Question 1 

            //Q1: Identify the type of relationship in each scenario below
            //(Inheritance, Association, Aggregation, Composition, or Dependency):

            //a) A University has Departments. If the university is closed, the departments no longer exist.
            //b) A Driver uses a Car.The driver does not own the car.
            //c) A Dog is an Animal.
            //d) A Team has Players. If the team is deleted, the players still exist.
            //e) A method receives a Logger as a parameter and calls it inside the method only.

            #endregion

            #region Question 2

            //Q2: Answer the following questions about access modifiers and sealed:

            //a) A parent class has a protected field.Can a child class in a different assembly access it?
            //What about through an object instance from outside?
            //b) What is the difference between protected internal and private protected?
            //c) What does the sealed keyword do when applied to a class? What about when applied to a method?
            //d) Can you create an object from a sealed class using new? Why or why not?

            #endregion

            #endregion

            #region  Part 02 : Practical

            //(Extending the Movie Ticket Booking System)
            //In Assignments 01 & 02, you built a Movie Ticket Booking System with a Ticket class,
            //properties, indexers, and static members.Now you will refactor and extend it using inheritance,
            //composition, and sealed classes.
            //What you need to build :

            #region 1. Create a base class Ticket

            //1. Create a base class Ticket with:
            //a.MovieName(string), Price(decimal, must be > 0), TicketId(int, read-only, auto-incremented).
            //b.A constructor that takes movieName and price.
            //c.A computed property PriceAfterTax that returns the price with 14% tax.
            //d.Override ToString() to return the ticket info.
            //e.A static int GetTotalTickets() method that returns the total number of tickets created.

            #endregion

            #region 2. Create three child classes

            //2. Create three child classes that inherit from Ticket:
            //a.StandardTicket — adds SeatNumber(string).
            //b.VIPTicket — adds LoungeAccess(bool) and ServiceFee(decimal) = 50.
            //c.IMAXTicket — adds Is3D(bool). If true, the price increases by 30 EGP.
            //Each child class should override ToString() to include its own extra info.

            #endregion

            #region 3. Create a Cinema class

            //3. Create a Cinema class that has a CinemaName, a Projector object (created inside Cinema),
            //and holds up to 20 tickets.Add:

            //a.AddTicket(Ticket t) — adds a ticket to the first available slot.
            //b.PrintAllTickets() — prints all tickets.
            //c.OpenCinema() and CloseCinema() — start/stop the projector.

            #endregion

            #region 4. In Main

            //4. In Main, do the following:
            //a.Create a Cinema and open it.
            //b.Create one of each ticket type (hardcoded data) and add them to the Cinema.
            //c.Print all tickets.
            //d.Close the Cinema.

            #endregion

            #endregion

            Console.WriteLine("\n" + new string('-', 70) + "\n");

        }
    }
}
