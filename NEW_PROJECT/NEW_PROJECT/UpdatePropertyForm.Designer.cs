namespace NEW_PROJECT
{
    partial class UpdatePropertyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.Label();
            this.txtPropertyPrice = new System.Windows.Forms.TextBox();
            this.cmbPropertyType = new System.Windows.Forms.ComboBox();
            this.txtPropertyAddress = new System.Windows.Forms.TextBox();
            this.txtPropertyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnUpdate.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(78, 378);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(169, 60);
            this.BtnUpdate.TabIndex = 0;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.IndianRed;
            this.BtnBack.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(333, 378);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(216, 60);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back to home page";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Property Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Property Type (choose one of the options below)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Property Adress";
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.Location = new System.Drawing.Point(64, 61);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(160, 26);
            this.p.TabIndex = 15;
            this.p.Text = "Property Name:";
            // 
            // txtPropertyPrice
            // 
            this.txtPropertyPrice.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyPrice.Location = new System.Drawing.Point(60, 322);
            this.txtPropertyPrice.Name = "txtPropertyPrice";
            this.txtPropertyPrice.Size = new System.Drawing.Size(100, 34);
            this.txtPropertyPrice.TabIndex = 14;
            // 
            // cmbPropertyType
            // 
            this.cmbPropertyType.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPropertyType.FormattingEnabled = true;
            this.cmbPropertyType.Items.AddRange(new object[] {
            "בית פרטי",
            "דירה",
            "משרד"});
            this.cmbPropertyType.Location = new System.Drawing.Point(60, 244);
            this.cmbPropertyType.Name = "cmbPropertyType";
            this.cmbPropertyType.Size = new System.Drawing.Size(121, 34);
            this.cmbPropertyType.TabIndex = 13;
            // 
            // txtPropertyAddress
            // 
            this.txtPropertyAddress.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyAddress.Location = new System.Drawing.Point(60, 170);
            this.txtPropertyAddress.Name = "txtPropertyAddress";
            this.txtPropertyAddress.Size = new System.Drawing.Size(254, 34);
            this.txtPropertyAddress.TabIndex = 12;
            
            // 
            // txtPropertyName
            // 
            this.txtPropertyName.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyName.Location = new System.Drawing.Point(60, 97);
            this.txtPropertyName.Name = "txtPropertyName";
            this.txtPropertyName.Size = new System.Drawing.Size(100, 34);
            this.txtPropertyName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Update Property";
            // 
            // UpdatePropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p);
            this.Controls.Add(this.txtPropertyPrice);
            this.Controls.Add(this.cmbPropertyType);
            this.Controls.Add(this.txtPropertyAddress);
            this.Controls.Add(this.txtPropertyName);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnUpdate);
            this.Name = "UpdatePropertyForm";
            this.Text = "UpdatePropertyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.TextBox txtPropertyPrice;
        private System.Windows.Forms.ComboBox cmbPropertyType;
        private System.Windows.Forms.TextBox txtPropertyAddress;
        private System.Windows.Forms.TextBox txtPropertyName;
        private System.Windows.Forms.Label label4;
    }
}