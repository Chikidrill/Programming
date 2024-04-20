using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Предоставляет методы для валидации значений полей.
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// Проверяет, что целое число является положительным.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <exception cref="ArgumentException">Ошибка, выдаваемая, если значение не проходит проверку.</exception>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"The value \"{value}\" is invalid for property \"{propertyName}\". It must be a positive integer.");
            }
        }
        /// <summary>
        /// Проверяет, что число типа double является положительным.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <exception cref="ArgumentException">Ошибка, выдаваемая, если значение не проходит проверку.</exception>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"The value \"{value}\" is invalid for property \"{propertyName}\". It must be a positive integer.");
            }
        }
        /// <summary>
        /// Проверяет, что целое число принадлежит промежутку от значения "min" до значения "max".
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Левая граница промежутка.</param>
        /// <param name="max">Правая граница промежутка.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"The value \"{value}\" is out of range for property \"{propertyName}\". It must be between {min} and {max}.");
            }
        }
        /// <summary>
        /// Проверяет, что число типа double принадлежит промежутку от значения "min" до значения "max".
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Левая граница промежутка.</param>
        /// <param name="max">Правая граница промежутка.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"The value \"{value}\" is out of range for property \"{propertyName}\". It must be between {min} and {max}.");
            }
        }
        /// <summary>
        /// Проверяет, что значение первого аргумента, больше второго.
        /// </summary>
        /// <param name="firstValue">Значение первого аргумента.</param>
        /// <param name="secondValue">Значение второго аргумента</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueIsMore(Double firstValue, Double secondValue)
        {
            if (firstValue < secondValue)
            {
                throw new ArgumentException();
            }
        }
    }
}