using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о координатах в двумерном пространстве.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата X для каждого экземпляра класса.
        /// </summary>
        private int _x;
        /// <summary>
        /// Координата Y для каждого экземпляра класса.
        /// </summary>
        private int _y;
        /// <summary>
        /// Возвращает и задаёт значение координаты X. Значение должно быть больше 0.
        /// </summary>
        public int coord_X
        {
            get
            {
                return _x;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(coord_X));
                _x = value;
            }

        }
        /// <summary>
        /// Возвращает и задаёт значение координаты Y. Значение должно быть больше 0.
        /// </summary>
        public int coord_Y
        {
            get
            {
                return _y;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(coord_Y));
                _y = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата X. Должна быть больше 0.</param>
        /// <param name="y">Координата Y. Должна быть больше 0.</param>
        public Point2D(int x, int y)
        {
            coord_X = x;
            coord_Y = y;
        }
    }
}
