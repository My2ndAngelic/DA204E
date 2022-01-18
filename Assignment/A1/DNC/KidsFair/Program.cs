using System;

namespace KidsFair
{
    class Program
    {
        static void Main(string[] args)
        {
            PrepareConsolesLook();
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            var pet = new Pet(); // New Pet object
            pet.Start(); // Start
            Console.WriteLine("Press Enter for to start the next part.");
            Console.ReadLine();

            var ts = new TicketSeller(); // New TicketSeller object
            ts.Start();
            Console.WriteLine("Press Enter for to start the next part.");
            Console.ReadLine();

            var album = new Album(); // New Album object
            album.Start();
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }

        /// <summary>
        ///     Decorating the console
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