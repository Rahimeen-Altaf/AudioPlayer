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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void cmbPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPerson.SelectedItem.ToString() == "Admin Login")
            {
                btnSignUp.Enabled = false;
            }
            else if (cmbPerson.SelectedItem.ToString() == "User Login")
            {
                btnSignUp.Enabled = true;
            }
            else { }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbPerson.SelectedItem == null)
            {
                MessageBox.Show("Please Select Your Role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbPerson.SelectedItem.ToString() == "Admin Login")
            {
                Login admin = new Login("Admin");
                admin.ShowDialog();
            }
            else
            {
                Login user = new Login("User");
                user.ShowDialog();
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.ShowDialog();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            btnSignUp.Enabled = false;
        }
    }

}
