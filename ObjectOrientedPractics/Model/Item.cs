using System;
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
    public class Item: ICloneable, IEquatable<Item>, IComparable<Item>
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
        /// Событие изменения названия товара.
        /// </summary>
        public event EventHandler<EventArgs> NameChanged;
        /// <summary>
        /// Событие изменения описания товара.
        /// </summary>
        public event EventHandler<EventArgs> InfoChanged;
        /// <summary>
        /// Событие изменения стоимости товара.
        /// </summary>
        public event EventHandler<EventArgs> CostChanged;

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
        /// Возвращает и задает категорию товара из перечисления Category
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
                if (_name == value) return;
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
                NameChanged?.Invoke(this, EventArgs.Empty);
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
                if (_info == value) return;
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
                InfoChanged?.Invoke(this, EventArgs.Empty);
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
                if(_cost == value) return;
                ValueValidator.AssertValueInRange(value,0,100000, nameof(Cost));
                _cost = value;
                CostChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Информация о товаре.</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <param name="category">Категория товара.</param>

        /// <inheritdoc/>
        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }
        /// <inheritdoc/>
        public bool Equals(Item? item2)
        {
            if (item2 == null)
                return false;
            if (object.ReferenceEquals(this, item2))
                return true;
            return (Id == item2.Id);
        }
        /// <inheritdoc/>
        public int CompareTo(Item? item2)
        {
            if (item2 == null)
                return 1;
            if (object.ReferenceEquals(this, item2))
                return 0;
            if (Cost < item2.Cost)
            {
                return -1;
            }
            else if (Cost == item2.Cost)
            {
                return 0;
            }
            return 1;
        }

        [JsonConstructor]
        public Item(string name, string info, double cost, Category category)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }
        public Item() 
        {
            _id = IdGenerator.GetNextId();
        }
    }
}
