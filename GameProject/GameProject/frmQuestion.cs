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
    public partial class frmQuestion : Form
    {
        Questions questions = new Questions();
        string points = "";
        string topics = "";
        public int CorNC;
        private int time;


        public frmQuestion(string topic, string point)
        {
            topics = topic;
            points = point;
            InitializeComponent();



        }


        private void frmQuestion_Load(object sender, EventArgs e)
        {
            timer.Start();
    
            questions.getQuestion(dgvJeopardy, points, topics);
           
            int rowindex = dgvJeopardy.CurrentCell.RowIndex;
            int columnindex = dgvJeopardy.CurrentCell.ColumnIndex;
            lblQuestions.Text = dgvJeopardy.Rows[rowindex].Cells[columnindex].Value.ToString();


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtanswerfor.Text.Equals(dgvJeopardy.Rows[0].Cells[1].Value.ToString()))
            {
                MessageBox.Show("Answer is correct!");
                CorNC = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Answer is incorrect!");
                CorNC = 0;
                this.Close();

            }
        }

        private void dgvJeopardy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time++;
            this.Text = time.ToString();

            if(time == 60)
            {
                MessageBox.Show("Times up");
                timer.Stop();
                this.Close();
            }
        }
    }
}

