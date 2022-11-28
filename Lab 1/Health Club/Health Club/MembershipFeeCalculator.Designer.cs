
namespace Health_Club
{
    partial class MembershipFeeCalculator
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
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.Membershiplength_label = new System.Windows.Forms.Label();
            this.Membershipfeelabel = new System.Windows.Forms.Label();
            this.Monthlyfeellbl = new System.Windows.Forms.Label();
            this.totallbl = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMonthlyFee = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTOM = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radAdult = new System.Windows.Forms.RadioButton();
            this.radChild = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.radSenior = new System.Windows.Forms.RadioButton();
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.chkKarate = new System.Windows.Forms.CheckBox();
            this.chkPersonalTrainer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(91, 303);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(202, 22);
            this.txtmonth.TabIndex = 4;
            // 
            // Membershiplength_label
            // 
            this.Membershiplength_label.AutoSize = true;
            this.Membershiplength_label.Location = new System.Drawing.Point(88, 236);
            this.Membershiplength_label.Name = "Membershiplength_label";
            this.Membershiplength_label.Size = new System.Drawing.Size(133, 17);
            this.Membershiplength_label.TabIndex = 5;
            this.Membershiplength_label.Text = "Membership Length";
            // 
            // Membershipfeelabel
            // 
            this.Membershipfeelabel.AutoSize = true;
            this.Membershipfeelabel.Location = new System.Drawing.Point(453, 236);
            this.Membershipfeelabel.Name = "Membershipfeelabel";
            this.Membershipfeelabel.Size = new System.Drawing.Size(113, 17);
            this.Membershipfeelabel.TabIndex = 6;
            this.Membershipfeelabel.Text = "Membership Fee";
            // 
            // Monthlyfeellbl
            // 
            this.Monthlyfeellbl.AutoSize = true;
            this.Monthlyfeellbl.Location = new System.Drawing.Point(453, 277);
            this.Monthlyfeellbl.Name = "Monthlyfeellbl";
            this.Monthlyfeellbl.Size = new System.Drawing.Size(81, 17);
            this.Monthlyfeellbl.TabIndex = 7;
            this.Monthlyfeellbl.Text = "Monthly fee";
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Location = new System.Drawing.Point(453, 308);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(40, 17);
            this.totallbl.TabIndex = 8;
            this.totallbl.Text = "Total";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(91, 369);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(113, 37);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(272, 369);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 37);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(453, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 37);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lblMonthlyFee
            // 
            this.lblMonthlyFee.AutoSize = true;
            this.lblMonthlyFee.Location = new System.Drawing.Point(573, 277);
            this.lblMonthlyFee.Name = "lblMonthlyFee";
            this.lblMonthlyFee.Size = new System.Drawing.Size(16, 17);
            this.lblMonthlyFee.TabIndex = 12;
            this.lblMonthlyFee.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(573, 306);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 17);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "0";
            // 
            // lblTOM
            // 
            this.lblTOM.AutoSize = true;
            this.lblTOM.Location = new System.Drawing.Point(88, 76);
            this.lblTOM.Name = "lblTOM";
            this.lblTOM.Size = new System.Drawing.Size(137, 17);
            this.lblTOM.TabIndex = 14;
            this.lblTOM.Text = "Type of Membership";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(453, 76);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(57, 17);
            this.lblOptions.TabIndex = 15;
            this.lblOptions.Text = "Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter the Number or Months:";
            // 
            // radAdult
            // 
            this.radAdult.AutoSize = true;
            this.radAdult.Location = new System.Drawing.Point(91, 107);
            this.radAdult.Name = "radAdult";
            this.radAdult.Size = new System.Drawing.Size(123, 21);
            this.radAdult.TabIndex = 17;
            this.radAdult.TabStop = true;
            this.radAdult.Text = "Standard Adult";
            this.radAdult.UseVisualStyleBackColor = true;
            // 
            // radChild
            // 
            this.radChild.AutoSize = true;
            this.radChild.Location = new System.Drawing.Point(91, 134);
            this.radChild.Name = "radChild";
            this.radChild.Size = new System.Drawing.Size(60, 21);
            this.radChild.TabIndex = 18;
            this.radChild.TabStop = true;
            this.radChild.Text = "Child";
            this.radChild.UseVisualStyleBackColor = true;
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Location = new System.Drawing.Point(91, 161);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(78, 21);
            this.radStudent.TabIndex = 19;
            this.radStudent.TabStop = true;
            this.radStudent.Text = "Student";
            this.radStudent.UseVisualStyleBackColor = true;
            // 
            // radSenior
            // 
            this.radSenior.AutoSize = true;
            this.radSenior.Location = new System.Drawing.Point(91, 188);
            this.radSenior.Name = "radSenior";
            this.radSenior.Size = new System.Drawing.Size(116, 21);
            this.radSenior.TabIndex = 20;
            this.radSenior.TabStop = true;
            this.radSenior.Text = "Senior Citizen";
            this.radSenior.UseVisualStyleBackColor = true;
            // 
            // chkYoga
            // 
            this.chkYoga.AutoSize = true;
            this.chkYoga.Location = new System.Drawing.Point(453, 108);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(63, 21);
            this.chkYoga.TabIndex = 21;
            this.chkYoga.Text = "Yoga";
            this.chkYoga.UseVisualStyleBackColor = true;
            // 
            // chkKarate
            // 
            this.chkKarate.AutoSize = true;
            this.chkKarate.Location = new System.Drawing.Point(453, 135);
            this.chkKarate.Name = "chkKarate";
            this.chkKarate.Size = new System.Drawing.Size(72, 21);
            this.chkKarate.TabIndex = 22;
            this.chkKarate.Text = "Karate";
            this.chkKarate.UseVisualStyleBackColor = true;
            // 
            // chkPersonalTrainer
            // 
            this.chkPersonalTrainer.AutoSize = true;
            this.chkPersonalTrainer.Location = new System.Drawing.Point(453, 161);
            this.chkPersonalTrainer.Name = "chkPersonalTrainer";
            this.chkPersonalTrainer.Size = new System.Drawing.Size(136, 21);
            this.chkPersonalTrainer.TabIndex = 23;
            this.chkPersonalTrainer.Text = "Personal Trainer";
            this.chkPersonalTrainer.UseVisualStyleBackColor = true;
            // 
            // MembershipFeeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkPersonalTrainer);
            this.Controls.Add(this.chkKarate);
            this.Controls.Add(this.chkYoga);
            this.Controls.Add(this.radSenior);
            this.Controls.Add(this.radStudent);
            this.Controls.Add(this.radChild);
            this.Controls.Add(this.radAdult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblTOM);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMonthlyFee);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.Monthlyfeellbl);
            this.Controls.Add(this.Membershipfeelabel);
            this.Controls.Add(this.Membershiplength_label);
            this.Controls.Add(this.txtmonth);
            this.Name = "MembershipFeeCalculator";
            this.Text = "Steven Ton - Membership Fee Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.Label Membershiplength_label;
        private System.Windows.Forms.Label Membershipfeelabel;
        private System.Windows.Forms.Label Monthlyfeellbl;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMonthlyFee;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTOM;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radAdult;
        private System.Windows.Forms.RadioButton radChild;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.RadioButton radSenior;
        private System.Windows.Forms.CheckBox chkYoga;
        private System.Windows.Forms.CheckBox chkKarate;
        private System.Windows.Forms.CheckBox chkPersonalTrainer;
    }
}

