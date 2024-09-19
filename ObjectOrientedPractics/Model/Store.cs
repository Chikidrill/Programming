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

        /// <summary>
        /// Получает и задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Получает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        /// <summary>
        /// Загружает данные о товарах и покупателях из файлов.
        /// </summary>
        public void LoadData()
        {
            LoadItems();
            LoadCustomers();
        }

        /// <summary>
        /// Загружает данные о товарах из файла <see cref="itemsFilePath"/>.
        /// Если файл не существует или происходит ошибка при его чтении, выводится сообщение об ошибке.
        /// </summary>
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

        /// <summary>
        /// Загружает данные о покупателях из файла <see cref="customersFilePath"/>.
        /// Если файл не существует или происходит ошибка при его чтении, выводится сообщение об ошибке.
        /// </summary>
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

        /// <summary>
        /// Сохраняет текущие данные о товарах и покупателях в соответствующие файлы.
        /// </summary>
        public void SaveData()
        {
            SaveItems();
            SaveCustomers();
        }

        /// <summary>
        /// Сохраняет данные о товарах в файл <see cref="itemsFilePath"/>.
        /// Если возникает ошибка при сохранении, выводится сообщение об ошибке.
        /// </summary>
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

        /// <summary>
        /// Сохраняет данные о покупателях в файл <see cref="customersFilePath"/>.
        /// Если возникает ошибка при сохранении, выводится сообщение об ошибке.
        /// </summary>
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

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Store"/> и создает пустые списки для товаров и покупателей.
        /// </summary>
        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();
        }
    }
}
