using System;

namespace Shop
{
    public class CashierOneItem
    {
        /// <summary>
        /// Private fields
        /// </summary>
        private DateTime dateTime;
        private string itemName;
        private double pricePerItem;
        private int quantity;
        private double total;

        /// <summary>
        /// Launcher
        /// </summary>
        public void Start()
        {
            ReadAndSaveItem();
            DisplayPrice();
        }
        
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        private void ReadAndSavePricePerItem()
        {
            Console.WriteLine("What is the price per " + itemName + "?");
            pricePerItem = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// 
        /// </summary>
        private void ReadAndSaveQuantity()
        {
            Console.WriteLine("How many " + itemName + " that you are buying?");
            quantity = int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// 
        /// </summary>
        private void ReadAndSaveItemName()
        {
            Console.WriteLine("What is the item name that you are buying?");
            itemName = Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateTotal()
        {
            total = pricePerItem * quantity;
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetDateTime()
        {
            dateTime = DateTime.Now;
        }

        /// <summary>
        /// Display the receipt out
        /// </summary>
        private void DisplayPrice()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Name: " + itemName);
            Console.WriteLine("Price: " + pricePerItem);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Total payment: $" + total);
            Console.WriteLine("Printed: " + dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine();
            Console.WriteLine("Thank you for shopping with BnL. See you later!");
            Console.WriteLine("==================");
        }
    }
}