using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Players
    {
      
        string strSQL;

    

        public void Update_score(int team1Score, int team2Score)
        {
            string connectionStr = ("provider=Microsoft.ACE.OLEDB.12.0;Data Source= JepordyTable.accdb;");
            strSQL = "UPDATE Team " + " SET Team1 = " +
            team1Score + ", Team2 = " + team2Score;
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

