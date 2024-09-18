using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;
        public Address Address
        {
            get
            {
                // Return a new Address instance with updated values
                return new Address
                {
                    Country = CountryTextBox.Text,
                    City = CityTextBox.Text,
                    Street = StreetTextBox.Text,
                    Building = BuildingTextBox.Text,
                    Apartment = ApartsTextBox.Text,
                    Index = int.Parse(IndexTextBox.Text)
                };
            }
            set
            {
                if (_address != value)
                {
                    _address = value;
                    UpdateAddressInfo();
                }
                
            }
        }

        public AddressControl()
        {
            InitializeComponent();
            Address = new Address();

        }
        
        private void UpdateAddressFromFields()
        {
            try
            {
                // Валидация данных и сохранение
                _address.Index = int.Parse(IndexTextBox.Text);
                _address.Country = CountryTextBox.Text;
                _address.City = CityTextBox.Text;
                _address.Street = StreetTextBox.Text;
                _address.Building = BuildingTextBox.Text;
                _address.Apartment = ApartsTextBox.Text;

                // Обновление UI после сохранения
                UpdateAddressInfo();
            }
            catch (ArgumentException ex)
            {
                // Обработка ошибок валидации
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                // Ошибка формата ввода
                MessageBox.Show("Invalid format for index.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void UpdateAddressInfo()
        {
            
            IndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartsTextBox.Text = _address.Apartment;
           
        }
        public void ClearInfo()
        {
            IndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartsTextBox.Clear();  
        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IndexTextBox.BackColor = AppColors.StandartColor;
                if (int.TryParse(IndexTextBox.Text, out int index))
                {
                    _address.Index = index;
                }
                else
                {
                    IndexTextBox.BackColor = AppColors.InvalidColor;
                }

            }
            catch (Exception ex)
            {
                IndexTextBox.BackColor = AppColors.InvalidColor;
                // MessageBox.Show(ex.Message);
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CountryTextBox.BackColor = AppColors.StandartColor;
                string country = CountryTextBox.Text;
                _address.Country = country;
            }
            catch (Exception ex)
            {
                CountryTextBox.BackColor = AppColors.InvalidColor;
                // MessageBox.Show(ex.Message);
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CityTextBox.BackColor = AppColors.StandartColor;
                string city = CityTextBox.Text;
                _address.City = city;
            }
            catch (Exception ex)
            {
                CityTextBox.BackColor = AppColors.InvalidColor;
                // MessageBox.Show(ex.Message);
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StreetTextBox.BackColor = AppColors.StandartColor;
                string street = StreetTextBox.Text;
                _address.Street = street;
            }
            catch (Exception ex)
            {
                StreetTextBox.BackColor = AppColors.InvalidColor;
                // MessageBox.Show(ex.Message);
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BuildingTextBox.BackColor = AppColors.StandartColor;
                string building = BuildingTextBox.Text;
                _address.Building = building;
            }
            catch (Exception ex)
            {
                CountryTextBox.BackColor = AppColors.InvalidColor;
                // MessageBox.Show(ex.Message);
            }
        }

        private void ApartsTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ApartsTextBox.BackColor = AppColors.StandartColor;
                string aparts = ApartsTextBox.Text;
                _address.Apartment = aparts;
            }
            catch (Exception ex)
            {
                ApartsTextBox.BackColor = AppColors.InvalidColor;
                // MessageBox.Show(ex.Message);
            }
        }
    }
}
