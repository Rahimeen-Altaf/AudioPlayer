using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AudioPlayer
{
    public partial class InsertSongForm : Form
    {
        private DatabaseHelper dbHelper;
        private string name;
        private string currentFormName = "InsertSongForm";
        public InsertSongForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }
        public InsertSongForm(string name)
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            this.name = name;
        }

        private void SongForm_Load(object sender, EventArgs e)
        {
            ClsVisitedForms.VisitedForms.Add(name + " admin has visited " + currentFormName);
            ActivityLOG a = new ActivityLOG();
            string userVisited = string.Join(", ", ClsVisitedForms.VisitedForms);
            a.InsertActivityLog(name, currentFormName, userVisited);
            // TODO: This line of code loads data into the 'audioPlayerDataSet4.Songs' table. You can move, or remove it, as needed.
            this.songsTableAdapter2.Fill(this.audioPlayerDataSet4.Songs);
            // TODO: This line of code loads data into the 'audioPlayerDataSet2.Songs' table. You can move, or remove it, as needed.
            this.songsTableAdapter1.Fill(this.audioPlayerDataSet2.Songs);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            LoadSongs();

        }

        private void btnSelectSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Audio Files|*.mp3;*.wav;*.wma|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected song file path
                string filePath = openFileDialog.FileName;
                txtFilePath.Text = filePath;
            }
        }
        private void LoadSongs()
        {
            string query = "SELECT * FROM Songs";

            DataTable dataTable = dbHelper.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                dataGridViewSongs.DataSource = dataTable;
            }
        }

        private void btnInsertSong_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string artist = txtArtist.Text;
            string album = txtAlbum.Text;
            int duration = Convert.ToInt32(txtDuration.Text);
            string filePath = txtFilePath.Text;

            // Insert the song into the Song table
            InsertSong(title, artist, album, duration, filePath);

            // Clear the textboxes
            ClearTextBoxes();
            MessageBox.Show("Song Inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Refresh the DataGridView to show the updated song list
            LoadSongs();
        }
        private void InsertSong(string title, string artist, string album, int duration, string filePath)
        {
            string query = "INSERT INTO Songs (SongID, Title, Artist, Album, Duration, FilePath) " +
                           "VALUES (@songID, @title, @artist, @album, @duration, @filePath)";

            // Generate a new unique SongID
            int songID = GenerateUniqueSongID();

            // Create a list of SQL parameters for the query
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@songID", songID),
                new SqlParameter("@title", title),
                new SqlParameter("@artist", artist),
                new SqlParameter("@album", album),
                new SqlParameter("@duration", duration),
                new SqlParameter("@filePath", filePath)
            };

            // Execute the insert query
            dbHelper.ExecuteNonQuery(query, parameters);
        }

        private int GenerateUniqueSongID()
        {
            // Generate a unique SongID using a suitable algorithm
            // You can implement your own logic to generate a unique identifier
            // For simplicity, let's generate a random number as the SongID
            Random random = new Random();
            return random.Next(1000, 9999);
        }
        private void ClearTextBoxes()
        {
            txtTitle.Clear();
            txtArtist.Clear();
            txtAlbum.Clear();
            txtDuration.Clear();
            txtFilePath.Clear();
        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            ActivityLOG a = new ActivityLOG();
            a.ClearVisitedForms();
            Application.Exit();
        }
    }
}
