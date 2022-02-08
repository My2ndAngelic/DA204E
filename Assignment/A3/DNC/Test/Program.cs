using System;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 69;
            Console.WriteLine(n is 69 or 420 ? "Nice" : "Hello World");
        }
    }
}