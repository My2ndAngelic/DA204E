using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2
{
    public class TemperatureConverter
    {
        public TemperatureConverter()
        {
            Console.Clear();
            Start();
        }

        public void Start()
        {
            var choice = -1;

            while (choice != 0)
            {
                ShowMenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0: break;
                    case 1:
                        for (int i = 0; i <= 100; i++)
                        {
                            string s = string.Format("{0,6:f2} C = {1, 6:f2} F", i, CelciusToFarenheit(i));
                            Console.WriteLine(s);
                        }
                        break;
                    case 2:
                        for (int i = 0; i <= 100; i++)
                        {
                            string s = string.Format("{0,6:f2} F = {1, 6:f2} C", i, FarenheitToCelcius(i));
                            Console.WriteLine(s);
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="celcius"></param>
        /// <returns></returns>
        private double CelciusToFarenheit(double celcius)
        {
            return TempConvert(celcius, "C");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="farenheit"></param>
        /// <returns></returns>
        private double FarenheitToCelcius(double farenheit)
        {
            return TempConvert(farenheit, "F");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="sourceUnit"></param>
        /// <returns></returns>
        private static double TempConvert(double temp, string sourceUnit)
        {
            return Math.Pow((double)5 / 9, sourceUnit.Equals("F") ? 1 : 0) *
                   (
                       Math.Pow(-1, sourceUnit.Equals("F") ? 1 : 0) * 32 +
                       Math.Pow(1.8, !sourceUnit.Equals("F") ? 1 : 0) * temp
                   );
        }

        public static Func<string, double> TempConvert2 = s => Convert.ToDouble(s.Length);

        private void ShowMenu()
        {
            Console.WriteLine("Pick a number: 0, 1, 2");
        }

        private void UrMom()
        {
        }
    }
}