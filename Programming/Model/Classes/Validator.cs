using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Programming.Model.Classes
{
    public class Validator
    {
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"The value \"{value}\" is invalid for property \"{propertyName}\". It must be a positive integer.");
            }
        }
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"The value \"{value}\" is invalid for property \"{propertyName}\". It must be a positive integer.");
            }
        }
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"The value \"{value}\" is out of range for property \"{propertyName}\". It must be between {min} and {max}.");
            }
        }
        public static void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"The value \"{value}\" is out of range for property \"{propertyName}\". It must be between {min} and {max}.");
            }
        }
        public static void AssertValueIsMore(Double firstValue, Double secondValue)
        {
            if (firstValue < secondValue)
            {
                throw new ArgumentException();
            }
        }
    }
}