﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvJeopardy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJeopardy
            // 
            this.dgvJeopardy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJeopardy.Location = new System.Drawing.Point(41, 25);
            this.dgvJeopardy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvJeopardy.Name = "dgvJeopardy";
            this.dgvJeopardy.RowHeadersWidth = 62;
            this.dgvJeopardy.RowTemplate.Height = 28;
            this.dgvJeopardy.Size = new System.Drawing.Size(652, 153);
            this.dgvJeopardy.TabIndex = 1;
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.Location = new System.Drawing.Point(255, 194);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(72, 17);
            this.lblQuestions.TabIndex = 2;
            this.lblQuestions.Text = "Questions";
            // 
            // frmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 455);
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
    }
}