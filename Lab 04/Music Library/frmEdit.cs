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

    public partial class frmEdit : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter data;
        OleDbCommand command;
        DataSet songDataSet;
        DataTable songTable;
        string strSQL;

        public frmEdit()
        {

            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            frmMain gridForm = new frmMain();
            string connectionStr = ("provider=Microsoft.ACE.OLEDB.12.0;Data Source= songList.accdb;");
            strSQL = "UPDATE SongList " + " SET Songname = '" +
                txtSongName.Text + "' , Artist= '" + txtArtist.Text + "', Albulmname= '" +
                txtAlbum.Text+ "', Genre = '" + txtGenre.Text + "', Duration = '" +
                txtSongDuration.Text + "', Releaseyear =" + int.Parse(txtSongYear.Text) + " WHERE ID = " + id;
            OleDbConnection connnection = new OleDbConnection(connectionStr);
            OleDbCommand insertCmd = new OleDbCommand(strSQL, connnection);

            try
            {
                connnection.Open();
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
                connnection.Close();
            }
            
            gridForm.ShowDialog();

            


        }
    }
}
