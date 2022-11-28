using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaBuilder
{
    public partial class frmMain : Form
    {
        public int toppingcount = 0;
        private string name;
        private string adress;
        private string phonenumber;
        private double tip;
        private string crust;
        private string size;
        private string sauce;
        private string[] topings = new string[] { };

        customer na;
        order price;
        pizza piza;


        public frmMain()
        {
            InitializeComponent();


        }
        //becuase i want to make my topping a set price like 1 topping is .10 cents 2 would be .20 i am making them count how many check boxes are checked so it i can just multiple it by .10;
        


        private void butsubmit_Click(object sender, EventArgs e)
        {
            na = new customer(txtname.Text, txtaddress.Text, txtphone.Text);
            price = new order(na, piza);
            piza = new pizza();



            this.name = txtname.Text;
            this.adress = txtaddress.Text;
            this.phonenumber = txtphone.Text;
            this.size = combopizzasize.Text;
            this.crust = combopizzacrust.Text;
            this.sauce = combosauce.Text;
            

            na.Name = name;
            na.Address = adress;
            na.Phonenumber = phonenumber;

            piza.Size = size;
            piza.Sauce = sauce;
            piza.Crust = crust;
            
            ///get date of the moment you hit the submit
            price.Date = DateTime.Now;
            piza.Toping = topings;
            //checks to see if the fields are filled in not send error
            if (txtname.Text == null || txtaddress.Text == null || txtphone.Text == null)
            {
                lblError.Text = "Please enter info into all fields.";
            }
            else
            {
                //calculate the cost of normal toppings
                for (int i = 0; i < chkToppings.Items.Count; i++)
                {
                    if (chkToppings.GetItemChecked(i))
                    {
                        topings = topings.Append(chkToppings.GetItemText(chkToppings.Items[i])).ToArray();
                        toppingcount++;
                    }
                }
                //calculate the cost of all the preimum toppings
                for (int i = 0; i < chkPremiumtoppings.Items.Count; i++)
                {
                    if (chkPremiumtoppings.GetItemChecked(i))
                    {
                        topings = topings.Append(chkToppings.GetItemText(chkPremiumtoppings.Items[i])).ToArray();

                        toppingcount++;
                    }
                }
            }

            ///assign price by which the selected item is in so my first item is extra large index 0 so case 0 would mean index 0 so it extra large is 10.
            int sizeprice = 0;
            switch (combopizzasize.SelectedIndex)
            {
                case 3:
                    sizeprice = 5;
                    break;
                case 2:
                    sizeprice = 7;
                    break;
                case 1:
                    sizeprice = 9;
                    break;
                case 0:
                    sizeprice = 10;
                    break;
            }
            tip = double.Parse(txttip.Text);
          
            frmReceipt submit = new frmReceipt();
            submit.data(na.Name, na.Phonenumber, size, crust, sauce, topings, price.Date);
            
            submit.pickupordiv(na.Address);
            submit.total(sizeprice, toppingcount, tip);
            submit.Show();
            

        }

    }
}
