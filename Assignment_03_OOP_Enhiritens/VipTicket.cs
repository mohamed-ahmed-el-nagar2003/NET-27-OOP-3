using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP_Enhiritens
{
    internal class VipTicket : Ticket
    {
        public bool _LoungeAccess;
        public decimal ServiceFee = 50;

        public VipTicket(bool loungeAccess , string movieName, int price ): base(movieName , price + 50)
        {
            _LoungeAccess = loungeAccess;
        }

        public override string ToString()
        {
            Console.WriteLine("=================Ticket Info=================");
            return $"Ticket ID : {_Id} | Movie Name : {_MovieName}  | Price : {Price} | ServiceFee : {ServiceFee} | LoungeAccess : {_LoungeAccess}";
        }


    }
}
