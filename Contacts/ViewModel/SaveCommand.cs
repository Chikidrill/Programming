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

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _serializer.Save(_getContact());
        }
        public SaveCommand(Serializer serializer, Func<Contact> getContact)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
            _getContact = getContact ?? throw new ArgumentNullException(nameof(getContact));
        }
    }
}
