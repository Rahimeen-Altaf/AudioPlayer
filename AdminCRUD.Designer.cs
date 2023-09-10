namespace AudioPlayer
{
    partial class AdminCRUD
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
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.lblAdminCRUD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "Insert Song",
            "Delete Song",
            "Update Song"});
            this.cmbOperation.Location = new System.Drawing.Point(252, 119);
            this.cmbOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(240, 24);
            this.cmbOperation.TabIndex = 0;
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.cmbOperation_SelectedIndexChanged);
            // 
            // lblAdminCRUD
            // 
            this.lblAdminCRUD.AutoSize = true;
            this.lblAdminCRUD.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminCRUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminCRUD.Location = new System.Drawing.Point(180, 54);
            this.lblAdminCRUD.Name = "lblAdminCRUD";
            this.lblAdminCRUD.Size = new System.Drawing.Size(396, 31);
            this.lblAdminCRUD.TabIndex = 1;
            this.lblAdminCRUD.Text = "ADMIN CRUD OPERATIONS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(232, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select The OPeration You Want To Perforn.";
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(322, 148);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 36);
            this.btnlogout.TabIndex = 39;
            this.btnlogout.Text = "log out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // AdminCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AudioPlayer.Properties.Resources.adminimage1;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdminCRUD);
            this.Controls.Add(this.cmbOperation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminCRUD";
            this.Text = "AdminCRUD";
            this.Load += new System.EventHandler(this.AdminCRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.Label lblAdminCRUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogout;
    }
}