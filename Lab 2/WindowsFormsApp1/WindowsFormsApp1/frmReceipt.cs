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
    public partial class frmReceipt : Form
    {
        
        private string order;
        private string address;
        private double totalcost;
        public string[] topping;

     
        public void data(string name, string phonenumber,string size, string crust, string sauce, string[] newtopping, DateTime now)
        {
            topping = newtopping;
            this.order = "Receipt"+ "\nDate: "  + now + "\nName = "+ name + "\nPhone #: " + phonenumber 
                + "\nSize: " + size + "\nCrust: " + crust + "\nSauce: "+ sauce + "\nTopping: " + string.Join(" ", topping).TrimStart();
           
            lblreciet.Text = this.order;
            
        }

        public void pickupordiv(string address)
        {
            this.address = "Pickup or Delivery" + "\nAddress: "+ address;
            lblpickupordilvery.Text = this.address;
        }

        public void total(int sizeprice,int toppingcoung, double tip)
        {
           
            this.totalcost = sizeprice + (toppingcoung * .10) + tip ;
            double taxes = totalcost * .06;

            lbltotal.Text = "Tax = $" + Math.Round(taxes,2) + "\nTip= $" + Math.Round(tip,2) +"\nTotal Cost = $" + Math.Round(totalcost,2);
        }
        
        public frmReceipt()
        {
            InitializeComponent();
            
        }

        private void frmReceipt_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            Array.Clear(topping, 0, topping.Length);



        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {

        }
    }
    }
    
