using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    public class ValueValidator
    {
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length < maxLength)
            {
                throw new ArgumentException($"The value \"{value}\" is out of range for property \"{propertyName}\". It must be < \"{maxLength}\" symbols");
            }
        }
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"The value \"{value}\" is out of range for property \"{propertyName}\". It must be between {min} and {max}");
            }
        }
    }
}
