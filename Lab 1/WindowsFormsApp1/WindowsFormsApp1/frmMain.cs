using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculatePay_Click(object sender, EventArgs e)
        {
            int hourlyrate = int.Parse(txtHourlyRate.Text);
            int hourworked = int.Parse(txtHoursWorked.Text);
            int grossincome = (hourlyrate * hourworked);
            double statetax = .035 * grossincome;
            double federltax = .15 * grossincome;
            double ficasc = .062 * grossincome;
            double ficamed = .029 * grossincome;
            double netincome = grossincome - statetax - federltax - ficasc - ficamed;
            lblDisplay.Text ="Gross income = $" + grossincome + ", state tax = $" + statetax + ", federal tax  = $" + federltax  + ", Social security tax =  $" + ficasc + ", medical tax = $" + ficamed + ", Net Income is " + "$" + netincome.ToString();
           
            
        }

        private void txtHourlyRate_TextChanged(object sender, EventArgs e)
        {
            TextBox tbox = (TextBox)sender;

            String inputvalue = tbox.Text;

            int value = 0;

            if (int.TryParse(inputvalue, out value) == false)
            {
                Error.Text = "Sorry! You must entered an interger for " + tbox.Name + ".";
                tbox.BackColor = Color.LightYellow;
            }
            else
            {
                Error.Text = "";
                tbox.BackColor = Color.White;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHourlyRate.Clear();
            txtHoursWorked.Clear();
            lblDisplay.Text = "Total Payment";
            Error.Text = "";
        }
    }
}
