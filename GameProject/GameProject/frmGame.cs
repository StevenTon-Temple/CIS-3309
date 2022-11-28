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
            frmQuestion questions = new frmQuestion(topic);
            questions.ShowDialog();
        }
    }
}
