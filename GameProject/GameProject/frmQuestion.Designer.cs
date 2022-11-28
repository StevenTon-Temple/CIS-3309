
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
            this.dgvJeopardy = new System.Windows.Forms.DataGridView();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJeopardy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJeopardy
            // 
            this.dgvJeopardy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJeopardy.Location = new System.Drawing.Point(237, 354);
            this.dgvJeopardy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvJeopardy.Name = "dgvJeopardy";
            this.dgvJeopardy.RowHeadersWidth = 62;
            this.dgvJeopardy.RowTemplate.Height = 28;
            this.dgvJeopardy.Size = new System.Drawing.Size(276, 100);
            this.dgvJeopardy.TabIndex = 1;
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestions.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestions.Location = new System.Drawing.Point(138, 67);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(78, 20);
            this.lblQuestions.TabIndex = 2;
            this.lblQuestions.Text = "Questions";
            this.lblQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(237, 167);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(276, 22);
            this.txtAnswer.TabIndex = 3;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(135, 167);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(96, 17);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "Enter Answer:";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(317, 212);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(69, 50);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit Answer";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 455);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.dgvJeopardy);
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
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnSubmit;
    }
}