using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    public class Order
    {
        public Order(Customer theCustomer, Pizza thePizza)
        {
            customer = theCustomer;
            pizza = thePizza;
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
    }
}
