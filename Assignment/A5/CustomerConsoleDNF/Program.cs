using System;
using BackendLibrary;

namespace CustomerConsoleDNF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            // Console.WriteLine(Countries.Antigua_and_Barbuda.ToString().Replace("_", " "));
            // Console.WriteLine(new Email("a@a.com").IsValidPersonalMail());
            // Console.ReadLine();
            Console.Clear();
            // string a = Console.ReadLine();
            // Console.WriteLine(a == "42069" || a == "69420" ? "Hello World" : "Goodbye World");
            // Contact c = new Contact("John", "Cena", new Address("", "", "", Countries.Afghanistan), new Email("john@gmail.com", "cena@gmail.com"),
            //     new Phone("+69 420"));
            // Customer cu = new Customer(c);
            // CustomerManager cm = new CustomerManager();
            // cm.Add(cu);
            // cm.Add(cu);
            // cm.Add(cu);
            // cm.Add(cu);
            // cm.Add(cu);
            // foreach (string customer in cm.GetCustomers())
            // {
            //     Console.WriteLine(customer);
            // }
            // Customer c = new Customer();
            // string s = null;
            // Console.WriteLine();
            // Console.WriteLine(c.Contact.FName == null);
            Console.WriteLine(new Address("", "", "", Countries.Afghanistan).IsValidCountry());
        }
    }
}
