using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Club
{
    public partial class MembershipFeeCalculator : Form
    {
        public MembershipFeeCalculator()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int monthes = int.Parse(txtmonth.Text);
            int standardadult = 40;
            int child = 20;
            int student = 25 ;
            int senior = 30 ;
            int yoga = 10 ;
            int karate = 30 ;
            int personaltrainer = 50;
            int monthlyfee = 0;
            int total = 0;

            if (radAdult.Checked == true)
            {
                total += standardadult * monthes;
                monthlyfee += standardadult;

            }
            else if (radChild.Checked == true)
            {
                total += child * monthes;
                monthlyfee += child;

            }

            else if (radStudent.Checked == true)
            {
                total += student * monthes;
                monthlyfee += student;

            }
            else if (radSenior.Checked == true)
            {
                total += senior * monthes;
                monthlyfee += senior;


            }
            {
                if (chkYoga.Checked == true)
                {
                    total += yoga * monthes;
                    monthlyfee += yoga;
                }
                if (chkKarate.Checked == true)
                {
                    total += karate * monthes;
                    monthlyfee += karate;
                }
                if (chkPersonalTrainer.Checked == true)
                {
                    total += personaltrainer * monthes;
                    monthlyfee += personaltrainer;
                }
            }

            lblTotal.Text = "$"+total.ToString();
            lblMonthlyFee.Text = "$" + monthlyfee.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtmonth.Clear();
            chkYoga.Checked = false;
            chkKarate.Checked = false;
            chkPersonalTrainer.Checked = false;
            radAdult.Checked = false;
            radChild.Checked = false;
            radStudent.Checked = false;
            radSenior.Checked = false;
            lblMonthlyFee.Text = "0";
            lblTotal.Text = "0";

        }

       
    }
}
