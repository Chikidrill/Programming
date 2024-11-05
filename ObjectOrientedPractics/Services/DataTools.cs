using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public static class DataTools
    {

        /// <summary>
        /// Осуществляет фильтрацию списка предметов
        /// </summary>
        /// <param name="items">Список предметов</param>
        /// <param name="compare">Функция сравнения, возвращающая true для включаемых элементов.</param>
        /// <returns>Отфильтрованный список предметов</returns>
        public static List<Item> Filter(List<Item> items, Func<Item, bool> compare)
        {
            List<Item> filteredItems = new List<Item>();
            foreach (Item item in items)
            {
                if (compare(item))
                {
                    filteredItems.Add(item);
                }
            }
            return filteredItems;
        }

        /// <summary>
        /// Осуществляет сортировку списка предметов
        /// </summary>
        /// <param name="items">Список предметов</param>
        /// <param name="compare">Функция сортировки </param>
        /// <returns>Отсортированный список предметов</returns>
        public static List<Item> Sort(List<Item> items, Func<Item, Item, bool> compare)
        {
            List<Item> sortedItems = [.. items];
            int count = items.Count;
            while (count-- != 0)
            {
                bool swapped = false;

                for (int i = 0; i < count; i++)
                {
                    if (compare(sortedItems[i], sortedItems[i + 1]))
                    {
                        Item temp = sortedItems[i];
                        sortedItems[i] = sortedItems[i + 1];
                        sortedItems[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped) break;
            }

            return sortedItems;
        }
    }
}
