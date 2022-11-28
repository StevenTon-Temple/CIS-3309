using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    class pizza
    {
        private string crust;
        private string size;
        private string sauce;
        private string[] topings;

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
        public string[] Toping
        {

            get { return topings; }

            set { topings = value; }


        }

      

        
    }
}
