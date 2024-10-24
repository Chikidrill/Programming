﻿
/// <summary>
/// Перечисление, отражающее статус заказа
/// </summary>
public enum OrderStatus
{
    New=1,
    Processing,
    Assembly,
    Sent,
    Delivered,
    Returned,
    Abandoned
}