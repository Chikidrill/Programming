using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        private List<Item> _items;
        private List<Customer> _customers;
        private string itemsFilePath = "items.json";
        private string customersFilePath = "customers.json";

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Store"/> class.
        /// </summary>


        /// <summary>
        /// Adds a new item to the store.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void LoadData()
        {
            LoadItems();
            LoadCustomers();
        }

        private void LoadItems()
        {
            if (File.Exists(itemsFilePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(itemsFilePath);
                    _items = JsonSerializer.Deserialize<List<Item>>(jsonString) ?? new List<Item>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении файла с товарами: " + ex.Message);
                }
            }
        }

        private void LoadCustomers()
        {
            if (File.Exists(customersFilePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(customersFilePath);
                    _customers = JsonSerializer.Deserialize<List<Customer>>(jsonString) ?? new List<Customer>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении файла с покупателями: " + ex.Message);
                }
            }
        }

        public void SaveData()
        {
            SaveItems();
            SaveCustomers();
        }

        private void SaveItems()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(_items, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(itemsFilePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла с товарами: " + ex.Message);
            }
        }

        private void SaveCustomers()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(_customers, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(customersFilePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла с покупателями: " + ex.Message);
            }
        }
        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();
        }
    }
}
