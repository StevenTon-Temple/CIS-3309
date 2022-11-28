using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzabuilder
{
    public partial class FrmReceipt : Form
    {

        private string order;
        private string address;
        private double total;
        public string[] Toppings;
        public string[] premToppings;
        public FrmReceipt()
        {
            InitializeComponent();
        }

        public void pizzaOrder(string name, string number, string size, string crust, string sauce, string[]toppings, string[] premtoppings, DateTime now)
        {
            Toppings = toppings;
            premToppings = premtoppings;
            this.order = "Date & Time: " + now + "\nName: " + name + "\nPhone Number: " + number + "\nSize: " + size + "\nCrust: " + crust + "\nSauce: " + sauce + "\nToppings: " + string.Join(" ", toppings).TrimStart() + "\nPremium Toppings: " + string.Join("", premToppings).TrimStart();
            lblOrder.Text = this.order; 
        }

        public void pickUp(string address)
        {
            this.address = "Address: " + address;
            lblPickUp.Text = this.address;
        }

        public void price(int sizeprice, int topCount, int premTopCount, double tip)
        {
            this.total = sizeprice + (topCount * 1) + (premTopCount * 2) + tip;
            lblPrice.Text = "Total: $" + total.ToString();
        }

    }
}
