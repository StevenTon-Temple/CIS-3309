using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    public class Customer
    {
        public Customer(string name, string address, string number)
        {
            Name = name;
            Address = address;
            Number = number;
        }

        public string Name
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string Number
        {
            get;
            set;
        }
    }
}
