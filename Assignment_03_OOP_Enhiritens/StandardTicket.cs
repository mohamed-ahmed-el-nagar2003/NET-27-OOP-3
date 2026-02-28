using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP_Enhiritens
{
    internal class StandardTicket : Ticket
    {
        
        public string _SeatNumber { get; set; }

        public StandardTicket(string seatNumber, string movieName, int price) : base(movieName, price)
        {
            _SeatNumber = seatNumber;
        }

        public override string ToString()
        {
            Console.WriteLine("=================Ticket Info=================");
            return $"Ticket ID : {_Id} | Movie Name : {_MovieName}  | Price : {Price} | Seat Number : {_SeatNumber}";
        }

    }
}
