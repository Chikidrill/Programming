using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.Model.Orders
{
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        private DateTime _desiredDeliveryDate;

        /// <summary>
        /// Желаемое время доставки.
        /// </summary>
        private DeliveryTimeRange _desiredDeliveryTime;

        /// <summary>
        /// Возвращает и задает желаемую дату доставки.
        /// </summary>
        public DateTime DesiredDeliveryDate
        {
            get => _desiredDeliveryDate;
            set => _desiredDeliveryDate = value;
        }
        public OrderStatus Status { get; set; }
        /// <summary>
        /// Возвращает и задает желаемое время доставки.
        /// </summary>
        public DeliveryTimeRange DesiredDeliveryTime
        {
            get => _desiredDeliveryTime;
            set => _desiredDeliveryTime = value;
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="PriorityOrder"/> с параметрами по умолчанию.
        /// </summary>
        public PriorityOrder() : base()
        {
            DesiredDeliveryDate = DateTime.Now.AddDays(1); // Например, завтрашняя дата
            DesiredDeliveryTime = DeliveryTimeRange.From9To11;
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="PriorityOrder"/> с указанными параметрами.
        /// </summary>
        /// <param name="deliveryAddress">Адрес доставки.</param>
        /// <param name="fullName">Имя покупателя.</param>
        /// <param name="deliveryTime">Желаемое время доставки.</param>
        /// <param name="deliveryDate">Желаемая дата доставки.</param>
        public PriorityOrder(Address deliveryAddress, string fullName, DateTime deliveryDate, DeliveryTimeRange deliveryTime)
            : base(deliveryAddress, fullName)
        {
            DesiredDeliveryDate = deliveryDate;
            DesiredDeliveryTime = deliveryTime;
        }

        /// <summary>
        /// Переопределяет метод ToString для вывода информации о приоритетном заказе.
        /// </summary>
        public override string ToString()
        {
            return $"{base.ToString()}, Desired Delivery Date: {DesiredDeliveryDate.ToShortDateString()}, Desired Delivery Time: {DesiredDeliveryTime}";
        }
    }

}