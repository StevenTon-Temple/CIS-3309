
namespace Music_Library
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listSongs = new System.Windows.Forms.ListView();
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAlbumName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDOR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColImgUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearchBy = new System.Windows.Forms.Label();
            this.picAlbulm = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbulm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(867, 482);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 65);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // listSongs
            // 
            this.listSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle,
            this.colArtist,
            this.colAlbumName,
            this.ColGenre,
            this.ColDOR,
            this.ColDuration,
            this.ColDescription,
            this.ColImgUrl});
            this.listSongs.HideSelection = false;
            this.listSongs.Location = new System.Drawing.Point(14, 58);
            this.listSongs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(1033, 416);
            this.listSongs.TabIndex = 1;
            this.listSongs.UseCompatibleStateImageBehavior = false;
            this.listSongs.View = System.Windows.Forms.View.List;
            this.listSongs.Click += new System.EventHandler(this.listSongs_Click);
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.Width = 150;
            // 
            // colArtist
            // 
            this.colArtist.Text = "Artist";
            // 
            // colAlbumName
            // 
            this.colAlbumName.Text = "Album Name";
            // 
            // ColGenre
            // 
            this.ColGenre.Text = "Genre";
            // 
            // ColDOR
            // 
            this.ColDOR.Text = "Date of Release";
            // 
            // ColDuration
            // 
            this.ColDuration.Text = "Duration";
            // 
            // ColDescription
            // 
            this.ColDescription.Text = "Description";
            // 
            // ColImgUrl
            // 
            this.ColImgUrl.Text = "Image Url";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(246, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(711, 26);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(963, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 41);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboSearch
            // 
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "Name",
            "Year",
            "Genre",
            ""});
            this.comboSearch.Location = new System.Drawing.Point(119, 16);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(121, 28);
            this.comboSearch.TabIndex = 5;
            // 
            // txtSearchBy
            // 
            this.txtSearchBy.AutoSize = true;
            this.txtSearchBy.Location = new System.Drawing.Point(27, 21);
            this.txtSearchBy.Name = "txtSearchBy";
            this.txtSearchBy.Size = new System.Drawing.Size(86, 20);
            this.txtSearchBy.TabIndex = 6;
            this.txtSearchBy.Text = "Search By:";
            // 
            // picAlbulm
            // 
            this.picAlbulm.Location = new System.Drawing.Point(14, 482);
            this.picAlbulm.Name = "picAlbulm";
            this.picAlbulm.Size = new System.Drawing.Size(175, 74);
            this.picAlbulm.TabIndex = 7;
            this.picAlbulm.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(235, 482);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(239, 65);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset Search";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 562);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.picAlbulm);
            this.Controls.Add(this.txtSearchBy);
            this.Controls.Add(this.comboSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listSongs);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Music Library";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbulm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListView listSongs;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.Label txtSearchBy;
        private System.Windows.Forms.PictureBox picAlbulm;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colArtist;
        private System.Windows.Forms.ColumnHeader colAlbumName;
        private System.Windows.Forms.ColumnHeader ColGenre;
        private System.Windows.Forms.ColumnHeader ColDOR;
        private System.Windows.Forms.ColumnHeader ColDuration;
        private System.Windows.Forms.ColumnHeader ColDescription;
        private System.Windows.Forms.ColumnHeader ColImgUrl;
        private System.Windows.Forms.Button btnReset;
    }
}

