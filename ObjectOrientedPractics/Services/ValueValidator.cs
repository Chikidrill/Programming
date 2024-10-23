using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для валидации значений полей.
    /// </summary>
    public class ValueValidator
    {
        /// <summary>
        /// Проверяет, что длина строки меньше значения "maxLength".
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="maxLength">Максимальная длина строки.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"The value \"{value}\" is out of range for property \"{propertyName}\". It must be < \"{maxLength}\" symbols");
            }
        }
        /// <summary>
        /// Проверяет, что вещественное число принадлежит промежутку от значения "min" до значения "max".
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Левая граница промежутка.</param>
        /// <param name="max">Правая граница промежутка.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"The value \"{value}\" is out of range for property \"{propertyName}\". It must be between {min} and {max}");
            }
        }
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"The value \"{value}\" is out of range for property \"{propertyName}\". It must be between {min} and {max}");
            }
        }
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Значение \"{value}\" не может быть присвоено \"{propertyName}\". Значение должно быть положительным целым числом.");
            }
        }
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Значение \"{value}\" не может быть присвоено \"{propertyName}\". Значение должно быть положительным целым числом.");
            }
        }
    }
}
