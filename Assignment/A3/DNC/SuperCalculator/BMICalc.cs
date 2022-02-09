namespace SuperCalculator
{
    public class BMICalc
    {
        private double height;
        private string name;
        private UnitType unit;
        private double weight;

        /// <summary>
        ///     Default constructor
        /// </summary>
        public BMICalc()
        {
            name = "No name";
            weight = 0.0;
            height = 0.0;
            unit = UnitType.Imperial;
        }

        /// <summary>
        ///     Debug constructor
        /// </summary>
        /// <param name="name">Name of person</param>
        /// <param name="weight">Weight of person</param>
        /// <param name="height">Height of person</param>
        /// <param name="unit">Unit of measurement</param>
        public BMICalc(string name, double weight, double height, UnitType unit)
        {
            this.name = name;
            this.weight = weight;
            this.height = height;
            this.unit = unit;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = !string.IsNullOrEmpty(name) ? name : "No name";
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public double GetWeight()
        {
            return weight;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }

        public UnitType GetUnitType()
        {
            return unit;
        }

        public void SetUnitType(UnitType unitType)
        {
            unit = unitType;
        }

        /// <summary>
        ///     Return BMI result, depending on the unit
        /// </summary>
        /// <returns>BMI result in double</returns>
        public double GetBMIResult()
        {
            return unit switch
            {
                UnitType.Metric => weight / (height * height),
                UnitType.Imperial => weight / (height * height) * 703.0,
                _ => 0.0
            };
        }

        /// <summary>
        ///     Return BMI category
        /// </summary>
        /// <returns>BMI category in string form</returns>
        public string GetBMICategory()
        {
            return _ = GetBMIResult() switch
            {
                > 40 => "Overweight (Obesity class III)",
                >= 35 and < 40 => "Overweight (Obesity class II)",
                >= 30 and < 35 => "Overweight (Obesity class I)",
                >= 25 and < 30 => "Overweight (Pre-obesity)",
                >= 18.5 and < 25 => "Normal weight",
                < 18.5 => "Underweight",
                _ => "Something is wrong"
            };
        }

        /// <summary>
        ///     Return normal weight
        /// </summary>
        /// <returns>Return normal weight in double array</returns>
        public double[] GetNormalWeight()
        {
            return new[]
            {
                18.5 * height * height / (GetUnitType() == UnitType.Imperial ? 703 : 1),
                24.9 * height * height / (GetUnitType() == UnitType.Imperial ? 703 : 1)
            };
        }

        /// <summary>
        ///     Convert weight to kg
        /// </summary>
        /// <returns>Weight in kg in double</returns>
        public double ToKg()
        {
            return unit switch
            {
                UnitType.Imperial => GetWeight() * 0.45359237, // 1 lb = 0.45359237 kg
                UnitType.Metric => GetWeight(),
                _ => 0.0
            };
        }

        /// <summary>
        ///     Convert height to m
        /// </summary>
        /// <returns>Height in m in double</returns>
        public double ToM()
        {
            return unit switch
            {
                UnitType.Imperial => GetHeight() * 0.0254, // 1 m = 2.54 cm
                UnitType.Metric => GetHeight(),
                _ => 0.0
            };
        }

        /// <summary>
        ///     Convert height to cm by calling ToM method
        /// </summary>
        /// <returns>Height in cm in double</returns>
        public double ToCM()
        {
            return ToM() * 100;
        }
    }
}