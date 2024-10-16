﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий и хранящий информацию о "товаре".
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Генератор ID
        /// </summary>
        private static IdGenerator IdGenerator = new IdGenerator();
        /// <summary>
        /// Уникальный идентификатор для объекта класса <see cref="Item"/>. Доступен только для чтения.
        /// </summary>
        private readonly int _id; [JsonInclude]

        /// <summary>
        /// Название товара для каждого объекта класса <see cref="Item"/>. 
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о товаре для каждого объекта класса <see cref="Item"/>. 
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара для каждого объекта класса <see cref="Item"/>. 
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает ID. Является полем, доступным только для чтения.
        /// </summary>

        /// <summary>
        /// Возвращает значение ID
        /// </summary>
        public int Id 
        {
            get 
            {  
                return _id; 
            }
        }
        /// <summary>
        /// Вовзращает и задает категорию товара из перечисления Category
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает название товара
        /// </summary>
        public string Name
        {
            get { return _name; }
            set 
            { 
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает и задает информацию о товаре. Не может быть длиной больше 1000 символов.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set 
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }
        /// <summary>
        /// Возвращает и задает стоимость товара. Не может быть меньше 0 и больше 100 000.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set 
            {
                ValueValidator.AssertValueInRange(value,0,100000, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Информация о товаре.</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <param name="category">Категория товара.</param>

        [JsonConstructor]
        public Item(string name, string info, double cost, Category category)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }
        public Item() { }
    }
}
