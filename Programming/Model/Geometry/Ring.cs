using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о кольце - внешний и внутренний радиусы, координаты центра, площадь кольца.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Значение внешнего радиуса для каждого экземпляра класса.
        /// </summary>
        private Double _outerRadius;
        /// <summary>
        /// Значение внутреннего радиуса для каждого экземпляра класса.
        /// </summary>
        private Double _innerRadius;
        private Double _p = 3.14;
        /// <summary>
        /// Значение координаты X центра кольца для каждого экземпляра класса. 
        /// </summary>
        private int _centerX;
        /// <summary>
        /// Значение координаты Y центра кольца для каждого экземпляра класса. 
        /// </summary>
        private int _centerY;
        Random rand = new Random();

        /// <summary>
        /// Возвращает и задает внешний радиус. Должно быть от 0 до 50.
        /// </summary>
        public Double OuterRadius
        {
            get { return _outerRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                Validator.AssertValueIsMore(value, _innerRadius);
                Validator.AssertValueInRange(value, 0, 50, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внутренний радиус. Должно быть от 0 до 50.
        /// </summary>
        public Double InnerRadius
        {
            get { return _innerRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                Validator.AssertValueIsMore(_outerRadius, value);
                Validator.AssertValueInRange(value, 0, 50, nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает координаты центра в двумерном пространстве.
        /// </summary>
        public Point2D Center { get; private set; }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public Double Area
        {
            get => (((_p * (OuterRadius * OuterRadius)) - (_p * (InnerRadius * InnerRadius))));
            private set { }
        }

        /// <summary>
        /// Создает объект класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="outerRadius">Внешний радиус.</param>
        /// <param name="innerRadius">Внутренний радиус.</param>
        public Ring(Double outerRadius, Double innerRadius)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;

            _centerX = rand.Next(50, 150);
            _centerY = rand.Next(50, 150);
            Center = new Point2D(_centerY, _centerX);
        }
    }
}
