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
        string point200 = "200";
        string point400 = "400";
        string point600 = "600";
        string point800 = "800";

        

        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            topic = "";
        }



        private void gbSport_Enter(object sender, EventArgs e)
        {
            topic = gbSport.Text;
        }

        private void gbHistory_Enter(object sender, EventArgs e)
        {
            topic = gbHistory.Text;
        }

        private void gbScience_Enter(object sender, EventArgs e)
        {
            topic = gbScience.Text;
        }

        private void gbMath_Enter(object sender, EventArgs e)
        {
            topic = gbMath.Text;
        }

        private void gbGeography_Enter(object sender, EventArgs e)
        {
            topic = gbGeography.Text;
        }
        private void btnSport200_Click(object sender, EventArgs e)
        {
            int score1 = int.Parse(lbl1Score.Text);
            frmQuestion questions = new frmQuestion(topic, point200);
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
                score1 += int.Parse(point200);
                    lbl1Score.Text = score1.ToString();
              

            }
        }

        private void btnSport400_Click(object sender, EventArgs e)
        {
            int score1 = int.Parse(lbl1Score.Text);
            frmQuestion questions = new frmQuestion(topic,point400);
            questions.ShowDialog();
            if (questions.CorNC == 1)
            {
                if (topic.Equals("Sport"))
                {
                    btnSport400.Visible = false;
                }
                if (topic.Equals("History"))
                {
                    btnHis400.Visible = false;
                }
                if (topic.Equals("Science"))
                {
                    btnSci400.Visible = false;
                }
                if (topic.Equals("Math"))
                {
                    btnMath400.Visible = false;
                }
                if (topic.Equals("Geography"))
                {
                    btnGeo400.Visible = false;
                }
                score1 += int.Parse(point400);
                    lbl1Score.Text = score1.ToString();
             
                
            }
        }

        private void btnSport600_Click(object sender, EventArgs e)
        {
            int score1 = int.Parse(lbl1Score.Text);
            frmQuestion questions = new frmQuestion(topic, point600);
            questions.ShowDialog();
            if (questions.CorNC == 1)
            {
                if (topic.Equals("Sport"))
                {
                    btnSport600.Visible = false;
                }
                if (topic.Equals("History"))
                {
                    btnHis600.Visible = false;
                }
                if (topic.Equals("Science"))
                {
                    btnSci600.Visible = false;
                }
                if (topic.Equals("Math"))
                {
                    btnMath600.Visible = false;
                }
                if (topic.Equals("Geography"))
                {
                    btnGeo600.Visible = false;
                }
                score1 += int.Parse(point600);
                lbl1Score.Text = score1.ToString();

            }
            }

        private void btnSport800_Click(object sender, EventArgs e)
        {
            int score1 = int.Parse(lbl1Score.Text);
            frmQuestion questions = new frmQuestion(topic, point800);
            questions.ShowDialog();
            if (questions.CorNC == 1)
            {
                if (topic.Equals("Sport"))
                {
                    btnSport800.Visible = false;
                }
                if (topic.Equals("History"))
                {
                    btnHis800.Visible = false;
                }
                if (topic.Equals("Science"))
                {
                    btnSci800.Visible = false;
                }
                if (topic.Equals("Math"))
                {
                    btnMath800.Visible = false;
                }
                if (topic.Equals("Geography"))
                {
                    btnGeo800.Visible = false;
                }
                score1 += int.Parse(point800);
                    lbl1Score.Text = score1.ToString();
             
               
            }
        }
    }
}
