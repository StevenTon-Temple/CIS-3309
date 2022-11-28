using SongClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private List<Song> songItems = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            songItems = SongItemDB.GetItems();
            FillSongListBox();
            picAlbulm.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }
        private void FillSongListBox()
        {
            listSongs.Items.Clear();
            foreach (Song i in songItems)
 {
                listSongs.View = View.Details;
                ListViewItem view = new ListViewItem(i.Title);
                view.SubItems.Add(i.Album);
                view.SubItems.Add(i.Artist);
                view.SubItems.Add(i.Genre);
                view.SubItems.Add(i.ReleaseYear);
                view.SubItems.Add(i.Duration_Time);
                view.SubItems.Add(i.song_Description);
                view.SubItems.Add(i.imgUrl);

                listSongs.Items.Add(view);
            }
        }
        //saves song to list
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            frmAddSong songAdd = new frmAddSong();
            Song theSong = songAdd.GetNewSong();
            if (theSong != null)
            {
                
                songItems.Add(theSong);
                SongItemDB.SaveSongs(songItems);
                FillSongListBox();
                
            }
            
        
        }

      
        private void listSongs_Click(object sender, EventArgs e)
        {
            string http = listSongs.SelectedItems[0].SubItems[7].Text;

            picAlbulm.Load(http);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            listSongs.Items.Clear();
            foreach (Song i in songItems)
            {
                if (i.Title.Equals(txtSearch.Text) && comboSearch.Text.Equals("Name"))
                {
                    songItems = SongItemDB.GetItems();
                    listSongs.View = View.Details;
                    ListViewItem viewCopy = new ListViewItem(i.Title);
                    viewCopy.SubItems.Add(i.Album);
                    viewCopy.SubItems.Add(i.Artist);
                    viewCopy.SubItems.Add(i.Genre);
                    viewCopy.SubItems.Add(i.ReleaseYear);
                    viewCopy.SubItems.Add(i.Duration_Time);
                    viewCopy.SubItems.Add(i.song_Description);
                    viewCopy.SubItems.Add(i.imgUrl);

                    listSongs.Items.Add(viewCopy);
                }
                if (i.Genre.Equals(txtSearch.Text) && comboSearch.Text.Equals("Genre"))
                {
                    songItems = SongItemDB.GetItems();
                    listSongs.View = View.Details;
                    ListViewItem viewCopy = new ListViewItem(i.Title);
                    viewCopy.SubItems.Add(i.Album);
                    viewCopy.SubItems.Add(i.Artist);
                    viewCopy.SubItems.Add(i.Genre);
                    viewCopy.SubItems.Add(i.ReleaseYear);
                    viewCopy.SubItems.Add(i.Duration_Time);
                    viewCopy.SubItems.Add(i.song_Description);
                    viewCopy.SubItems.Add(i.imgUrl);

                    listSongs.Items.Add(viewCopy);
                }
                if (i.ReleaseYear.Equals(txtSearch.Text) && comboSearch.Text.Equals("Year"))
                {
                    songItems = SongItemDB.GetItems();
                    listSongs.View = View.Details;
                    ListViewItem viewCopy = new ListViewItem(i.Title);
                    viewCopy.SubItems.Add(i.Album);
                    viewCopy.SubItems.Add(i.Artist);
                    viewCopy.SubItems.Add(i.Genre);
                    viewCopy.SubItems.Add(i.ReleaseYear);
                    viewCopy.SubItems.Add(i.Duration_Time);
                    viewCopy.SubItems.Add(i.song_Description);
                    viewCopy.SubItems.Add(i.imgUrl);

                    listSongs.Items.Add(viewCopy);
                }


                listSongs.View = View.Details;

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listSongs.Items.Clear();
            foreach (Song i in songItems)
            {
                listSongs.View = View.Details;
                ListViewItem view = new ListViewItem(i.Title);
                view.SubItems.Add(i.Album);
                view.SubItems.Add(i.Artist);
                view.SubItems.Add(i.Genre);
                view.SubItems.Add(i.ReleaseYear);
                view.SubItems.Add(i.Duration_Time);
                view.SubItems.Add(i.song_Description);
                view.SubItems.Add(i.imgUrl);

                listSongs.Items.Add(view);
            }
            txtSearch.Text = "";
            comboSearch.SelectedIndex = 0;
        }
    }
}
