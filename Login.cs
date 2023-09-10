using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace AudioPlayer
{
    public partial class Login : Form
    {
        private string Person;

        public Login(string Person)
        {
            InitializeComponent();
            this.Person = Person;
            cmbPerson.Text = Person;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPass.Text;
            string query;
            if (Person == "Admin")
                query = "SELECT * FROM Admin_Login WHERE Adminname = @username AND Password = @password";
            else
                query = "SELECT * FROM User_LoginSignup WHERE Username = @username AND Password = @password";

            List<SqlParameter> parameters = new List<SqlParameter>
    {
        new SqlParameter("@username", username),
        new SqlParameter("@password", password)
    };

            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable dataTable = dbHelper.ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                if (Person == "Admin")
                {
                    AdminCRUD adminForm = new AdminCRUD(username);
                    adminForm.ShowDialog();
                }
                else if (Person == "User")
                {
                    UserPanel userForm = new UserPanel(username);
                    userForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtConPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == txtConPass.Text)
            {
                btnLogin.Enabled = true;
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "password does not match!";
                btnLogin.Enabled = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void lblLoginPage_Click(object sender, EventArgs e)
        {

        }

        private void cmbPerson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}