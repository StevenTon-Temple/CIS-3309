using SongClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Library
{
    public partial class frmAddSong : Form
    {
        frmMain songs;

        public Song the_Song;
        public frmAddSong()
        {
            InitializeComponent();
        }
        public void SetForm(Form theForm)
        {
            songs = (frmMain)theForm;
        }

        public Song GetNewSong()
        {
            this.ShowDialog();
            return the_Song;
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            the_Song = new Song(
                txtSong.Text, 
                txtArtist.Text, 
                txtAlbumName.Text, 
                comboGenre.Text, 
                txtReleaseYear.Text, 
                txtDuration.Text, 
                txtDescription.Text, 
                txtCover.Text
                );
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboGenre.SelectedIndex = 0;
            txtSong.Clear();
            txtReleaseYear.Clear();
            txtAlbumName.Clear();
            txtDuration.Clear();
            txtDescription.Clear();
            txtCover.Clear();
            txtArtist.Clear();
        }
    }
}
