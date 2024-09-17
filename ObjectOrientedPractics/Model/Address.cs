using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ObjectOrientedPractics.Services.ValueValidator;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывабщий и хранящий информацию об адресе доставки
    /// </summary>
    public class Address
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

        /// <summary>
        /// Возвращает, задает и осуществляет валидацию вводимого значения поля Index - должно быть целое шестизначное число.
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
                AssertValueInRange(value, 6, 6, "Index");
            }
        }

        /// <summary>
        /// Возвращает, задает и осуществляет валидацию вводимого значения поля Country. Длина строки не более 50 символов.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
                AssertStringOnLength(value, 50, "Country");
            }
        }

        /// <summary>
        /// Возвращает, задает и осуществляет валидацию вводимого значения поля City. Длина строки не более 50 символов.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
                AssertStringOnLength(value, 50, "City");
            }
        }

        /// <summary>
        /// Возвращает, задает и осуществляет валидацию вводимого значения поля Street. Длина строки не более 100 символов.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
                AssertStringOnLength(value, 100, "Street");
            }
        }

        /// <summary>
        /// Возвращает, задает и осуществляет валидацию вводимого значения поля Building. Длина строки не более 10 символов.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                _building = value;
                AssertStringOnLength(value, 10, "Building");
            }
        }

        /// <summary>
        /// Возвращает, задает и осуществляет валидацию вводимого значения поля Apartment. Длина строки не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                _apartment = value;
                AssertStringOnLength(value, 10, "Apartment");
            }
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
        /// 
        /// </summary>
        public Address() { }
    }
}
