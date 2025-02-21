using Contacts.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.ViewModel
{
    public class MainVM: INotifyPropertyChanged
    {
        private Contact _contact;
        private string _errorMessage;

        public string Name
        {
            get => _contact.Name;
            set
            {
                var error = ContactValidator.ValidateName(value);
                if (error == null)
                {
                    _contact.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
                ErrorMessage = error;
            }
        }

        public string PhoneNumber
        {
            get => _contact.PhoneNumber;
            set
            {
                var error = ContactValidator.ValidatePhoneNumber(value);
                if (error == null)
                {
                    _contact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
                ErrorMessage = error;
            }
        }

        public string Email
        {
            get => _contact.Email;
            set
            {
                var error = ContactValidator.ValidateEmail(value);
                if (error == null)
                {
                    _contact.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
                ErrorMessage = error;
            }
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            private set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public MainVM()
        {
            _contact = new Contact();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
