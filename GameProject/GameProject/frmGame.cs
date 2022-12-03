using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject
{
    public partial class frmGame : Form
    {
        string topic;
       
        Game gamecs = new Game();
        Questions question = new Questions();
        string g;
        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
        }



        private void gbSport_Enter(object sender, EventArgs e)
        {
            
            string t = (sender as GroupBox).Text;
            topic = t;
            question.Category = t;
            g = t;
        }

       
        private void btnSport200_Click(object sender, EventArgs e)
        {
            int score1 = int.Parse(lbl1Score.Text);
            string point = (sender as Button).Text;
            
            frmQuestion questions = new frmQuestion(g, point);
            questions.ShowDialog();
            if (questions.CorNC == 1)
            {
                if (topic.Equals("Sport"))
                {
                    btnSport200.Visible = false;
                }
                if (topic.Equals("History"))
                {
                    btnHis200.Visible = false;
                }
                if (topic.Equals("Science"))
                {
                    btnSci200.Visible = false;
                }
                if (topic.Equals("Math"))
                {
                    btnMath200.Visible = false;
                }
                if (topic.Equals("Geography"))
                {
                    btnGeo200.Visible = false;
                }
                int t = gamecs.GetPoint(point);
                score1 += t;
                lbl1Score.Text = score1.ToString();
              

            }
        }
    }
}
