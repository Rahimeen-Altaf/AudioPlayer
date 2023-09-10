using System;
using NAudio.Wave.SampleProviders;
using NAudio.Wave;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Collections;

namespace AudioPlayer
{
    public partial class UserPanel : Form
    {
        //private bool isPlaying = false;
        private string currentFormName = "UserPanel";

        string name;
        public UserPanel()
        {
            InitializeComponent();
            LoadPlaylists();
        }
        public UserPanel(string username)
        {
            InitializeComponent();
            LoadPlaylists();
            name = username;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbluser.Text = name + "'s Profile";
            ClsVisitedForms.VisitedForms.Add(name + " user has visited " + currentFormName);
            string userVisited = string.Join(", ", ClsVisitedForms.VisitedForms);
            ActivityLOG a = new ActivityLOG();
            a.InsertActivityLog(name, currentFormName, userVisited);
            LoadPlaylists();
        }

        private void btnSongs_Click(object sender, EventArgs e)
        {
            // Create an instance of the DatabaseHelper class
            DatabaseHelper dbHelper = new DatabaseHelper();

            string query = "SELECT title FROM Songs";

            // Execute the query and get the result
            DataTable dataTable = dbHelper.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                string songTitle = row["title"].ToString();
                lbSongs.Items.Add(songTitle);
            }

        }

        private WaveOut waveOut;
        private AudioFileReader audioFileReader;
        private Timer timer;


        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    if (audioFileReader != null && waveOut != null)
        //    {
        //        // Update the TrackBar position based on the current playback position
        //        tkbSongs.Value = (int)(audioFileReader.Position / (audioFileReader.Length / (double)tkbSongs.Maximum));
        //    }
        //}



        private DataTable dataTable;
        private string selectedSongFilePath;
        private void lbSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSongTitle = lbSongs.SelectedItem.ToString();

            // Create an instance of the DatabaseHelper class
            DatabaseHelper dbHelper = new DatabaseHelper();

            string query = "SELECT SongID, Title, Artist, Album, Duration, FilePath FROM Songs WHERE Title = @title";

            // Set the parameter values for the query
            List<SqlParameter> parameters = new List<SqlParameter>
    {
        new SqlParameter("@title", selectedSongTitle)
    };

            // Execute the query and get the result
            DataTable dataTable = dbHelper.ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                // Store the file path of the selected song
                selectedSongFilePath = dataTable.Rows[0]["FilePath"].ToString();

                // Enable the play button

                // Load and play the selected song in the axWindowsMediaPlayer control
                axWindowsMediaPlayer1.URL = selectedSongFilePath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                // Clear the axWindowsMediaPlayer control if no rows are found
                axWindowsMediaPlayer1.URL = null;
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        }

        private void LoadPlaylists()
        {
            // Clear the existing items in the ListBox
            listBoxPlaylists.Items.Clear();

            // Query the database to retrieve all playlists
            string query = "SELECT PlaylistName FROM Playlists";
            DatabaseHelper dbHelper = new DatabaseHelper();

            // Execute the query and get the result
            DataTable dataTable = dbHelper.ExecuteQuery(query);

            // Add each playlist name to the ListBox
            foreach (DataRow row in dataTable.Rows)
            {
                string playlistName = row["PlaylistName"].ToString();
                listBoxPlaylists.Items.Add(playlistName);
            }
        }



        // Define a custom Song class to store the song information

        private void listBoxPlaylists_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Clear the existing items in the ListBox
            listBoxSongs.Items.Clear();

            // Get the selected playlist from the ListBox
            string selectedPlaylist = listBoxPlaylists.SelectedItem.ToString();

            // Query the database to retrieve the songs for the selected playlist
            string query = "SELECT Songs.SongID, Songs.Title FROM Songs " +
                           "INNER JOIN PlaylistSongs ON Songs.SongID = PlaylistSongs.SongID " +
                           "INNER JOIN Playlists ON PlaylistSongs.PlaylistID = Playlists.PlaylistID " +
                           "WHERE Playlists.PlaylistName = @playlistName";

            // Create a list of SQL parameters for the query
            List<SqlParameter> parameters = new List<SqlParameter>
    {
        new SqlParameter("@playlistName", selectedPlaylist)
    };
            DatabaseHelper dbHelper = new DatabaseHelper();

            // Execute the query and get the result
            DataTable dataTable = dbHelper.ExecuteQuery(query, parameters);

            // Add the songs to the ListBox
            foreach (DataRow row in dataTable.Rows)
            {
                int songID = Convert.ToInt32(row["SongID"]);
                string songTitle = row["Title"].ToString();
                listBoxSongs.Items.Add(new Song(songID, songTitle)); // Assuming you have a custom Song class
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex >= 0)
            {
                // Get the selected song title from the ListBox
                string selectedSongTitle = listBoxSongs.SelectedItem.ToString();

                // Create an instance of the DatabaseHelper class
                DatabaseHelper dbHelper = new DatabaseHelper();

                string query = "SELECT FilePath FROM Songs WHERE Title = @title";

                // Set the parameter values for the query
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                new SqlParameter("@title", selectedSongTitle)
                };

                // Execute the query and get the result
                DataTable dataTable = dbHelper.ExecuteQuery(query, parameters);

                if (dataTable.Rows.Count > 0)
                {
                    string filePath = dataTable.Rows[0]["FilePath"].ToString();

                    // Load the selected song into the axWindowsMediaPlayer control
                    axWindowsMediaPlayer1.URL = filePath;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            // Clear existing rows in the dataGridView
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            ActivityLOG a = new ActivityLOG();
            a.ClearVisitedForms();
            Application.Exit();
        }
    }
}
