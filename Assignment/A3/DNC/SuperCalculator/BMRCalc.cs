using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculator
{
    public class BMRCalc : BMICalc
    {
        private int age;
        private bool gender; // T: male, F: female
        private double factor;

        public BMRCalc()
        {
            age = 0;
            gender = true;
            factor = 1.2;
        }
        
        public BMRCalc(BMICalc bmiCalc) : base(bmiCalc.GetName(), bmiCalc.GetWeight(), bmiCalc.GetHeight(), bmiCalc.GetUnitType())
        {
            age = 0;
            gender = true;
            factor = 1.2;
        }

        public string ExtractName()
        {
            return GetName();
        }

        public double ToKg()
        {
            return GetUnitType() == UnitType.Metric ? GetWeight() : GetWeight() * 0.45359237;
        }

        public double ToM()
        {
            return GetUnitType() == UnitType.Metric ? GetHeight() : GetHeight() * 0.0254;
        }
        
        public int GetBMR()
        {
            return 0;
        }

        public BMRCalc(int age, bool gender, double factor)
        {
            this.age = age;
            this.gender = gender;
            this.factor = factor;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age >= 0 ? age : 0;
        }

        public bool GetGender()
        {
            return gender;
        }

        public void SetGender(bool gender)
        {
            this.gender = gender;
        }

        public double GetFactor()
        {
            return factor;
        }

        public void SetFactor(double factor)
        {
            this.factor = factor;
        }
    }
}
