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
    public partial class UpdateSongForm : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable dataTable;
        private string name;
        private string currentFormName = "UpdateSongForm";

        public UpdateSongForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }
        public UpdateSongForm(string name)
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            this.name = name;
        }

        private void UpdateSongForm_Load(object sender, EventArgs e)
        {
            ActivityLOG a = new ActivityLOG();
            string userVisited = string.Join(", ", ClsVisitedForms.VisitedForms);
            a.InsertActivityLog(name, currentFormName, userVisited);
            LoadSongs();
        }

        private void LoadSongs()
        {
            string query = "SELECT * FROM Songs";
            dataTable = dbHelper.ExecuteQuery(query);
            dataGridView1.DataSource = dataTable;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the SongID from the selected row
                int songID = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Update the corresponding row in the database
                string updateQuery = "UPDATE Songs SET Title = @title, Artist = @artist, Album = @album, Duration = @duration, FilePath = @filePath WHERE SongID = @songID";

                List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@title", txtTitle.Text),
            new SqlParameter("@artist", txtArtist.Text),
            new SqlParameter("@album", txtAlbum.Text),
            new SqlParameter("@duration", Convert.ToInt32(txtDuration.Text)),
            new SqlParameter("@filePath", txtFilePath.Text),
            new SqlParameter("@songID", songID)
        };

                DatabaseHelper dbHelper = new DatabaseHelper();
                dbHelper.ExecuteNonQuery(updateQuery, parameters);
                ClearTextBoxes();
                MessageBox.Show("Song updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView
                LoadSongs();
            }
        }
        private void ClearTextBoxes()
        {
            txtTitle.Clear();
            txtArtist.Clear();
            txtAlbum.Clear();
            txtDuration.Clear();
            txtFilePath.Clear();
        }

        private void btnSelectSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MPEG Audio Files|*.mp3;*.wav;*.wma|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected song file path
                string filePath = openFileDialog.FileName;
                txtFilePath.Text = filePath;
            }
        }

        private void UpdateSongForm_Load_1(object sender, EventArgs e)
        {
            ClsVisitedForms.VisitedForms.Add(name + " admin has visited " + currentFormName);
            ActivityLOG a = new ActivityLOG();
            string userVisited = string.Join(", ", ClsVisitedForms.VisitedForms);
            a.InsertActivityLog(name, currentFormName, userVisited);

            // TODO: This line of code loads data into the 'audioPlayerDataSet3.Songs' table. You can move, or remove it, as needed.
            this.songsTableAdapter2.Fill(this.audioPlayerDataSet3.Songs);
            LoadSongs();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtSongID.Text = row.Cells[0].Value.ToString();
                txtTitle.Text = row.Cells[1].Value.ToString();
                txtArtist.Text = row.Cells[2].Value.ToString();
                txtAlbum.Text = row.Cells[3].Value.ToString();
                txtDuration.Text = row.Cells[4].Value.ToString();
                txtFilePath.Text = row.Cells[5].Value.ToString();
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            ActivityLOG a = new ActivityLOG();
            a.ClearVisitedForms();
            Application.Exit();
        }
    }
}
