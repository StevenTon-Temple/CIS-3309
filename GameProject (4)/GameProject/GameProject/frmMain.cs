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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            frmPlayers player = new frmPlayers();
       
            player.Show();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            frmRules rules = new frmRules();
            
            rules.Show();


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
             
        }
    }
}
