using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControlDemo
{
    public partial class Form_Demo : Form
    {
        public Form_Demo()
        {
            InitializeComponent();
        }

        private void txtbutton_Click(object sender, EventArgs e)
        {
            label1.Text = "You entered " + txtuser.Text;
        }

        private void txtbutton_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;



        }

        private void txtbutton_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Blue;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "you selected '" + DDLStates.SelectedItem.ToString().Trim() + "' from the drop down list.";
        }

        private void txtvalue1_TextChanged(object sender, EventArgs e)
        {
            TextBox tbox = (TextBox)sender;
           
            String inputvalue = tbox.Text;

            int value = 0;

            if (int.TryParse(inputvalue, out value) == false)
            {
                label1.Text = "sorry! you must entered an interger for " + tbox.Name +".";
                tbox.BackColor = Color.LightYellow;
            }
            else
            {
                label1.Text = "";
                tbox.BackColor = Color.White;
            }
        }

        private void Form_Demo_Load(object sender, EventArgs e)
        {
            label1.Text = "the form has loaded";
        }
    }
}

       