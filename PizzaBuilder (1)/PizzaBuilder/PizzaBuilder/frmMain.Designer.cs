
namespace pizzabuilder
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.radDelivery = new System.Windows.Forms.RadioButton();
            this.radPickup = new System.Windows.Forms.RadioButton();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.cmbCrust = new System.Windows.Forms.ComboBox();
            this.lblSauce = new System.Windows.Forms.Label();
            this.cmbSauce = new System.Windows.Forms.ComboBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.lblPremium = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.chkToppings = new System.Windows.Forms.CheckedListBox();
            this.chkAdditions = new System.Windows.Forms.CheckedListBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(25, 70);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(161, 25);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone Number:\r\n";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(25, 118);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(97, 25);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:\r\n";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 31);
            this.txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(192, 64);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 31);
            this.txtPhone.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(128, 112);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 31);
            this.txtAddress.TabIndex = 5;
            // 
            // radDelivery
            // 
            this.radDelivery.AutoSize = true;
            this.radDelivery.Location = new System.Drawing.Point(375, 18);
            this.radDelivery.Name = "radDelivery";
            this.radDelivery.Size = new System.Drawing.Size(121, 29);
            this.radDelivery.TabIndex = 6;
            this.radDelivery.TabStop = true;
            this.radDelivery.Text = "Delivery\r\n";
            this.radDelivery.UseVisualStyleBackColor = true;
            // 
            // radPickup
            // 
            this.radPickup.AutoSize = true;
            this.radPickup.Location = new System.Drawing.Point(375, 66);
            this.radPickup.Name = "radPickup";
            this.radPickup.Size = new System.Drawing.Size(108, 29);
            this.radPickup.TabIndex = 7;
            this.radPickup.TabStop = true;
            this.radPickup.Text = "Pickup\r\n";
            this.radPickup.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(879, 18);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(119, 25);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "Pizza Size:\r\n";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Location = new System.Drawing.Point(605, 18);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(128, 25);
            this.lblCrust.TabIndex = 10;
            this.lblCrust.Text = "Pizza Crust:\r\n";
            // 
            // cmbCrust
            // 
            this.cmbCrust.FormattingEnabled = true;
            this.cmbCrust.Items.AddRange(new object[] {
            "Regular",
            "Stuffed",
            "Deep Dish",
            "Thin",
            "Cheesy Garlic Butter"});
            this.cmbCrust.Location = new System.Drawing.Point(610, 61);
            this.cmbCrust.Name = "cmbCrust";
            this.cmbCrust.Size = new System.Drawing.Size(121, 33);
            this.cmbCrust.TabIndex = 11;
            // 
            // lblSauce
            // 
            this.lblSauce.AutoSize = true;
            this.lblSauce.Location = new System.Drawing.Point(605, 112);
            this.lblSauce.Name = "lblSauce";
            this.lblSauce.Size = new System.Drawing.Size(138, 25);
            this.lblSauce.TabIndex = 16;
            this.lblSauce.Text = "Pizza Sauce:\r\n";
            // 
            // cmbSauce
            // 
            this.cmbSauce.FormattingEnabled = true;
            this.cmbSauce.Items.AddRange(new object[] {
            "Tomato",
            "White ",
            "Pesto",
            "Vodka",
            "Buffalo",
            "White Garlic",
            "BBQ ",
            "Ranch",
            "Hot Sauce",
            "No Sauce"});
            this.cmbSauce.Location = new System.Drawing.Point(612, 150);
            this.cmbSauce.Name = "cmbSauce";
            this.cmbSauce.Size = new System.Drawing.Size(121, 33);
            this.cmbSauce.TabIndex = 17;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(25, 204);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(166, 25);
            this.lblToppings.TabIndex = 18;
            this.lblToppings.Text = "Pizza Toppings:\r\n";
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(-240, 385);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(88, 29);
            this.chkHam.TabIndex = 22;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            // 
            // lblPremium
            // 
            this.lblPremium.AutoSize = true;
            this.lblPremium.Location = new System.Drawing.Point(431, 204);
            this.lblPremium.Name = "lblPremium";
            this.lblPremium.Size = new System.Drawing.Size(192, 25);
            this.lblPremium.TabIndex = 30;
            this.lblPremium.Text = "Premium Additons:";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(916, 204);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(48, 25);
            this.lblTip.TabIndex = 41;
            this.lblTip.Text = "Tip:";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(884, 252);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(100, 31);
            this.txtTip.TabIndex = 42;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(849, 368);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 70);
            this.btnSubmit.TabIndex = 43;
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(854, 563);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 25);
            this.lblError.TabIndex = 44;
            // 
            // chkToppings
            // 
            this.chkToppings.FormattingEnabled = true;
            this.chkToppings.Items.AddRange(new object[] {
            "Pepperoni",
            "Sausage",
            "Bacon",
            "Ham",
            "Onions",
            "Peppers",
            "Mushrooms",
            "Olives",
            "Anchovies",
            "Pineapple"});
            this.chkToppings.Location = new System.Drawing.Point(30, 252);
            this.chkToppings.Name = "chkToppings";
            this.chkToppings.Size = new System.Drawing.Size(222, 284);
            this.chkToppings.TabIndex = 45;
            // 
            // chkAdditions
            // 
            this.chkAdditions.FormattingEnabled = true;
            this.chkAdditions.Items.AddRange(new object[] {
            "Extra Cheese",
            "Extra Sauce",
            "Extra Bacon",
            "Extra Sausage",
            "Extra Ham",
            "Chicken",
            "Steak",
            "Avocado",
            "Extra Anchovies ",
            "Extra Pineapple"});
            this.chkAdditions.Location = new System.Drawing.Point(436, 252);
            this.chkAdditions.Name = "chkAdditions";
            this.chkAdditions.Size = new System.Drawing.Size(236, 284);
            this.chkAdditions.TabIndex = 46;
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Extra Large"});
            this.cmbSize.Location = new System.Drawing.Point(882, 61);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 33);
            this.cmbSize.TabIndex = 47;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 785);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.chkAdditions);
            this.Controls.Add(this.chkToppings);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblPremium);
            this.Controls.Add(this.chkHam);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.cmbSauce);
            this.Controls.Add(this.lblSauce);
            this.Controls.Add(this.cmbCrust);
            this.Controls.Add(this.lblCrust);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.radPickup);
            this.Controls.Add(this.radDelivery);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Name = "FrmMain";
            this.Text = "Jessica Classen - Pizza Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton radDelivery;
        private System.Windows.Forms.RadioButton radPickup;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.ComboBox cmbCrust;
        private System.Windows.Forms.Label lblSauce;
        private System.Windows.Forms.ComboBox cmbSauce;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.Label lblPremium;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckedListBox chkToppings;
        private System.Windows.Forms.CheckedListBox chkAdditions;
        private System.Windows.Forms.ComboBox cmbSize;
    }
}

