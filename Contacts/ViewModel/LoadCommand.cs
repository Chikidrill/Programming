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


        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            Contact loadedContact = _serializer.Load();
            _setContact(loadedContact);
        }
     
        public LoadCommand(Serializer serializer, Action<Contact> setContact)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
            _setContact = setContact ?? throw new ArgumentNullException(nameof(setContact));
        }
    }
}
