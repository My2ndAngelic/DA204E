using System;
using SuperCalculator;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            BMICalc bmic = new BMICalc("John", 69, 1.69, UnitType.Metric);
            BMRCalc bmrc = new BMRCalc();
            bmrc.SetName("John");
            Console.WriteLine(bmrc.ExtractName());
        }
    }
}