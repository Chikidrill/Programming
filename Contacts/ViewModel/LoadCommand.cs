using System;
using System.Windows.Input;

/// <summary>
/// Команда для загрузки данных контакта из файла.
/// </summary>
public class LoadCommand : ICommand
{
    /// <summary>
    /// Объект для сериализации и десериализации контактов.
    /// </summary>
    private readonly Serializer _serializer;

    /// <summary>
    /// Действие для обновления данных контакта.
    /// </summary>
    private readonly Action<Contact> _setContact;

    /// <summary>
    /// Событие, оповещающее об изменении состояния выполнения команды.
    /// </summary>
    public event EventHandler CanExecuteChanged;

    /// <summary>
    /// Определяет, может ли команда выполняться.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
    /// <returns>Всегда возвращает <c>true</c>, так как команда может выполняться в любой момент.</returns>
    public bool CanExecute(object parameter) => true;

    /// <summary>
    /// Выполняет загрузку данных контакта из файла.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
    public void Execute(object parameter)
    {
        Contact loadedContact = _serializer.Load();
        _setContact(loadedContact);
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="LoadCommand"/>.
    /// </summary>
    /// <param name="serializer">Сериализатор контактов.</param>
    /// <param name="setContact">Метод для обновления данных контакта.</param>
    public LoadCommand(Serializer serializer, Action<Contact> setContact)
    {
        _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
        _setContact = setContact ?? throw new ArgumentNullException(nameof(setContact));
    }
}
