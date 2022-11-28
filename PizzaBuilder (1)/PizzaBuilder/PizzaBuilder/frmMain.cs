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
    public partial class FrmMain : Form
    {
        private string name;
        private string phoneNumber;
        private string address;
        private string crust;
        private string size;
        private string sauce;
        private int topCount = 0;
        private int premTopCount = 0;
        private string[] toppings = new string[] { };
        private string[] premToppings = new string[] { };
        private double tip;

        Customer customer;
        Order order;
        Pizza pizza;


        
        public FrmMain()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {

            customer = new Customer(txtName.Text, txtAddress.Text, txtPhone.Text);
            order = new Order(customer, pizza);
            pizza = new Pizza();


            this.name = txtName.Text;
            this.phoneNumber = txtPhone.Text;
            this.address = txtAddress.Text;
            this.size = cmbSize.Text;
            this.crust = cmbCrust.Text;
            this.sauce = cmbCrust.Text;

            customer.Name = name;
            customer.Address = address;
            customer.Number = phoneNumber;
            pizza.Size = size;
            pizza.Crust = crust;
            pizza.Sauce = sauce;
            order.Date = DateTime.Now;
            pizza.Toppings = toppings;
            pizza.PremToppings = premToppings;


           

            int sizeprice = 0;
            switch (cmbSize.SelectedIndex)
            {
                case 1:
                    sizeprice = 3;
                    break;

                case 2:
                    sizeprice = 5;
                    break;

                case 3:
                    sizeprice = 8;
                    break;

                case 4:
                    sizeprice = 10;
                    break;
            }

            for (int i = 0; i < chkToppings.Items.Count; i++)
            {
                if (chkToppings.GetItemChecked(i))
                {
                    toppings = toppings.Append(chkToppings.GetItemText(chkToppings.Items[i])).ToArray();
                    
                    topCount++;
                }
            }
            //calculate the cost of all the extra toppings
            for (int i = 0; i < chkAdditions.Items.Count; i++)
            {
                if (chkAdditions.GetItemChecked(i))
                {
                    premToppings = premToppings.Append(chkToppings.GetItemText(chkAdditions.Items[i])).ToArray();
                    premTopCount++;
                }
            }

            tip = double.Parse(txtTip.Text);
            FrmReceipt submit = new FrmReceipt();
            submit.pizzaOrder(customer.Name, customer.Number, size, crust, sauce, toppings, premToppings, order.Date);
            submit.pickUp(customer.Address);
            submit.price(sizeprice, topCount, premTopCount, tip);
            submit.Show();
        }
    }
}
