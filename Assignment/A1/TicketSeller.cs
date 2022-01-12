using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1
{
    class TicketSeller
    {
        private string name; 
        private double price = 100; 
        private int numOfAdults; 
        private int numOfChildren; 
        private double amountToPay; 

        public void Start()
        {
            ReadAndSaveTickets();
            DisplayTicketPrice();
        }

        public void ReadAndSaveTickets()
        {
            ReadAndSaveName();
            ReadAndSaveAdult();
            ReadAndSaveChildren();
        }

        public void ReadAndSaveName()
        {
            Console.WriteLine("Your name please: ");
            name = Console.ReadLine();
        }

        public void ReadAndSaveAdult()
        {
            Console.Write("How many adults? ");
            numOfAdults = int.Parse(Console.ReadLine());
        }

        public void ReadAndSaveChildren()
        {
            Console.Write("How many children? ");
            numOfChildren = int.Parse(Console.ReadLine());
        }

        public void CalculateTicketPrice()
        {
            amountToPay = numOfAdults*100 + numOfChildren*25;
        }

        public void DisplayTicketPrice()
        {
            Console.WriteLine("ur mom");
        }
    }
}
