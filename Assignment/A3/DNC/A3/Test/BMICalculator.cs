using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    enum UnitType
    {
        Metric,
        American
    }
    class BMICalculator
    {
        public BMICalculator()
        {
            this.name   = "No name";
            this.weight = 0.0;
            this.height = 0.0;
            this.unit   = UnitType.American;
        }

        public BMICalculator(string name, double weight, double height, UnitType unit)
        {
            this.name   = name;
            this.weight = weight;
            this.height = height;
            this.unit   = unit;
        }

        private string name;
        public string GetName() => name;
        public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : this.name;

        private double height;
        public double GetHeight() => height;
        public void SetHeight(double height) => this.height = height >= 0 ? height : this.height;

        private double weight;
        public double GetWeight() => weight;
        public void SetWeight(double weight) => this.weight = weight >= 0 ? weight : this.weight;

        private UnitType unit;
        public UnitType GetUnitType() => unit;
        public void SetUnitType(UnitType unit) => this.unit = unit;

        public double BMIResult() => unit switch
        {
            UnitType.Metric => weight / (height * height),
            UnitType.American => weight / (height * height) * 730.0,
            _ => 0.0,
        };


        public string BMICategory() => _ = BMIResult() switch
        {
            > 40 => "Overweight (Obesity class III)",
            >= 35 and < 40 => "Overweight (Obesity class II)",
            >= 30 and < 35 => "Overweight (Obesity class I)",
            >= 25 and < 30 => "Overweight (Pre-obesity)",
            >= 18.5 and < 25 => "Normal weight",
            < 18.5 => "Underweight",
            _ => "Something is wrong",
        };
    }
}
