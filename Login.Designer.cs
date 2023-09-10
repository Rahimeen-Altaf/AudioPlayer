namespace AudioPlayer
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.lblLoginPage = new System.Windows.Forms.Label();
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblConPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.lblLoginPage);
            this.panel1.Controls.Add(this.cmbPerson);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Controls.Add(this.txtConPass);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.lblConPass);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Location = new System.Drawing.Point(191, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 323);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Location = new System.Drawing.Point(198, 224);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 11;
            // 
            // lblLoginPage
            // 
            this.lblLoginPage.AutoSize = true;
            this.lblLoginPage.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginPage.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPage.ForeColor = System.Drawing.Color.Black;
            this.lblLoginPage.Location = new System.Drawing.Point(101, 36);
            this.lblLoginPage.Name = "lblLoginPage";
            this.lblLoginPage.Size = new System.Drawing.Size(187, 36);
            this.lblLoginPage.TabIndex = 0;
            this.lblLoginPage.Text = "LOGIN PAGE";
            this.lblLoginPage.Click += new System.EventHandler(this.lblLoginPage_Click);
            // 
            // cmbPerson
            // 
            this.cmbPerson.FormattingEnabled = true;
            this.cmbPerson.Location = new System.Drawing.Point(164, 73);
            this.cmbPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(84, 24);
            this.cmbPerson.TabIndex = 9;
            this.cmbPerson.SelectedIndexChanged += new System.EventHandler(this.cmbPerson_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(143, 242);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 35);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.Black;
            this.lblusername.Location = new System.Drawing.Point(90, 133);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(86, 19);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Username";
            // 
            // txtConPass
            // 
            this.txtConPass.Location = new System.Drawing.Point(202, 204);
            this.txtConPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.PasswordChar = '*';
            this.txtConPass.Size = new System.Drawing.Size(115, 22);
            this.txtConPass.TabIndex = 7;
            this.txtConPass.TextChanged += new System.EventHandler(this.txtConPass_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(202, 171);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(115, 22);
            this.txtPass.TabIndex = 8;
            // 
            // lblConPass
            // 
            this.lblConPass.AutoSize = true;
            this.lblConPass.BackColor = System.Drawing.Color.Transparent;
            this.lblConPass.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConPass.ForeColor = System.Drawing.Color.Black;
            this.lblConPass.Location = new System.Drawing.Point(54, 206);
            this.lblConPass.Name = "lblConPass";
            this.lblConPass.Size = new System.Drawing.Size(137, 19);
            this.lblConPass.TabIndex = 5;
            this.lblConPass.Text = "Confirm Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(202, 133);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(115, 22);
            this.txtUsername.TabIndex = 6;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.Black;
            this.lblPass.Location = new System.Drawing.Point(88, 172);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(81, 19);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::AudioPlayer.Properties.Resources.music1;
            this.ClientSize = new System.Drawing.Size(837, 471);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoginPage;
        private System.Windows.Forms.ComboBox cmbPerson;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblConPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblError;
    }
}