namespace NEW_PROJECT
{
    partial class AddPropertyForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtPropertyName = new System.Windows.Forms.TextBox();
            this.txtPropertyAdress = new System.Windows.Forms.TextBox();
            this.cmbPropertyType = new System.Windows.Forms.ComboBox();
            this.txtPropertyPrice = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "הוספת נכס חדש";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(260, 20);
            this.lblTitle.Size = new System.Drawing.Size(280, 40);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblName
            // 
            this.lblName.Text = "שם נכס:";
            this.lblName.Location = new System.Drawing.Point(620, 80);
            this.lblName.Size = new System.Drawing.Size(100, 25);

            // 
            // txtPropertyName
            // 
            this.txtPropertyName.Location = new System.Drawing.Point(400, 80);
            this.txtPropertyName.Size = new System.Drawing.Size(200, 26);

            // 
            // lblAddress
            // 
            this.lblAddress.Text = "כתובת:";
            this.lblAddress.Location = new System.Drawing.Point(620, 130);
            this.lblAddress.Size = new System.Drawing.Size(100, 25);

            // 
            // txtPropertyAdress
            // 
            this.txtPropertyAdress.Location = new System.Drawing.Point(400, 130);
            this.txtPropertyAdress.Size = new System.Drawing.Size(200, 26);

            // 
            // lblType
            // 
            this.lblType.Text = "סוג נכס:";
            this.lblType.Location = new System.Drawing.Point(620, 180);
            this.lblType.Size = new System.Drawing.Size(100, 25);

            // 
            // cmbPropertyType
            // 
            this.cmbPropertyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPropertyType.Location = new System.Drawing.Point(400, 180);
            this.cmbPropertyType.Size = new System.Drawing.Size(200, 28);

            // 
            // lblPrice
            // 
            this.lblPrice.Text = "מחיר:";
            this.lblPrice.Location = new System.Drawing.Point(620, 230);
            this.lblPrice.Size = new System.Drawing.Size(100, 25);

            // 
            // txtPropertyPrice
            // 
            this.txtPropertyPrice.Location = new System.Drawing.Point(400, 230);
            this.txtPropertyPrice.Size = new System.Drawing.Size(200, 26);

            // 
            // BtnAdd
            // 
            this.BtnAdd.Text = "שמור";
            this.BtnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(400, 290);
            this.BtnAdd.Size = new System.Drawing.Size(100, 35);
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);

            // 
            // BtnBack
            // 
            this.BtnBack.Text = "ביטול";
            this.BtnBack.BackColor = System.Drawing.Color.IndianRed;
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Location = new System.Drawing.Point(520, 290);
            this.BtnBack.Size = new System.Drawing.Size(100, 35);
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);

            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(400, 340);
            this.lblError.Size = new System.Drawing.Size(300, 25);
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblError.Visible = false;

            // 
            // AddPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPropertyName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPropertyAdress);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbPropertyType);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPropertyPrice);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.lblError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "AddPropertyForm";
            this.Text = "הוספת נכס";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPropertyName;
        private System.Windows.Forms.TextBox txtPropertyAdress;
        private System.Windows.Forms.ComboBox cmbPropertyType;
        private System.Windows.Forms.TextBox txtPropertyPrice;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPrice;
    }
}
