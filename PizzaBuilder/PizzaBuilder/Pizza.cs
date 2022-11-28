using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    public class Pizza
    {
        public Pizza(string size, string crust, string sauce, string toppings, string extra, int topCount, int extraCount, float index, int tip)
        {
            Size = size;
            Crust = crust;
            Sauce = sauce;
            Toppings = toppings;
            Extra = extra;
            Index = index;
            ToppingPrice = topCount * .25f;
            ExtraPrice = extraCount * .25f;
            Tip = tip;
        }
        public string Size
        {
            get;
            set;
        }
        public string Crust
        {
            get;
            set;
        }
        public string Sauce
        {
            get;
            set;
        }
        public string Toppings
        {
            get;
            set;
        }
        public string Extra
        {
            get;
            set;
        }
        public float Index
        {
            get;
            set;
        }
        public float ToppingPrice
        {
            get;
            set;
        }
        public float ExtraPrice
        {
            get;
            set;
        }
        public int Tip
        {
            get;
            set;
        }
    }
}
