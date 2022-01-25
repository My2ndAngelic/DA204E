using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BMICalculator.BMICalc bmi = new BMICalculator.BMICalc("John", 69, 1.69, BMICalculator.UnitType.Metric);
            Console.WriteLine(bmi.BMIResult());

        }
    }
}
