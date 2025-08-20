using System;

namespace BMICalculatorApp
{
    public class BMICalculator
    {
        public double CalculateBMI(double weightKg, double heightM)
        {
            if (heightM <= 0)
                throw new ArgumentException("Height must be greater than zero.");

            return weightKg / (heightM * heightM);
        }

        public string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi < 24.9)
                return "Normal weight";
            else if (bmi < 29.9)
                return "Overweight";
            else
                return "Obese";
        }
    }
}
