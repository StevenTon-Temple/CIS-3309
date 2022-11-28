
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearchBy = new System.Windows.Forms.Label();
            this.picAlbulm = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.songListDataSet = new Music_Library.songListDataSet();
            this.songListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songListTableAdapter = new Music_Library.songListDataSetTableAdapters.SongListTableAdapter();
            this.songListDataSetnew = new Music_Library.songListDataSetnew();
            this.songListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.songListTableAdapter1 = new Music_Library.songListDataSetnewTableAdapters.SongListTableAdapter();
            this.btnFav = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbulm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songListDataSetnew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songListBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1080, 446);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(460, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(632, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1098, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
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
            this.comboSearch.Location = new System.Drawing.Point(346, 15);
            this.comboSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(108, 24);
            this.comboSearch.TabIndex = 5;
            // 
            // txtSearchBy
            // 
            this.txtSearchBy.AutoSize = true;
            this.txtSearchBy.Location = new System.Drawing.Point(263, 18);
            this.txtSearchBy.Name = "txtSearchBy";
            this.txtSearchBy.Size = new System.Drawing.Size(77, 17);
            this.txtSearchBy.TabIndex = 6;
            this.txtSearchBy.Text = "Search By:";
            // 
            // picAlbulm
            // 
            this.picAlbulm.Location = new System.Drawing.Point(12, 386);
            this.picAlbulm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAlbulm.Name = "picAlbulm";
            this.picAlbulm.Size = new System.Drawing.Size(346, 142);
            this.picAlbulm.TabIndex = 7;
            this.picAlbulm.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(404, 446);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(169, 40);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset Search";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 46);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(1401, 335);
            this.dataGrid.TabIndex = 10;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            this.dataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(861, 446);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 40);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // songListDataSet
            // 
            this.songListDataSet.DataSetName = "songListDataSet";
            this.songListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // songListBindingSource
            // 
            this.songListBindingSource.DataMember = "SongList";
            this.songListBindingSource.DataSource = this.songListDataSet;
            // 
            // songListTableAdapter
            // 
            this.songListTableAdapter.ClearBeforeFill = true;
            // 
            // songListDataSetnew
            // 
            this.songListDataSetnew.DataSetName = "songListDataSetnew";
            this.songListDataSetnew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // songListBindingSource1
            // 
            this.songListBindingSource1.DataMember = "SongList";
            this.songListBindingSource1.DataSource = this.songListDataSetnew;
            // 
            // songListTableAdapter1
            // 
            this.songListTableAdapter1.ClearBeforeFill = true;
            // 
            // btnFav
            // 
            this.btnFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFav.Location = new System.Drawing.Point(623, 446);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(169, 40);
            this.btnFav.TabIndex = 11;
            this.btnFav.Text = "Favorite";
            this.btnFav.UseVisualStyleBackColor = true;
            this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 539);
            this.Controls.Add(this.btnFav);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.picAlbulm);
            this.Controls.Add(this.txtSearchBy);
            this.Controls.Add(this.comboSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmMain";
            this.Text = "Music Library";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbulm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songListDataSetnew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songListBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.Label txtSearchBy;
        private System.Windows.Forms.PictureBox picAlbulm;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.DataGridView dataGrid;
        private songListDataSet songListDataSet;
        private System.Windows.Forms.BindingSource songListBindingSource;
        private songListDataSetTableAdapters.SongListTableAdapter songListTableAdapter;
        private songListDataSetnew songListDataSetnew;
        private System.Windows.Forms.BindingSource songListBindingSource1;
        private songListDataSetnewTableAdapters.SongListTableAdapter songListTableAdapter1;
        private System.Windows.Forms.Button btnFav;
    }
}

