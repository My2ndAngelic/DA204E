using System;

namespace Assignment2
{
    public class TemperatureConverter
    {
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
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        for (var i = 0; i <= 100; i++)
                        {
                            var s = $"{i,6:f2} C = {CelciusToFarenheit(i),6:f2} F";
                            Console.WriteLine(s);
                        }

                        break;
                    case 2:
                        for (var i = 0; i <= 212; i++)
                        {
                            var s = $"{i,6:f2} F = {FarenheitToCelcius(i),6:f2} C";
                            Console.WriteLine(s);
                        }

                        break;
                }
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
            }
        }

        /// <summary>
        ///     Convert Celcius to Farenheit
        /// </summary>
        /// <param name="farenheit">Celcius degree in double</param>
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
            Console.Write("Pick a number: 0, 1, 2: ");
        }
    }
}