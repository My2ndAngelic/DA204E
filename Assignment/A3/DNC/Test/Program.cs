using System;
using SuperCalculator;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BMRCalc bmrCalc = new BMRCalc(new BMICalc("Apu", 150.0, 66, UnitType.Imperial), 66, true, 1);
            
            Console.WriteLine(10 * bmrCalc.ToKg() + 6.25 * bmrCalc.ToCM() - 5 * bmrCalc.GetAge() + 5);
        }
    }
}