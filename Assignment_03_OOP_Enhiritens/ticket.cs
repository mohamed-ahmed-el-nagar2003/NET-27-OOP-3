using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP_Enhiritens
{
    internal class Ticket
    {
        public string _MovieName { get; set; }

        private int _Price;
        public int Price
        {
            get
            {
                return _Price;
            }
            set
            {
                if (0 < value)
                    _Price = value;
                else
                    throw new ArgumentException("Price must be > 0");
            }
        }

        public int _Id { get; }

        private static int counter = 0;

        public Ticket(string movieName, int price)
        {
            _MovieName = movieName;
            _Price = price;
            counter++;
            _Id = counter;
        }

        public double PriceAfterTax => _Price + (_Price * .14);

        public override string ToString()
        {
            Console.WriteLine("=================Ticket Info=================");
            return $"Ticket ID : {_Id} | Movie Name : {_Price}  | Price : {_Price} ";
        }

        public static int GetTotalTickets()
        {
            return counter;
        }
    }
}
