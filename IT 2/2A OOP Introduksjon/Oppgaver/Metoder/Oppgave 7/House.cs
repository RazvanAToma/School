using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_7
{
    internal class House
    {
        public string Address { get; set; }
        public int Floors { get; set; }
        public int Rooms { get; set; }

        public House(string address, int floors, int rooms)
        {
            Address = address;
            Floors = floors;
            Rooms = rooms;
        }

        public void Info()
        {
            Console.WriteLine($"Huset på adressen {Address}, har {Floors} etasjer og {Rooms} rom.");
        }
    }
}
