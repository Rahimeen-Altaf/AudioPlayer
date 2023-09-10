namespace AudioPlayer
{
    partial class InsertSongForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsertSong = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectSong = new System.Windows.Forms.Button();
            this.dataGridViewSongs = new System.Windows.Forms.DataGridView();
            this.songIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.audioPlayerDataSet4 = new AudioPlayer.AudioPlayerDataSet4();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.songsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet2 = new AudioPlayer.masterDataSet2();
            this.masterDataSet = new AudioPlayer.masterDataSet();
            this.masterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songsTableAdapter = new AudioPlayer.masterDataSet2TableAdapters.SongsTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.audioPlayerDataSet2 = new AudioPlayer.AudioPlayerDataSet2();
            this.songsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.songsTableAdapter1 = new AudioPlayer.AudioPlayerDataSet2TableAdapters.SongsTableAdapter();
            this.songsTableAdapter2 = new AudioPlayer.AudioPlayerDataSet4TableAdapters.SongsTableAdapter();
            this.btnlogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayerDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnInsertSong);
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Controls.Add(this.btnSelectSong);
            this.panel1.Controls.Add(this.dataGridViewSongs);
            this.panel1.Controls.Add(this.txtAlbum);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtArtist);
            this.panel1.Controls.Add(this.txtDuration);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(146, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 464);
            this.panel1.TabIndex = 34;
            // 
            // btnInsertSong
            // 
            this.btnInsertSong.Location = new System.Drawing.Point(244, 322);
            this.btnInsertSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertSong.Name = "btnInsertSong";
            this.btnInsertSong.Size = new System.Drawing.Size(112, 30);
            this.btnInsertSong.TabIndex = 39;
            this.btnInsertSong.Text = "Insert";
            this.btnInsertSong.UseVisualStyleBackColor = true;
            this.btnInsertSong.Click += new System.EventHandler(this.btnInsertSong_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(273, 248);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(112, 22);
            this.txtFilePath.TabIndex = 38;
            // 
            // btnSelectSong
            // 
            this.btnSelectSong.Location = new System.Drawing.Point(404, 243);
            this.btnSelectSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectSong.Name = "btnSelectSong";
            this.btnSelectSong.Size = new System.Drawing.Size(108, 30);
            this.btnSelectSong.TabIndex = 37;
            this.btnSelectSong.Text = "Upload Song";
            this.btnSelectSong.UseVisualStyleBackColor = true;
            this.btnSelectSong.Click += new System.EventHandler(this.btnSelectSong_Click);
            // 
            // dataGridViewSongs
            // 
            this.dataGridViewSongs.AutoGenerateColumns = false;
            this.dataGridViewSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.filePathDataGridViewTextBoxColumn});
            this.dataGridViewSongs.DataSource = this.songsBindingSource2;
            this.dataGridViewSongs.Location = new System.Drawing.Point(27, 358);
            this.dataGridViewSongs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSongs.Name = "dataGridViewSongs";
            this.dataGridViewSongs.RowHeadersWidth = 62;
            this.dataGridViewSongs.RowTemplate.Height = 28;
            this.dataGridViewSongs.Size = new System.Drawing.Size(535, 93);
            this.dataGridViewSongs.TabIndex = 36;
            // 
            // songIDDataGridViewTextBoxColumn
            // 
            this.songIDDataGridViewTextBoxColumn.DataPropertyName = "SongID";
            this.songIDDataGridViewTextBoxColumn.HeaderText = "SongID";
            this.songIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.songIDDataGridViewTextBoxColumn.Name = "songIDDataGridViewTextBoxColumn";
            this.songIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            this.artistDataGridViewTextBoxColumn.Width = 150;
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn.HeaderText = "Album";
            this.albumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            this.albumDataGridViewTextBoxColumn.Width = 150;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 150;
            // 
            // filePathDataGridViewTextBoxColumn
            // 
            this.filePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath";
            this.filePathDataGridViewTextBoxColumn.HeaderText = "FilePath";
            this.filePathDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
            this.filePathDataGridViewTextBoxColumn.Width = 150;
            // 
            // songsBindingSource2
            // 
            this.songsBindingSource2.DataMember = "Songs";
            this.songsBindingSource2.DataSource = this.audioPlayerDataSet4;
            // 
            // audioPlayerDataSet4
            // 
            this.audioPlayerDataSet4.DataSetName = "AudioPlayerDataSet4";
            this.audioPlayerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(273, 172);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(112, 22);
            this.txtAlbum.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Album";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "INSERT SONG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(273, 100);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(112, 22);
            this.txtTitle.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Artist";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "File Path";
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(273, 138);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(112, 22);
            this.txtArtist.TabIndex = 24;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(273, 206);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(112, 22);
            this.txtDuration.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Duration";
            // 
            // songsBindingSource
            // 
            this.songsBindingSource.DataMember = "Songs";
            this.songsBindingSource.DataSource = this.masterDataSet2;
            // 
            // masterDataSet2
            // 
            this.masterDataSet2.DataSetName = "masterDataSet2";
            this.masterDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterDataSetBindingSource
            // 
            this.masterDataSetBindingSource.DataSource = this.masterDataSet;
            this.masterDataSetBindingSource.Position = 0;
            // 
            // songsTableAdapter
            // 
            this.songsTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // audioPlayerDataSet2
            // 
            this.audioPlayerDataSet2.DataSetName = "AudioPlayerDataSet2";
            this.audioPlayerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // songsBindingSource1
            // 
            this.songsBindingSource1.DataMember = "Songs";
            this.songsBindingSource1.DataSource = this.audioPlayerDataSet2;
            // 
            // songsTableAdapter1
            // 
            this.songsTableAdapter1.ClearBeforeFill = true;
            // 
            // songsTableAdapter2
            // 
            this.songsTableAdapter2.ClearBeforeFill = true;
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(745, 462);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 36);
            this.btnlogout.TabIndex = 35;
            this.btnlogout.Text = "log out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // InsertSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AudioPlayer.Properties.Resources.adminimage1;
            this.ClientSize = new System.Drawing.Size(857, 571);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InsertSongForm";
            this.Text = "SongForm";
            this.Load += new System.EventHandler(this.SongForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayerDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewSongs;
        private System.Windows.Forms.BindingSource masterDataSetBindingSource;
        private masterDataSet masterDataSet;
        private masterDataSet2 masterDataSet2;
        private System.Windows.Forms.BindingSource songsBindingSource;
        private masterDataSet2TableAdapters.SongsTableAdapter songsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn songIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectSong;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnInsertSong;
        private AudioPlayerDataSet2 audioPlayerDataSet2;
        private System.Windows.Forms.BindingSource songsBindingSource1;
        private AudioPlayerDataSet2TableAdapters.SongsTableAdapter songsTableAdapter1;
        private AudioPlayerDataSet4 audioPlayerDataSet4;
        private System.Windows.Forms.BindingSource songsBindingSource2;
        private AudioPlayerDataSet4TableAdapters.SongsTableAdapter songsTableAdapter2;
        private System.Windows.Forms.Button btnlogout;
    }
}