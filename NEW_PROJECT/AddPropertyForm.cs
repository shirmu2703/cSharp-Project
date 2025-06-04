using System;
using System.Windows.Forms;

namespace NEW_PROJECT
{
    public partial class AddPropertyForm : Form
    {
        private readonly PropertyManager propertyManager;
        private readonly HomeForm homeForm;

        public AddPropertyForm(PropertyManager manager, HomeForm home)
        {
            InitializeComponent();
            propertyManager = manager;
            homeForm = home;

            cmbPropertyType.DataSource = Enum.GetValues(typeof(PropertyType));
            cmbPropertyType.DropDownStyle = ComboBoxStyle.DropDownList;
            lblError.Visible = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (string.IsNullOrWhiteSpace(txtPropertyName.Text))
            {
                ShowError("Please enter a property name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPropertyAdress.Text))
            {
                ShowError("Please enter a property address.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPropertyPrice.Text) ||
                !decimal.TryParse(txtPropertyPrice.Text, out decimal price) ||
                price < Constants.MinPropertyPrice)
            {
                ShowError($"Price must be a number greater than {Constants.MinPropertyPrice}.");
                return;
            }

            var newProperty = CreateProperty(
                txtPropertyName.Text,
                txtPropertyAdress.Text,
                price,
                homeForm.EmployeeName
            );

            if (newProperty != null)
            {
                propertyManager.Add(newProperty);
                MessageBox.Show("Property added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                homeForm.Show();
            }
            else
            {
                ShowError("Invalid property type selected.");
            }
        }

        private Property CreateProperty(string name, string address, decimal price, string owner)
        {
            return (PropertyType)cmbPropertyType.SelectedItem switch
            {
                PropertyType.PrivateHouse => new PrivateHouse(name, address, price, owner),
                PropertyType.Apartment => new Apartment(name, address, price, owner),
                PropertyType.Office => new Office(name, address, price, owner),
                _ => null
            };
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeForm.Show();
        }
    }
}
