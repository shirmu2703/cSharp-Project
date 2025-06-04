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
                ShowError("יש להזין שם נכס.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPropertyAdress.Text))
            {
                ShowError("יש להזין כתובת.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPropertyPrice.Text) ||
                !decimal.TryParse(txtPropertyPrice.Text, out decimal price) ||
                price < Constants.MinPropertyPrice)
            {
                ShowError($"המחיר חייב להיות מספר גדול מ־{Constants.MinPropertyPrice}.");
                return;
            }

            var newProperty = CreateProperty(txtPropertyName.Text, txtPropertyAdress.Text, price);

            if (newProperty != null)
            {
                propertyManager.Add(newProperty);
                MessageBox.Show("הנכס נוסף בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                homeForm.Show();
            }
            else
            {
                ShowError("סוג נכס לא תקין.");
            }
        }

        private Property CreateProperty(string name, string address, decimal price)
        {
            return (PropertyType)cmbPropertyType.SelectedItem switch
            {
                PropertyType.PrivateHouse => new PrivateHouse(name, address, price),
                PropertyType.Apartment => new Apartment(name, address, price),
                PropertyType.Office => new Office(name, address, price),
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
