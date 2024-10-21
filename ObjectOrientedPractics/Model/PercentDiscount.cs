using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PercentDiscount
    {
        /// <summary>
        /// Категория товаров, на которые распространяется скидка
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Общая сумма покупок в этой категории
        /// </summary>
        public double TotalSpent { get; private set; }

        /// <summary>
        /// Процент скидки, рассчитываемый на основе общей суммы покупок
        /// </summary>
        public int DiscountPercentage
        {
            get
            {
                int discountPercentage = (int)Math.Floor(TotalSpent / 1000);
                if (discountPercentage == 9) { discountPercentage = 9; }
                return discountPercentage+1;
            }
        }

        /// <summary>
        /// Возвращает информацию о процентной скидке в виде строки
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная «{Category}» - {DiscountPercentage}%";
            }
        }

        /// <summary>
        /// Рассчитывает сумму скидки для списка товаров, соответствующих категории.
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Сумма скидки</returns>
        public double Calculate(List<Item> items)
        {
            double amount = GetAmount(items);
            double discountAmount = amount * ((double)DiscountPercentage) / 100;
            return discountAmount;
        }
        /// <summary>
        /// Применяет скидку к списку товаров и возвращает сумму скидки
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Примененная сумма скидки</returns>
        public double Apply(List<Item> items)
        {
            double discountAmount = Calculate(items);
            return discountAmount;
        }

        /// <summary>
        /// Обновляет потраченную сумму на основе списка товаров
        /// </summary>
        /// <param name="items">Список товаров</param>
        public void Update(List<Item> items)
        {
            double amount = GetAmount(items);
            TotalSpent += amount;

        }

        /// <summary>
        /// Возвращает сумму товаров
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public double GetAmount(List<Item> items)
        {
            double sum = 0;
            foreach (Item item in items)
            {
                if(item.Category == Category)
                {
                    sum += item.Cost;
                }
            }
            return Math.Round(sum, 2);
        }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="category">Категория товара</param>
        /// <param name="totalSpent">Общая потраченная сумма в этой категории</param>
        public PercentDiscount(Category category, double totalSpent)
        {
            Category = category;
            TotalSpent = totalSpent;
        }
        public override string ToString()
        {
            return Info;
        }
    }
}
