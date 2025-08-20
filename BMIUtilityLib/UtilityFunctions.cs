using System;

namespace BMIUtilityLib
{
    public class UtilityFunctions
    {
        public string FormatBMIResult(double bmi)
        {
            return $"Your BMI is {bmi:F2}. This is a calculated value based on your input.";
        }

        public string GetHealthTip(double bmi)
        {
            if (bmi < 18.5) return "Consider consulting a nutritionist for a healthy weight gain plan.";
            else if (bmi < 24.9) return "Great job! Maintain a balanced diet and exercise.";
            else if (bmi < 29.9) return "Consider a balanced diet to achieve a healthier weight.";
            else return "Consult a healthcare professional for weight management advice.";
        }
    }
}