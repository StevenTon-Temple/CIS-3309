
namespace PizzaBuilder
{
    partial class frmReceipt
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecSize = new System.Windows.Forms.Label();
            this.lblRecSauce = new System.Windows.Forms.Label();
            this.lblRecToppings = new System.Windows.Forms.Label();
            this.lblRecCrust = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRecCost = new System.Windows.Forms.Label();
            this.lblRecAddress = new System.Windows.Forms.Label();
            this.lblRecNumber = new System.Windows.Forms.Label();
            this.lblRecName = new System.Windows.Forms.Label();
            this.lblRecExtra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Confirmed!";
            // 
            // lblRecSize
            // 
            this.lblRecSize.AutoSize = true;
            this.lblRecSize.Location = new System.Drawing.Point(12, 41);
            this.lblRecSize.Name = "lblRecSize";
            this.lblRecSize.Size = new System.Drawing.Size(73, 17);
            this.lblRecSize.TabIndex = 1;
            this.lblRecSize.Text = "PIzza Size";
            // 
            // lblRecSauce
            // 
            this.lblRecSauce.AutoSize = true;
            this.lblRecSauce.Location = new System.Drawing.Point(12, 75);
            this.lblRecSauce.Name = "lblRecSauce";
            this.lblRecSauce.Size = new System.Drawing.Size(48, 17);
            this.lblRecSauce.TabIndex = 2;
            this.lblRecSauce.Text = "Sauce";
            // 
            // lblRecToppings
            // 
            this.lblRecToppings.AutoSize = true;
            this.lblRecToppings.Location = new System.Drawing.Point(12, 92);
            this.lblRecToppings.Name = "lblRecToppings";
            this.lblRecToppings.Size = new System.Drawing.Size(67, 17);
            this.lblRecToppings.TabIndex = 3;
            this.lblRecToppings.Text = "Toppings";
            // 
            // lblRecCrust
            // 
            this.lblRecCrust.AutoSize = true;
            this.lblRecCrust.Location = new System.Drawing.Point(12, 58);
            this.lblRecCrust.Name = "lblRecCrust";
            this.lblRecCrust.Size = new System.Drawing.Size(41, 17);
            this.lblRecCrust.TabIndex = 4;
            this.lblRecCrust.Text = "Crust";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Approximate time: 30 min";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblRecCost
            // 
            this.lblRecCost.AutoSize = true;
            this.lblRecCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecCost.Location = new System.Drawing.Point(19, 323);
            this.lblRecCost.Name = "lblRecCost";
            this.lblRecCost.Size = new System.Drawing.Size(48, 25);
            this.lblRecCost.TabIndex = 6;
            this.lblRecCost.Text = "cost";
            // 
            // lblRecAddress
            // 
            this.lblRecAddress.AutoSize = true;
            this.lblRecAddress.Location = new System.Drawing.Point(18, 372);
            this.lblRecAddress.Name = "lblRecAddress";
            this.lblRecAddress.Size = new System.Drawing.Size(59, 17);
            this.lblRecAddress.TabIndex = 7;
            this.lblRecAddress.Text = "address";
            this.lblRecAddress.Click += new System.EventHandler(this.lblRecAddress_Click);
            // 
            // lblRecNumber
            // 
            this.lblRecNumber.AutoSize = true;
            this.lblRecNumber.Location = new System.Drawing.Point(18, 389);
            this.lblRecNumber.Name = "lblRecNumber";
            this.lblRecNumber.Size = new System.Drawing.Size(56, 17);
            this.lblRecNumber.TabIndex = 8;
            this.lblRecNumber.Text = "number";
            // 
            // lblRecName
            // 
            this.lblRecName.AutoSize = true;
            this.lblRecName.Location = new System.Drawing.Point(18, 406);
            this.lblRecName.Name = "lblRecName";
            this.lblRecName.Size = new System.Drawing.Size(105, 17);
            this.lblRecName.TabIndex = 9;
            this.lblRecName.Text = "customer name";
            // 
            // lblRecExtra
            // 
            this.lblRecExtra.AutoSize = true;
            this.lblRecExtra.Location = new System.Drawing.Point(198, 92);
            this.lblRecExtra.Name = "lblRecExtra";
            this.lblRecExtra.Size = new System.Drawing.Size(40, 17);
            this.lblRecExtra.TabIndex = 10;
            this.lblRecExtra.Text = "Extra";
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 459);
            this.Controls.Add(this.lblRecExtra);
            this.Controls.Add(this.lblRecName);
            this.Controls.Add(this.lblRecNumber);
            this.Controls.Add(this.lblRecAddress);
            this.Controls.Add(this.lblRecCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRecCrust);
            this.Controls.Add(this.lblRecToppings);
            this.Controls.Add(this.lblRecSauce);
            this.Controls.Add(this.lblRecSize);
            this.Controls.Add(this.label1);
            this.Name = "frmReceipt";
            this.Text = "Order summary";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecSize;
        private System.Windows.Forms.Label lblRecSauce;
        private System.Windows.Forms.Label lblRecToppings;
        private System.Windows.Forms.Label lblRecCrust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRecCost;
        private System.Windows.Forms.Label lblRecAddress;
        private System.Windows.Forms.Label lblRecNumber;
        private System.Windows.Forms.Label lblRecName;
        private System.Windows.Forms.Label lblRecExtra;
    }
}