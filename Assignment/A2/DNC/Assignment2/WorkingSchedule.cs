using System;

namespace Assignment2
{
    public class WorkingSchedule
    {
        private readonly string line = "----------------------";

        public WorkingSchedule()
        {
            Start();
        }

        /// <summary>
        ///     AAA
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
                    case 0:
                        break;
                    case 1:
                        ShowNight(1);
                        break;
                    case 2:
                        ShowNight(2);
                        break;
                    default:
                        Console.WriteLine("Illegal argument detected.");
                        break;
                }
            } while (choice != 0);

            Console.WriteLine(line);
        }

        /// <summary>
        ///     AAA
        /// </summary>
        /// <param name="option"></param>
        private static void ShowNight(int option)
        {
            int p = 0;
            switch (option)
            {
                case 1:
                {
                    for (int i = 1; i <= 52; i += 4)
                    {
                        p++;
                        Console.Write("{0,10} {1,2}", "Week", i);
                        if (p % 4 == 0 && p > 0)
                        {
                            Console.WriteLine();
                        }
                    }

                    break;
                }
                case 2:
                {
                    for (int i = 2; i <= 52; i += 4)
                    {
                        p++;
                        Console.Write("{0,10} {1,2}", "Week", i);
                        if (p % 4 == 0 && p > 0)
                        {
                            Console.WriteLine();
                        }
                    }

                    break;
                }
                default:
                    Console.WriteLine("Invalid argument detected.");
                    break;
            }

            Console.WriteLine();
        }

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