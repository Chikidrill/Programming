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

        private string _fullName;
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
        public OrderStatus Status { get; set; }
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
        public string FullName
        {
            get => _fullName;
            set => _fullName = value ?? "Unknown";
        }
        public Order(Address deliveryAddress, string FullName)
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            _deliveryAddress = deliveryAddress;
            _fullName = FullName;
            _items = new List<Item>();
            Status = OrderStatus.New;
        }
    }
}
