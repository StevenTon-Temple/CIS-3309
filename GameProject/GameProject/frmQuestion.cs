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
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet songDataSet;
        DataTable songTable;
        BindingSource myBindingSource;
        string strSQL;
       
        public frmQuestion()
        {
            InitializeComponent();
        }

        private void frmQuestion_Load(object sender, EventArgs e)
        {
            
            // Connect to the database, retrieve a result set of records, and store them in a DataSet
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=JepordyTable.accdb;");
            strSQL = "SELECT * FROM Jepordy";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            songDataSet = new DataSet("JepordyTable");
            myDataAdapter.Fill(songDataSet, "JepordyTable");


            // Set the data source for the DataGridView to display the records and their information.
            songTable = songDataSet.Tables["JepordyTable"];
            dgvJeopardy.DataSource = songTable;
            strSQL = "SELECT TOP 1 Sport, AnswersForSport FROM Jepordy ORDER BY Rnd(-(1000*ID)*Time())";

            //strSQL = "SELECT Sport FROM Jepordy WHERE AnswersForSport = 'Baseball';";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            songDataSet = new DataSet("JepordyTable");
            myDataAdapter.Fill(songDataSet, "JepordyTable");
            songTable = songDataSet.Tables["JepordyTable"];
            dgvJeopardy.DataSource = songTable;
            int rowindex = dgvJeopardy.CurrentCell.RowIndex;
            int columnindex = dgvJeopardy.CurrentCell.ColumnIndex;
            lblQuestions.Text = dgvJeopardy.Rows[rowindex].Cells[columnindex].Value.ToString();


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Equals(dgvJeopardy.Rows[0].Cells[1].Value.ToString()))
            {
                lblQuestions.Text = "Answer was correct";
            }
            else
            {
                lblQuestions.Text = "Answer was incorrect";
            }

        }
    }
}
