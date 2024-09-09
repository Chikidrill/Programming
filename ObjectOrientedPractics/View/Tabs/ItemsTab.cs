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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private Item _currentItem;
        public ItemsTab()
        {
            InitializeComponent();
        }
        private IdGenerator idGenerator = new IdGenerator();
        private void AddButton_Click(object sender, EventArgs e)
        {
            var newItem = new Item(idGenerator.GetNextId(), NameTextBox.Text, DescriptionTextBox.Text, double.Parse(CostTextBox.Text));
            _items.Add(newItem);
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
            CostTextBox.Clear();
            ClearInputFields();
            DisplayItemsList();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _items.RemoveAt(selectedIndex);
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
            }
            catch (Exception ex)
            {
                DescriptionTextBox.BackColor = AppColors.InvalidColor;
                //  MessageBox.Show(ex.Message);
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

            if (selectedIndex != -1) { 
            
                _currentItem = _items[selectedIndex];


                CostTextBox.Text = _currentItem.Cost.ToString();
                NameTextBox.Text = _currentItem.Name;
                DescriptionTextBox.Text = _currentItem.Info;

            }
            else
            {
                _currentItem = null;
                CostTextBox.Text = string.Empty;
                NameTextBox.Text = string.Empty;
                DescriptionTextBox.Text = string.Empty;
            }

        }
        private void DisplayItemsList()
        {
            // Очищаем ListBox перед добавлением обновленных данных
            ItemsListBox.Items.Clear();

            // Добавляем каждую песню из списка в ListBox
            foreach (Item item in _items)
            {
                ItemsListBox.Items.Add($"Item name: {item.Name} - Item cost: {item.Cost}");
            }
        }

        private void ClearInputFields()
        {
            IdTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            CostTextBox.Text = string.Empty;


            if (ItemsListBox.SelectedIndex == -1)
            {
                ItemsListBox.SelectedItem = null;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _currentItem = null; 
            IdTextBox.Text = string.Empty;
            CostTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            CostTextBox.BackColor = AppColors.StandartColor;
            NameTextBox.BackColor = AppColors.StandartColor;
            DescriptionTextBox.BackColor = AppColors.StandartColor;
        }
    }
}
