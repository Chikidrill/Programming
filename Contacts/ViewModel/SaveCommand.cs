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
        /// Выполняет сохранение контакта.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        public void Execute(object parameter)
        {
            _serializer.Save(_viewModel.Contact);
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="SaveCommand"/>.
        /// </summary>
        /// <param name="contact">Контакт, который необходимо сохранить.</param>
        /// <param name="serializer">Функция, возвращающая контакт для сохранения.</param>
        public SaveCommand(Serializer serializer, MainVM viewModel)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
            _viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }
    }
}
