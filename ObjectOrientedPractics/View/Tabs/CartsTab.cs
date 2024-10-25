using ObjectOrientedPractics.Model.Orders;
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
                // Основная общая сумма товаров в корзине
                double totalAmount = CurrentCustomer.Cart.Amount;

                // Сумма после применения всех скидок
                double amountWithDiscounts = totalAmount;

                // Рассчитываем все скидки, если они есть
                foreach (var discount in CurrentCustomer.Discounts)
                {
                    double discountAmount = discount.Calculate(CurrentCustomer.Cart.Items);
                    amountWithDiscounts -= discountAmount;
                    DiscountAmountLabel.Text = $"Discount: {discountAmount}";
                }

                // Отображаем обновленную информацию о сумме
                TotalAmountLabel.Text = $"Total: {amountWithDiscounts}";
                AmountLabel.Text = $"Total: {totalAmount}";

                // Отображаем информацию о накопительной скидке

            }
            else
            {
                AmountLabel.Text = "Total: $0.00";
                TotalAmountLabel.Text = "Total: $0.00";
                DiscountAmountLabel.Text = "Discount: $0.00";
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
            InitializeDiscountCheckedListBox();
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
                UpdateTotalDiscountAmount();
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
                UpdateTotalDiscountAmount();
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
            if (CurrentCustomer == null || CurrentCustomer.Cart.Items.Count == 0)
            {
                MessageBox.Show("Выберите покупателя и добавьте товары в корзину.");
                return;
            }

            double discountSum = 0;

            if (CurrentCustomer.IsPriority)
            {
                for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
                {
                    if (DiscountCheckedListBox.GetItemChecked(i))
                    {
                        if (CurrentCustomer.Discounts != null && CurrentCustomer.Discounts[i] != null)
                        {
                            discountSum += CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.Items);
                            CurrentCustomer.Discounts[i].Apply(CurrentCustomer.Cart.Items);
                            
                        }
                    }
                }
                if (CurrentCustomer.Discounts != null)
                {
                    foreach (var discount in CurrentCustomer.Discounts)
                    {
                        discount.Update(CurrentCustomer.Cart.Items);
                    }
                }

                var newPriorityOrder = new PriorityOrder(CurrentCustomer.Address, CurrentCustomer.FullName, DateTime.Now.AddDays(1), DeliveryTimeRange.From9To11)
                {
                    Items = new List<Item>(CurrentCustomer.Cart.Items),
                    DiscountAmount = discountSum 
                    
                };
                MessageBox.Show(discountSum.ToString());
                CurrentCustomer.Orders.Add(newPriorityOrder);
                MessageBox.Show("Заказ приоритетного покупателя успешно создан!");
                InitializeDiscountCheckedListBox();
            }
            else
            {
                for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
                {
                    if (DiscountCheckedListBox.GetItemChecked(i))
                    {
                        if (CurrentCustomer.Discounts != null && CurrentCustomer.Discounts[i] != null)
                        {
                            discountSum += CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.Items);
                            CurrentCustomer.Discounts[i].Apply(CurrentCustomer.Cart.Items);

                        }
                    }
                }

                if (CurrentCustomer.Discounts != null)
                {
                    foreach (var discount in CurrentCustomer.Discounts)
                    {
                        discount.Update(CurrentCustomer.Cart.Items);
                    }
                }
                var newOrder = new Order(CurrentCustomer.Address, CurrentCustomer.FullName)
                {
                    Items = new List<Item>(CurrentCustomer.Cart.Items),
                    DiscountAmount = discountSum
                };
                MessageBox.Show(discountSum.ToString());
                CurrentCustomer.Orders.Add(newOrder);
                MessageBox.Show("Заказ успешно создан!");
                InitializeDiscountCheckedListBox();
            }

            CurrentCustomer.Cart.Items.Clear();
            CartListBox.DataSource = null;
            UpdateTotalAmount(); 
            UpdateTotalDiscountAmount(); 
        }
        /// <summary>
        /// Осуществляет изменение скидки в зависимости от выделенных элементов в CheckedListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiscountCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            double discountSum = 0.0;

            if (CurrentCustomer != null)
            {
                for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
                {
                    if (i == e.Index)
                    {
                        if (e.NewValue == CheckState.Checked)
                        {
                            discountSum += CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.Items);
                            
                        }
                    }
                    else
                    {
                        if (DiscountCheckedListBox.GetItemChecked(i))
                        {
                            discountSum += CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.Items);
                        }
                    }
                }
            }
            DiscountAmountLabel.Text = $"Discount: {discountSum}";
            UpdateTotalAmountWithDiscount(discountSum);
        }
        /// <summary>
        /// Обновляет общий размер скидки
        /// </summary>
        private void UpdateTotalDiscountAmount()
        {
            double discountSum = CalculateDiscountSum();
            DiscountAmountLabel.Text = $"Discount: {discountSum}";
        }
        /// <summary>
        /// Обновляет стоимость с учетом скидки
        /// </summary>
        /// <param name="discountSum">Размер скидки</param>
        private void UpdateTotalAmountWithDiscount(double discountSum)
        {
            if (CurrentCustomer != null && CurrentCustomer.Cart != null)
            {
                double totalAmount = CurrentCustomer.Cart.Amount;
                double amountWithDiscounts = totalAmount - discountSum;

                TotalAmountLabel.Text = $"Total: {amountWithDiscounts}";
                AmountLabel.Text = $"Total: {totalAmount}";
            }
            else
            {
                AmountLabel.Text = "Total: $0.00";
                TotalAmountLabel.Text = "Total: $0.00";
            }
        }
        /// <summary>
        /// Рассчитывает общий размер скидки
        /// </summary>
        /// <returns></returns>
        private double CalculateDiscountSum()
        {
            double discountSum = 0.0;

            if (CurrentCustomer != null && CurrentCustomer.Discounts != null)
            {
                for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
                {
                    bool isChecked = DiscountCheckedListBox.GetItemChecked(i);
                    if (isChecked && CurrentCustomer.Discounts[i] != null)
                    {
                        discountSum += CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.Items);
                    }
                }
            }

            return discountSum;
        }
        /// <summary>
        /// Инициализирует значениями CheckedListBox
        /// </summary>
        private void InitializeDiscountCheckedListBox()
        {
            DiscountCheckedListBox.Items.Clear();

            if (CurrentCustomer != null && CurrentCustomer.Discounts != null)
            {
                foreach (var discount in CurrentCustomer.Discounts)
                {
                    DiscountCheckedListBox.Items.Add(discount.Info, true); 
                }
            }
        }
    }
}