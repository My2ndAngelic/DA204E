using System;

namespace Shop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            CashierOneItem cashierOneItem = new CashierOneItem();
            cashierOneItem.Start();

            Console.ReadLine();
        }
    }
}
