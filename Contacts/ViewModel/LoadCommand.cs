using Contacts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Model.Services;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    public class LoadCommand:ICommand
    {
        private readonly Serializer _serializer;
        private readonly Action<Contact> _setContact;

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
}
