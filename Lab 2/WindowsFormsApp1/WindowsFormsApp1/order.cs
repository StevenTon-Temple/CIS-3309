using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    class order
    {
       
        private DateTime date;
        

        public order(customer Customer1, pizza Pizza1)
        {
            Customer = Customer1;

            Pizza = Pizza1;

        }

        public customer Customer
        {
            get; set;
        }

        public pizza Pizza
        {
            get; set;
        }


        public DateTime Date
        {
            get { return date; }
            set { date = value; }

        }
       
    }
}
