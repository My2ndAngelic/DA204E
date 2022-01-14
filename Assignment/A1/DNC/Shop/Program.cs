using System;

namespace Shop
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            var cashierOneItem = new CashierOneItem();
            Console.Clear();
            cashierOneItem.Start();
            Console.ReadLine();
        }
    }
}