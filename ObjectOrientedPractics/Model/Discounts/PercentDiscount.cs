﻿using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PercentDiscount : IDiscount
    {
        private int _percent = 1;
        private Category _category;
        public double TotalSpent { get; private set; }

        /// <summary>
        /// Возвращает размер скидки в процентах.
        /// </summary>
        public int Percent
        {
            get { return _percent; }
            private set { _percent = value; }
        }

        /// <summary>
        /// Возвращает категорию скидки.
        /// </summary>
        public Category Category { get { return _category; } }

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная '{_category}' - {DiscountPercentage}%";
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
            double discountAmount = amount * ((double)DiscountPercentage) / 100;
            return discountAmount;
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public double Apply(List<Item> items)
        {
            double discountAmount = Calculate(items);
            return discountAmount;
        }

        /// <summary>
        /// Обновляет итоговую сумму покупок.
        /// </summary>
        /// <param name="items"></param>
        public void Update(List<Item> items)
        {
            double amount = GetAmount(items);
            TotalSpent += amount;
        }

        /// <summary>
        /// Возвращает сумму товаров заказа соответствующих категории.
        /// </summary>
        public double GetAmount(List<Item> items)
        {
            double sum = 0;
            items.ForEach(x =>
            {
                if (x.Category == Category)
                {
                    sum += x.Cost;
                }
            }
            );
            return Math.Round(sum, 2);
        }
        /// <summary>
        /// Рассчитывает размер процентной скидки в зависимости от общей потраченной суммы в категории
        /// </summary>
        public int DiscountPercentage
        {
            get
            {
                int discountPercentage = (int)Math.Floor(TotalSpent / 1000);
                if (discountPercentage > 9) discountPercentage = 9;
                return discountPercentage + 1;
            }
        }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="category">Категория товара</param>
        /// <param name="totalSpent">Общая потраченная сумма</param>
        public PercentDiscount(Category category, double totalSpent)
        {
            _category = category;
            TotalSpent = totalSpent;
        }
        public override string ToString()
        {
            return Info;
        }
    }
}