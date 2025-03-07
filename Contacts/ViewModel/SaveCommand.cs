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
    public class SaveCommand:ICommand
    {
        private readonly Serializer _serializer;
        private readonly Func<Contact> _getContact;

        
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
