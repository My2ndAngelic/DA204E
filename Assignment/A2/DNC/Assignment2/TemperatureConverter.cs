using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class TemperatureConverter
    {

        public TemperatureConverter()
        {
            Console.Clear();
            Start();
        }
        
        public void Start()
        {
            int choice = -1;

            while (choice != 0)
            {
                ShowMenu();

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0 : break;
                    case 1 : CelciusToFarenheit(69); break;
                    case 2 : FarenheitToCelcius(420); break;
                }
            }
        }
        private double CelciusToFarenheit(double celcius)
        {
            return celcius * 1.8 + 32;
        }

        private double FarenheitToCelcius(double farenheit)
        {
            return (farenheit - 32) / 1.8;
        }

        private void ShowMenu()
        {

        }

        private void UrMom()
        {
            
        }
    }
}
