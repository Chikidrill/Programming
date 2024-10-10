using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {

        /// <summary>
        /// Генератор ID
        /// </summary>
        private static IdGenerator IdGenerator = new IdGenerator();

        /// <summary>
        /// Уникальный идентификатор для объекта класса <see cref="Item"/>. Доступен только для чтения.
        /// </summary>
        private readonly int _id; [JsonInclude]

        /// <summary>
        /// Уникальная дата для каждого заказа
        /// </summary>
        private readonly DateTime _date;

        /// <summary>
        /// Уникальное имя покупателя для каждого экземпляра класса
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Уникальный адрес доставки для каждого экземпляра класса
        /// </summary>
        private Address _deliveryAddress;

        /// <summary>
        /// Список предметов в каждом заказе
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Возвращает ID
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает дату создания заказа
        /// </summary>
        public DateTime CreationDate
        {
            get { return _date; }
        }


        /// <summary>
        /// Возвращает и задает адрес доставки класса <see cref="Address"></see>
        /// </summary>
        public Address DeliveryAddress
        { 
            get { return _deliveryAddress; } 
            set {_deliveryAddress = value; }
        }

        /// <summary>
        /// Возвращает и задает список предметов 
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value ?? new List<Item>();
        }

        /// <summary>
        /// Возвращает и задает статус заказа из перечисления <see cref="OrderStatus"/>
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Возвращает общую стоимость заказа
        /// </summary>
        public double TotalCost
        {
            get
            {
                if (_items == null || _items.Count == 0)
                {
                    return 0.0;
                }

                double totalCost = 0.0;
                foreach (var item in _items)
                {
                    totalCost += item.Cost;
                }

                return totalCost;
            }
        }

        /// <summary>
        /// Возвращает и задает имя покупателя
        /// </summary>
        public string FullName
        {
            get => _fullName;
            set => _fullName = value ?? "Unknown";
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>
        /// </summary>
        /// <param name="deliveryAddress">Адрес доставки</param>
        /// <param name="FullName">Имя покупателя</param>
        public Order(Address deliveryAddress, string FullName)
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            _deliveryAddress = deliveryAddress;
            _fullName = FullName;
            _items = new List<Item>();
            Status = OrderStatus.New;
        }

        public Order() { }
    }
}
