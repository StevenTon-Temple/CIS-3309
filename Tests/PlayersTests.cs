using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace GameProject.Tests
{
    [TestClass()]
    public class PlayersTests
    {
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet jepordyDataSet;
        DataTable jepordyTable;
        string strSQL;
        [TestMethod()]
        public void Update_scoreTest()
        {
            Players player = new Players();
            int team1Score = 500;
            int team2Score = 500;
            string connectionStr = ("provider=Microsoft.ACE.OLEDB.12.0;Data Source= JepordyTable.accdb;");
            string strSQL = "UPDATE [Player] SET [Player1] = " + team1Score + ", [Player2] = " + team2Score + " WHERE [ID] = " + 1 + ";";
            OleDbConnection con = new OleDbConnection(connectionStr);
            OleDbCommand com = new OleDbCommand(strSQL, con);
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            jepordyDataSet = new DataSet("JepordyTable");
            jepordyTable = jepordyDataSet.Tables["JepordyTable"];
            Assert.IsNotNull(jepordyDataSet);

            string s = "UPDATE [Player] SET [Player1] = " + team1Score + ", [Player2] = " + team2Score + " WHERE [ID] = " + 1 + ";";
            OleDbConnection connection = new OleDbConnection(connectionStr);
            OleDbCommand cmb = new OleDbCommand(strSQL, con);
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            jepordyDataSet = new DataSet("JepordyTable");
            jepordyTable = jepordyDataSet.Tables["JepordyTable"];
            Assert.IsNull(jepordyTable);

            string str = "UPDATE [Player] SET [Player1] = " + team1Score + ", [Player2] = " + team2Score + " WHERE [ID] = " + 1 + ";";
            OleDbConnection strconnection = new OleDbConnection(connectionStr);
            OleDbCommand scmb = new OleDbCommand(strSQL, con);
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            jepordyDataSet = new DataSet("JepordyTable");
            jepordyTable = jepordyDataSet.Tables["JepordyTable"];
            Assert.IsNotNull(jepordyDataSet);

             }

        [TestMethod()]
        public void Player1Tests()
        {
            Players player = new Players();
            player.Player1 = "test";
            string test = "test";
            Assert.AreEqual(test, player.Player1);
            player.Player1 = "Nadir";
            string test1 = "larry";
            Assert.AreNotEqual(test1, player.Player1);
            player.Player1 = "Nadir";
            int test2 = 1;
            Assert.AreNotEqual(test2, player.Player1);
        }

        [TestMethod()]
        public void Player2Tests()
        {
            Players player = new Players();
            player.Player2 = "test";
            string test = "test";
            Assert.AreEqual(test, player.Player2);
            player.Player2 = "Mark";
            string test1 = "larry";
            Assert.AreNotEqual(test1, player.Player2);
            player.Player2 = "Steven";
            int test2 = 1;
            Assert.AreNotEqual(test2, player.Player2);
        }
    }
}