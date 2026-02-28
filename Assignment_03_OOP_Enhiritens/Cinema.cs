using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP_Enhiritens
{
    internal class Cinema
    {
        public string CinemaName { get; set; }

        private Projector Projector = new Projector();  

        private Ticket[] reservation = new Ticket[20];

        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
        }

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < reservation.Length; i++)
            {
                if (reservation[i] == null)
                {
                    reservation[i] = t;
                    return;
                }
               
            }

            Console.WriteLine("Cinema is full. Cannot add more tickets.");
        }

        public void PrintallTickets()
        {
            for (int i = 0; i < reservation.Length; i++)
            {

                if (reservation[i] != null)
                {
                    Console.WriteLine($"{reservation[i].ToString()}");
                }
                

               
            }
        }


        public void Opencinem()
        {
            Projector.turnOn();
        }

        public void CloseCinema()
        {
            Projector.turnOff();
        }
    }
}
