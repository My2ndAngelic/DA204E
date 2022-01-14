using System;

namespace A1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrepareConsolesLook();
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            Pet pet = new(); // New Pet object
            pet.Start(); // Start
            Console.WriteLine("Press Enter for to start the next part.");
            Console.ReadLine();

            TicketSeller ts = new();  // New TicketSeller object
            ts.Start();
            Console.WriteLine("Press Enter for to start the next part.");
            Console.ReadLine();

            Album album = new(); // New Album object
            album.Start(); 
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();

        }

        /// <summary>
        /// 
        /// </summary>
        static void PrepareConsolesLook()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "KIDS' FAIR";
        }
    }
}
