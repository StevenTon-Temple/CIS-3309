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
    // This example demonstrates the ability to work with multiple forms in 
    // a Windows Form Application. It also demonstrates the ability to share data 
    // between the two forms. The forms must mark their controls or data with an 
    // access modifier that allows the controls/data to be access outside of the form's class.
    // This example uses the internal access modifier to allow access ti all classes in the same
    // project/assembly. 

    // The frmMain class creates an instance of the frmCustomer form and opens it.
    // This allows the frmMain class object the ability to easily access the
    // frmCustomer object's controls because it has a reference to the form object
    // it was responsible for creating. However, the tricky part is allowing the
    // frmCustomer object to access the frmMain object's data because it doesn't
    // know the object that created and opened it. Therefore, this example passes an
    // instance of the form (owner) that created and opened the frmCustomer.
    public partial class frmMain : Form
    {
        // This global variable stores the current user that is using the program.
        // The variable is marked with the internal access modifier, so it can be
        // used by other classes that are in the same project/assembly.
        internal String userLoggedIn;   

        public frmMain()
        {
            InitializeComponent();
        }

        // This button is used to assign the username textbox's value to
        // the form's global class variable that stores the username of the
        // person that is logged into the system.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            userLoggedIn = txtUsername.Text;
            lblDisplay.Text = "Hi " + userLoggedIn + ", you are logged in.";
        }

        // This button is used to open a Modal form to allow the user to enter
        // a new customer's information. The code inside this button passes the
        // current form, so the new form can access data on this form. 
        private void btnNewCustomerForm_Click(object sender, EventArgs e)
        {
            // Create an instance of the form to open.
            frmCustomer customerForm = new frmCustomer();

            // Pass an instance of the current form (frmMain object) to the
            // frmCustomer object so that it knows the object that created and opened it.
            customerForm.SetOwner(this);

            // Open the form as a Modal form. Opening a modal form requires the user
            // to only interact with that form and no other forms until it is closed.
            customerForm.ShowDialog();

            // Get the frmCustomer object's data from it's controls. These three textboxes
            // were given the internal access modifier in their declarations stored in
            // the form's designer file (frmCustomer.designer.cs file).
            String name = customerForm.txtName.Text;
            String phone = customerForm.txtPhone.Text;

            // Alternative method of accessing a control from the form.
            TextBox emailTextbox = (TextBox)customerForm.Controls["txtEmail"];
            String email = emailTextbox.Text;

            // Display the data that was retrieved from the frmCustomer object.
            lblDisplay.Text = "Customer Info: " + name + ", " + phone + ", " + email;
            lblDisplay.Text = lblDisplay.Text + "\nCustomer Form Password = " + customerForm.secretPassword;


        }
    }
}
