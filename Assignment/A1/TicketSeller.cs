using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1
{
    class TicketSeller
    {
        /**
         * Private fields
         */
        private string name; 
        private double price = 100.00; // Big assumption from the given screenshot, normal price = 100
        private int numOfAdults; 
        private int numOfChildren; 
        private double amountToPay; 

        public void Start()
        {
            Console.WriteLine("Welcome to KIDS' FAIR!\nChildren always get a 75% discount");
            ReadAndSaveTickets();
            Console.WriteLine();
            DisplayTicketPrice();
        }

        public void ReadAndSaveTickets()
        {
            ReadAndSaveName();
            ReadAndSaveAdult();
            ReadAndSaveChildren();
            CalculateTicketPrice();
        }

        public void ReadAndSaveName()
        {
            Console.WriteLine("Your name please: "); // Read and save buyer's name
            name = Console.ReadLine();
        }

        public void ReadAndSaveAdult()
        {
            Console.WriteLine("Number of adults: "); // Read and save how many adults are there
            numOfAdults = int.Parse(Console.ReadLine());
        }

        public void ReadAndSaveChildren()
        {
            Console.WriteLine("Number of children: "); // Read and save how many children are there
            numOfChildren = int.Parse(Console.ReadLine());
        }

        public void CalculateTicketPrice()
        {
            amountToPay = price * (numOfAdults + 0.25 * numOfChildren); // Calculate the ticket price, 75% discount for children
        }

        public void DisplayTicketPrice()
        {
            Console.WriteLine("+++ Your receipt +++");
            Console.WriteLine("+++ Amount to pay = " + amountToPay);
            Console.WriteLine();
            Console.WriteLine("+++ Thank you " + name + " and please come back! +++");
        }
    }
}
