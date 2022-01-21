using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SelectionAndIteration sai = new SelectionAndIteration();
            
            TemperatureConverter tc = new TemperatureConverter();
            tc.Start();
        }
    }
}
