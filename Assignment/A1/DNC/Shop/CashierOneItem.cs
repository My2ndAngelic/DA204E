using System;
using System.Globalization;

namespace Shop
{
    /// <summary>
    ///     Store and display receipt info
    /// </summary>
    public class CashierOneItem
    {
        private DateTime dateTime;
        private string itemName;
        private double pricePerItem;
        private int quantity;
        private double total;

        /// <summary>
        ///     Launcher
        /// </summary>
        public void Start()
        {
            Welcome();
            ReadAndSaveItem();
            DisplayPrice();
        }

        /// <summary>
        ///     Display welcome messages from the shop.
        /// </summary>
        private static void Welcome()
        {
            Console.WriteLine("Welcome to BnL!");
            Console.WriteLine("Buy N Large is your super store.");
            Console.WriteLine("We got all you need and so much more.");
            Console.WriteLine();
        }

        /// <summary>
        ///     Read and save user item info
        /// </summary>
        private void ReadAndSaveItem()
        {
            ReadAndSaveItemName();
            ReadAndSaveQuantity();
            ReadAndSavePricePerItem();
            CalculateTotal();
            SetDateTime();
        }

        /// <summary>
        ///     Read and save item price once
        /// </summary>
        private void ReadAndSavePricePerItem()
        {
            Console.WriteLine("What is the price per " + itemName + "?");
            pricePerItem =
                double.Parse(Console.ReadLine(),
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture); // Parsing double input, any number style, regional independent
        }

        /// <summary>
        ///     Read and save how many user wants to buy
        /// </summary>
        private void ReadAndSaveQuantity()
        {
            Console.WriteLine("How many " + itemName + "(s) " + "that you are buying?");
            quantity = int.Parse(Console.ReadLine()); // Parsing integer input, possibly throwing exceptions
        }

        /// <summary>
        ///     Read and save the item name
        /// </summary>
        private void ReadAndSaveItemName()
        {
            Console.WriteLine("What is the item name that you are buying?");
            itemName = Console.ReadLine(); // Saving item name
        }

        /// <summary>
        ///     Calculate total payment
        /// </summary>
        private void CalculateTotal()
        {
            total = pricePerItem * quantity;
        }

        /// <summary>
        ///     Save the printing receipt date
        /// </summary>
        private void SetDateTime()
        {
            dateTime = DateTime.Now; // Saving time
        }

        /// <summary>
        ///     Display the receipt
        /// </summary>
        private void DisplayPrice()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Item: {0}", itemName);
            Console.WriteLine("Price: {0}", pricePerItem);
            Console.WriteLine("Quantity: {0}", quantity);
            Console.WriteLine("Total payment: {0}", total);
            Console.WriteLine("Printed: {0:yyyy-MM-dd HH:mm:ss}", dateTime);
            Console.WriteLine();
            Console.WriteLine("Thank you for shopping with BnL. See you later!");
            Console.WriteLine("==================");
        }
    }
}