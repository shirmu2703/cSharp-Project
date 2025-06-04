using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEW_PROJECT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            lblUsername.Font = lblPassword.Font = new Font("Segoe UI", 10);
            txtUsername.Font = txtPassword.Font = new Font("Segoe UI", 10);

            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.BackColor = Color.LightSteelBlue;
            btnLogin.ForeColor = Color.Black;
            btnLogin.Font = new Font("Segoe UI", 10);
            btnLogin.Cursor = Cursors.Hand;

            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.BackColor = Color.Gainsboro;
            btnExit.ForeColor = Color.Black;
            btnExit.Font = new Font("Segoe UI", 10);
            btnExit.Cursor = Cursors.Hand;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // בדיקת תקינות לשם משתמש
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(txtUsername.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("User name must contain letters only.");
                return;
            }

            // בדיקת תקינות לסיסמה
            if (string.IsNullOrWhiteSpace(txtPassword.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text, @"^\d+$"))
            {
                MessageBox.Show("Password must contain numbers only.");
                return;
            }

            // פתיחת הטופס הראשי
            var homeForm = new HomeForm(txtUsername.Text);
            homeForm.Show();
            this.Hide();
        }
    }
}
