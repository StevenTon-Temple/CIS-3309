using SongClassLibrary;
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

namespace Music_Library
{
    public partial class frmAddSong : Form
    {
        
        string conectionStr = "provider=Microsoft.ACE.OLEDB.12.0;Data Source= songList.accdb;";
       
        public Song the_Song;

        public frmAddSong()
        {
            InitializeComponent();
        }
        

        public Song GetNewSong()
        {
            this.ShowDialog();
            return the_Song;
        }
        //Got help from TA
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            string commandStr = "INSERT INTO SongList (SongName, Artist, Albulmname, Genre, Releaseyear, Duration, Description, imgurl) " +
                "VALUES ('" + txtSong.Text + "','" + txtArtist.Text + "','" + txtAlbumName.Text + "','" + comboGenre.Text + "','" + txtReleaseYear.Text +
            "','" + txtDuration.Text + "','" + txtDescription.Text + "','" + txtCover.Text + "')";

            OleDbConnection conection = new OleDbConnection(conectionStr);
            OleDbCommand insertCmd = new OleDbCommand(commandStr, conection);
            
            try
            {
                conection.Open();
                insertCmd.ExecuteNonQuery();

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
                conection.Close();
            }

            
            this.Close();
           
        }
       


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSong.Clear();
            txtReleaseYear.Clear();
            txtAlbumName.Clear();
            txtDuration.Clear();
            txtDescription.Clear();
            txtCover.Clear();
            txtArtist.Clear();
            comboGenre.SelectedIndex = 0;
        }
        public void AddARow(DataTable table)
        {
            //ref https://stackoverflow.com/questions/8708057/rows-cannot-be-programmatically-added-to-the-datagridviews-row-collection-when
            // Use the NewRow method to create a DataRow with 
            // the table's schema.
            DataRow newRow = table.NewRow();

            // Add the row to the rows collection.
            table.Rows.Add(newRow);
        }

        private void frmAddSong_Load(object sender, EventArgs e)
        {
            


        }

        private void frmAddSong_Leave(object sender, EventArgs e)
        {
         
        }
    }
}
