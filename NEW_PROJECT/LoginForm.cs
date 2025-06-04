using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

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
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Username validation: must contain letters only
            if (string.IsNullOrWhiteSpace(username) || !username.All(char.IsLetter))
            {
                MessageBox.Show("Username must contain letters only.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password validation: must contain digits only
            if (string.IsNullOrWhiteSpace(password) || !password.All(char.IsDigit))
            {
                MessageBox.Show("Password must contain digits only.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If passed validation, open the home screen
            var homeForm = new HomeForm(username);
            homeForm.Show();
            this.Hide();
        }
    }
}
