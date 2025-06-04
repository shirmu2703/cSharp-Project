using System;
using System.Linq;
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
            LoadProperties();
        }

        private void LoadProperties()
        {
            var allProperties = propertyManager.GetAll();
            var userProperties = allProperties
                .Where(p => p.Owner == homeForm.EmployeeName)
                .ToList();

            lstProperties.DataSource = null;
            lstProperties.DataSource = userProperties;

            if (userProperties.Count == 0)
            {
                MessageBox.Show("No properties found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstProperties.SelectedItem == null)
            {
                MessageBox.Show("Please select a property to delete.", "Delete Property", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedProperty = lstProperties.SelectedItem as Property;

            var result = MessageBox.Show($"Are you sure you want to delete '{selectedProperty.Name}'?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                propertyManager.Delete(selectedProperty);
                MessageBox.Show("Property deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProperties();
            }
        }
    }
}
