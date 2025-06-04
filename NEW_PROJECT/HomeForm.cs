using System;
using System.Windows.Forms;

namespace NEW_PROJECT
{
    public partial class HomeForm : Form
    {
        private string employeeName;
        public string EmployeeName => employeeName;

        private PropertyManager propertyManager;

        public HomeForm(string name)
        {
            InitializeComponent();
            employeeName = name;
            propertyManager = new PropertyManager("properties.json");
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {employeeName}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            var addForm = new AddPropertyForm(propertyManager, this);
            addForm.Show();
            this.Hide();
        }

        private void btnViewProperties_Click(object sender, EventArgs e)
        {
            var viewForm = new ViewPropertiesForm(propertyManager, this);
            viewForm.Show();
            this.Hide();
        }
    }
}
