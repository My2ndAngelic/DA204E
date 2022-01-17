using System;

namespace Shop
{
    class Program 
    { 
        static void Main(string[] args)
        {
            Console.Clear();
            
            var cashierOneItem = new CashierOneItem();
            cashierOneItem.Start();
            
            Console.ReadLine();
        }
    }
}