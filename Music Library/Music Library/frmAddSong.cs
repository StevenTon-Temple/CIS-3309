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
            txtSong.Clear();
            txtReleaseYear.Clear();
            txtAlbumName.Clear();
            txtDuration.Clear();
            txtDescription.Clear();
            txtCover.Clear();
            txtArtist.Clear();
            comboGenre.SelectedIndex = 0;
        }

        private void frmAddSong_Load(object sender, EventArgs e)
        {

        }
    }
}
