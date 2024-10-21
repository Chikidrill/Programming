using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal interface IDiscount
    {
        /// <summary>
        /// Получает информацию о скидке в виде строки.
        /// </summary>
        string Info { get; }
        /// <summary>
        /// Рассчитывает сумму скидки для заданного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров для расчета скидки.</param>
        /// <returns>Сумма скидки, рассчитанная на основе переданных товаров.</returns>
        double Calculate(List<Item> items);
        /// <summary>
        /// Применяет скидку к заданному списку товаров.
        /// Обновляет необходимые значения, связанные со скидкой (например, баланс баллов).
        /// </summary>
        /// <param name="items">Список товаров, к которым применяется скидка.</param>
        /// <returns>Сумма скидки, которая была применена к товарам.</returns>
        double Apply(List<Item> items);
        /// <summary>
        /// Обновляет данные, связанные со скидкой, на основе переданных товаров (например, накопление баллов).
        /// </summary>
        /// <param name="items">Список товаров, по которым обновляются данные скидки.</param>
        void Update(List<Item> items);
        /// <summary>
        /// Возвращает общую сумму для заданного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров для расчета общей суммы.</param>
        /// <returns>Общая сумма товаров в списке.</returns>
        double GetAmount(List<Item> items);
    }
}
