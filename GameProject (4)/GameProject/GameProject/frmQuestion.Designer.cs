
namespace GameProject
{
    partial class frmQuestion
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
            this.dgvJeopardy = new System.Windows.Forms.DataGridView();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.txtanswerfor = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJeopardy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJeopardy
            // 
            this.dgvJeopardy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJeopardy.Location = new System.Drawing.Point(193, 375);
            this.dgvJeopardy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvJeopardy.Name = "dgvJeopardy";
            this.dgvJeopardy.RowHeadersWidth = 62;
            this.dgvJeopardy.RowTemplate.Height = 28;
            this.dgvJeopardy.Size = new System.Drawing.Size(344, 167);
            this.dgvJeopardy.TabIndex = 1;
            this.dgvJeopardy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJeopardy_CellContentClick);
            // 
            // lblQuestions
            // 
            this.lblQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestions.ForeColor = System.Drawing.Color.Yellow;
            this.lblQuestions.Location = new System.Drawing.Point(12, 94);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(803, 167);
            this.lblQuestions.TabIndex = 2;
            this.lblQuestions.Text = "Questions";
            this.lblQuestions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtanswerfor
            // 
            this.txtanswerfor.Location = new System.Drawing.Point(214, 209);
            this.txtanswerfor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtanswerfor.Name = "txtanswerfor";
            this.txtanswerfor.Size = new System.Drawing.Size(310, 26);
            this.txtanswerfor.TabIndex = 3;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Yellow;
            this.lblAnswer.Location = new System.Drawing.Point(46, 205);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(162, 29);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "Enter Answer:";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Yellow;
            this.btnSubmit.Location = new System.Drawing.Point(295, 276);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 61);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(827, 569);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtanswerfor);
            this.Controls.Add(this.dgvJeopardy);
            this.Controls.Add(this.lblQuestions);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuestion";
            this.Text = "frmQuestion";
            this.Load += new System.EventHandler(this.frmQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJeopardy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJeopardy;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.TextBox txtanswerfor;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Timer timer;
    }
}