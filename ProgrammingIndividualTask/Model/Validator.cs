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
    }
}
