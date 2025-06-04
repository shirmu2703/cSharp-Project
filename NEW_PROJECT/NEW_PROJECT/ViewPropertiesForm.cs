using System;
using System.Windows.Forms;

namespace NEW_PROJECT
{
    public partial class ViewPropertiesForm : Form
    {
        private PropertyManager propertyManager;
        private HomeForm homeForm;

        public ViewPropertiesForm(PropertyManager manager, HomeForm home)
        {
            InitializeComponent();
            propertyManager = manager;
            homeForm = home;

            lstProperties.DataSource = propertyManager.GetAll();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeForm.Show();
        }
    }
}
