using System.Drawing;
using System.Windows.Forms;
using System;

namespace NEW_PROJECT
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;
        private Button btnViewProperties;
        private Button btnAddProperty;
        private Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new Label();
            this.btnViewProperties = new Button();
            this.btnAddProperty = new Button();
            this.btnLogout = new Button();

            this.SuspendLayout();

            // 
            // lblWelcome
            // 
            this.lblWelcome.Text = "שלום, משתמש";
            this.lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblWelcome.ForeColor = Color.White;
            this.lblWelcome.BackColor = Color.Transparent;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new Point(30, 30);

            // 
            // btnViewProperties
            // 
            this.btnViewProperties.Text = "הצגת נכסים";
            this.btnViewProperties.Font = new Font("Segoe UI", 12F);
            this.btnViewProperties.Size = new Size(180, 40);
            this.btnViewProperties.Location = new Point(80, 100);
            this.btnViewProperties.BackColor = Color.SteelBlue;
            this.btnViewProperties.ForeColor = Color.White;
            this.btnViewProperties.FlatStyle = FlatStyle.Flat;
            this.btnViewProperties.FlatAppearance.BorderSize = 0;
            this.btnViewProperties.Cursor = Cursors.Hand;
            this.btnViewProperties.Click += new EventHandler(this.btnViewProperties_Click); // ✅ נוסף

            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Text = "הוספת נכס";
            this.btnAddProperty.Font = new Font("Segoe UI", 12F);
            this.btnAddProperty.Size = new Size(180, 40);
            this.btnAddProperty.Location = new Point(80, 160);
            this.btnAddProperty.BackColor = Color.SteelBlue;
            this.btnAddProperty.ForeColor = Color.White;
            this.btnAddProperty.FlatStyle = FlatStyle.Flat;
            this.btnAddProperty.FlatAppearance.BorderSize = 0;
            this.btnAddProperty.Cursor = Cursors.Hand;
            this.btnAddProperty.Click += new EventHandler(this.btnAddProperty_Click); // ✅ נוסף

            // 
            // btnLogout
            // 
            this.btnLogout.Text = "יציאה";
            this.btnLogout.Font = new Font("Segoe UI", 10F);
            this.btnLogout.Size = new Size(100, 35);
            this.btnLogout.Location = new Point(120, 230);
            this.btnLogout.BackColor = Color.White;
            this.btnLogout.ForeColor = Color.SteelBlue;
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderColor = Color.SteelBlue;
            this.btnLogout.FlatAppearance.BorderSize = 1;
            this.btnLogout.Cursor = Cursors.Hand;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // 
            // HomeForm
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(350, 300);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnViewProperties);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "מסך ראשי";
            this.BackgroundImage = Properties.Resources.buildings002;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Load += new EventHandler(this.HomeForm_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
