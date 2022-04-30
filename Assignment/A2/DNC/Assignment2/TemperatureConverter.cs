using System;

namespace Assignment2
{
    public class TemperatureConverter
    {
        /// <summary>
        ///     Constructor, launching 4 methods
        /// </summary>
        public TemperatureConverter()
        {
            Console.Clear();
            Start();
        }

        /// <summary>
        ///     Start the class
        /// </summary>
        public void Start()
        {
            int choice = -1;

            while (choice != 0)
            {
                ShowMenu();
                choice = int.Parse(Console.ReadLine()); // Pick the option from the user
                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        ShowTableC2F();
                        break;
                    case 2:
                        ShowTableF2C();
                        break;
                    default:
                        Console.WriteLine("Invalid option, try again");
                        break;
                }
            }
        }

        /// <summary>
        ///     Show the table from Celcius to Farenheit
        /// </summary>
        private void ShowTableC2F()
        {
            const int column = 2;
            const int max = 100;
            int p = 0;

            for (int i = 0; i <= max; i += 1)
            {
                double result = CelciusToFarenheit(i);
                Console.Write($"{i,6:f2} C = {result,6:f2} F    ");
                p++;

                if (p % column == 0 && p >= column) Console.WriteLine();
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Show the table from Farenheit to Celcius
        /// </summary>
        private void ShowTableF2C()
        {
            const int column = 2;
            const int max = 212;
            int p = 0;

            for (int i = 0; i <= max; i += 4)
            {
                double result = FarenheitToCelcius(i);

                Console.Write($"{i,6:f2} F = {result,6:f2} C    ");
                p++;

                if (p % column == 0 && p >= column) Console.WriteLine();
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Convert Celcius to Farenheit
        /// </summary>
        /// <param name="celcius">Celcius degree in double</param>
        /// <returns>Farenheit degree in double</returns>
        private double CelciusToFarenheit(double celcius)
        {
            return celcius * 1.8 + 32;
        }

        /// <summary>
        ///     Convert Farenheit to Celcius
        /// </summary>
        /// <param name="farenheit">Farenheit degree in double</param>
        /// <returns>Celcius degree in double</returns>
        private double FarenheitToCelcius(double farenheit)
        {
            return (farenheit - 32) / 1.8;
        }

        /// <summary>
        ///     Show the main menu for the temperature converter
        /// </summary>
        private void ShowMenu()
        {
            Console.WriteLine("----------------------" + Environment.NewLine + Environment.NewLine +
                              "Temperature converter" + Environment.NewLine + Environment.NewLine +
                              "----------------------");
            Console.WriteLine();

            string[] message = {"Exit", "Celcius to Farenheit", "Farenheit to Celcius"};
            for (int i = 0; i < message.Length; i++) Console.WriteLine("{0,-22}{1} {2}", message[i], ":", i);

            Console.WriteLine();
            Console.WriteLine("----------------------" + Environment.NewLine);
            Console.Write("Pick a number: 0, 1, 2: ");
        }
    }
}
