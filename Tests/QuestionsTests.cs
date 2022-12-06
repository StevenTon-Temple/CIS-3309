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
    public class QuestionsTests
    {
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet jepordyDataSet;
        DataTable jepordyTable;
        string strSQL;
        [TestMethod()]
        public void getQuestionTest()
        {
            string point = "800";
            string topic = "Math";
            string answersfor = topic + point + "Answers";
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=JepordyTable.accdb;");
            strSQL = "SELECT TOP 1 " + topic + point + ", " + answersfor + " FROM Jepordy ORDER BY Rnd(-(1000ID)Time())";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            jepordyDataSet = new DataSet("JepordyTable");
            jepordyTable = jepordyDataSet.Tables["JepordyTable"];
            Assert.IsNotNull(jepordyDataSet);

            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=JepordyTable.accdb;");
            strSQL = "SELECT TOP 1 " + point + ", " + answersfor + " FROM Jepordy ORDER BY Rnd(-(1000ID)Time())";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            jepordyDataSet = new DataSet("JepordyTable");
            jepordyTable = jepordyDataSet.Tables["JepordyTable"];
            Assert.IsNull(jepordyTable);

            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=JepordyTable.accdb;");
            strSQL = "SELECT TOP 1 " + ", " + answersfor + " FROM Jepordy ORDER BY Rnd(-(1000ID)Time())";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            jepordyDataSet = new DataSet("JepordyTable");
            jepordyTable = jepordyDataSet.Tables["JepordyTable"];
            Assert.IsNull(jepordyTable);

            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=JepordyTable.accdb;");
            strSQL = "SELECT TOP 1 " + topic + point + ", " + answersfor + " FROM Jepordy ORDER BY Rnd(-(1000ID)Time())";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            jepordyDataSet = new DataSet("JepordyTable");
            jepordyTable = jepordyDataSet.Tables["JepordyTable"];
            Assert.IsNotNull(jepordyDataSet);


        }

        [TestMethod()]
        public void CategoryTests()
        {
            Questions question = new Questions();
            question.Category = "Sport";
            string test = "History";
            Assert.AreNotEqual(test, question.Category = "Sport");
            question.Category = "History";
            string test1 = "Math";
            Assert.AreNotEqual(test1, question.Category = "History");
            question.Category = "Science";
            string test2 = "History";
            Assert.AreNotEqual(test2, question.Category = "Science");
            question.Category = "Geography";
            string test3 = "Science";
            Assert.AreNotEqual(test3, question.Category = "Geography");
            question.Category = "Science";
            string test4 = "Science";
            Assert.AreEqual(test4, question.Category = "Science");
            question.Category = "Math";
            string test5 = "Math";
            Assert.AreEqual(test5, question.Category = "Math");
            question.Category = "Geography";
            string test6 = "Geography";
            Assert.AreEqual(test6, question.Category = "Geography");
        }
    }
}