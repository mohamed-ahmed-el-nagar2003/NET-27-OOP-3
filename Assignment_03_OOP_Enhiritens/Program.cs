namespace Assignment_03_OOP_Enhiritens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            //Identify the type of relationship in each scenario below (Inheritance, Association, Aggregation, Composition, or Dependency):

            /*
             a) A University has Departments. If the university is closed, the departments no longer exist. // Composition
             b) A Driver uses a Car. The driver does not own the car.  // Association
             c) A Dog is an Animal. //  Inheritance
             d) A Team has Players. If the team is deleted, the players still exist.  // Aggregation
             e) A method receives a Logger as a parameter and calls it inside the method only. // Dependency

             */
            #endregion

            #region Q2

            //a) A parent class has a protected field. Can a child class in a different assembly access it? What about through an object instance from outside?
            /*
              1 -  child class in a different assembly can access a protected field inside itself.
              2 -  Cannot access it through an object instance from outside.
             */


            //b) What is the difference between protected internal and private protected?
            /*
                Protected internal: accessible in same assembly OR in any child class in any assembly.
                private protected: accessible only in child classes within the same assembly.
             */


            //c) What does the sealed keyword do when applied to a class? What about when applied to a method?
            /*
             sealed class: cannot be inherited .
             Sealed method: cannot be overridden in derived classes.
             */

            //d) Can you create an object from a sealed class using new? Why or why not?
            /*
             Yes, you can create an object normally.
             Reason: Sealed prevents inheritance only, it does not prevent instantiation.
             */


            #endregion


            #region Cinema System
            Cinema cinema01 = new Cinema("City");
            Console.WriteLine("===========================  Open Cinema  ==================================");
            cinema01.Opencinem();

            StandardTicket ST01 = new StandardTicket("A15", "Zaky Chann", 200);

            VipTicket VT01 = new VipTicket(true , "Zaky Chann" , 350) ;

            IMAXTicket IMAXT01 = new IMAXTicket("Harly", 400, true);

            cinema01.AddTicket(ST01);
            cinema01.AddTicket(VT01);
            cinema01.AddTicket(IMAXT01);

            Console.WriteLine("===========================  Print All Tickets ==================================");
            cinema01.PrintallTickets();

            Console.WriteLine("===========================  Close Cinema ==================================");
            cinema01.CloseCinema();

            Console.WriteLine("===========================  Statistics ==================================");

            Console.WriteLine($"Total Tickets :  {Ticket.GetTotalTickets()}");

            #endregion
        }
    }
}
