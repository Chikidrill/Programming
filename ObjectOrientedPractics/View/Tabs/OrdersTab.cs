using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
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
    public partial class OrdersTab : UserControl
    {
        private List<Order> _orders;
        private Order _selectedOrder;

        public OrdersTab()
        {
            InitializeComponent();
            LoadOrders();
            InitializeDataGridView();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
        }

        public List<Customer> Customers { get; set; }

        public Order SelectedOrder
        {
            get { return _selectedOrder; }
            private set { _selectedOrder = value; }
        }
        private void InitializeDataGridView()
        {
            OrdersDataGridView.Columns.Clear();

            // Столбец для Id заказа
            var idColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Order Id",
                DataPropertyName = "Id",  // Свойство класса Order
                ReadOnly = true
            };
            OrdersDataGridView.Columns.Add(idColumn);

            // Столбец для даты создания
            var creationDateColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Creation Date",
                DataPropertyName = "CreationDate",  // Свойство класса Order
                ReadOnly = true
            };
            OrdersDataGridView.Columns.Add(creationDateColumn);

            // Столбец для ФИО покупателя
            var customerNameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Customer Full Name",
                DataPropertyName = "FullName",  // Свойство класса Order
                ReadOnly = true
            };
            OrdersDataGridView.Columns.Add(customerNameColumn);

            // Столбец для адреса доставки
            var addressColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Delivery Address",
                DataPropertyName = "DeliveryAddress",  // Свойство класса Order (для простоты преобразуем в строку)
                ReadOnly = true
            };
            OrdersDataGridView.Columns.Add(addressColumn);

            // Столбец для общей стоимости
            var totalCostColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Cost",
                DataPropertyName = "TotalCost",  // Свойство класса Order
                ReadOnly = true
            };
            OrdersDataGridView.Columns.Add(totalCostColumn);

            // Столбец для статуса заказа
            var statusColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status",  // Свойство класса Order
                ReadOnly = true
            };
            OrdersDataGridView.Columns.Add(statusColumn);

            // Настройки для DataGridView
            OrdersDataGridView.AutoGenerateColumns = false;
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrdersDataGridView.AllowUserToResizeColumns = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.AllowUserToOrderColumns = false;
        }

        private void SetOrders(List<Order> orders)
        {
            _orders = orders;
            LoadOrders();
        }

        // Method to load orders into DataGridView
        private void LoadOrders()
        {
            OrdersDataGridView.DataSource = null; // Clear the DataGridView first
            OrdersDataGridView.DataSource = _orders; // Set the DataGridView's DataSource to the list of orders
        }
        public void UpdateOrders()
        {
            if (Customers == null || Customers.Count == 0)
            {
                MessageBox.Show("Customers list is empty or null.");
                return;
            }

            List<Order> orders = new List<Order>();

            // Собираем все заказы от всех покупателей
            foreach (var customer in Customers)
            {
                orders.AddRange(customer.Orders);
            }

            // Привязываем список заказов к DataGridView
            OrdersDataGridView.DataSource = null;
            OrdersDataGridView.DataSource = orders;
        }

        private void OrdersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что была выбрана строка
            if (e.RowIndex >= 0)
            {
                //   Получаем выбранную строку
                DataGridViewRow selectedRow = OrdersDataGridView.Rows[e.RowIndex];
                SelectedOrder = (Order)selectedRow.DataBoundItem;

                //  Извлекаем данные из выбранной строки
                var orderId = selectedRow.Cells[0].Value.ToString();
                var creationDate = selectedRow.Cells[1].Value.ToString();
                var FullName = selectedRow.Cells[2].Value.ToString();
                var deliveryAddress = selectedRow.Cells[3].Value.ToString();
                var totalCost = selectedRow.Cells[4].Value.ToString();
                var status = selectedRow.Cells[5].Value.ToString();

                // Присваиваем данные текстовым полям
                OrderIdTextBox.Text = orderId;
                OrderCreationTimeTextBox.Text = creationDate;
                StatusComboBox.SelectedItem = SelectedOrder.Status;
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedOrder != null)
            {
                // Получаем новое значение статуса из ComboBox
                OrderStatus newStatus = (OrderStatus)StatusComboBox.SelectedItem;

                // Обновляем статус выбранного заказа
                SelectedOrder.Status = newStatus;

                // Обновляем DataGridView (если требуется)
                UpdateOrders();
            }
        }

        public void RefreshData()
        {
            UpdateOrders();
            SelectedOrder = null;
        }
    }
}
