using Contacts.Model;
using Contacts.Model.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    public class MainVM: INotifyPropertyChanged
    {
        private Contact _contact;
        private readonly Serializer _serializer;

        public string Name
        {
            get => _contact.Name;
            set
            {
                _contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string PhoneNumber
        {
            get => _contact.PhoneNumber;
            set
            {
                _contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        public string Email
        {
            get => _contact.Email;
            set
            {
                _contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public ICommand SaveCommand { get; }
        public ICommand LoadCommand { get; }

        public MainVM()
        {
            _serializer = new Serializer();
            _contact = new Contact();

            SaveCommand = new SaveCommand(_serializer, () => _contact);
            LoadCommand = new LoadCommand(_serializer, contact =>
            {
                _contact = contact;
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(PhoneNumber));
                OnPropertyChanged(nameof(Email));
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
