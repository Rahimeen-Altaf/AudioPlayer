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
    public partial class DeleteSong : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable dataTable;
        private string name;
        private string currentFormName = "DeleteSongForm";
        public DeleteSong()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }
        public DeleteSong(string name)
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            this.name = name;
        }

        private void DeleteSong_Load(object sender, EventArgs e)
        {
            ClsVisitedForms.VisitedForms.Add(name + " admin has visited " + currentFormName);
            ActivityLOG a = new ActivityLOG();
            string userVisited = string.Join(", ", ClsVisitedForms.VisitedForms);
            a.InsertActivityLog(name, currentFormName, userVisited);
            // TODO: This line of code loads data into the 'audioPlayerDataSet1.Songs' table. You can move, or remove it, as needed.
            this.songsTableAdapter2.Fill(this.audioPlayerDataSet1.Songs);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
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
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the SongID from the selected row
                int songID = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Show a confirmation message box
                DialogResult result = MessageBox.Show("Are you sure you want to delete this song?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Execute the delete query
                    string deleteQuery = "DELETE FROM Songs WHERE SongID = @songID";

                    List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@songID", songID)
            };

                    DatabaseHelper dbHelper = new DatabaseHelper();
                    dbHelper.ExecuteNonQuery(deleteQuery, parameters);

                    // Refresh the DataGridView
                    LoadSongs();

                    // Show a success message
                    MessageBox.Show("Song deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            ActivityLOG a = new ActivityLOG();
            a.ClearVisitedForms();
            Application.Exit();
        }
    }
}
