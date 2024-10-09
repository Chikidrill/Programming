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
    /// Класс описывающий и хранящий информацию о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор для объекта класса <see cref="Item"/>. Доступен только для чтения.
        /// </summary>
        private readonly int _id; [JsonInclude]

        /// <summary>
        /// ФИО покупателя для каждого объекта класса <see cref="Item"/>. 
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки для каждого объекта класса <see cref="Item"/>. 
        /// </summary>
        private Address _address;

        /// <summary>
        /// Генератор ID
        /// </summary>
        private static IdGenerator IdGenerator = new IdGenerator();

        /// <summary>
        /// Возвращает ID. Является полем, доступным только для чтения.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }
        
        /// <summary>
        /// Уникальная корзина для каждого покупателя
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Список заказов
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Возвращает и задает корзину
        /// </summary>
        public Cart Cart { get; set; }

        /// <summary>
        /// Возвращает и задает список заказов
        /// </summary>
        public List<Order> Orders
        {
            get => _orders;
            set => _orders = value ?? new List<Order>();
        }

        /// <summary>
        /// Возвращает и задает ФИО покупателя. Не может быть длиной больше 200 символов.
        /// </summary>
        public string FullName 
        { 
            get { return _fullname; } 
            set 
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullname = value; 
            }
        }

        /// <summary>
        /// Возвращает и задает адрес доставки. Не может быть длиной больше 500 символов.
        /// </summary>
        public Address Address
        {
            get => _address;
            set => _address = value ?? new Address(); // Убедитесь, что _address не равен null
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName">ФИО покупателя.</param>
        /// <param name="address">Адрес доставки.</param>

        [JsonConstructor]
        public Customer(string fullName, Address address)
        { 
            _id = IdGenerator.GetNextId();
            FullName = fullName;
            Address = address;
            _cart = new Cart();
            _orders = new List<Order>();
        }
        public Customer() 
        {
            Cart = new Cart();
        }
    }
}
