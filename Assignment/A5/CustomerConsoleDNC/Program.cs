using System;
using BackendLibrary;

namespace CustomerConsoleDNC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Countries.Antigua_and_Barbuda.ToString().Replace("_"," "));
            Console.WriteLine(new Phone("69420").Number);
            Console.ReadLine();
        }
    }
}