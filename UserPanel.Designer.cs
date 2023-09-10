namespace AudioPlayer
{
    partial class UserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            this.btnSongs = new System.Windows.Forms.Button();
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.songsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new AudioPlayer.masterDataSet();
            this.songsTableAdapter = new AudioPlayer.masterDataSetTableAdapters.songsTableAdapter();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.listBoxPlaylists = new System.Windows.Forms.ListBox();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.songsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.audioPlayerDataSet = new AudioPlayer.AudioPlayerDataSet();
            this.songsTableAdapter1 = new AudioPlayer.AudioPlayerDataSetTableAdapters.SongsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSongs
            // 
            this.btnSongs.Location = new System.Drawing.Point(11, 423);
            this.btnSongs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.Size = new System.Drawing.Size(76, 54);
            this.btnSongs.TabIndex = 1;
            this.btnSongs.Text = "Load Songs";
            this.btnSongs.UseVisualStyleBackColor = true;
            this.btnSongs.Click += new System.EventHandler(this.btnSongs_Click);
            // 
            // lbSongs
            // 
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.ItemHeight = 16;
            this.lbSongs.Location = new System.Drawing.Point(11, 64);
            this.lbSongs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(77, 356);
            this.lbSongs.TabIndex = 2;
            this.lbSongs.SelectedIndexChanged += new System.EventHandler(this.lbSongs_SelectedIndexChanged);
            // 
            // songsBindingSource
            // 
            this.songsBindingSource.DataMember = "songs";
            this.songsBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // songsTableAdapter
            // 
            this.songsTableAdapter.ClearBeforeFill = true;
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Location = new System.Drawing.Point(114, 303);
            this.btnCreatePlaylist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(185, 27);
            this.btnCreatePlaylist.TabIndex = 6;
            this.btnCreatePlaylist.Text = "Playlist";
            this.btnCreatePlaylist.UseVisualStyleBackColor = true;
            // 
            // listBoxPlaylists
            // 
            this.listBoxPlaylists.FormattingEnabled = true;
            this.listBoxPlaylists.ItemHeight = 16;
            this.listBoxPlaylists.Location = new System.Drawing.Point(117, 335);
            this.listBoxPlaylists.Name = "listBoxPlaylists";
            this.listBoxPlaylists.Size = new System.Drawing.Size(94, 132);
            this.listBoxPlaylists.TabIndex = 10;
            this.listBoxPlaylists.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaylists_SelectedIndexChanged_1);
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 16;
            this.listBoxSongs.Location = new System.Drawing.Point(216, 335);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(83, 132);
            this.listBoxSongs.TabIndex = 11;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // songsBindingSource1
            // 
            this.songsBindingSource1.DataMember = "Songs";
            this.songsBindingSource1.DataSource = this.audioPlayerDataSet;
            // 
            // audioPlayerDataSet
            // 
            this.audioPlayerDataSet.DataSetName = "AudioPlayerDataSet";
            this.audioPlayerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // songsTableAdapter1
            // 
            this.songsTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 369);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 57);
            this.label1.TabIndex = 21;
            this.label1.Text = "MUSIC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 57);
            this.label2.TabIndex = 22;
            this.label2.Text = "PLAYER";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(104, 92);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(306, 151);
            this.axWindowsMediaPlayer1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(803, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(12, 21);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(130, 19);
            this.lbluser.TabIndex = 15;
            this.lbluser.Text = "@Name\'s Profile.";
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(562, 484);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 25;
            this.btnlogout.Text = "log out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(660, 572);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.listBoxPlaylists);
            this.Controls.Add(this.btnCreatePlaylist);
            this.Controls.Add(this.lbSongs);
            this.Controls.Add(this.btnSongs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserPanel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MUSIC PLAYER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioPlayerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSongs;
        private System.Windows.Forms.ListBox lbSongs;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource songsBindingSource;
        private masterDataSetTableAdapters.songsTableAdapter songsTableAdapter;
        private System.Windows.Forms.Button btnCreatePlaylist;
        private System.Windows.Forms.ListBox listBoxPlaylists;
        private System.Windows.Forms.ListBox listBoxSongs;
        private AudioPlayerDataSet audioPlayerDataSet;
        private System.Windows.Forms.BindingSource songsBindingSource1;
        private AudioPlayerDataSetTableAdapters.SongsTableAdapter songsTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Button btnlogout;
    }
}

