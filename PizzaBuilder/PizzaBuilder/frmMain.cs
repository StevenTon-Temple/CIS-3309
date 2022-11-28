using System;
using System.Windows.Forms;

namespace PizzaBuilder
{
    public partial class frmMain : Form
    {
        internal Customer customer;
        Order order;
        Pizza pizza;
        string checkTop = "Toppings: \n";
        string checkExtra = "Extras: \n";
        int topCount = 0;
        int extraCount = 0;
        int tip;

        public frmMain()
        {
            InitializeComponent();
        }



        private void btnTotal_Click(object sender, EventArgs e)
        {
            
            //checks for input of Customer Info
            if (txtName.Text== null || txtAddress.Text==null || txtNumber.Text==null)
            {
                lblError.Text = "Something is missing, please check all required fields";
            }
            else
            {
                //calculate the cost of normal toppings
                for (int i = 0; i < chkToppings.Items.Count; i++)
                {
                    if (chkToppings.GetItemChecked(i))
                    {
                        checkTop = checkTop + chkToppings.GetItemText(chkToppings.Items[i]) + "\n";
                        topCount++;
                    }
                }
                //calculate the cost of all the extra toppings
                for (int i = 0; i < chkExtra.Items.Count; i++)
                {
                    if (chkExtra.GetItemChecked(i))
                    {
                        checkExtra = checkExtra + chkExtra.GetItemText(chkExtra.Items[i]) + "\n";
                        extraCount++;
                    }
                }
                //check the size selected and apply price accordingly
                float sizePrice = 0;
                switch (ddSize.SelectedIndex)
                {
                    case 0:
                        sizePrice = 7.00f;
                        break;
                    case 1:
                        sizePrice = 10.00f;
                        break;
                    case 2:
                        sizePrice = 12.00f;
                        break;
                    case 3:
                        sizePrice = 15.00f;
                        break;
                }
                tip = int.Parse(txtTip.Text);

                customer = new Customer(txtName.Text, txtAddress.Text, txtNumber.Text);
                pizza = new Pizza(ddSize.Text, ddCrust.Text, ddSauce.Text, checkTop, checkExtra, topCount, extraCount, sizePrice, tip);

                order = new Order(customer, pizza);

                frmReceipt frm = new frmReceipt();

                frm.SetForm(this);
                frm.SetOrder(order);
                frm.Show();


                Console.WriteLine(customer.Address + "\n" + customer.Address.ToString());
                Show();
            }
        }


        //misclicks
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
