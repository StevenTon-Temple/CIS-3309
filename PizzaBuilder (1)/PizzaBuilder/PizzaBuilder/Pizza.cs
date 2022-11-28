using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzabuilder
{
    class Pizza
    {
        private string size;
        private string crust;
        private string sauce;
        private string[] toppings;
        private string[] premToppings;
        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public string Crust
        {
            get { return crust; }
            set { crust = value; }
        }

        public string Sauce
        {
            get { return sauce; }
            set { sauce = value; }
        }

        public string[] Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        public string[] PremToppings
        {
            get { return premToppings; }
            set { premToppings = value;  }
        }


    }
}
