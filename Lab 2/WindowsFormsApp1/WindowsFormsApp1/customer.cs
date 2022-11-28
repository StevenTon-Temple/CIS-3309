using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    class customer
    {
        private string name;
        private string address;
        private string phonenumber;

        public customer(string name, string address, string number)
        {
            Name = name;
            Address = address;
            Phonenumber = number;
        
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
       
        }

        public string Address
        {
            get { return address; }
            set { address = value; }

        }

        public string Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }

        }
    }
}
