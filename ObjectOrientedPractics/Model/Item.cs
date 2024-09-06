using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        public int Id
        {
         get 
            { 
                return _id; 
            }
         set
            {

            }
        }
        public string Name
        {
            get { return _name; }
            set { }
        }
        public string Info
        {
            get { return _info; }
            set { }
        }
        public double Cost
        {
            get { return _cost; }
            set { }
        }
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
