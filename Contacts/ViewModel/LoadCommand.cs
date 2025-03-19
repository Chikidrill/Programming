using Contacts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Model.Services;
using System.Windows.Input;
using System.Diagnostics.Contracts;
using System.Runtime.Remoting.Contexts;

namespace Contacts.ViewModel
{
    public class LoadCommand:ICommand
    {
        private readonly Serializer _serializer;
        private readonly Contact _contact;
        private readonly MainVM _viewModel; 
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
            _viewModel.Name = loadedContact.Name;
            _viewModel.PhoneNumber = loadedContact.PhoneNumber;
            _viewModel.Email = loadedContact.Email;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="LoadCommand"/>.
        /// </summary>
        /// <param name="serializer">Сериализатор контактов.</param>
        /// <param name="contact">Контакт для обновления данных.</param>
        public LoadCommand(Serializer serializer, MainVM viewModel)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
            _viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }
    }
}
