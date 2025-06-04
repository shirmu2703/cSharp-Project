using System;
using System.Windows.Forms;

namespace NEW_PROJECT
{
    public partial class UpdatePropertyForm : Form
    {
        private PropertyManager propertyManager;
        private Property originalProperty;

        public UpdatePropertyForm(PropertyManager manager, Property propertyToUpdate)
        {
            InitializeComponent();
            propertyManager = manager;
            originalProperty = propertyToUpdate;

            cmbPropertyType.DataSource = Enum.GetValues(typeof(PropertyType));
            cmbPropertyType.SelectedItem = propertyToUpdate.Type;

            txtPropertyName.Text = propertyToUpdate.Name;
            txtPropertyAddress.Text = propertyToUpdate.Address;
            txtPropertyPrice.Text = propertyToUpdate.Price.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPropertyName.Text))
            {
                MessageBox.Show("Name can't be null.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPropertyPrice.Text) ||
                !decimal.TryParse(txtPropertyPrice.Text, out decimal price) ||
                price < Constants.MinPropertyPrice)
            {
                MessageBox.Show($"Price must be higher than {Constants.MinPropertyPrice}.");
                return;
            }

            Property updatedProperty = CreateProperty(txtPropertyName.Text, txtPropertyAddress.Text, price);
            if (updatedProperty != null)
            {
                propertyManager.Update(originalProperty, updatedProperty);
                this.Close();
            }
        }

        private Property? CreateProperty(string name, string address, decimal price)
        {
            return ((PropertyType)cmbPropertyType.SelectedItem) switch
            {
                PropertyType.PrivateHouse => new PrivateHouse(name, address, price),
                PropertyType.Apartment => new Apartment(name, address, price),
                PropertyType.Office => new Office(name, address, price),
                _ => null
            };
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
