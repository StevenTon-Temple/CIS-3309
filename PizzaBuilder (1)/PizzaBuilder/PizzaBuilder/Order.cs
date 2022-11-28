using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzabuilder
{
    class Order 
    {
        private DateTime date;

        public Order(Customer cust, Pizza piz)
        {
            customer = cust;
            pizza = piz;
        }

        public Customer customer
        {
            get;
            set;
        }
        
        public Pizza pizza
        {
            get;
            set;
        }
        
        public DateTime Date
        {
            get { return date;}
            set { date = value; }
        }
    }
}
