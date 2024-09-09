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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer;
        private IdGenerator idGenerator = new IdGenerator();
        public CustomersTab()
        {
            InitializeComponent();
        }

        

        private void AddButton_Click(object sender, EventArgs e)
        {
            var newCustomer = new Customer(idGenerator.GetNextId(), FullNameTextBox.Text, AddressTextBox.Text);
            _customers.Add(newCustomer);
            FullNameTextBox.Clear();
            AddressTextBox.Clear();
            ClearInputFields();
            DisplayCustomersList();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _customers.RemoveAt(selectedIndex);
                DisplayCustomersList();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Выберите песню для удаления.");
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
            }
            catch (Exception ex)
            {
                FullNameTextBox.BackColor = AppColors.InvalidColor;
                // MessageBox.Show(ex.Message);
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressTextBox.BackColor = AppColors.StandartColor;
                if (_currentCustomer == null)
                {
                    _currentCustomer = new Customer();
                }
                string address = AddressTextBox.Text;
                _currentCustomer.Address = address;
            }
            catch (Exception ex)
            {
                AddressTextBox.BackColor = AppColors.InvalidColor;
                // MessageBox.Show(ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = null;
            IdTextBox.Text = string.Empty;
            FullNameTextBox.Text = string.Empty;
            AddressTextBox.Text = string.Empty;
            FullNameTextBox.BackColor = AppColors.StandartColor;
            AddressTextBox.BackColor = AppColors.StandartColor;
        }
        private void ClearInputFields()
        {
            IdTextBox.Text = string.Empty;
            FullNameTextBox.Text = string.Empty;
            AddressTextBox.Text = string.Empty;

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
                CustomersListBox.Items.Add($"ID: {customer.Id} Full name: {customer.FullName}");
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           int selectedIndex = CustomersListBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                _currentCustomer = _customers[selectedIndex];
                FullNameTextBox.Text = _currentCustomer.FullName;
                AddressTextBox.Text = _currentCustomer.Address;
            }
            else
            {
                _currentCustomer = null;
                FullNameTextBox.Text = string.Empty;
                AddressTextBox.Text = string.Empty;
            }
        }
    }
}
