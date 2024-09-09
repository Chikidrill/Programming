using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private readonly int _id;

        /// <summary>
        /// ФИО покупателя для каждого объекта класса <see cref="Item"/>. 
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки для каждого объекта класса <see cref="Item"/>. 
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает ID. Является полем, доступным только для чтения.
        /// </summary>
        public int Id { get { return _id; } }

        // <summary>
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

        // <summary>
        /// Возвращает и задает адрес доставки. Не может быть длиной больше 500 символов.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set 
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value; 
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName">ФИО покупателя.</param>
        /// <param name="address">Адрес доставки.</param>
        public Customer(string fullName, string address)
        { 
            FullName = fullName;
            Address = address;
        }
    }
}
