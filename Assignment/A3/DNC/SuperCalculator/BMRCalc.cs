namespace SuperCalculator
{
    public class BMRCalc : BMICalc
    {
        private int age;
        private bool isMale; // T: male, F: female
        private int group;

        /// <summary>
        ///     Default constructor
        /// </summary>
        public BMRCalc()
        {
            age = 0;
            isMale = true;
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
            isMale = true;
            group = 0;
        }

        /// <summary>
        ///     Constructor with all the parameter
        /// </summary>
        /// <param name="bmiCalc">Data from BMICalc</param>
        /// <param name="age">Age</param>
        /// <param name="isMale">Gender (M/F) = (T/F)</param>
        /// <param name="group">Weekly activity level group (0 - 4)</param>
        public BMRCalc(BMICalc bmiCalc, int age, bool isMale, int group) :
            base(bmiCalc.GetName(),
                bmiCalc.GetWeight(),
                bmiCalc.GetHeight(),
                bmiCalc.GetUnitType())
        {
            this.age = age;
            this.isMale = isMale;
            this.group = group;
        }

        /// <summary>
        ///     Return calories to gain or lose weight after factored isMale, age and activity level
        /// </summary>
        /// <param name="calories">Calories entered</param>
        /// <returns>Calories after addition</returns>
        public double GetCalories(double calories)
        {
            return GetFactoredBMR() + calories;
        }

        /// <summary>
        ///     Returned BMR after factored isMale, age and weekly activity level
        /// </summary>
        /// <returns>Factored BMR</returns>
        public double GetFactoredBMR()
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
        ///     Return minimum BMR depending on isMale and age
        /// </summary>
        /// <returns>BMR depending on isMale</returns>
        public double GetMinBMR()
        {
            double baseBMR = 10 * ToKg() + 6.25 * ToCM() - 5 * GetAge();
            return isMale ? baseBMR + 5 : baseBMR - 161;
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
            return isMale;
        }

        public void SetGender(bool gender)
        {
            this.isMale = gender;
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