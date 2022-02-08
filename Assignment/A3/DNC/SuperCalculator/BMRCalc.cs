using System;

namespace SuperCalculator
{
    public class BMRCalc : BMICalc
    {
        private int age;
        private bool gender; // T: male, F: female
        private int group;

        public BMRCalc()
        {
            age = 0;
            gender = true;
            group = 0;
        }

        public BMRCalc(BMICalc bmiCalc) :
            base(bmiCalc.GetName(),
                bmiCalc.GetWeight(),
                bmiCalc.GetHeight(),
                bmiCalc.GetUnitType())
        {
            age = 0;
            gender = true;
            group = 0;
        }

        public BMRCalc(BMICalc bmiCalc, int age, bool gender, int group) :
            base(bmiCalc.GetName(),
                bmiCalc.GetWeight(),
                bmiCalc.GetHeight(),
                bmiCalc.GetUnitType())
        {
            this.age = age;
            this.gender = gender;
            this.group = group;
        }

        public BMRCalc(int age, bool gender, int group)
        {
            this.age = age;
            this.gender = gender;
            this.group = group;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="calories"></param>
        /// <returns></returns>
        public double GetCalories(double calories)
        {
            return GetFactoredBMR() + calories;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public double GetFactoredBMR()
        {
            return group switch
            {
                0 => 1.2 * GetMinBMR(),
                1 => 1.375 * GetMinBMR(),
                2 => 1.550 * GetMinBMR(),
                3 => 1.725 * GetMinBMR(),
                4 => 1.9 * GetMinBMR(),
                _ => throw new ArgumentException("Not yet implemented")
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetMinBMR()
        {
            double baseBMR = 10 * ToKg() + 6.25 * ToCM() - 5 * GetAge();
            return gender ? baseBMR + 5 : baseBMR - 161;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public bool GetGender()
        {
            return gender;
        }

        public void SetGender(bool gender)
        {
            this.gender = gender;
        }

        public int GetGroup()
        {
            return group;
        }

        public void SetGroup(int group)
        {
            this.group = group;
        }
    }
}