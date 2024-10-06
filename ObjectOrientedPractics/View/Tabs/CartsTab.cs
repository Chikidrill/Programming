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
        // Поля для списка товаров и покупателей
        private List<Item> _items;
        private List<Customer> _customers;

        // Текущий выбранный покупатель
        private Customer _currentCustomer;

        // Свойства для списка товаров и покупателей
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                InitializeItemsList();
            }
        }

        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
                InitializeCustomersList();
            }
        }

        // Свойство для текущего покупателя
        private Customer CurrentCustomer
        {
            get => _currentCustomer;
            set
            {
                _currentCustomer = value;
                InitializeCartListBox(); // обновляем список корзины при изменении покупателя
            }
        }

        public CartsTab()
        {
            InitializeComponent();
            CustomerComboBox.SelectedIndex = -1;
        }

        // Метод для инициализации списка товаров
        public void InitializeItemsList()
        {
            ItemsListBox.DataSource = null; // Сброс данных
            if (Items != null && Items.Count > 0)
            {
                ItemsListBox.DataSource = Items;
                ItemsListBox.DisplayMember = "Name"; // Отображаемое свойство
            }
        }

        // Метод для инициализации списка покупателей
        public void InitializeCustomersList()
        {
            if (_customers != null)
            {
                CustomerComboBox.DataSource = null; // Сбрасываем DataSource
                CustomerComboBox.DataSource = _customers; // Присваиваем новый источник данных
                CustomerComboBox.DisplayMember = "FullName"; // Отображаем имя покупателя
                CustomerComboBox.SelectedIndex = -1;
            }
        }

        // Инициализация товаров в корзине текущего покупателя
        private void InitializeCartListBox()
        {
            CartListBox.DataSource = null; // Сбрасываем DataSource
            CartListBox.DataSource = CurrentCustomer?.Cart?.Items; // Присваиваем новый источник данных
            CartListBox.DisplayMember = "Name";
            UpdateTotalAmount();
        }

        public void RefreshData()
        {
            InitializeItemsList(); // Перезаполняем ListBox с товарами
            InitializeCustomersList(); // Перезаполняем ComboBox с покупателями
            CurrentCustomer = null; // Сбрасываем выбранного покупателя
            InitializeCartListBox(); // Обновляем ListBox с корзиной
        }

        // Обработчик изменения выбора покупателя
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCustomer = (Customer)CustomerComboBox.SelectedItem; // Устанавливаем выбранного покупателя
        }

        // Обработчик добавления товара в корзину
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer.Cart == null)
            {
                CurrentCustomer.Cart = new Cart(); // Инициализация корзины, если не инициализирована
            }

            var selectedItem = (Item)ItemsListBox.SelectedItem;
            if (selectedItem != null)
            {
                // Сбрасываем DataSource
                CartListBox.DataSource = null;

                // Добавляем выбранный товар в корзину
                CurrentCustomer.Cart.Items.Add(selectedItem);

                // Снова устанавливаем DataSource
                CartListBox.DataSource = CurrentCustomer.Cart.Items;
                CartListBox.DisplayMember = "Name";

                // Обновляем общую стоимость корзины
                UpdateTotalAmount();
            }
        }

        // Обработчик удаления товара из корзины
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            var selectedItem = (Item)CartListBox.SelectedItem;

            if (selectedItem != null && CurrentCustomer != null)
            {
                // Сбрасываем DataSource, чтобы можно было изменять список
                CartListBox.DataSource = null;

                // Удаляем выбранный товар из корзины
                CurrentCustomer.Cart.Items.Remove(selectedItem);

                // Снова устанавливаем DataSource после изменения списка
                CartListBox.DataSource = CurrentCustomer.Cart.Items;
                CartListBox.DisplayMember = "Name";  // Убедитесь, что отображаем имя товара

                // Обновляем общую стоимость корзины
                UpdateTotalAmount();
            }
        }

        // Метод для обновления отображения общей суммы корзины
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

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            CurrentCustomer.Cart.Items.Clear();
            CartListBox.DataSource = null;
            UpdateTotalAmount();
            InitializeCartListBox();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null || CurrentCustomer.Cart.Items.Count == 0)
            {
                MessageBox.Show("Выберите покупателя и добавьте товары в корзину.");
                return;
            }

            // Создайте новый заказ
            var newOrder = new Order(CurrentCustomer.Address);

            // Добавьте новый заказ в список заказов покупателя
            CurrentCustomer.Orders.Add(newOrder);

            // Очистите корзину
            CurrentCustomer.Cart.Items.Clear();

            // Обновите интерфейс
            CartListBox.DataSource = null; // Обновление ListBox
            UpdateTotalAmount(); // Обновление общей стоимости

            MessageBox.Show("Заказ успешно создан!");
        } 
    }
}
