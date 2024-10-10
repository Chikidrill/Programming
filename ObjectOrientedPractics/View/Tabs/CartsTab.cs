using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список предметов
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список покупателей
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Выбранный (текущий) покупатель
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Возвращает и задает список предметов
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                InitializeItemsList();
            }
        }

        /// <summary>
        /// Возвращает и задает список покупателей
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
                InitializeCustomersList();
            }
        }

        /// <summary>
        /// Возвращает и задает текущего (выбранного) покупателя
        /// </summary>
        private Customer CurrentCustomer
        {
            get => _currentCustomer;
            set
            {
                _currentCustomer = value;
                InitializeCartListBox(); 
            }
        }

        public CartsTab()
        {
            InitializeComponent();
            CustomerComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Инициализирует список предметов в ListBox
        /// </summary>
        public void InitializeItemsList()
        {
            ItemsListBox.DataSource = null; 
            if (Items != null && Items.Count > 0)
            {
                ItemsListBox.DataSource = Items;
                ItemsListBox.DisplayMember = "Name"; 
            }
        }

        /// <summary>
        /// Инициализирует список покупателей в ComboBox
        /// </summary>
        public void InitializeCustomersList()
        {
            if (_customers != null)
            {
                CustomerComboBox.DataSource = null; 
                CustomerComboBox.DataSource = _customers; 
                CustomerComboBox.DisplayMember = "FullName"; 
                CustomerComboBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Инициализирует корзину в ListBox
        /// </summary>
        private void InitializeCartListBox()
        {
            CartListBox.DataSource = null; 
            CartListBox.DataSource = CurrentCustomer?.Cart?.Items; 
            CartListBox.DisplayMember = "Name";
            UpdateTotalAmount();
        }

        /// <summary>
        /// Обновляет данные на вкладке
        /// </summary>
        public void RefreshData()
        {
            InitializeItemsList(); 
            InitializeCustomersList(); 
            CurrentCustomer = null; 
            InitializeCartListBox(); 
        }

        /// <summary>
        /// Осуществляет обновление общей стоимости
        /// </summary>
        private void UpdateTotalAmount()
        {
            if (CurrentCustomer != null && CurrentCustomer.Cart != null)
            {
                AmountLabel.Text = $"Total: {CurrentCustomer.Cart.Amount:C}";
            }
            else
            {
                AmountLabel.Text = "Total: $0.00";
            }
        }

        /// <summary>
        /// Осуществляет изменение выбранного покупателя в ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCustomer = (Customer)CustomerComboBox.SelectedItem; 
        }

        /// <summary>
        /// Осуществляет добавление предмета в корзину
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer.Cart == null)
            {
                CurrentCustomer.Cart = new Cart(); 
            }

            var selectedItem = (Item)ItemsListBox.SelectedItem;
            if (selectedItem != null)
            {
                CartListBox.DataSource = null;
                CurrentCustomer.Cart.Items.Add(selectedItem);
                CartListBox.DataSource = CurrentCustomer.Cart.Items;
                CartListBox.DisplayMember = "Name";
                UpdateTotalAmount();
            }
        }

        /// <summary>
        /// Осуществляет удаление предмета из корзины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            var selectedItem = (Item)CartListBox.SelectedItem;

            if (selectedItem != null && CurrentCustomer != null)
            {
                CartListBox.DataSource = null;
                CurrentCustomer.Cart.Items.Remove(selectedItem);
                CartListBox.DataSource = CurrentCustomer.Cart.Items;
                CartListBox.DisplayMember = "Name"; 
                UpdateTotalAmount();
            }
        }

        /// <summary>
        /// Осуществляет очищение корзины покупателя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            CurrentCustomer.Cart.Items.Clear();
            CartListBox.DataSource = null;
            UpdateTotalAmount();
            InitializeCartListBox();
        }

        /// <summary>
        /// Осуществляет создание заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer.IsPriority == true)
            {
                if (CurrentCustomer == null || CurrentCustomer.Cart.Items.Count == 0)
                {
                    MessageBox.Show("Выберите покупателя и добавьте товары в корзину.");
                    return;
                }
                var newPriorityOrder = new PriorityOrder(CurrentCustomer.Address, CurrentCustomer.FullName, DeliveryTimeRange.From9To11, DateTime.Now.AddDays(1))
                {
                    Items = new List<Item>(CurrentCustomer.Cart.Items)
                };
                CurrentCustomer.Orders.Add(newPriorityOrder);
                CurrentCustomer.Cart.Items.Clear();
                CartListBox.DataSource = null;
                UpdateTotalAmount();
                MessageBox.Show("Заказ приоритетного покупателя успешно создан!");
            }
            else
            {
                if (CurrentCustomer == null || CurrentCustomer.Cart.Items.Count == 0)
                {
                    MessageBox.Show("Выберите покупателя и добавьте товары в корзину.");
                    return;
                }
                var newOrder = new Order(CurrentCustomer.Address, CurrentCustomer.FullName)
                {
                    Items = new List<Item>(CurrentCustomer.Cart.Items)
                };
                CurrentCustomer.Orders.Add(newOrder);
                CurrentCustomer.Cart.Items.Clear();
                CartListBox.DataSource = null;
                UpdateTotalAmount();
                MessageBox.Show("Заказ успешно создан!");
            }

        }
        }
    }
