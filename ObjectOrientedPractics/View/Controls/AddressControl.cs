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

        /// <summary>
        /// Получает или задает адрес, который будет отображен в элементе управления.
        /// При установке нового значения автоматически обновляется информация об адресе.
        /// </summary>
        public Address Address
        {
            get
            {
                
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
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AddressControl"/> и создает новый адрес.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
            Address = new Address();
        }

        /// <summary>
        /// Обновляет информацию об адресе на основе введенных пользователем данных из текстовых полей.
        /// </summary>
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

        /// <summary>
        /// Обновляет текстовые поля с текущей информацией об адресе.
        /// </summary>
        public void UpdateAddressInfo()
        {
            
            IndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartsTextBox.Text = _address.Apartment;
           
        }

        /// <summary>
        /// Очищает все текстовые поля в элементе управления.
        /// </summary>
        public void ClearInfo()
        {
            IndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartsTextBox.Clear();  
        }

        /// <summary>
        /// Обрабатывает изменение текста в поле для индекса и обновляет цвет фона в зависимости от корректности ввода.
        /// </summary>
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

        /// <summary>
        /// Обрабатывает изменение текста в поле для страны и обновляет цвет фона в зависимости от корректности ввода.
        /// </summary>
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

        /// <summary>
        /// Обрабатывает изменение текста в поле для города и обновляет цвет фона в зависимости от корректности ввода.
        /// </summary>
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

        /// <summary>
        /// Обрабатывает изменение текста в поле для улицы и обновляет цвет фона в зависимости от корректности ввода.
        /// </summary>
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

        /// <summary>
        /// Обрабатывает изменение текста в поле для дома и обновляет цвет фона в зависимости от корректности ввода.
        /// </summary>
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

        /// <summary>
        /// Обрабатывает изменение текста в поле для квартиры и обновляет цвет фона в зависимости от корректности ввода.
        /// </summary>
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
