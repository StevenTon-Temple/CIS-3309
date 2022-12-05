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
       
        Game gamecs = new Game();
        Questions question = new Questions();
        Players player = new Players();
        int teamTurn = 1;
        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {

        }



        private void gbSport_Enter(object sender, EventArgs e)
        {
            
            string topic = (sender as GroupBox).Text;
            question.Category = topic;
           
        }

       
        private void btnSport200_Click(object sender, EventArgs e)
        {

            int score1 = int.Parse(lbl1Score.Text);
            int score2 = int.Parse(lbl2Score.Text);
            string point = (sender as Button).Text;

            frmQuestion questions = new frmQuestion(question.Category, point);
            questions.ShowDialog();

            Button clickedButton = (Button)sender;
           
            if (questions.CorNC == 0)
            {
                if (teamTurn.Equals(1))
                {
                    teamTurn = 2;
                    lblTeamTurn.Text = "Team 2 Turn";
                }
                else
                {
                    teamTurn = 1;
                    lblTeamTurn.Text = "Team 1 Turn";
                }
            }

            int t = gamecs.GetPoint(point);
            if (questions.CorNC == 1) {
                clickedButton.Visible = false;
                if (teamTurn.Equals(1))
                {
                    score1 += t;
                    lbl1Score.Text = score1.ToString();
                }
                else
                {
                    score2 += t;
                    lbl2Score.Text = score2.ToString();

                }
                player.Update_score(score1, score2);

            }
           
            Console.WriteLine(score1);
            

        }
    }
}
