using Contacts.Model;
using System;
using Contacts.Model.Services;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    /// <summary>
    /// Команда для сохранения контакта в файл.
    /// </summary>
    public class SaveCommand : ICommand
    {
        /// <summary>
        /// Сервис для сериализации и десериализации контактов.
        /// </summary>
        private readonly Serializer _serializer;

        /// <summary>
        /// Функция, возвращающая контакт для сохранения.
        /// </summary>
        private readonly Func<Contact> _getContact;

        /// <summary>
        /// Событие, вызываемое при изменении состояния выполнения команды.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Определяет, может ли команда выполняться.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        /// <returns>Всегда возвращает <c>true</c>, так как команда может выполняться в любой момент.</returns>
        public bool CanExecute(object parameter) => true;

        /// <summary>
        /// Выполняет сохранение контакта.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        public void Execute(object parameter)
        {
            _serializer.Save(_getContact());
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="SaveCommand"/>.
        /// </summary>
        /// <param name="getContact">Контакт, который необходимо сохранить.</param>
        /// <param name="serializer">Функция, возвращающая контакт для сохранения.</param>
        public SaveCommand(Serializer serializer, Func<Contact> getContact)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
            _getContact = getContact ?? throw new ArgumentNullException(nameof(getContact));
        }
    }
}