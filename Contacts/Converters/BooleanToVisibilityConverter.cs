using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Contacts.View.Converters;
/// <summary>
/// Класс конвертера значений. Преобразует значение типа <see cref="bool"/> в значение <see cref="Visibility"/>.
/// </summary>
public class BooleanToVisibilityConverter : IValueConverter
{
    /// <summary>
    /// Преобразует логическое значение в значение <see cref="Visibility"/>.
    /// </summary>
    /// <param name="value">Значение типа <see cref="bool"/> для преобразования.</param>
    /// <param name="targetType">Тип целевого свойства привязки.</param>
    /// <param name="parameter">Не используется.</param>
    /// <param name="culture">Культура, используемая в преобразовании.</param>
    /// <returns>
    /// Возвращает <see cref="Visibility.Visible"/>, если <paramref name="value"/> равно <c>true</c>,
    /// иначе возвращает <see cref="Visibility.Collapsed"/>.
    /// </returns>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is bool boolValue)
            return boolValue ? Visibility.Visible : Visibility.Collapsed;
        return Visibility.Collapsed;
    }

    /// <summary>
    /// Обратное преобразование. Не имеет реализации.
    /// </summary>
    /// <param name="value">Значение для преобразования обратно.</param>
    /// <param name="targetType">Тип целевого свойства привязки.</param>
    /// <param name="parameter">Не используется.</param>
    /// <param name="culture">Культура, используемая в преобразовании. </param>
    /// <returns>Не возвращает значение, всегда выбрасывает исключение.</returns>
    /// <exception cref="NotImplementedException">Всегда выбрасывается, так как метод не реализован.</exception>
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
