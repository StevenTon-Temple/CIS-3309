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
        int teamturn = 1;
        Game gamecs = new Game();
        Questions question = new Questions();
        Players player = new Players();
        int questionnumber = 20;

        public frmGame(string player1, string player2)
        {
            //sets players to players in our class
            player.Player1 = player1;
            player.Player2 = player2;
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            // setting the name in our form to players from class
            lblTeam1.Text = player.Player1;
            lblTeam2.Text = player.Player2;
            lblTeamTurn.Text = player.Player1 + " can choose ";
        }



        private void gbSport_Enter(object sender, EventArgs e)
        {
            
            string topic = (sender as GroupBox).Text;
            question.Category = topic;
           
        }

       
        private void btnSport200_Click(object sender, EventArgs e)
        {
            //shows score here and keeps record of it in DBMS (look at players class)

            int score1 = int.Parse(lbl1Score.Text);
            int score2 = int.Parse(lbl2Score.Text);
            string point = (sender as Button).Text;

            frmQuestion questions = new frmQuestion(question.Category, point);
            questions.ShowDialog();

            Button clickedButton = (Button)sender;
             

            // to show if you got incorrect or correct answer and it will add the points of 
            // question to your score
            // button will go away if question is correct
            int t = gamecs.GetPoint(point);
            if (questions.CorNC == 1) {
                questionnumber--;
                clickedButton.Visible = false;
                if (teamturn.Equals(1))
                {
                    score1 += t;
                    lbl1Score.Text = score1.ToString();
                }
                else
                {
                    score2 += t;
                    lbl2Score.Text = score2.ToString();

                }
                
            }
            if (questions.CorNC == 0)
            {
                // if you get answer incorrect it changes the other persons turn
                if (teamturn.Equals(1))
                {
                    teamturn = 2;
                    lblTeamTurn.Text = "" + player.Player2 +" can choose";
                }
                else
                {
                    teamturn = 1;
                    lblTeamTurn.Text ="" + player.Player1 +" can choose";
                }
            }

            

            if (questionnumber.Equals(0))
            {
                player.Update_score(score1, score2);
                //end of game to display who the winner is 
                frmScoreboard scoreboard = new frmScoreboard();
                scoreboard.Show();
                if (score1 > score2)
                {
                    MessageBox.Show( player.Player1 + " Wins");
                    this.Close();
                }
                else if (score2 > score1)
                {
                    MessageBox.Show(player.Player2 + " Wins");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("It is a tie");
                    this.Close();
                }
            }


        }
        }
}
