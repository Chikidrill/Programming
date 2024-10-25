using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        private List<Item> _items;
        private List<Customer> _customers;
        private List<Order> _orders;
        private string _itemsFilePath = "items.json";
        private string _customersFilePath = "customers.json";

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
        /// Загружает данные о товарах из файла <see cref="_itemsFilePath"/>.
        /// Если файл не существует или происходит ошибка при его чтении, выводится сообщение об ошибке.
        /// </summary>
        public void LoadItems()
        {
            if (File.Exists(_itemsFilePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(_itemsFilePath);
                    // Используем TypeNameHandling.All для сохранения информации о типах объектов
                    _items = JsonConvert.DeserializeObject<List<Item>>(jsonString, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    }) ?? new List<Item>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении файла с товарами: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Загружает данные о покупателях из файла <see cref="_customersFilePath"/>.
        /// Если файл не существует или происходит ошибка при его чтении, выводится сообщение об ошибке.
        /// </summary>
        public void LoadCustomers()
        {
            if (File.Exists(_customersFilePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(_customersFilePath);
                    // Используем TypeNameHandling.All для сохранения информации о типах объектов
                    _customers = JsonConvert.DeserializeObject<List<Customer>>(jsonString, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    }) ?? new List<Customer>();
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
        /// Сохраняет данные о товарах в файл <see cref="_itemsFilePath"/>.
        /// Если возникает ошибка при сохранении, выводится сообщение об ошибке.
        /// </summary>
        public void SaveItems()
        {
            try
            {
                // Используем TypeNameHandling.All для сохранения информации о типах объектов
                string jsonString = JsonConvert.SerializeObject(_items, Formatting.Indented, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                });
                File.WriteAllText(_itemsFilePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла с товарами: " + ex.Message);
            }
        }

        /// <summary>
        /// Сохраняет данные о покупателях в файл <see cref="_customersFilePath"/>.
        /// Если возникает ошибка при сохранении, выводится сообщение об ошибке.
        /// </summary>
        public void SaveCustomers()
        {
            try
            {
                // Используем TypeNameHandling.All для сохранения информации о типах объектов
                string jsonString = JsonConvert.SerializeObject(_customers, Formatting.Indented, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                });
                File.WriteAllText(_customersFilePath, jsonString);
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
            _orders = new List<Order>();
        }
    }
}
