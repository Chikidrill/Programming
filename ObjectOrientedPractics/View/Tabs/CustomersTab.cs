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
using ObjectOrientedPractics.Model;
using System.Reflection.Emit;
using ObjectOrientedPractics.View.Controls;
using System.Text.Json;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer;
        private IdGenerator idGenerator = new IdGenerator();
        private string filePath = "customers.json";
        AddressControl _addressControl;
        public CustomersTab()
        {
            InitializeComponent();
            InitializeAddressControl();
            LoadCustomersList();
            DisplayCustomersList();
        }

        /// <summary>
        /// Открытое свойство для работы с списком покупателей.
        /// При установке свойства обновляет ListBox с покупателями.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                DisplayCustomersList();
            }
        }

        private void InitializeAddressControl()
        {
            _addressControl = new AddressControl
            {
                Location = new System.Drawing.Point(423, 112), // Установите нужные координаты
                Size = new System.Drawing.Size(590, 500) // Установите нужный размер
            };
            Controls.Add(_addressControl); // Добавляем AddressControl на форму
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var address = _addressControl.Address;

            var newCustomer = new Customer(idGenerator.GetNextId(), FullNameTextBox.Text, address);
            _customers.Add(newCustomer);

            // Обновление UI и очистка
            IdTextBox.Text = newCustomer.Id.ToString();
            FullNameTextBox.Clear();
            _addressControl.ClearInfo(); // Очистить адрес
            ClearInputFields();
            DisplayCustomersList();
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _customers.RemoveAt(selectedIndex);
                SaveCustomersList() ;
                DisplayCustomersList();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Выберите покупателя для удаления.");
            }
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = null;
            IdTextBox.Text = string.Empty;
            FullNameTextBox.Text = string.Empty;
            _addressControl.Address = new Address(); // Очистить адрес
            FullNameTextBox.BackColor = AppColors.StandartColor;
        }
        private void ClearInputFields()
        {
            IdTextBox.Text = string.Empty;
            FullNameTextBox.Text = string.Empty;
            _addressControl.Address = new Address(); // Очистить адрес

            if (CustomersListBox.SelectedIndex == -1)
            {
                CustomersListBox.SelectedItem = null;
            }
        }
        private void DisplayCustomersList()
        {
            // Очищаем ListBox перед добавлением обновленных данных
            CustomersListBox.Items.Clear();

            // Добавляем каждую песню из списка в ListBox
            foreach (Customer customer in _customers)
            {
                CustomersListBox.Items.Add($"ID: {customer.Id} Full name: {customer.FullName} {customer.Address}");
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                FullNameTextBox.BackColor = AppColors.StandartColor;
                if (_currentCustomer == null)
                {
                    _currentCustomer = new Customer();
                }
                string fullname = FullNameTextBox.Text;
                _currentCustomer.FullName = fullname;
                SaveCustomersList();
                DisplayCustomersList();
            }
            catch (Exception ex)
            {
                FullNameTextBox.BackColor = AppColors.InvalidColor;
                // MessageBox.Show(ex.Message);
            }

        }

        private void CustomersListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                _currentCustomer = _customers[selectedIndex];
                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;

                if (_currentCustomer.Address != null)
                {
                    _addressControl.Address = _currentCustomer.Address;
                }
                else
                {
                    _addressControl.Address = new Address(); // Очистить AddressControl
                }
            }
            else
            {
                _currentCustomer = null;
                IdTextBox.Clear();
                FullNameTextBox.Clear();
                _addressControl.Address = new Address(); // Очистить AddressControl
            }
        }
        private void LoadCustomersList()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(filePath);
                    _customers = JsonSerializer.Deserialize<List<Customer>>(jsonString) ?? new List<Customer>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Осуществляет сохранение данных в файл .json.
        /// </summary>
        private void SaveCustomersList()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(_customers, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }
    }
}
