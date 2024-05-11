using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingIndividualTask.Model
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
        public static void AssertValueLength(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"The value \"{value}\" is out of range for property \"{propertyName}\". It must be between {min} and {max}.");
            }
        }
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"The value \"{value}\" is out of range for property \"{propertyName}\". It must be between {min} and {max}.");
            }
        }
    }
}
