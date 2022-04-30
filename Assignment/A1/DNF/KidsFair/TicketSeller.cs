using System;

namespace A1
{
    class TicketSeller
    {
        /// <summary>
		/// Private fields
		/// </summary>
        private string name; 
        private double price = 100.00; // Big assumption from the given screenshot, normal price = 100
        private int numOfAdults; 
        private int numOfChildren; 
        private double amountToPay; 

        /// <summary>
		/// 
		/// </summary>
        public void Start()
        {
            Console.WriteLine("Welcome to KIDS' FAIR!\nChildren always get a 75% discount");
            ReadAndSaveTickets();
            Console.WriteLine();
            DisplayTicketPrice();
        }

        /// <summary>
		/// 
		/// </summary>
        public void ReadAndSaveTickets()
        {
            ReadAndSaveName();
            ReadAndSaveAdult();
            ReadAndSaveChildren();
            CalculateTicketPrice();
        }

        /// <summary>
		/// 
		/// </summary>
        public void ReadAndSaveName()
        {
            Console.WriteLine("Your name please: "); // Read and save buyer's name
            name = Console.ReadLine();
        }

        /// <summary>
		/// 
		/// </summary>
        public void ReadAndSaveAdult()
        {
            Console.WriteLine("Number of adults: "); // Read and save how many adults are there
            numOfAdults = int.Parse(Console.ReadLine());
        }

        /// <summary>
		/// 
		/// </summary>
        public void ReadAndSaveChildren()
        {
            Console.WriteLine("Number of children: "); // Read and save how many children are there
            numOfChildren = int.Parse(Console.ReadLine());
        }

        /// <summary>
		/// 
		/// </summary>
        public void CalculateTicketPrice()
        {
            amountToPay = price * (numOfAdults + 0.25 * numOfChildren); // Calculate the ticket price, 75% discount for children
        }

        /// <summary>
		/// 
		/// </summary>
        public void DisplayTicketPrice()
        {
            Console.WriteLine("+++ Your receipt +++");
            Console.WriteLine("+++ Amount to pay = " + amountToPay);
            Console.WriteLine();
            Console.WriteLine("+++ Thank you " + name + " and please come back! +++");
        }
    }
}
