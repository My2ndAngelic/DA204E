using System;

namespace Shop
{
    class Program 
    { 
        static void Main(string[] args)
        {
            var cashierOneItem = new CashierOneItem();
            Console.Clear();
            cashierOneItem.Start();
            Console.ReadLine();
        }
    }
}