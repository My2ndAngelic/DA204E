using System;
using BackendLibrary;

namespace CustomerConsoleDNF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Countries.Antigua_and_Barbuda.ToString().Replace("_", " "));
            Console.WriteLine(new Email("a@a.com").IsValidPersonalMail());
            Console.ReadLine();
        }
    }
}