using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;        // namespace needed in order to connect to Access database

namespace DatabaseExample
{
    public partial class frmStudents : Form
    {
         string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\source\\SiteCore65\\Individual-Data.xls;Extended Properties=Excel 8.0;";

        List<Student> studentsList = new List<Student>();
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet studentDataSet, lastNameDataSet;
        DataTable studentTable;
        BindingSource myBindingSource;
        string strSQL;

        public frmStudents()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The Form Load Event connects to the database, retrieves all the student records,
        /// displays the student records inside a DatGridView control using the DataSet as the data source.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStudentInfo_Load(object sender, EventArgs e)
        {
            // Connect to the database, retrieve a result set of records, and store them in a DataSet
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=School.accdb;");
            strSQL = "SELECT * FROM Students";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            studentDataSet = new DataSet("StudentsTable");
            myDataAdapter.Fill(studentDataSet, "StudentsTable");

            // Set the data source for the DataGridView to display the records and their information.
            // The DataGridView DataSource property can be assigned a DataTable, BindingSource, or a collection.
            studentTable = studentDataSet.Tables["StudentsTable"];
            dgvStudents.DataSource = studentTable;

            // Alternative Method of setting the data source for the DataGridView.
            // This method uses a BindingSource object as the data source. 
            //myBindingSource = new BindingSource();
            //myBindingSource.DataSource = myDataSet;
            //myBindingSource.DataMember = "StudentsTable";
            //dgvStudents.DataSource = myBindingSource;

            // Populate the ComboBox control with a list of majors coming from the database.
            // Change the SQL command text for the DataAdapter to execute a new query that
            // contains a list of all the distinct values for the Major field.
            strSQL = "SELECT distinct Lastname FROM Students";
            myDataAdapter.SelectCommand.CommandText = strSQL;
            lastNameDataSet = new DataSet("LastnameTable");
            myDataAdapter.Fill(lastNameDataSet, "LastnameTable");

            // Display the data from the query in the ComboBox control.
            ddlLastname.DataSource = lastNameDataSet.Tables["LastnameTable"];
            ddlLastname.DisplayMember = "Lastname";   // sets the field to be displayed in the ComboBox.
            ddlLastname.ValueMember = "Lastname";     // sets the field value used by the SelectedValue property.
        }

        /// <summary>
        /// This button is used to display the collection of Student objects in the
        /// DataGridView. It creates a collection (List<Student>) of Student objects that contain the 
        /// data contained in the student records.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadStudentsFromCollection_Click(object sender, EventArgs e)
        {
            // Create a list of Student objects containing data from the records 
            // retrieved from the database. Loop through all the records in the
            // DataTable inside the DataSet,create a Student object for each record,
            // and store the Student object in a collection.
            foreach (DataRow record in studentTable.Rows)
            {
                Student student = new Student();
                student.StudentID = record["StudentID"].ToString();
                student.FirstName = record["Firstname"].ToString();
                student.LastName = record["Lastname"].ToString();
                student.Major = record["Major"].ToString();

                studentsList.Add(student);
            }

            // Set the data source for the DataGridView to display the collection of Student objects.
            dgvStudents.DataSource = studentsList;

            // Display a message that the operation was completed.
            MessageBox.Show("Data from the Student List has been loaded.");
        }

        /// <summary>
        /// This button is used to search the database and display the Students that 
        /// match the criteria for major.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchDatabase_Click(object sender, EventArgs e)
        {
            // Perform a query on the database and display the records in the DataGridView.
            // Connect to the database, retrieve a result set of records, and store them in a DataSet
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=School.accdb;");
            strSQL = "SELECT * FROM Students WHERE Lastname = '" + ddlLastname.SelectedValue + "'";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            studentDataSet = new DataSet("StudentsTable");
            myDataAdapter.Fill(studentDataSet, "StudentsTable");

            // Set the data source for the DataGridView to display the records and their information.
            // The DataGridView DataSource property can be assigned a DataTable, BindingSource, or a collection.
            studentTable = studentDataSet.Tables["StudentsTable"];
            dgvStudents.DataSource = studentTable;          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This button searches the collection of Students and display the objects that
        /// match the search criteria.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchCollection_Click(object sender, EventArgs e)
        {
            // Create a new collection that will contain only the Student objects that match
            // the search criteria.
            List<Student> searchResults = new List<Student>();

            // Search through the collection to find Student objects that have a major that
            // matches the major selected from the ComboBox.
            foreach (Student student in studentsList)
            {
                if (student.Major.CompareTo(ddlLastname.SelectedValue) == 0)
                    searchResults.Add(student);
            }

            // Display the search results in the DataGridView
            dgvStudents.DataSource = searchResults;
        }
    
    }
}
