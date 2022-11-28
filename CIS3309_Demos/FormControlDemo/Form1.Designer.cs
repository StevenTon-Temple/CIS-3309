
namespace FormControlDemo
{
    partial class Form_Demo
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
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DDLStates = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtvalue1 = new System.Windows.Forms.TextBox();
            this.txtvalue2 = new System.Windows.Forms.TextBox();
            this.txtvalue3 = new System.Windows.Forms.TextBox();
            this.txtvalue4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(420, 152);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(183, 22);
            this.txtuser.TabIndex = 0;
            this.txtuser.Text = "Enter something here";
            // 
            // txtbutton
            // 
            this.txtbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtbutton.Location = new System.Drawing.Point(415, 207);
            this.txtbutton.Name = "txtbutton";
            this.txtbutton.Size = new System.Drawing.Size(187, 63);
            this.txtbutton.TabIndex = 1;
            this.txtbutton.Text = "click me";
            this.txtbutton.UseVisualStyleBackColor = false;
            this.txtbutton.Click += new System.EventHandler(this.txtbutton_Click);
            this.txtbutton.MouseEnter += new System.EventHandler(this.txtbutton_MouseEnter);
            this.txtbutton.MouseLeave += new System.EventHandler(this.txtbutton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text me";
            this.label1.Click += new System.EventHandler(this.txtbutton_Click);
            // 
            // DDLStates
            // 
            this.DDLStates.FormattingEnabled = true;
            this.DDLStates.Items.AddRange(new object[] {
            "Pennslyvaina",
            "New Jeresy",
            "Delware",
            "Maryland"});
            this.DDLStates.Location = new System.Drawing.Point(705, 150);
            this.DDLStates.Name = "DDLStates";
            this.DDLStates.Size = new System.Drawing.Size(132, 24);
            this.DDLStates.TabIndex = 3;
            this.DDLStates.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(712, 249);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(124, 68);
            this.listBox1.TabIndex = 4;
            // 
            // txtvalue1
            // 
            this.txtvalue1.Location = new System.Drawing.Point(366, 331);
            this.txtvalue1.Name = "txtvalue1";
            this.txtvalue1.Size = new System.Drawing.Size(77, 22);
            this.txtvalue1.TabIndex = 5;
            this.txtvalue1.TextChanged += new System.EventHandler(this.txtvalue1_TextChanged);
            // 
            // txtvalue2
            // 
            this.txtvalue2.Location = new System.Drawing.Point(488, 331);
            this.txtvalue2.Name = "txtvalue2";
            this.txtvalue2.Size = new System.Drawing.Size(77, 22);
            this.txtvalue2.TabIndex = 6;
            this.txtvalue2.TextChanged += new System.EventHandler(this.txtvalue1_TextChanged);
            // 
            // txtvalue3
            // 
            this.txtvalue3.Location = new System.Drawing.Point(366, 372);
            this.txtvalue3.Name = "txtvalue3";
            this.txtvalue3.Size = new System.Drawing.Size(77, 22);
            this.txtvalue3.TabIndex = 7;
            this.txtvalue3.TextChanged += new System.EventHandler(this.txtvalue1_TextChanged);
            // 
            // txtvalue4
            // 
            this.txtvalue4.Location = new System.Drawing.Point(488, 372);
            this.txtvalue4.Name = "txtvalue4";
            this.txtvalue4.Size = new System.Drawing.Size(77, 22);
            this.txtvalue4.TabIndex = 8;
            this.txtvalue4.TextChanged += new System.EventHandler(this.txtvalue1_TextChanged);
            // 
            // Form_Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 541);
            this.Controls.Add(this.txtvalue4);
            this.Controls.Add(this.txtvalue3);
            this.Controls.Add(this.txtvalue2);
            this.Controls.Add(this.txtvalue1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DDLStates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbutton);
            this.Controls.Add(this.txtuser);
            this.Name = "Form_Demo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Demo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button txtbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DDLStates;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtvalue1;
        private System.Windows.Forms.TextBox txtvalue2;
        private System.Windows.Forms.TextBox txtvalue3;
        private System.Windows.Forms.TextBox txtvalue4;
    }
}

