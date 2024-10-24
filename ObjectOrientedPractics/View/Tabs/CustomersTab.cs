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
using ObjectOrientedPractics.View;
using System.Text.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer;
        private IdGenerator idGenerator = new IdGenerator();
        private string filePath = "customers.json";
        private List<IDiscount>? _discounts;
        AddressControl _addressControl;
        private AddDiscountForm addDiscountForm;
        public CustomersTab()
        {
            InitializeComponent();
            InitializeAddressControl();
            DisplayCustomersList();
            addDiscountForm = new AddDiscountForm();
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
        /// <summary>
        /// Возвращает и задает список скидок
        /// </summary>
        public List<IDiscount>? Discounts
        {
            get
            {
                return _discounts;
            }
            set
            {
                _discounts = value;
                FillDiscountsListBox();
            }
        }
        /// <summary>
        /// Инициализация элемента AddressControl.
        /// </summary>
        private void InitializeAddressControl()
        {
            _addressControl = new AddressControl
            {
                Location = new System.Drawing.Point(423, 112), 
                Size = new System.Drawing.Size(590, 500) 
            };
            Controls.Add(_addressControl);
            _addressControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }
        /// <summary>
        /// Осуществляет добавление нового элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var address = _addressControl.Address;

            var newCustomer = new Customer(FullNameTextBox.Text, address);
            if (isPriorityCheckBox.Checked == true)
            {
                newCustomer.IsPriority = true;
            }
            _customers.Add(newCustomer);


            IdTextBox.Text = newCustomer.Id.ToString();
            FullNameTextBox.Clear();
            _addressControl.ClearInfo(); 
            ClearInputFields();
            DisplayCustomersList();
            isPriorityCheckBox.Checked = false;
        }

        /// <summary>
        /// Осуществляет удаление выбранного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show("Выберите покупателя для удаления.");
            }
        }

        /// <summary>
        /// Осуществляет сброс выбранного элемента и очищение полей ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = null;
            IdTextBox.Text = string.Empty;
            FullNameTextBox.Text = string.Empty;
            _addressControl.Address = new Address();
            FullNameTextBox.BackColor = AppColors.StandartColor;
            isPriorityCheckBox.Checked = false;
            DiscountsListBox.Items.Clear();
        }

        /// <summary>
        /// Функция очищения полей ввода
        /// </summary>
        private void ClearInputFields()
        {
            IdTextBox.Text = string.Empty;
            FullNameTextBox.Text = string.Empty;
            _addressControl.Address = new Address(); 
            if (CustomersListBox.SelectedIndex == -1)
            {
                CustomersListBox.SelectedItem = null;
            }
            isPriorityCheckBox.Checked = false;
        }

        /// <summary>
        /// Функция отображения элементов в ЛистБокс
        /// </summary>
        private void DisplayCustomersList()
        {
            CustomersListBox.Items.Clear();
            foreach (Customer customer in _customers)
            {
                CustomersListBox.Items.Add($"ID: {customer.Id} Full name: {customer.FullName} {customer.Address}");
            }

        }

        /// <summary>
        /// Осуществляет изменение значения поля FullName у выбранного элемента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                DisplayCustomersList();
            }
            catch (Exception ex)
            {
                FullNameTextBox.BackColor = AppColors.InvalidColor;
            }

        }

        /// <summary>
        /// Функция отображения выбранного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                _currentCustomer = _customers[selectedIndex];
                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;
                FillDiscountsListBox();
                if (_currentCustomer.Address != null)
                {
                    _addressControl.Address = _currentCustomer.Address;
                }
                else
                {
                    _addressControl.Address = new Address(); 
                }
                isPriorityCheckBox.Checked = _currentCustomer.IsPriority;
            }
            else
            {
                _currentCustomer = null;
                IdTextBox.Clear();
                FullNameTextBox.Clear();
                _addressControl.Address = new Address(); 
                DiscountsListBox.Items.Clear();
            }
        }

        /// <summary>
        /// Заполняет значениями DiscountListBox
        /// </summary>
        private void FillDiscountsListBox()
        {
            DiscountsListBox.Items.Clear();
            if (_currentCustomer != null)
            {
                foreach (IDiscount discount in _currentCustomer.Discounts)
                {
                    DiscountsListBox.Items.Add($"{discount.Info}");
                }
            }

        }
        /// <summary>
        /// Осуществляет добавление скидки покупателю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Выберите покупателя.");
                return;
            }
            if (_currentCustomer.Cart == null)
            {
                _currentCustomer.Cart = new Cart(); 
            }

            Category category;
            AddDiscountForm addDiscountForm = new AddDiscountForm();
            addDiscountForm.ShowDialog();

            if (addDiscountForm.IsChanged)
            {
                bool isContains = false;

                foreach (var discount in _currentCustomer.Discounts)
                {
                    if (discount is PercentDiscount percentDiscount1)
                    {
                        if (percentDiscount1.Category == addDiscountForm.Category)
                        {
                            isContains = true;
                            break;
                        }
                    }
                }

                if (!isContains)
                {
                    category = addDiscountForm.Category;
                    if (_currentCustomer.Cart.Items.Count > 0)
                    {
                        PercentDiscount percentDiscount = new PercentDiscount(category, _currentCustomer.Cart.Amount);
                        _currentCustomer.Discounts.Add(percentDiscount);
                        MessageBox.Show("Процентная скидка успешно добавлена.");
                    }
                    else
                    {
                        MessageBox.Show("Корзина пуста, добавьте товары перед применением скидки.");
                    }
                }
                else
                {
                    MessageBox.Show("Скидка для выбранной категории уже существует.");
                }
            }

            FillDiscountsListBox(); 
        }
        /// <summary>
        /// Осуществляет удаление скидки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null && DiscountsListBox.SelectedIndex != 0)
            {
                _currentCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
                FillDiscountsListBox();
            }
        }
    }
}
