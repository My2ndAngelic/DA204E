using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SuperCalculator.BMICalc bmi = new SuperCalculator.BMICalc("John", 69, 1.69, SuperCalculator.UnitType.Metric);
            Console.WriteLine(bmi.BMIResult());

        }
    }
}
