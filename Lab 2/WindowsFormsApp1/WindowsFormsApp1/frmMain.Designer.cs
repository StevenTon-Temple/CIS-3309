
namespace PizzaBuilder
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.txtname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.radpickup = new System.Windows.Forms.RadioButton();
            this.radDelivery = new System.Windows.Forms.RadioButton();
            this.combopizzasize = new System.Windows.Forms.ComboBox();
            this.combopizzacrust = new System.Windows.Forms.ComboBox();
            this.combosauce = new System.Windows.Forms.ComboBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtdorp = new System.Windows.Forms.Label();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.butsubmit = new System.Windows.Forms.Button();
            this.lblcrust = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.lblsauce = new System.Windows.Forms.Label();
            this.txttip = new System.Windows.Forms.TextBox();
            this.lbltip = new System.Windows.Forms.Label();
            this.chkToppings = new System.Windows.Forms.CheckedListBox();
            this.chkPremiumtoppings = new System.Windows.Forms.CheckedListBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lbltoppings = new System.Windows.Forms.Label();
            this.lblPremiumtoppings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(63, 134);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(156, 22);
            this.txtname.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(63, 224);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(156, 22);
            this.txtaddress.TabIndex = 2;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(63, 282);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(156, 22);
            this.txtphone.TabIndex = 3;
            // 
            // radpickup
            // 
            this.radpickup.AutoSize = true;
            this.radpickup.Location = new System.Drawing.Point(149, 197);
            this.radpickup.Name = "radpickup";
            this.radpickup.Size = new System.Drawing.Size(71, 21);
            this.radpickup.TabIndex = 4;
            this.radpickup.TabStop = true;
            this.radpickup.Text = "Pickup";
            this.radpickup.UseVisualStyleBackColor = true;
            // 
            // radDelivery
            // 
            this.radDelivery.AutoSize = true;
            this.radDelivery.Location = new System.Drawing.Point(63, 197);
            this.radDelivery.Name = "radDelivery";
            this.radDelivery.Size = new System.Drawing.Size(80, 21);
            this.radDelivery.TabIndex = 5;
            this.radDelivery.TabStop = true;
            this.radDelivery.Text = "Delivery";
            this.radDelivery.UseVisualStyleBackColor = true;
            // 
            // combopizzasize
            // 
            this.combopizzasize.FormattingEnabled = true;
            this.combopizzasize.Items.AddRange(new object[] {
            "Extra Large",
            "Large",
            "Medium",
            "Small"});
            this.combopizzasize.Location = new System.Drawing.Point(299, 134);
            this.combopizzasize.Name = "combopizzasize";
            this.combopizzasize.Size = new System.Drawing.Size(95, 24);
            this.combopizzasize.TabIndex = 6;
            // 
            // combopizzacrust
            // 
            this.combopizzacrust.FormattingEnabled = true;
            this.combopizzacrust.Items.AddRange(new object[] {
            "Regular",
            "Stuffed",
            "Deep dish",
            "Thin",
            "Cheesy garlic butter",
            "Thick",
            "Thickest",
            "Cheesey",
            "Spicey",
            "Garlic"});
            this.combopizzacrust.Location = new System.Drawing.Point(299, 222);
            this.combopizzacrust.Name = "combopizzacrust";
            this.combopizzacrust.Size = new System.Drawing.Size(95, 24);
            this.combopizzacrust.TabIndex = 7;
            // 
            // combosauce
            // 
            this.combosauce.FormattingEnabled = true;
            this.combosauce.Items.AddRange(new object[] {
            "Tomato",
            "White",
            "Pesto",
            "Teriyaki",
            "BBQ",
            "Chesse",
            "New York Style",
            "Spcieal",
            "Homemade",
            "Italian"});
            this.combosauce.Location = new System.Drawing.Point(299, 282);
            this.combosauce.Name = "combosauce";
            this.combosauce.Size = new System.Drawing.Size(95, 24);
            this.combosauce.TabIndex = 8;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(60, 114);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(96, 17);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "Enter A Name";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdorp
            // 
            this.txtdorp.AutoSize = true;
            this.txtdorp.Location = new System.Drawing.Point(60, 177);
            this.txtdorp.Name = "txtdorp";
            this.txtdorp.Size = new System.Drawing.Size(122, 17);
            this.txtdorp.TabIndex = 10;
            this.txtdorp.Text = "Delivery or Pickup";
            this.txtdorp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Location = new System.Drawing.Point(60, 262);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(141, 17);
            this.lblphonenumber.TabIndex = 11;
            this.lblphonenumber.Text = "Enter Phone Number";
            this.lblphonenumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butsubmit
            // 
            this.butsubmit.Location = new System.Drawing.Point(63, 411);
            this.butsubmit.Name = "butsubmit";
            this.butsubmit.Size = new System.Drawing.Size(119, 23);
            this.butsubmit.TabIndex = 13;
            this.butsubmit.Text = "Submit";
            this.butsubmit.UseVisualStyleBackColor = true;
            this.butsubmit.Click += new System.EventHandler(this.butsubmit_Click);
            // 
            // lblcrust
            // 
            this.lblcrust.AutoSize = true;
            this.lblcrust.Location = new System.Drawing.Point(296, 199);
            this.lblcrust.Name = "lblcrust";
            this.lblcrust.Size = new System.Drawing.Size(41, 17);
            this.lblcrust.TabIndex = 36;
            this.lblcrust.Text = "Crust";
            this.lblcrust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Location = new System.Drawing.Point(296, 114);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(35, 17);
            this.lblsize.TabIndex = 37;
            this.lblsize.Text = "Size";
            this.lblsize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsauce
            // 
            this.lblsauce.AutoSize = true;
            this.lblsauce.Location = new System.Drawing.Point(296, 263);
            this.lblsauce.Name = "lblsauce";
            this.lblsauce.Size = new System.Drawing.Size(48, 17);
            this.lblsauce.TabIndex = 38;
            this.lblsauce.Text = "Sauce";
            this.lblsauce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttip
            // 
            this.txttip.Location = new System.Drawing.Point(63, 365);
            this.txttip.Name = "txttip";
            this.txttip.Size = new System.Drawing.Size(93, 22);
            this.txttip.TabIndex = 39;
            this.txttip.Text = "0";
            // 
            // lbltip
            // 
            this.lbltip.AutoSize = true;
            this.lbltip.Location = new System.Drawing.Point(60, 331);
            this.lbltip.Name = "lbltip";
            this.lbltip.Size = new System.Drawing.Size(65, 17);
            this.lbltip.TabIndex = 40;
            this.lbltip.Text = "Tip (in $)";
            this.lbltip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkToppings
            // 
            this.chkToppings.FormattingEnabled = true;
            this.chkToppings.Items.AddRange(new object[] {
            "Pepperoni",
            "Mushroom",
            "Extra Cheese",
            "Sausage",
            "Onion",
            "Black Olives",
            "Green Pepper",
            "Fresh Garlic",
            "Tomato Cuts",
            "Fresh Basil"});
            this.chkToppings.Location = new System.Drawing.Point(577, 115);
            this.chkToppings.Name = "chkToppings";
            this.chkToppings.Size = new System.Drawing.Size(237, 174);
            this.chkToppings.TabIndex = 41;
            // 
            // chkPremiumtoppings
            // 
            this.chkPremiumtoppings.FormattingEnabled = true;
            this.chkPremiumtoppings.Items.AddRange(new object[] {
            "BBQ Chicken Slices",
            "Salsa Sauce",
            "Teriyaki Jerky",
            "Olive Oil and Garlic",
            "Salami",
            "Procuiitto",
            "Meatball",
            "Anchovies",
            "Sopressata",
            "Fig Jam",
            ""});
            this.chkPremiumtoppings.Location = new System.Drawing.Point(889, 115);
            this.chkPremiumtoppings.Name = "chkPremiumtoppings";
            this.chkPremiumtoppings.Size = new System.Drawing.Size(254, 174);
            this.chkPremiumtoppings.TabIndex = 42;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(507, 50);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 43;
            // 
            // lbltoppings
            // 
            this.lbltoppings.AutoSize = true;
            this.lbltoppings.Location = new System.Drawing.Point(577, 92);
            this.lbltoppings.Name = "lbltoppings";
            this.lbltoppings.Size = new System.Drawing.Size(67, 17);
            this.lbltoppings.TabIndex = 44;
            this.lbltoppings.Text = "Toppings";
            // 
            // lblPremiumtoppings
            // 
            this.lblPremiumtoppings.AutoSize = true;
            this.lblPremiumtoppings.Location = new System.Drawing.Point(886, 92);
            this.lblPremiumtoppings.Name = "lblPremiumtoppings";
            this.lblPremiumtoppings.Size = new System.Drawing.Size(126, 17);
            this.lblPremiumtoppings.TabIndex = 45;
            this.lblPremiumtoppings.Text = "Premium Toppings";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 815);
            this.Controls.Add(this.lblPremiumtoppings);
            this.Controls.Add(this.lbltoppings);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.chkPremiumtoppings);
            this.Controls.Add(this.chkToppings);
            this.Controls.Add(this.lbltip);
            this.Controls.Add(this.txttip);
            this.Controls.Add(this.lblsauce);
            this.Controls.Add(this.lblsize);
            this.Controls.Add(this.lblcrust);
            this.Controls.Add(this.butsubmit);
            this.Controls.Add(this.lblphonenumber);
            this.Controls.Add(this.txtdorp);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.combosauce);
            this.Controls.Add(this.combopizzacrust);
            this.Controls.Add(this.combopizzasize);
            this.Controls.Add(this.radDelivery);
            this.Controls.Add(this.radpickup);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Name = "frmMain";
            this.Text = "PizzaBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.RadioButton radpickup;
        private System.Windows.Forms.RadioButton radDelivery;
        private System.Windows.Forms.ComboBox combopizzasize;
        private System.Windows.Forms.ComboBox combopizzacrust;
        private System.Windows.Forms.ComboBox combosauce;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label txtdorp;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.Button butsubmit;
        private System.Windows.Forms.Label lblcrust;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Label lblsauce;
        private System.Windows.Forms.TextBox txttip;
        private System.Windows.Forms.Label lbltip;
        private System.Windows.Forms.CheckedListBox chkToppings;
        private System.Windows.Forms.CheckedListBox chkPremiumtoppings;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lbltoppings;
        private System.Windows.Forms.Label lblPremiumtoppings;
    }
}

