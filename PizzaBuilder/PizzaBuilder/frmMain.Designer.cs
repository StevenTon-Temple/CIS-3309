
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ddCrust = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ddSize = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ddSauce = new System.Windows.Forms.ComboBox();
            this.chkToppings = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioDelivery = new System.Windows.Forms.RadioButton();
            this.radioPickup = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.chkExtra = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.TotalNum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(20, 128);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(185, 22);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(20, 178);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(185, 22);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone Number:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address:";
            // 
            // ddCrust
            // 
            this.ddCrust.FormattingEnabled = true;
            this.ddCrust.Items.AddRange(new object[] {
            "Regular",
            "Stuffed",
            "Deep Dish",
            "Thin Crust",
            "Cheesy Garlic Butter",
            "New York",
            "Neapolitan",
            "St. Louis",
            "Sicilian",
            "Detroit"});
            this.ddCrust.Location = new System.Drawing.Point(20, 381);
            this.ddCrust.Name = "ddCrust";
            this.ddCrust.Size = new System.Drawing.Size(121, 24);
            this.ddCrust.TabIndex = 7;
            this.ddCrust.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Crust";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pie Size";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ddSize
            // 
            this.ddSize.FormattingEnabled = true;
            this.ddSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Extra-Large"});
            this.ddSize.Location = new System.Drawing.Point(20, 308);
            this.ddSize.Name = "ddSize";
            this.ddSize.Size = new System.Drawing.Size(121, 24);
            this.ddSize.TabIndex = 9;
            this.ddSize.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sauce";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ddSauce
            // 
            this.ddSauce.FormattingEnabled = true;
            this.ddSauce.Items.AddRange(new object[] {
            "Tomato",
            "White",
            "Pesto",
            "Pepper",
            "Sweet",
            "Creamy Alfredo",
            "BBQ",
            "Buffalo",
            "Ranch",
            "Sundried Tomato Sauce"});
            this.ddSauce.Location = new System.Drawing.Point(20, 451);
            this.ddSauce.Name = "ddSauce";
            this.ddSauce.Size = new System.Drawing.Size(121, 24);
            this.ddSauce.TabIndex = 13;
            this.ddSauce.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // chkToppings
            // 
            this.chkToppings.FormattingEnabled = true;
            this.chkToppings.Items.AddRange(new object[] {
            "Pepperoni",
            "Mushroom",
            "Anchovy",
            "Pineapple",
            "Bacon",
            "Ham",
            "Onion",
            "Pepper",
            "Sausage",
            "Olive"});
            this.chkToppings.Location = new System.Drawing.Point(217, 301);
            this.chkToppings.Name = "chkToppings";
            this.chkToppings.Size = new System.Drawing.Size(203, 174);
            this.chkToppings.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Toppings";
            // 
            // radioDelivery
            // 
            this.radioDelivery.AutoSize = true;
            this.radioDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDelivery.Location = new System.Drawing.Point(198, 46);
            this.radioDelivery.Name = "radioDelivery";
            this.radioDelivery.Size = new System.Drawing.Size(80, 21);
            this.radioDelivery.TabIndex = 17;
            this.radioDelivery.TabStop = true;
            this.radioDelivery.Text = "Delivery";
            this.radioDelivery.UseVisualStyleBackColor = true;
            this.radioDelivery.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioPickup
            // 
            this.radioPickup.AutoSize = true;
            this.radioPickup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPickup.Location = new System.Drawing.Point(198, 73);
            this.radioPickup.Name = "radioPickup";
            this.radioPickup.Size = new System.Drawing.Size(71, 21);
            this.radioPickup.TabIndex = 18;
            this.radioPickup.TabStop = true;
            this.radioPickup.Text = "Pickup";
            this.radioPickup.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(455, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Extra";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // chkExtra
            // 
            this.chkExtra.FormattingEnabled = true;
            this.chkExtra.Items.AddRange(new object[] {
            "Pepperoni",
            "Mushroom",
            "Anchovy",
            "Pineapple",
            "Bacon",
            "Ham",
            "Onion",
            "Pepper",
            "Sausage",
            "Olive",
            "Cheese"});
            this.chkExtra.Location = new System.Drawing.Point(446, 55);
            this.chkExtra.Name = "chkExtra";
            this.chkExtra.Size = new System.Drawing.Size(203, 169);
            this.chkExtra.TabIndex = 19;
            this.chkExtra.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tip (%)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 498);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 31);
            this.label14.TabIndex = 28;
            this.label14.Text = "Finish Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkExtra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 249);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Pizza";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 214);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblError);
            this.groupBox3.Controls.Add(this.txtTip);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.radioPickup);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.radioDelivery);
            this.groupBox3.Controls.Add(this.btnTotal);
            this.groupBox3.Controls.Add(this.TotalNum);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 501);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 119);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Finish Order";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(311, 57);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(21, 31);
            this.lblError.TabIndex = 31;
            this.lblError.Text = " ";
            this.lblError.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(14, 54);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(165, 38);
            this.txtTip.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = " ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(550, 50);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(89, 44);
            this.btnTotal.TabIndex = 28;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // TotalNum
            // 
            this.TotalNum.AutoSize = true;
            this.TotalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNum.Location = new System.Drawing.Point(200, 177);
            this.TotalNum.Name = "TotalNum";
            this.TotalNum.Size = new System.Drawing.Size(17, 25);
            this.TotalNum.TabIndex = 27;
            this.TotalNum.Text = " ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 632);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkToppings);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ddSauce);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ddCrust);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmMain";
            this.Text = "Pizza Builder";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddCrust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddSauce;
        private System.Windows.Forms.CheckedListBox chkToppings;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioDelivery;
        private System.Windows.Forms.RadioButton radioPickup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox chkExtra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label TotalNum;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblError;
    }
}

