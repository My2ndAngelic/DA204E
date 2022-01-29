using System;
using SuperCalculator;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BMICalc bmi = new BMICalc("John", 69, 1.69, UnitType.Metric);
            Console.WriteLine(bmi.GetNormalWeight()[0]);

        }
    }
}
