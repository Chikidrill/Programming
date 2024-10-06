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

        private readonly DateTime _date;
        private Address _deliveryAddress;
        private List<Item> _items;

        public int Id
        {
            get
            {
                return _id;
            }
        }
        public DateTime CreationDate
        {
            get { return _date; }
        }

        public Address DeliveryAddress
        { 
            get { return _deliveryAddress; } 
            set {_deliveryAddress = value; }
        }
       public List<Item> Items
        {
            get => _items;
            set => _items = value ?? new List<Item>();
        }
        public double TotalAmount
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

        public Order(int id, Address deliveryAddress, OrderStatus status)
        {
            _id = id;
            _date = DateTime.Now;
            _deliveryAddress = deliveryAddress;
            _items = new List<Item>();
           
        }
    }
}
