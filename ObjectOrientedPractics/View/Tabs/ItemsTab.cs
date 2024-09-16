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
        /// 
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
                SaveItemsList();
                DisplayItemsList();
            }
            catch (Exception ex)
            {
                CostTextBox.BackColor = AppColors.InvalidColor;
                //   MessageBox.Show(ex.Message);
            }
        }

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

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CategoryComboBox.SelectedIndex;

            try
            {
                if (selectedIndex != -1 && Enum.TryParse(CategoryComboBox.SelectedItem?.ToString(), out Category category))
                {
                    Item selectedItem = _items[selectedIndex];
                    selectedItem.Category = category;
                    ItemsListBox.Items[selectedIndex] = selectedItem;

                    SaveItemsList();
                    DisplayItemsList();
                }
            }
            catch (Exception ex)
            {

            }
        }
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
        /// Осуществляет сохранение данных в файл.
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
