using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzabuilder
{
    class Customer
    {
        private string name;
        private string phoneNumber;
        private string address;


        public Customer(string name, string phoneNumber, string address)
        {
            Name = name;
            Number = phoneNumber;
            Address = address;

        }

        public string Name
        {
            get;
            set;
        }

        public string Number
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }
    }
}
