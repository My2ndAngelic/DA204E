using System;

namespace Calculator
{
    public class CashierOneItem
    {
        private string itemName;
        private double pricePerItem;
        private int quantity;
        private double total;
        private DateTime dateTime;

        public void Start()
        {
            ReadAndSaveItem();
            DisplayPrice();
        }

        private void ReadAndSaveItem()
        {
            ReadAndSaveItemName();
            ReadAndSaveQuantity();
            ReadAndSavePricePerItem();
            CalculateTotal();
            SetDateTime();
        }

        private void ReadAndSavePricePerItem()
        {
            Console.WriteLine("What is the price per " + itemName + "?");
            pricePerItem = double.Parse(Console.ReadLine());
        }

        private void ReadAndSaveQuantity()
        {
            Console.WriteLine("How many " + itemName + " that you are buying?");
            quantity = int.Parse(Console.ReadLine());
        }

        private void ReadAndSaveItemName()
        {
            Console.WriteLine("What is the item name that you are buying?");
            itemName = Console.ReadLine();
        }

        private void CalculateTotal()
        {
            total = pricePerItem * quantity;
        }

        private void SetDateTime()
        {
            dateTime = DateTime.Now;
        }

        private void DisplayPrice()
        {
            Console.WriteLine("===================");
            Console.WriteLine("Name: " + itemName);
            Console.WriteLine("Price: " + pricePerItem);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Total payment: " + total);
            Console.WriteLine("Printed: " + dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine();
            Console.WriteLine("Thank you for shopping with BnL. See you later!");
            Console.WriteLine("==================");
        }
    }
}