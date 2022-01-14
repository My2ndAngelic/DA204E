using System;

namespace A1
{
    public class TicketSeller
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
		/// The Starting price
		/// </summary>
        public void Start()
        {
            Console.WriteLine("Welcome to KIDS' FAIR!\nChildren always get a 75% discount");
            ReadAndSaveTickets();
            Console.WriteLine();
            DisplayTicketPrice();
        }

        /// <summary>
		/// First method
		/// </summary>
        public void ReadAndSaveTickets()
        {
            ReadAndSaveName();
            ReadAndSaveAdult();
            ReadAndSaveChildren();
            CalculateTicketPrice();
        }

        /// <summary>
		/// This method asks user to enter name and save it to the field
		/// </summary>
        public void ReadAndSaveName()
        {
            Console.WriteLine("Your name please: "); // Read and save buyer's name
            name = Console.ReadLine();
        }

        /// <summary>
		/// This method asks user to enter number of adults and save it to the field
		/// </summary>
        public void ReadAndSaveAdult()
        {
            Console.WriteLine("Number of adults: "); // Read and save how many adults are there
            numOfAdults = int.Parse(Console.ReadLine());
        }

        /// <summary>
		/// This method asks user to enter number of children and save it to the field
		/// </summary>
        public void ReadAndSaveChildren()
        {
            Console.WriteLine("Number of children: "); // Read and save how many children are there
            numOfChildren = int.Parse(Console.ReadLine());
        }

        /// <summary>
		/// This method calculate ticket price save it to the field
		/// </summary>
        public void CalculateTicketPrice()
        {
            amountToPay = price * (numOfAdults + 0.25 * numOfChildren); // Calculate the ticket price, 75% discount for children
        }

        /// <summary>
		/// This method display the ticket price and some messages
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
