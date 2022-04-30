namespace SuperCalculator
{
    public class BMRCalc : BMICalc
    {
        private int age;
        private bool gender; // T: male, F: female
        private int group;

        /// <summary>
        ///     Default constructor
        /// </summary>
        public BMRCalc()
        {
            age = 0;
            gender = true;
            group = 0;
        }

        /// <summary>
        ///     Constructor with BMI calc initiated
        /// </summary>
        /// <param name="bmiCalc">Data from BMICalc</param>
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

        /// <summary>
        ///     Constructor with all the parameter
        /// </summary>
        /// <param name="bmiCalc">Data from BMICalc</param>
        /// <param name="age">Age</param>
        /// <param name="gender">Gender (M/F) = (T/F)</param>
        /// <param name="group">Weekly activity level group (0 - 4)</param>
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

        /// <summary>
        ///     Return calories to gain or lose weight after factored gender, age and activity level
        /// </summary>
        /// <param name="calories">Calories entered</param>
        /// <returns>Calories after addition</returns>
        public double GetCalories(double calories)
        {
            return GetFactoredBMR() + calories;
        }

        /// <summary>
        ///     Returned BMR after factored gender, age and weekly activity level
        /// </summary>
        /// <returns>Factored BMR</returns>
        private double GetFactoredBMR()
        {
            return group switch
            {
                0 => 1.2 * GetMinBMR(),
                1 => 1.375 * GetMinBMR(),
                2 => 1.550 * GetMinBMR(),
                3 => 1.725 * GetMinBMR(),
                4 => 1.9 * GetMinBMR(),
                _ => 0.0 * GetMinBMR()
            };
        }

        /// <summary>
        ///     Return minimum BMR depending on gender and age
        /// </summary>
        /// <returns>BMR depending on gender</returns>
        public double GetMinBMR()
        {
            double baseBMR = 10 * ToKg() + 6.25 * ToCM() - 5 * GetAge();
            return gender ? baseBMR + 5 : baseBMR - 161;
        }

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
