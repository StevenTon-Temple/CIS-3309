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
        //saves the song
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            frmAddSong songAdd = new frmAddSong();
            Song theSong = songAdd.GetNewSong();
            if (theSong != null)
            {
                Console.WriteLine("here:    " + theSong);
                songItems.Add(theSong);
                SongItemDB.SaveSongs(songItems);
                FillSongListBox();
                
            }
            
        
        }

        //God I got so angry when I got this part to be correct it took me 5 hours and I was overthinking so hard :(
        private void listSongs_Click(object sender, EventArgs e)
        {
            string http = listSongs.SelectedItems[0].SubItems[7].Text;

            picAlbulm.Load(http);
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    string searchBY = comboSearch.Text;

       

        //}
    }
}
