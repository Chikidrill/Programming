using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ObjectOrientedPractics.Services.ValueValidator;

namespace ObjectOrientedPractics.Model
{
    public class Address
    {
        /// <summary>
        /// 
        /// </summary>
        private int _index;
        /// <summary>
        /// 
        /// </summary>
        private string _country;
        /// <summary>
        /// 
        /// </summary>
        private string _city;
        /// <summary>
        /// 
        /// </summary>
        private string _street;
        /// <summary>
        /// 
        /// </summary>
        private string _building;
        /// <summary>
        /// 
        /// </summary>
        private string _apartment;

        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        /// <param name="building"></param>
        /// <param name="apartment"></param>
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
