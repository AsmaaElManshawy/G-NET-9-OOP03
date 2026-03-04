using System;
using System.Net.Sockets;

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
            // Composition (Strong ownership — lifecycle dependent)
            //b) A Driver uses a Car.The driver does not own the car.
            //Association (Weak relationship — no ownership)
            //c) A Dog is an Animal.
            // Inheritance (Is-a relationship)
            //d) A Team has Players. If the team is deleted, the players still exist.
            //Aggregation (Weak ownership — lifecycle independent)
            //e) A method receives a Logger as a parameter and calls it inside the method only.
            //Dependency (Temporary relationship — method-level)
            #endregion

            #region Question 2

            //Q2: Answer the following questions about access modifiers and sealed:

            //a) A parent class has a protected field.Can a child class in a different assembly access it?
            //What about through an object instance from outside?

            //A child class in a different assembly can access a protected field,
            //but only through inheritance, not through an object instance from outside. 
            //Protected members are accessible within the class and by derived classes, but not through instances of the class.

            //b) What is the difference between protected internal and private protected?

            //Protected internal allows access from derived classes or any class within the same assembly,
            //while private protected allows access only from derived classes within the same assembly.

            //c) What does the sealed keyword do when applied to a class? What about when applied to a method?

            //When applied to a class, the sealed keyword prevents other classes from inheriting from it.
            //When applied to a method, it prevents derived classes from overriding that method.

            //d) Can you create an object from a sealed class using new? Why or why not?

            // Yes, you can create objects normally using new. You just cannot inherit from it.

            #endregion

            #endregion

            #region  Part 02 : Practical

            /*
            //(Extending the Movie Ticket Booking System)
            //In Assignments 01 & 02, you built a Movie Ticket Booking System with a Ticket class,
            //properties, indexers, and static members.Now you will refactor and extend it using inheritance,
            //composition, and sealed classes.
            //What you need to build :
            */

            #region 4. In Main

            //4. In Main, do the following:

            //a.Create a Cinema and open it.
            Cinema cinema = new Cinema("Galaxy Cinema");

            cinema.OpenCinema();

            //b.Create one of each ticket type (hardcoded data) and add them to the Cinema.
            Ticket t1 = new StandardTicket("Inception", 120m, "A-5");
            Ticket t2 = new VIPTicket("Avengers", 200m, true);
            Ticket t3 = new IMAXTicket("Dune", 180m, false);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            //c.Print all tickets.
            cinema.PrintAllTickets();

            // Generate and print 2 booking references.
            Console.WriteLine($"\nBooking References 1: {BookingHelper.GenerateBookingReference()}");
            Console.WriteLine($"Booking References 2: {BookingHelper.GenerateBookingReference()}");

            // Calculate and print the group discount for a group of 5 tickets at 80 EGP each of them.
            decimal discount = BookingHelper.CalcGroupDiscount(5, 100m);
            Console.WriteLine($"\nGroup Discount (5 tickets x 100 EGP): {discount} EGP (10% off)");
         

            //d.Close the Cinema.
            cinema.CloseCinema();

            #endregion

            #endregion

            Console.WriteLine("\n" + new string('-', 70) + "\n");

        }
    }
}
