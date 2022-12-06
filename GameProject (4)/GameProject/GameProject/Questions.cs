using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject
{
  public class Questions
    {
        private string category;
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet jepordyDataSet;
        DataTable jepordyTable;
        string strSQL;

        string topic;
        string point;


        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public void getQuestion(DataGridView dgvJeopardy, string points, string topics)
        {
            point = points;
            topic = topics;
            string answersfor = topic + point + "Answers";
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=JepordyTable.accdb;");
            strSQL = "SELECT TOP 1 " + topic + point + ", " + answersfor + " FROM Jepordy ORDER BY Rnd(-(1000*ID)*Time())";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            jepordyDataSet = new DataSet("JepordyTable");
            myDataAdapter.Fill(jepordyDataSet, "JepordyTable");
            jepordyTable = jepordyDataSet.Tables["JepordyTable"];
            dgvJeopardy.DataSource = jepordyTable;

        }
    }
}

