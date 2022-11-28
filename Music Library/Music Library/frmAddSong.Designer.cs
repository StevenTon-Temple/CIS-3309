
namespace Music_Library
{
    partial class frmAddSong
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
            this.lblSong = new System.Windows.Forms.Label();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtCover = new System.Windows.Forms.TextBox();
            this.lblAlbumCover = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.lblDateOfRelease = new System.Windows.Forms.Label();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Location = new System.Drawing.Point(35, 34);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(47, 20);
            this.lblSong.TabIndex = 0;
            this.lblSong.Text = "Song";
            // 
            // txtSong
            // 
            this.txtSong.Location = new System.Drawing.Point(38, 59);
            this.txtSong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(222, 26);
            this.txtSong.TabIndex = 1;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(38, 115);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(222, 26);
            this.txtArtist.TabIndex = 2;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(35, 90);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(46, 20);
            this.lblArtist.TabIndex = 3;
            this.lblArtist.Text = "Artist";
            // 
            // txtCover
            // 
            this.txtCover.Location = new System.Drawing.Point(38, 228);
            this.txtCover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCover.Name = "txtCover";
            this.txtCover.Size = new System.Drawing.Size(222, 26);
            this.txtCover.TabIndex = 5;
            // 
            // lblAlbumCover
            // 
            this.lblAlbumCover.AutoSize = true;
            this.lblAlbumCover.Location = new System.Drawing.Point(35, 202);
            this.lblAlbumCover.Name = "lblAlbumCover";
            this.lblAlbumCover.Size = new System.Drawing.Size(146, 20);
            this.lblAlbumCover.TabIndex = 4;
            this.lblAlbumCover.Text = "Album Cover (URL)";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(35, 259);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(54, 20);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre";
            // 
            // comboGenre
            // 
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Items.AddRange(new object[] {
            "Not Known",
            "Rock",
            "Pop",
            "Hip Hop",
            "Rap",
            "Country",
            "Indie",
            "Classical",
            "Jazz",
            "Heavy Metal",
            "Latin",
            "K-Pop",
            "J-Pop"});
            this.comboGenre.Location = new System.Drawing.Point(38, 285);
            this.comboGenre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(222, 28);
            this.comboGenre.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(38, 491);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 44);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(170, 491);
            this.btnAddSong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(90, 44);
            this.btnAddSong.TabIndex = 11;
            this.btnAddSong.Text = "Add";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.AutoSize = true;
            this.lblAlbumName.Location = new System.Drawing.Point(35, 146);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(100, 20);
            this.lblAlbumName.TabIndex = 13;
            this.lblAlbumName.Text = "Album Name";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(38, 171);
            this.txtAlbumName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(222, 26);
            this.txtAlbumName.TabIndex = 12;
            // 
            // lblDateOfRelease
            // 
            this.lblDateOfRelease.AutoSize = true;
            this.lblDateOfRelease.Location = new System.Drawing.Point(35, 319);
            this.lblDateOfRelease.Name = "lblDateOfRelease";
            this.lblDateOfRelease.Size = new System.Drawing.Size(173, 20);
            this.lblDateOfRelease.TabIndex = 17;
            this.lblDateOfRelease.Text = "Date of Release (Year)";
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(38, 344);
            this.txtReleaseYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(222, 26);
            this.txtReleaseYear.TabIndex = 16;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(38, 400);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(222, 26);
            this.txtDuration.TabIndex = 15;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(35, 375);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(70, 20);
            this.lblDuration.TabIndex = 14;
            this.lblDuration.Text = "Duration";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(38, 456);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(222, 26);
            this.txtDescription.TabIndex = 19;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(35, 431);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Description";
            // 
            // frmAddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 558);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDateOfRelease);
            this.Controls.Add(this.txtReleaseYear);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblAlbumName);
            this.Controls.Add(this.txtAlbumName);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.comboGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtCover);
            this.Controls.Add(this.lblAlbumCover);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtSong);
            this.Controls.Add(this.lblSong);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddSong";
            this.Text = "Add Song";
            this.Load += new System.EventHandler(this.frmAddSong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtCover;
        private System.Windows.Forms.Label lblAlbumCover;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Label lblAlbumName;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.Label lblDateOfRelease;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
    }
}