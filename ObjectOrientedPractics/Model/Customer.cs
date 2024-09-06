using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        private readonly int _id;
        private string _fullname;
        private string _address;

        public int Id { get { return _id; } }
        public string FullName 
        { 
            get { return _fullname; } 
            set { _fullname = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public Customer(string fullname, string address)
        { 
            FullName = fullname;
            Address = address;
        }
    }
}
