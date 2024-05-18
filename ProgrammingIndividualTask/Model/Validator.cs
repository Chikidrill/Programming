using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingIndividualTask.Model
{
    /// <summary>
    /// Класс, содержащий функции для валидации значений.
    /// </summary>
    public class Validator
    {
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение \"{value}\" не может быть присвоено \"{propertyName}\". Значение должно быть положительным целым числом.");
            }
        }
        public static void AssertValueLength(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Длина строки равная \"{value}\" вышла за рамки для \"{propertyName}\". Она должна быть от {min} до {max}.");
            }
        }
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение \"{value}\" вышло за рамки промежутка для \"{propertyName}\". Оно должно быть от {min} до {max}.");
            }
        }
    }
}
