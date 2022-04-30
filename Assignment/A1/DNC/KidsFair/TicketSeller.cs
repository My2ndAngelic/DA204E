using System;

namespace KidsFair
{
    public class TicketSeller
    {
        private const double Price = 100.00; // Big assumption from the given screenshot, normal price = 100
        private double amountToPay; // Total amount of payment  
        private string name; // Name of the buyer
        private int numOfAdults; // Number of tickets for adults
        private int numOfChildren; // Number of tickets for children

        /// <summary>
        ///     The Starting price
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Welcome to KIDS' FAIR!\nChildren always get a 75% discount");
            ReadAndSaveTickets();
            Console.WriteLine();
            DisplayTicketPrice();
        }

        /// <summary>
        ///     First method
        /// </summary>
        private void ReadAndSaveTickets()
        {
            ReadAndSaveName();
            ReadAndSaveAdult();
            ReadAndSaveChildren();
            CalculateTicketPrice();
        }

        /// <summary>
        ///     This method asks user to enter name and save it to the field
        /// </summary>
        private void ReadAndSaveName()
        {
            Console.WriteLine("Your name please: "); // Read and save buyer's name
            name = Console.ReadLine();
        }

        /// <summary>
        ///     This method asks user to enter number of adults and save it to the field
        /// </summary>
        private void ReadAndSaveAdult()
        {
            Console.WriteLine("Number of adults: "); // Read and save how many adults are there
            numOfAdults = int.Parse(Console.ReadLine());
        }

        /// <summary>
        ///     This method asks user to enter number of children and save it to the field
        /// </summary>
        private void ReadAndSaveChildren()
        {
            Console.WriteLine("Number of children: "); // Read and save how many children are there
            numOfChildren = int.Parse(Console.ReadLine());
        }

        /// <summary>
        ///     This method calculate ticket price save it to the field
        /// </summary>
        private void CalculateTicketPrice()
        {
            amountToPay =
                Price * (numOfAdults + 0.25 * numOfChildren); // Calculate the ticket price, 75% discount for children
        }

        /// <summary>
        ///     This method display the ticket price and some messages
        /// </summary>
        private void DisplayTicketPrice()
        {
            Console.WriteLine("+++ Your receipt +++");
            Console.WriteLine("+++ Amount to pay = " + amountToPay);
            Console.WriteLine();
            Console.WriteLine("+++ Thank you " + name + " and please come back! +++");
        }
    }
}
