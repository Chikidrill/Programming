using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    public class PriorityOrder : Order
    {
        private DeliveryTimeRange _deliveryTime;
        private DateTime _deliveryDate;
        public bool IsPriority { get; set; }
        /// <summary>
        /// Возвращает и задаёт время доставки.
        /// </summary>
        public DeliveryTimeRange DesiredDeliveryTime
        {
            get { return _deliveryTime; }
            set { _deliveryTime = value; }
        }

        /// <summary>
        /// Возвращает и задаёт дату доставки.
        /// </summary>
        public DateTime DesiredDeliveryDate
        {
            get { return _deliveryDate; }
            set { _deliveryDate = value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="deliveryAddress">Адрес доставки.</param>
        /// <param name="customerName">Имя покупателя.</param>
        /// <param name="totalPrice">Итоговая цена.</param>
        /// <param name="customerId">ID покупателя.</param>
        /// <param name="desiredDeliveryTime">Время доставки.</param>
        /// <param name="deliveryDate">Дата доставки.</param>
        public PriorityOrder(Address deliveryAddress, string fullName, DeliveryTimeRange desiredDeliveryTime, DateTime deliveryDate)
            : base(deliveryAddress, fullName)  // Вызов конструктора базового класса
        {
            DesiredDeliveryTime = desiredDeliveryTime;
            DesiredDeliveryDate = deliveryDate;
        }

        public PriorityOrder() : base() 
        {
            DesiredDeliveryDate = DateTime.Now.AddDays(1); // Например, завтрашняя дата
            DesiredDeliveryTime = DeliveryTimeRange.From9To11;
        }
    }
}
