using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит цвета, использумые в приложении.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет для отображения корректных значений.
        /// </summary>
        public static readonly Color ValidColor = Color.LightGreen;
        /// <summary>
        /// Цвет для отображения пересечения прямоугольников.
        /// </summary>
        public static readonly Color ColissionColor = Color.Red;
        /// <summary>
        /// Цвет для отображения некорректных значений.
        /// </summary>
        public static readonly Color InvalidColor = Color.LightPink;
        /// <summary>
        /// Цвет для стандартного отображения значений.
        /// </summary>
        public static readonly Color StandartColor = Color.White;
        /// <summary>
        /// Цвет для работы SeasonHandle при значении "Winter"
        /// </summary>
        public static readonly Color WinterColor = Color.AliceBlue;
        /// <summary>
        /// Цвет для работы SeasonHandle при значении "Spring"
        /// </summary>
        public static readonly Color SpringColor = Color.Green;
        /// <summary>
        /// Цвет для работы SeasonHandle при значении "Autumn"
        /// </summary>
        public static readonly Color AutumnColor = Color.SandyBrown;

    }
}
