using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment1.Converters
{
    public static class Converter
    {
        public enum MeasurementUnits
        {
            Celcius,
            Fahrenheit
        }

        public static double ConvertBetweenFahrenAndCelcius(float value, MeasurementUnits measurementUnit)
        {
            var result = 0.0f;

            switch (measurementUnit)
            {
                case MeasurementUnits.Celcius:
                    result = (value * (9f / 5f)) + 32f; // Celcius to fahrenheit
                    break;
                case MeasurementUnits.Fahrenheit:
                    result = (value - 32f) * 5f / 9f; // Fahrenheit to celcius
                    break;
                default:
                    break;
            }

            return Math.Round(result, 1);
        }

        // 1234
        public static string ArabicToRomanNumerals(int arabicNum)
        {
            if (arabicNum == 0)
            {
                return "";
            }
            // Create a dict containing the arabic/roman key value literals
            var dict = new Dictionary<int, string>()
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"},
            };

            // Create a string builder
            var romanBuilder = new StringBuilder();

            foreach (KeyValuePair<int, string> entry in dict)
            {
                while (arabicNum >= entry.Key)
                {
                    arabicNum -= entry.Key;
                    romanBuilder.Append(entry.Value);
                }
            }
            return romanBuilder.ToString();
        }
    }
}
