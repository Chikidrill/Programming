using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.Text.Json;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private Item _currentItem;
        private string filePath = "items.json";
        private List<Item> _displayedItems = new List<Item>();

        public ItemsTab()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            SortComboBox.Items.AddRange(["Name", "Cost (Ascending)", "Cost (Descending)"]);
            SortComboBox.SelectedIndex = 0;
            DisplayItemsList();
        }
        private IdGenerator idGenerator = new IdGenerator();

        /// <summary>
        /// Задает и возвращает список _items 
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                _displayedItems = new List<Item>(_items);
                DisplayItemsList();
            }
        }

        /// <summary>
        /// Осуществляет добавление нового элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем новый элемент с данными из текстовых полей
                var newItem = new Item(NameTextBox.Text, DescriptionTextBox.Text, double.Parse(CostTextBox.Text), (Category)CategoryComboBox.SelectedItem);

                // Добавляем новый элемент в основной список и список отображаемых предметов
                _items.Add(newItem);
                _displayedItems.Add(newItem);

                // Сбрасываем текстовые поля
                ClearInputFields();

                // Обновляем список элементов на форме
                DisplayItemsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении предмета: {ex.Message}");
            }
        }
        /// <summary>
        /// Осуществляет удаление выбранного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                var itemToRemove = _displayedItems[selectedIndex];

                // Удаляем из обоих списков
                _items.Remove(itemToRemove);
                _displayedItems.Remove(itemToRemove);

                DisplayItemsList();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Выберите предмет для удаления.");
            }
        }
        /// <summary>
        /// Осуществляет сброс выбранного элемента и очищение полей ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            _currentItem = null;
            IdTextBox.Text = string.Empty;
            CostTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            CategoryComboBox.SelectedIndex = -1;
            CostTextBox.BackColor = AppColors.StandartColor;
            NameTextBox.BackColor = AppColors.StandartColor;
            DescriptionTextBox.BackColor = AppColors.StandartColor;
            CategoryComboBox.BackColor = AppColors.StandartColor;

            // Сбрасываем выделение в ItemsListBox
            ItemsListBox.ClearSelected();
        }
        /// <summary>
        /// Осуществляет изменение значения поля Name у выбранного элемента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = AppColors.StandartColor;
                if (_currentItem == null)
                {
                    _currentItem = new Item();
                }
                string name = NameTextBox.Text;
                _currentItem.Name = name;
            }
            catch (Exception ex)
            {
                NameTextBox.BackColor = AppColors.InvalidColor;
                // MessageBox.Show(ex.Message);
            }
            
        }
        /// <summary>
        /// Осуществляет изменение значения поля Description у выбранного элемента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DescriptionTextBox.BackColor = AppColors.StandartColor;
                if (_currentItem == null)
                {
                    _currentItem = new Item();
                }
                string description = DescriptionTextBox.Text;
                _currentItem.Info = description;
            }
            catch (Exception ex)
            {
                DescriptionTextBox.BackColor = AppColors.InvalidColor;
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Осуществляет изменение значения поля Cost у выбранного элемента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                CostTextBox.BackColor = AppColors.StandartColor;
                double cost = double.Parse(CostTextBox.Text);

                if (_currentItem == null)
                {
                    _currentItem = new Item();
                }

                _currentItem.Cost = cost;

            }
            catch (Exception ex)
            {
                CostTextBox.BackColor = AppColors.InvalidColor;
                //   MessageBox.Show(ex.Message);
            }
            DisplayItemsList();
        }
        /// <summary>
        /// Осуществляет изменение значения поля Category у выбранного элемента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentItem == null) return;
            int selectedIndex = CategoryComboBox.SelectedIndex;
            try
            {
                if (Enum.TryParse(CategoryComboBox.SelectedItem?.ToString(), out Category category))
                {
                    _currentItem.Category = category;
                    DisplayItemsList(); // Обновление списка отображаемых элементов
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        /// <summary>
        /// Функция отображения выбранного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;
            
            // Проверяем, что выбранный индекс не выходит за пределы _displayedItems
            if (selectedIndex < 0 || selectedIndex >= _displayedItems.Count)
            {
                return;
            }

            // Получаем выбранный элемент напрямую из _displayedItems
            _currentItem = _displayedItems[selectedIndex];

            // Обновляем поля UI с информацией из _currentItem
            IdTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameTextBox.Text = _currentItem.Name;
            DescriptionTextBox.Text = _currentItem.Info;
            CategoryComboBox.Text = _currentItem.Category.ToString();
        }
        /// <summary>
        /// Функция отображения элементов в ЛистБокс
        /// </summary>
        private void DisplayItemsList()
        {
            // Сохраняем выбранный элемент
            var selectedIndex = ItemsListBox.SelectedIndex;
            
            // Обновляем ListBox, не меняя изначальный список _items
            ItemsListBox.Items.Clear();
            foreach (var item in _displayedItems)
            {
                ItemsListBox.Items.Add($"ID: {item.Id} Item name: {item.Name} - Item cost: {item.Cost}");
            }

            // Восстанавливаем выбранный элемент
            if (selectedIndex >= 0 && selectedIndex < ItemsListBox.Items.Count)
            {
                ItemsListBox.SelectedIndex = selectedIndex;
            }
        }
        /// <summary>
        /// Функция очищения полей ввода
        /// </summary>
        private void ClearInputFields()
        {
            IdTextBox.Text = null;
            NameTextBox.Text = null;
            DescriptionTextBox.Text = null;
            CostTextBox.Text = null;
            CategoryComboBox.SelectedIndex = -1;
            CostTextBox.BackColor = AppColors.StandartColor;
            NameTextBox.BackColor = AppColors.StandartColor;
            DescriptionTextBox.BackColor = AppColors.StandartColor;
            CategoryComboBox.BackColor = AppColors.StandartColor;

        }
        /// <summary>
        /// Обрабатывает изменения текста в SearchTextBox и осуществляет фильтрацию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            
            string searchText = SearchTextBox.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                _displayedItems = new List<Item>(_items);
            }
            else
            {
                _displayedItems = DataTools.Filter(_items, item => item.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase));
            }
            DisplayItemsList();
        }
        /// <summary>
        /// Обновляет ItemsListBox
        /// </summary>
        private void UpdateItemsListBox()
        {
            
            var selectedItem = _currentItem;

            string searchText = SearchTextBox.Text;
            // Фильтруем и сортируем элементы, основываясь на выбранных критериях
            var filteredItems = DataTools.Filter(_items, item => item.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase));
            List<Item> sortedItems;
            switch (SortComboBox.SelectedIndex)
            {
                case 1:
                    sortedItems = DataTools.Sort(filteredItems, (item1, item2) => item1.Cost > item2.Cost);
                    break;
                case 2:
                    sortedItems = DataTools.Sort(filteredItems, (item1, item2) => item1.Cost < item2.Cost);
                    break;
                default:
                    sortedItems = DataTools.Sort(filteredItems, (item1, item2) => string.Compare(item1.Name, item2.Name, StringComparison.OrdinalIgnoreCase) > 0);
                    break;
            }

            // Обновляем _displayedItems и ListBox
            _displayedItems = sortedItems;
            DisplayItemsList();

            // Восстанавливаем выделение выбранного элемента
            if (selectedItem != null)
            {
                ItemsListBox.SelectedItem = _displayedItems.FirstOrDefault(item => item.Id == selectedItem.Id);
            }
        }

        /// <summary>
        /// Осуществляет изменение выбранного элемента в SortComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItemsListBox();
            if (_currentItem != null)
            {
                ItemsListBox.SelectedItem = _currentItem;
            }

        }
    }
}
