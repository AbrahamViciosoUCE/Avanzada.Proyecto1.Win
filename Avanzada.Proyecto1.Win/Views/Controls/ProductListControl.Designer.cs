namespace Avanzada.Proyecto1.Win.Views.Controls
{
    partial class ProductListControl
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
            ProductsDataGrid = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            SupplierID = new DataGridViewTextBoxColumn();
            CategoryID = new DataGridViewTextBoxColumn();
            QuantityPerUnit = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            UnitsInStock = new DataGridViewTextBoxColumn();
            UnitsOnOrder = new DataGridViewTextBoxColumn();
            ReorderLevel = new DataGridViewTextBoxColumn();
            Discontinued = new DataGridViewCheckBoxColumn();
            EditButton = new Button();
            CreateButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // ProductsDataGrid
            // 
            ProductsDataGrid.AllowUserToAddRows = false;
            ProductsDataGrid.AllowUserToDeleteRows = false;
            ProductsDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGrid.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, SupplierName, CategoryName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued });
            ProductsDataGrid.Location = new Point(3, 41);
            ProductsDataGrid.Name = "ProductsDataGrid";
            ProductsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDataGrid.Size = new Size(1414, 585);
            ProductsDataGrid.TabIndex = 0;
            // 
            // ProductID
            // 
            ProductID.DataPropertyName = "ProductID";
            ProductID.HeaderText = "ProductID";
            ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 100;
            ProductName.Name = "ProductName";
            // 
            // SupplierName
            // 
            SupplierName.DataPropertyName = "SupplierName";
            SupplierName.HeaderText = "SupplierName";
            SupplierName.MinimumWidth = 100;
            SupplierName.Name = "SupplierName";
            SupplierName.Width = 200;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "CategoryName";
            CategoryName.Name = "CategoryName";
            // 
            // SupplierID
            // 
            SupplierID.DataPropertyName = "SupplierID";
            SupplierID.HeaderText = "SupplierID";
            SupplierID.Name = "SupplierID";
            SupplierID.Visible = false;
            // 
            // CategoryID
            // 
            CategoryID.DataPropertyName = "CategoryID";
            CategoryID.HeaderText = "CategoryID";
            CategoryID.Name = "CategoryID";
            CategoryID.Visible = false;
            // 
            // QuantityPerUnit
            // 
            QuantityPerUnit.DataPropertyName = "QuantityPerUnit";
            QuantityPerUnit.HeaderText = "QuantityPerUnit";
            QuantityPerUnit.Name = "QuantityPerUnit";
            // 
            // UnitPrice
            // 
            UnitPrice.DataPropertyName = "UnitPrice";
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.Name = "UnitPrice";
            // 
            // UnitsInStock
            // 
            UnitsInStock.DataPropertyName = "UnitsInStock";
            UnitsInStock.HeaderText = "UnitsInStock";
            UnitsInStock.Name = "UnitsInStock";
            // 
            // UnitsOnOrder
            // 
            UnitsOnOrder.DataPropertyName = "UnitsOnOrder";
            UnitsOnOrder.HeaderText = "UnitsOnOrder";
            UnitsOnOrder.Name = "UnitsOnOrder";
            // 
            // ReorderLevel
            // 
            ReorderLevel.DataPropertyName = "ReorderLevel";
            ReorderLevel.HeaderText = "ReorderLevel";
            ReorderLevel.Name = "ReorderLevel";
            // 
            // Discontinued
            // 
            Discontinued.DataPropertyName = "Discontinued";
            Discontinued.HeaderText = "Discontinued";
            Discontinued.Name = "Discontinued";
            Discontinued.Resizable = DataGridViewTriState.True;
            Discontinued.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditButton.Location = new Point(1063, 3);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(174, 32);
            EditButton.TabIndex = 1;
            EditButton.Text = "Edit Product";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateButton.Location = new Point(883, 3);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(174, 32);
            CreateButton.TabIndex = 2;
            CreateButton.Text = "Create Product";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.Location = new Point(1243, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(174, 32);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete Product";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // ProductListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteButton);
            Controls.Add(CreateButton);
            Controls.Add(EditButton);
            Controls.Add(ProductsDataGrid);
            Name = "ProductListControl";
            Size = new Size(1420, 629);
            Load += ProductListControl_Load;
            ((System.ComponentModel.ISupportInitialize)ProductsDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductsDataGrid;
        private Button EditButton;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn SupplierID;
        private DataGridViewTextBoxColumn CategoryID;
        private DataGridViewTextBoxColumn QuantityPerUnit;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn UnitsInStock;
        private DataGridViewTextBoxColumn UnitsOnOrder;
        private DataGridViewTextBoxColumn ReorderLevel;
        private DataGridViewCheckBoxColumn Discontinued;
        private Button CreateButton;
        private Button deleteButton;
    }
}
