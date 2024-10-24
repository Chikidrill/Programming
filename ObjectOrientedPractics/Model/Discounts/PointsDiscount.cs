using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о накопительной скидке.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        [JsonInclude]
        private int _points = 0;

        /// <summary>
        /// Возвращает количество накопленных баллов.
        /// </summary>
        public int Points
        {
            get { return _points; }
            private set
            {
                if (value >= 0)
                {
                    _points = value;

                }
            }
        }

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                if (_points % 100 >= 11 && _points % 100 <= 14)
                {
                    return $"Накопительная - {_points} баллов";
                }

                int lastDigit = _points % 10;

                if (lastDigit == 1 && _points % 100 != 11)
                {
                    return $"Накопительная - {_points} балл";
                }
                else if (lastDigit >= 2 && lastDigit <= 4 && _points % 100 != 12 && _points % 100 != 13 && _points % 100 != 14)
                {
                    return $"Накопительная - {_points} балла";
                }
                else
                {
                    return $"Накопительная - {_points} баллов";
                }
            }
        }

        /// <summary>
        /// Возвращает размер доступной скидки.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public double Calculate(List<Item> items)
        {
            double amount = GetAmount(items);
            if (Points > amount * 0.3)
            {
                return Math.Floor(amount * 0.3);
            }
            else
            {
                return Points;
            }
        }

        /// <summary>
        /// Применяет скидку к товарам. Списывает баллы.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public double Apply(List<Item> items)
        {
            double discountAmount = Calculate(items);
            Points -= (int)discountAmount;
            return discountAmount;

        }

        /// <summary>
        /// Начисляет баллы после покупки.
        /// </summary>
        /// <param name="items"></param>
        public void Update(List<Item> items)
        {
            double amount = GetAmount(items);
            Points += (int)Math.Ceiling(amount * 0.1);
        }
        /// <summary>
        /// Возвращает сумму товаров заказа соответствующих категории.
        /// </summary>
        public double GetAmount(List<Item> items)
        {
            double sum = 0;
            items.ForEach(x => { sum += x.Cost; });
            return Math.Round(sum, 2);
        }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="pointsBalance">Количество баллов накопительной скидки</param>
        public PointsDiscount(int pointsBalance)
        {
            Points = pointsBalance;
        }
        public override string ToString()
        {
            return Info;
        }
    }
}