using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ObjectOrientedPractics.Model.Item;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список заказов
        /// </summary>
        private List<Order> _orders;
        /// <summary>
        /// Список предметов
        /// </summary>
        private List<ItemsTab> _items;
        /// <summary>
        /// Текущий выбранный заказ
        /// </summary>
        private Order _selectedOrder;

        private PriorityOrder _selectedPriorityOrder;

        /// <summary>
        /// Элемент AddressControl
        /// </summary>
        private AddressControl _addressControl;

        /// <summary>
        /// Возвращает и задает список покупателей
        /// </summary>
        public List<Customer> Customers { get; set; }

        PriorityOrder? SelectedPriorityOrder { get; set; }

        /// <summary>
        /// Возвращает и задает текущий выбранный заказ
        /// </summary>
        public Order SelectedOrder
        {
            get => _selectedOrder;
            set
            {
                _selectedOrder = value;
                if (_selectedOrder is PriorityOrder priorityOrder)
                {

                    _selectedPriorityOrder = priorityOrder;
                    delivTimePanel.Visible = true;
                    delivTimeComboBox.SelectedItem = _selectedPriorityOrder.DesiredDeliveryTime.ToString();
                }
                else
                {
                    _selectedPriorityOrder = null;
                    delivTimePanel.Visible = false;
                }
            }
        }
        public OrdersTab()
        {
            InitializeComponent();
            LoadOrders();
            InitializeDataGridView();
            InitializeAddressControl();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            totalAmountLabel.Text = "Total: $0.00";
            delivTimeComboBox.DataSource = Enum.GetValues(typeof(DeliveryTimeRange));
        }
        /// <summary>
        /// Инициализирует элемент управления AddressControl
        /// </summary>
        private void InitializeAddressControl()
        {
            _addressControl = new AddressControl
            {
                Location = new System.Drawing.Point(435, 150),
                Size = new System.Drawing.Size(590, 500)
            };
            Controls.Add(_addressControl);
            _addressControl.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
        }

        /// <summary>
        /// Осуществляет отображение списка предметов в заказе
        /// </summary>
        /// <param name="items"></param>
        private void DisplayOrderItems(List<Item> items)
        {
            OrderItemsRichTextBox.Clear();
            if (items != null && items.Count > 0)
            {
                StringBuilder itemsText = new StringBuilder();
                foreach (var item in items)
                {
                    itemsText.AppendLine($"Name: {item.Name}, Cost: {item.Cost}");
                }
                OrderItemsRichTextBox.Text = itemsText.ToString();
            }
            else
            {
                OrderItemsRichTextBox.Text = "No items in this order.";
            }
        }

        /// <summary>
        /// Инициализирует таблицу заказов OrdersDataGridView
        /// </summary>
        private void InitializeDataGridView()
        {
            OrdersDataGridView.Columns.Clear();
            var idColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Order Id",
                DataPropertyName = "Id",
                ReadOnly = true
            };
            OrdersDataGridView.Columns.Add(idColumn);

            var creationDateColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Creation Date",
                DataPropertyName = "CreationDate",
                ReadOnly = true
            };
            OrdersDataGridView.Columns.Add(creationDateColumn);

            var customerNameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Customer Full Name",
                DataPropertyName = "FullName",
                ReadOnly = true
            };
            OrdersDataGridView.Columns.Add(customerNameColumn);

            var addressColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Delivery Address",
                DataPropertyName = "DeliveryAddress",
                ReadOnly = true
            };
            OrdersDataGridView.Columns.Add(addressColumn);

            var totalCostColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Cost",
                DataPropertyName = "TotalCost",
                ReadOnly = true
            };
            OrdersDataGridView.Columns.Add(totalCostColumn);

            var statusColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status",
                ReadOnly = true
            };
            OrdersDataGridView.Columns.Add(statusColumn);

            var priorityColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Priority",
                DataPropertyName = "Priority",
                ReadOnly = true
            };
            OrdersDataGridView.Columns.Add(priorityColumn);

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

        /// <summary>
        /// Осуществляет загрузку заказов в таблицу
        /// </summary>
        private void LoadOrders()
        {
            OrdersDataGridView.DataSource = null;
            OrdersDataGridView.DataSource = _orders;
        }

        /// <summary>
        /// Осуществляет обновление списка заказов
        /// </summary>
        public void UpdateOrders()
        {
            if (Customers == null || Customers.Count == 0)
            {
                MessageBox.Show("Customers list is empty or null.");
                return;
            }

            List<Order> orders = new List<Order>();
            foreach (var customer in Customers)
            {
                orders.AddRange(customer.Orders);
            }
            OrdersDataGridView.DataSource = null;
            OrdersDataGridView.DataSource = orders;
        }

        /// <summary>
        /// Осуществляет отображение данных о выбранном в таблице заказе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrdersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = OrdersDataGridView.Rows[e.RowIndex];
                SelectedOrder = (Order)selectedRow.DataBoundItem;

                var orderId = selectedRow.Cells[0].Value.ToString();
                var creationDate = selectedRow.Cells[1].Value.ToString();
                var FullName = selectedRow.Cells[2].Value.ToString();
                var deliveryAddress = selectedRow.Cells[3].Value.ToString();
                var totalCost = selectedRow.Cells[4].Value.ToString();
                var status = selectedRow.Cells[5].Value.ToString();

                OrderIdTextBox.Text = orderId;
                OrderCreationTimeTextBox.Text = creationDate;
                StatusComboBox.SelectedItem = SelectedOrder.Status;
                _addressControl.DisplayAddress(SelectedOrder.DeliveryAddress);
                DisplayOrderItems(SelectedOrder.Items);
                totalAmountLabel.Text = $"Total: {totalCost} $";
            }
        }

        /// <summary>
        /// Осуществляет изменение параметра Status в ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedOrder != null)
            {
                OrderStatus newStatus = (OrderStatus)StatusComboBox.SelectedItem;
                SelectedOrder.Status = newStatus;
                UpdateOrders();
            }
        }

        /// <summary>
        /// Осуществляет обновление данных
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
            SelectedOrder = null;
        }

        private void delivTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedOrder != null)
            {
                DeliveryTimeRange newDeliveryTime = (DeliveryTimeRange)delivTimeComboBox.SelectedItem;
                _selectedPriorityOrder.DesiredDeliveryTime = newDeliveryTime;
                UpdateOrders();
            }
        }
    }
}
