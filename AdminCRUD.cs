using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class AdminCRUD : Form
    {

        private string currentFormName = "AdminCRUD";
        private string name;
        public AdminCRUD()
        {
            InitializeComponent();
        }
        public AdminCRUD(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperation.SelectedItem.ToString() == "Insert Song")
            {
                InsertSongForm insert = new InsertSongForm(name);
                insert.ShowDialog();
                
            }
             else if (cmbOperation.SelectedItem.ToString() == "Delete Song")
            {
                DeleteSong delete = new DeleteSong(name);
                delete.ShowDialog();
            }
             else if (cmbOperation.SelectedItem.ToString() == "Update Song")
            {
                UpdateSongForm update = new UpdateSongForm(name);
                update.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select An Operation.", "Operation Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AdminCRUD_Load(object sender, EventArgs e)
        {
            ClsVisitedForms.VisitedForms.Add(name + " admin has visited " + currentFormName);
            ActivityLOG a = new ActivityLOG();
            string userVisited = string.Join(", ", ClsVisitedForms.VisitedForms);
            a.InsertActivityLog(name, currentFormName, userVisited);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            ActivityLOG a = new ActivityLOG();
            a.ClearVisitedForms();
            Application.Exit();
        }
    }
}
