using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий и хранящий информацию о корзине
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Закрытое поле для списка товаров
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Свойство для получения списка товаров
        /// </summary>
        public List<Item> Items { get { return _items; } set { _items = value ?? new List<Item>(); } }

        /// <summary>
        /// Свойство, возвращающее общую стоимость товаров в корзине
        /// </summary>
        public double Amount
        {
            get
            {
                if (_items == null || _items.Count == 0)
                {
                    return 0.0;
                }

                double totalAmount = 0.0;
                foreach (var item in _items)
                {
                    totalAmount += item.Cost;
                }

                return totalAmount;
            }
        }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Cart()
        {
            _items = new List<Item>();
        }
    }
}
