
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
            this.lblreciet = new System.Windows.Forms.Label();
            this.lblpickupordilvery = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblreciet
            // 
            this.lblreciet.AutoSize = true;
            this.lblreciet.Location = new System.Drawing.Point(38, 202);
            this.lblreciet.Name = "lblreciet";
            this.lblreciet.Size = new System.Drawing.Size(56, 17);
            this.lblreciet.TabIndex = 0;
            this.lblreciet.Text = "Receipt";
            this.lblreciet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblpickupordilvery
            // 
            this.lblpickupordilvery.AutoSize = true;
            this.lblpickupordilvery.Location = new System.Drawing.Point(38, 40);
            this.lblpickupordilvery.Name = "lblpickupordilvery";
            this.lblpickupordilvery.Size = new System.Drawing.Size(117, 17);
            this.lblpickupordilvery.TabIndex = 1;
            this.lblpickupordilvery.Text = "Pickup or Dilivery";
            this.lblpickupordilvery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(38, 117);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(40, 17);
            this.lbltotal.TabIndex = 2;
            this.lbltotal.Text = "Total";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblpickupordilvery);
            this.Controls.Add(this.lblreciet);
            this.Name = "frmReceipt";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReceipt_FormClosing);
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblreciet;
        private System.Windows.Forms.Label lblpickupordilvery;
        private System.Windows.Forms.Label lbltotal;
    }
}