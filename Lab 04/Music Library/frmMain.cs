using SongClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Library
{

    public partial class frmMain : Form
    {
        string conectionStr = "provider=Microsoft.ACE.OLEDB.12.0;Data Source= songList.accdb;";
        OleDbConnection conection;
        OleDbDataAdapter data;
        OleDbCommand comand;
        DataSet songDataSet;
        DataTable dataTableset;
        string strSQL;


        public frmMain()
        {
            InitializeComponent();
        }



        private void frmMain_Load(object sender, EventArgs e)
        {

            conection = new OleDbConnection(conectionStr);
            strSQL = "SELECT * FROM SongList" + " ORDER BY ID";
            data = new OleDbDataAdapter(strSQL, conection);
            songDataSet = new DataSet("SongListTable");
            data.Fill(songDataSet, "SongListTable");

            dataTableset = songDataSet.Tables["SongListTable"];

            dataGrid.DataSource = dataTableset;


            picAlbulm.SizeMode = PictureBoxSizeMode.StretchImage;

        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboSearch.Text == "Name")
            {
                conection = new OleDbConnection(conectionStr);
                strSQL = "SELECT * FROM SongList WHERE Songname = '" + txtSearch.Text + "'" + " ORDER BY ID";
                data = new OleDbDataAdapter(strSQL, conection);
                songDataSet = new DataSet("SongListTable");
                data.Fill(songDataSet, "SongListTable");
                dataTableset = songDataSet.Tables["SongListTable"];
                dataGrid.DataSource = dataTableset;
            }
            if (comboSearch.Text == "Year")
            {
                conection = new OleDbConnection(conectionStr);
                strSQL = "SELECT * FROM SongList WHERE Releaseyear = " + txtSearch.Text + " ORDER BY ID";
                data = new OleDbDataAdapter(strSQL, conection);
                songDataSet = new DataSet("SongListTable");
                data.Fill(songDataSet, "SongListTable");
                dataTableset = songDataSet.Tables["SongListTable"];
                dataGrid.DataSource = dataTableset;
            }
            if (comboSearch.Text == "Genre")
            {
                conection = new OleDbConnection(conectionStr);
                strSQL = "SELECT * FROM SongList WHERE Genre = '" + txtSearch.Text + "'" + " ORDER BY ID";
                data = new OleDbDataAdapter(strSQL, conection);
                songDataSet = new DataSet("SongListTable");
                data.Fill(songDataSet, "SongListTable");
                dataTableset = songDataSet.Tables["SongListTable"];
                dataGrid.DataSource = dataTableset;
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            //firstrowindex and id ref https://stackoverflow.com/questions/42734357/getting-the-first-cell-from-selected-row-from-datagridview-in-c-sharp
            int firstRowIndex = dataGrid.SelectedRows.Count - 1;
            string id = dataGrid.SelectedRows[firstRowIndex].Cells[0].Value.ToString();
            string commandStr = "DELETE FROM SongList WHERE ID = " + id ;
            conection = new OleDbConnection(conectionStr);
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
            //DELETE FROM Customers WHERE CustomerName = 'Alfreds Futterkiste';
            //cited from stackoverflow https://stackoverflow.com/questions/13369273/removing-selected-rows-in-datagridview
            strSQL = "SELECT * FROM SongList" + " ORDER BY ID";
            data = new OleDbDataAdapter(strSQL, conection);
            songDataSet = new DataSet("SongListTable");
            data.Fill(songDataSet, "SongListTable");

            dataTableset = songDataSet.Tables["SongListTable"];

            dataGrid.DataSource = dataTableset;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            conection = new OleDbConnection(conectionStr);
            strSQL = "SELECT * FROM SongList" + " ORDER BY ID";
            data = new OleDbDataAdapter(strSQL, conection);
            songDataSet = new DataSet("SongListTable");
            data.Fill(songDataSet, "SongListTable");
            dataTableset = songDataSet.Tables["SongListTable"];
            dataGrid.DataSource = dataTableset;

        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cited from stackoverflow https://stackoverflow.com/questions/29909352/datagridview-selected-row-to-display-in-text-boxes
            DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];

            string http = row.Cells[8].Value.ToString();

            picAlbulm.Load(http);
        }

        private void dataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEdit edit = new frmEdit();
            edit.txtId.Text = this.dataGrid.CurrentRow.Cells[0].Value.ToString();
            edit.txtSongName.Text = this.dataGrid.CurrentRow.Cells[1].Value.ToString();
            edit.txtArtist.Text = this.dataGrid.CurrentRow.Cells[2].Value.ToString();
            edit.txtAlbum.Text = this.dataGrid.CurrentRow.Cells[3].Value.ToString();
            edit.txtGenre.Text = this.dataGrid.CurrentRow.Cells[4].Value.ToString();
            edit.txtSongYear.Text = this.dataGrid.CurrentRow.Cells[5].Value.ToString();
            edit.txtSongDuration.Text = this.dataGrid.CurrentRow.Cells[6].Value.ToString();
            this.Hide();
            edit.ShowDialog();
            this.Close();
            
            conection = new OleDbConnection(conectionStr);
            strSQL = "SELECT * FROM SongList" + " ORDER BY ID";
            data = new OleDbDataAdapter(strSQL, conection);
            songDataSet = new DataSet("SongListTable");
            data.Fill(songDataSet, "SongListTable");

            dataTableset = songDataSet.Tables["SongListTable"];

            dataGrid.DataSource = dataTableset;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddSong addSong = new frmAddSong();
            addSong.ShowDialog();
            addSong.AddARow(dataTableset);


            conection = new OleDbConnection(conectionStr);
            strSQL = "SELECT * FROM SongList" + " ORDER BY ID";
            data = new OleDbDataAdapter(strSQL, conection);
            songDataSet = new DataSet("SongListTable");
            data.Fill(songDataSet, "SongListTable");

            dataTableset = songDataSet.Tables["SongListTable"];

            dataGrid.DataSource = dataTableset;

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int firstRowIndex = dataGrid.SelectedRows.Count - 1;
            //string id = dataGrid.SelectedRows[firstRowIndex].Cells[0].Value.ToString();

            //conection = new OleDbConnection(conectionStr);
            //strSQL = "SELECT * FROM SongList" + "WHERE ID = " + id + " ORDER BY ID";
            //data = new OleDbDataAdapter(strSQL, conection);
            //songDataSet = new DataSet("SongListTable");
            //data.Fill(songDataSet, "SongListTable");

            //dataTableset = songDataSet.Tables["SongListTable"];

            //dataGrid.DataSource = dataTableset;

        }

        private void btnFav_Click(object sender, EventArgs e)
        {
            int firstRowIndex = dataGrid.SelectedRows.Count - 1;
            string id = dataGrid.SelectedRows[firstRowIndex].Cells[0].Value.ToString();
            string commandStr = "UPDATE SongList " + "SET Favorite = TRUE " + " WHERE ID = " + id;
            conection = new OleDbConnection(conectionStr);
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

            
            strSQL = "SELECT * FROM SongList" + " ORDER BY ID";
            data = new OleDbDataAdapter(strSQL, conection);
            songDataSet = new DataSet("SongListTable");
            data.Fill(songDataSet, "SongListTable");

            dataTableset = songDataSet.Tables["SongListTable"];

            dataGrid.DataSource = dataTableset;

        }
    }
}


