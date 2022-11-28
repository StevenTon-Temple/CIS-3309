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
        frmMain ownerForm;
        Order theOrder;
        public float sizePrice;

        public void SetForm(Form theForm)
        {
            ownerForm = (frmMain)theForm;
        }
        public void SetOrder(Order order)
        {
            theOrder = order;
            //for the customer
            lblRecAddress.Text = theOrder.customer.Address;
            lblRecName.Text = theOrder.customer.Name;
            lblRecNumber.Text = theOrder.customer.Number;
            //for the pizza
            lblRecSize.Text = theOrder.pizza.Size.ToString();
            lblRecToppings.Text = theOrder.pizza.Toppings.ToString();
            lblRecCrust.Text = theOrder.pizza.Crust.ToString();
            lblRecSauce.Text = theOrder.pizza.Sauce.ToString();
            lblRecExtra.Text = theOrder.pizza.Extra.ToString();
            
            
            //calculations for the cost of the pizza
            
            Console.Write(sizePrice);
            float subtotal = theOrder.pizza.Index + theOrder.pizza.ToppingPrice + theOrder.pizza.ExtraPrice;

            subtotal = subtotal + (subtotal * (.01f * theOrder.pizza.Tip));

            lblRecCost.Text = "Total: $" + subtotal.ToString();
        }

        public frmReceipt()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void frmReceipt_Load(object sender, EventArgs e)
        {

        }
        public void lblRecAddress_Click(object sender, EventArgs e)
        {
            
        }
    }
}
