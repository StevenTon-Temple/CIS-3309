using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject
{
    public partial class frmPlayers : Form
    {
        Players player = new Players();
        public frmPlayers()
        {
            InitializeComponent();
        }

        private void frmPlayers_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // prompt to ask for player names to send to player class
            player.Player1 = txtPlayer1.Text;
            player.Player2 = txtPlayer2.Text;

            frmGame game = new frmGame(player.Player1, player.Player2);
            this.Close();
            game.ShowDialog();
            
        }
    }
}
