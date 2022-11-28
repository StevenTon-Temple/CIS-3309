using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleFormsDemo
{
    public partial class frmCustomer : Form
    {
        // Global class variable used to store some data that can be retrieved
        // by other forms and classes in this project/assembly.
        internal String secretPassword = "Temple12345";

        // global class variable used to store a reference of the form that
        // created and opened this form.
        private frmMain ownerForm;  


        // This method is used to store a reference to the owner form that
        // created and opened this form.
        public void SetOwner(Form theForm)
        {
            // Cast the form to the correct class.
            ownerForm = (frmMain)theForm;              
        }

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Logged in user: " + ownerForm.userLoggedIn);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
