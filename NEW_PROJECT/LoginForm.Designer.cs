using System.Drawing;
using System.Windows.Forms;
using System;

namespace NEW_PROJECT
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private PictureBox pictureBoxLogo;
        private Label lblError;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblUsername = new Label();
            this.lblPassword = new Label();
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnExit = new Button();
            this.pictureBoxLogo = new PictureBox();
            this.lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();

             
            // pictureBoxLogo
            
            this.pictureBoxLogo.Location = new System.Drawing.Point(120, 15);
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;

             
            // lblTitle
            
            this.lblTitle.Text = "MyProperty Manager";
            this.lblTitle.Font = new Font("Segoe UI Semibold", 18F);
            this.lblTitle.ForeColor = Color.SteelBlue;
            this.lblTitle.Location = new Point(30, 120);
            this.lblTitle.Size = new Size(280, 35);
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

             
            // lblUsername
            
            this.lblUsername.Text = "Username:";
            this.lblUsername.Location = new Point(40, 170);
            this.lblUsername.Size = new Size(90, 20);
            this.lblUsername.Font = new Font("Segoe UI", 10F);
            this.lblUsername.ForeColor = Color.DimGray;

            
            // txtUsername
            
            this.txtUsername.Location = new Point(140, 170);
            this.txtUsername.Size = new Size(150, 25);
            this.txtUsername.Font = new Font("Segoe UI", 10F);
            this.txtUsername.BorderStyle = BorderStyle.FixedSingle;

            
            // lblPassword
            
            this.lblPassword.Text = "Password:";
            this.lblPassword.Location = new Point(40, 210);
            this.lblPassword.Size = new Size(90, 20);
            this.lblPassword.Font = new Font("Segoe UI", 10F);
            this.lblPassword.ForeColor = Color.DimGray;

            
            // txtPassword
            
            this.txtPassword.Location = new Point(140, 210);
            this.txtPassword.Size = new Size(150, 25);
            this.txtPassword.Font = new Font("Segoe UI", 10F);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.BorderStyle = BorderStyle.FixedSingle;

            
            // btnLogin
            
            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new Point(40, 260);
            this.btnLogin.Size = new Size(100, 35);
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.BackColor = Color.SteelBlue;
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLogin.Cursor = Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            this.btnLogin.Click += new EventHandler(this.BtnLogin_Click);

            
            // btnExit
            
            this.btnExit.Text = "Exit";
            this.btnExit.Location = new Point(190, 260);
            this.btnExit.Size = new Size(100, 35);
            this.btnExit.FlatStyle = FlatStyle.Flat;
            this.btnExit.BackColor = Color.White;
            this.btnExit.ForeColor = Color.SteelBlue;
            this.btnExit.Font = new Font("Segoe UI", 10F);
            this.btnExit.Cursor = Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = Color.SteelBlue;
            this.btnExit.FlatAppearance.BorderSize = 1;
            this.btnExit.FlatAppearance.MouseOverBackColor = Color.LightGray;
            this.btnExit.Click += new EventHandler(this.BtnExit_Click);

            
            // lblError
            
            this.lblError.ForeColor = Color.Red;
            this.lblError.Location = new Point(30, 310);
            this.lblError.Size = new Size(260, 20);
            this.lblError.TextAlign = ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;

            
            // LoginForm
             
            this.ClientSize = new Size(340, 360);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblError);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Text = "Login";
            this.Load += new EventHandler(this.LoginForm_Load);
            this.BackColor = Color.WhiteSmoke;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
