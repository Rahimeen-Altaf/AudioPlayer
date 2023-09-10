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
using System.Xml.Linq;

namespace AudioPlayer
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=R-A-H\\SQLEXPRESS;Initial Catalog=AudioPlayer;Integrated Security=True");

        private void txtConPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == txtConPass.Text)
            {
                btnSignIn.Enabled = true;
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "password does not match! ";
                btnSignIn.Enabled = false;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPass.Text;
            string query = "INSERT INTO User_LoginSignup (Username, Password) VALUES (@username, @password)";

            List<SqlParameter> parameters = new List<SqlParameter>
{
    new SqlParameter("@username", username),
    new SqlParameter("@password", password)
};

            DatabaseHelper dbHelper = new DatabaseHelper();
            dbHelper.ExecuteNonQuery(query, parameters);

            MessageBox.Show("User added successfully.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Login login = new Login("User");
            login.ShowDialog();

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
