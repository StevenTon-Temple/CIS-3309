using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class Players
    {
        string player1;
        string player2;
        string strSQL;

        public string Player1
        {
            get { return player1; }
            set { player1 = value; }
        }

        public string Player2
        {
            get { return player2; }
            set { player2 = value; }
        }

        //method to update player score to display at the end of game
        public void Update_score(int team1Score, int team2Score)
        {

            string connectionStr = ("provider=Microsoft.ACE.OLEDB.12.0;Data Source= JepordyTable.accdb;");
            strSQL = "UPDATE [Player] SET [Player1] = " + team1Score + ", [Player2] = " + team2Score + " WHERE [ID] = " + 1 + ";";
            OleDbConnection con = new OleDbConnection(connectionStr);
            OleDbCommand com = new OleDbCommand(strSQL, con);
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.WriteLine(ex);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex);
            }

            finally
            {
                con.Close();
            }
           
        }

    }
        
}

