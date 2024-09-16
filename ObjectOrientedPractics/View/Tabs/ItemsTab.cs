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

        public ItemsTab()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            LoadItemsList();
            DisplayItemsList();
        }
        private IdGenerator idGenerator = new IdGenerator();
        /// <summary>
        /// Осуществляет добавление нового элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var newItem = new Item(NameTextBox.Text, DescriptionTextBox.Text, double.Parse(CostTextBox.Text), (Category)CategoryComboBox.SelectedItem);
            IdTextBox.Text = newItem.Id.ToString();
            _items.Add(newItem);
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
            CostTextBox.Clear();
            SaveItemsList();
            ClearInputFields();
            DisplayItemsList();
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
                _items.RemoveAt(selectedIndex);
                SaveItemsList();
                DisplayItemsList();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Выберите песню для удаления.");
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
                SaveItemsList();
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
                SaveItemsList();
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
            DisplayItemsList();
            try
            {
                CostTextBox.BackColor = AppColors.StandartColor;
                double cost = double.Parse(CostTextBox.Text);

                if (_currentItem == null)
                {
                    _currentItem = new Item();
                }

                _currentItem.Cost = cost;
                SaveItemsList();
                
            }
            catch (Exception ex)
            {
                CostTextBox.BackColor = AppColors.InvalidColor;
                //   MessageBox.Show(ex.Message);
            }
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
                    SaveItemsList(); // Сохранение изменений
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

            if (selectedIndex == -1) return;

            _currentItem = _items[selectedIndex];

            IdTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameTextBox.Text = _currentItem.Name.ToString();
            DescriptionTextBox.Text = _currentItem.Info.ToString();
            CategoryComboBox.Text = _currentItem.Category.ToString();
        }
        /// <summary>
        /// Функция отображения элементов в ЛистБокс
        /// </summary>
        private void DisplayItemsList()
        {
            // Очищаем ListBox перед добавлением обновленных данных
            ItemsListBox.Items.Clear();

            // Добавляем каждую песню из списка в ListBox
            foreach (Item item in _items)
            {
                ItemsListBox.Items.Add($"ID: {item.Id} Item name: {item.Name} - Item cost: {item.Cost}");
            }
        }
        /// <summary>
        /// Функция очищения полей ввода
        /// </summary>
        private void ClearInputFields()
        {
            IdTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            CostTextBox.Text = string.Empty;
            CategoryComboBox.SelectedIndex = -1;
            CostTextBox.BackColor = AppColors.StandartColor;
            NameTextBox.BackColor = AppColors.StandartColor;
            DescriptionTextBox.BackColor = AppColors.StandartColor;
            CategoryComboBox.BackColor = AppColors.StandartColor;

        }
        /// <summary>
        /// Функция загрузки данных из файла .json
        /// </summary>
        private void LoadItemsList()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(filePath);
                    _items = JsonSerializer.Deserialize<List<Item>>(jsonString) ?? new List<Item>();
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
        private void SaveItemsList()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(_items, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }
    }
}
