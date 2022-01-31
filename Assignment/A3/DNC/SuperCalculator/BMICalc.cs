namespace SuperCalculator
{
    public class BMICalc
    {
        private double height;

        private string name;

        private UnitType unit;

        private double weight;

        public BMICalc()
        {
            name = "No name";
            weight = 0.0;
            height = 0.0;
            unit = UnitType.Imperial;
        }

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
            this.height = height >= 0 ? height : this.height;
        }

        public double GetWeight()
        {
            return weight;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight >= 0 ? weight : this.weight;
        }

        public UnitType GetUnitType()
        {
            return unit;
        }

        public void SetUnitType(UnitType unitType)
        {
            unit = unitType;
        }

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
        ///     Clicking the IDE randomly until it works
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
        public double[] GetNormalWeight()
        {
            return new[] {
                18.5 * height * height / (GetUnitType() == UnitType.Imperial ? 703 : 1), 
                24.9 * height * height / (GetUnitType() == UnitType.Imperial ? 703 : 1)
                };
        }

        public double ToKg()
        {
            return GetUnitType() == UnitType.Metric ? GetWeight() : GetWeight() * 0.45359237;
        }

        public double ToM()
        {
            return GetUnitType() == UnitType.Metric ? GetHeight() : GetHeight() * 0.0254;
        }

        public double ToCM()
        {
            return ToM() / 100;
        }
    }
}