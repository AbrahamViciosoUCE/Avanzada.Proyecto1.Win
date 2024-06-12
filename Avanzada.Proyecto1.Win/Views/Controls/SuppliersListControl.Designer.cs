namespace Avanzada.Proyecto1.Win.Views.Controls
{
    partial class SuppliersListControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridSuppliers = new DataGridView();
            SupplierID = new DataGridViewTextBoxColumn();
            CompanyName = new DataGridViewTextBoxColumn();
            ContactName = new DataGridViewTextBoxColumn();
            ContactTitle = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Region = new DataGridViewTextBoxColumn();
            PostalCode = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Fax = new DataGridViewTextBoxColumn();
            HomePage = new DataGridViewTextBoxColumn();
            deleteButton = new Button();
            CreateButton = new Button();
            EditButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dataGridSuppliers
            // 
            dataGridSuppliers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSuppliers.Columns.AddRange(new DataGridViewColumn[] { SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage });
            dataGridSuppliers.Location = new Point(3, 41);
            dataGridSuppliers.Name = "dataGridSuppliers";
            dataGridSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSuppliers.Size = new Size(663, 507);
            dataGridSuppliers.TabIndex = 0;
            // 
            // SupplierID
            // 
            SupplierID.DataPropertyName = "SupplierID";
            SupplierID.HeaderText = "SupplierID";
            SupplierID.Name = "SupplierID";
            // 
            // CompanyName
            // 
            CompanyName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CompanyName.DataPropertyName = "CompanyName";
            CompanyName.HeaderText = "CompanyName";
            CompanyName.MinimumWidth = 100;
            CompanyName.Name = "CompanyName";
            // 
            // ContactName
            // 
            ContactName.DataPropertyName = "ContactName";
            ContactName.HeaderText = "ContactName";
            ContactName.Name = "ContactName";
            // 
            // ContactTitle
            // 
            ContactTitle.DataPropertyName = "ContactTitle";
            ContactTitle.HeaderText = "ContactTitle";
            ContactTitle.Name = "ContactTitle";
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.Name = "Address";
            // 
            // City
            // 
            City.DataPropertyName = "City";
            City.HeaderText = "City";
            City.Name = "City";
            // 
            // Region
            // 
            Region.DataPropertyName = "Region";
            Region.HeaderText = "Region";
            Region.Name = "Region";
            // 
            // PostalCode
            // 
            PostalCode.DataPropertyName = "PostalCode";
            PostalCode.HeaderText = "PostalCode";
            PostalCode.Name = "PostalCode";
            // 
            // Country
            // 
            Country.DataPropertyName = "Country";
            Country.HeaderText = "Country";
            Country.Name = "Country";
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            // 
            // Fax
            // 
            Fax.DataPropertyName = "Fax";
            Fax.HeaderText = "Fax";
            Fax.Name = "Fax";
            // 
            // HomePage
            // 
            HomePage.DataPropertyName = "HomePage";
            HomePage.HeaderText = "HomePage";
            HomePage.Name = "HomePage";
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.Location = new Point(492, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(174, 32);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete Product";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateButton.Location = new Point(132, 3);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(174, 32);
            CreateButton.TabIndex = 5;
            CreateButton.Text = "Create Supplier";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditButton.Location = new Point(312, 3);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(174, 32);
            EditButton.TabIndex = 4;
            EditButton.Text = "Edit Product";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // SuppliersListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteButton);
            Controls.Add(CreateButton);
            Controls.Add(EditButton);
            Controls.Add(dataGridSuppliers);
            Name = "SuppliersListControl";
            Size = new Size(666, 548);
            Load += SuppliersListControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridSuppliers;
        private Button deleteButton;
        private Button CreateButton;
        private Button EditButton;
        private DataGridViewTextBoxColumn SupplierID;
        private DataGridViewTextBoxColumn CompanyName;
        private DataGridViewTextBoxColumn ContactName;
        private DataGridViewTextBoxColumn ContactTitle;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Region;
        private DataGridViewTextBoxColumn PostalCode;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Fax;
        private DataGridViewTextBoxColumn HomePage;
    }
}
