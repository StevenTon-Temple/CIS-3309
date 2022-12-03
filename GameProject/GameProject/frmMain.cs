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
            frmGame frm = new frmGame();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRules rules = new frmRules();
            rules.Show();


        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
