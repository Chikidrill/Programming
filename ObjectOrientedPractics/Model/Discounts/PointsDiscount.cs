using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о накопительной скидке.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        int _pointsBalance;

        /// <summary>
        /// Количество накопленных баллов, которые могут быть использованы для получения скидки.
        /// </summary>
        public int PointsBalance
        {
            get
            {
                return _pointsBalance;
            }
            private set
            {
                ValueValidator.AssertOnPositiveValue(value, nameof(PointsBalance));
                _pointsBalance = value;
            }
        }
        /// <summary>
        /// Возвращает информацию о текущем количестве накопленных баллов.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная - {PointsBalance} баллов";
            }
        }

        /// <summary>
        /// Рассчитывает сумму скидки, которая может быть применена к заказу на основе накопленных баллов.
        /// Максимальная скидка не может превышать 30% от общей суммы заказа.
        /// </summary>
        /// <param name="items">Список товаров для расчета скидки.</param>
        /// <returns>Сумма скидки, рассчитанная на основе накопленных баллов.</returns>
        public double Calculate(List<Item> items)
        {
            double amount = GetAmount(items);
            if (PointsBalance > amount * 0.3)
            {
                return Math.Floor(amount * 0.3);
            }
            else
            {
                return PointsBalance;
            }
        }
        /// <summary>
        /// Применяет рассчитанную скидку к списку товаров и уменьшает баланс накопленных баллов.
        /// </summary>
        /// <param name="items">Список товаров для применения скидки.</param>
        /// <returns>Сумма скидки, которая была применена.</returns>
        public double Apply(List<Item> items)
        {
            double discountAmount = Calculate(items);
            PointsBalance -= (int)discountAmount;
            return discountAmount;
        }
        /// <summary>
        /// Обновляет баланс накопленных баллов на основе суммы покупок.
        /// Покупатель получает 10% от суммы покупки в виде баллов.
        /// </summary>
        /// <param name="items">Список товаров для обновления баланса баллов.</param>
        public void Update(List<Item> items)
        {
            double amount = GetAmount(items);
            PointsBalance += (int)Math.Ceiling(amount * 0.1);
        }

        /// <summary>
        /// Возвращает общую сумму заказа.
        /// </summary>
        public double GetAmount(List<Item> items)
        {
            double sum = 0;
            items.ForEach(x => { sum += x.Cost; });
            return Math.Round(sum, 2);
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="pointsBalance">Баланс накопленных баллов.</param>
        public PointsDiscount(int pointsBalance)
        {
            PointsBalance = pointsBalance;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return Info;
        }
    }
}