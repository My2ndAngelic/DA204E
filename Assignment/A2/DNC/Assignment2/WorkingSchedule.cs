using System;

namespace Assignment2
{
    public class WorkingSchedule
    {
        private const string line = "----------------------"; // A line

        /// <summary>
        ///     Constructor
        /// </summary>
        public WorkingSchedule()
        {
            Start();
        }

        /// <summary>
        ///     Main method
        /// </summary>
        private void Start()
        {
            int choice;
            do
            {
                bool attempt;
                do
                {
                    ShowMenu();
                    attempt = int.TryParse(Console.ReadLine(), out choice);
                } while (!attempt || choice is < 0 or > 2);

                switch (choice)
                {
                    case 0: // Exit
                        break;
                    case 1: // Weekends
                        ShowWeek(1);
                        break;
                    case 2: // Nights
                        ShowWeek(2);
                        break;
                    default:
                        Console.WriteLine("Illegal argument detected."); // Just for safety
                        break;
                }
            } while (choice != 0);

            Console.WriteLine(line);
        }

        /// <summary>
        ///     Show what weeks need to be there
        /// </summary>
        /// <param name="option">1 for weekends, 2 for nights</param>
        private void ShowWeek(int option)
        {
            switch (option)
            {
                case 1:
                {
                    PrintSchedule(1, 52, 4, 5);
                    break;
                }
                case 2:
                {
                    PrintSchedule(2, 52, 4, 5);
                    break;
                }
                default:
                    Console.WriteLine("Invalid argument detected.");
                    break;
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Display the formatted schedule
        /// </summary>
        /// <param name="startWeek">First week</param>
        /// <param name="endWeek">Final week</param>
        /// <param name="period">How many weeks need to be skipped</param>
        /// <param name="column">How many columns of the schedule</param>
        public void PrintSchedule(int startWeek, int endWeek, int period, int column)
        {
            int p = 0;
            for (int i = startWeek; i <= endWeek; i += period)
            {
                p++;
                Console.Write("{0,10} {1,2}", "Week", i);
                if (p % column == 0 && p > 0) Console.WriteLine();
            }
        }

        /// <summary>
        ///     Main menu
        /// </summary>
        private void ShowMenu()
        {
            Console.WriteLine(line + Environment.NewLine +
                              "0 Exit." + Environment.NewLine +
                              "1 Show a list of weekends to work." + Environment.NewLine +
                              "2 Show a list of nights to work." + Environment.NewLine);
            Console.Write("Your choice: ");
        }
    }
}