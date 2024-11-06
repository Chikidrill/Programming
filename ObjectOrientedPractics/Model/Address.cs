using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывабщий и хранящий информацию об адресе доставки
    /// </summary>
    public class Address: ICloneable, IEquatable<Address>
    {
        /// <summary>
        /// Номер почтового индекса для каждого объекта класса.
        /// </summary>
        private int _index;
        /// <summary>
        /// Название страны для каждого объекта класса.
        /// </summary>
        private string _country;
        /// <summary>
        /// Название города для каждого объекта класса.
        /// </summary>
        private string _city;
        /// <summary>
        /// Название улицы для каждого объекта класса.
        /// </summary>
        private string _street;
        /// <summary>
        /// Дом (строение) для каждого объекта класса.
        /// </summary>
        private string _building;
        /// <summary>
        /// Квартира для каждого объекта класса.
        /// </summary>
        private string _apartment;

        public event EventHandler<EventArgs> AddressChanged;


        /// <summary>
        /// Возвращает, задает и осуществляет валидацию вводимого значения поля Index - должно быть целое шестизначное число.
        /// </summary>
        public int Index
        {
            get => _index;
            set
            {
                if (_index == value) return;
                ValueValidator.AssertValueInRange(value, 0, 999999, nameof(Index));
                _index = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Возвращает, задает и осуществляет валидацию вводимого значения поля Country.
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                if (_country == value) return;
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Возвращает, задает и осуществляет валидацию вводимого значения поля City.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                if(_city == value) return;
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Возвращает, задает и осуществляет валидацию вводимого значения поля Street.
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                if(_street == value) return;
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Возвращает, задает и осуществляет валидацию вводимого значения поля Building.
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                if (_building == value) return;
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Возвращает, задает и осуществляет валидацию вводимого значения поля Apartment.
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                if(_apartment == value) return;
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <inheritdoc/>
        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartment);
        }
        /// <inheritdoc/>
        public bool Equals(Address? address2)
        {
            if (address2 == null)
                return false;
            if (object.ReferenceEquals(this, address2))
                return true;
            PropertyInfo[] properties = typeof(Address).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                var value1 = property.GetValue(this);
                var value2 = property.GetValue(address2);
                if (value1 == null && value2 == null)
                    continue;
                if (value1 == null || value2 == null || value1 != value2)
                    return false; // Если одно из значений null или они не равны
            }
            return true;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>
        /// </summary>
        /// <param name="index">Почтовый индекс. Целое шестизначное число.</param>
        /// <param name="country">Страна. Строка, длиной не более 50 символов</param>
        /// <param name="city">Город. Строка, длиной не более 50 символов</param>
        /// <param name="street">Улица. Строка, длиной не более 100 символов</param>
        /// <param name="building">Строение. Строка, длиной не более 10 символов</param>
        /// <param name="apartment">Квартира. Строка, длиной не более 10 символов</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Address()
        {

        }
        /// <summary>
        /// Возвращает строковое представление объекта, 
        /// содержащего индекс, страну, город, улицу, 
        /// номер дома и номер квартиры.
        /// </summary>
        /// <returns>Строка в формате: "индекс, страна, город, улица, д. дом, кв. квартира"</returns>
        public override string ToString()
        {
            return $"{_index}, {_country}, {_city}, {_street}, д. {_building}, кв. {_apartment}";
        }
    }
}
