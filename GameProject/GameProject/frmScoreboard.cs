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
    public partial class frmScoreboard : Form
    {
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet jepordyDataSet;
        DataTable jepordyTable;
        string strSQL;
        public frmScoreboard()
        {
            InitializeComponent();
        }

        private void frmScoreboard_Load(object sender, EventArgs e)
        {

            //displays the scoreboard that we have been keeping track of until the end of the game
            // can see winner here Hope you enjoyed :D
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=JepordyTable.accdb;");
            strSQL = "SELECT Player1, Player2 FROM Player";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            jepordyDataSet = new DataSet("JepordyTable");
            myDataAdapter.Fill(jepordyDataSet, "JepordyTable");
            jepordyTable = jepordyDataSet.Tables["JepordyTable"];
            dgvScore.DataSource = jepordyTable;
        }
    }
}
