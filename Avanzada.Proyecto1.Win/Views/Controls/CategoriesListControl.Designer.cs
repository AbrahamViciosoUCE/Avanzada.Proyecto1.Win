namespace Avanzada.Proyecto1.Win.Views.Controls
{
    partial class CategoriesListControl
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
            categoryDatagridview = new DataGridView();
            CategoryName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Picture = new DataGridViewImageColumn();
            CateogryID = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            btncreate = new Button();
            btndelete = new Button();
            ((System.ComponentModel.ISupportInitialize)categoryDatagridview).BeginInit();
            SuspendLayout();
            // 
            // categoryDatagridview
            // 
            categoryDatagridview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoryDatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoryDatagridview.Columns.AddRange(new DataGridViewColumn[] { CategoryName, Description, Picture, CateogryID });
            categoryDatagridview.Location = new Point(0, 40);
            categoryDatagridview.Name = "categoryDatagridview";
            categoryDatagridview.RowTemplate.Height = 200;
            categoryDatagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categoryDatagridview.Size = new Size(982, 583);
            categoryDatagridview.TabIndex = 0;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "CategoryName";
            CategoryName.Name = "CategoryName";
            CategoryName.Resizable = DataGridViewTriState.True;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Picture
            // 
            Picture.DataPropertyName = "Picture";
            Picture.HeaderText = "Picture";
            Picture.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Picture.Name = "Picture";
            Picture.Width = 200;
            // 
            // CateogryID
            // 
            CateogryID.DataPropertyName = "CategoryID";
            CateogryID.HeaderText = "CateogryID";
            CateogryID.Name = "CateogryID";
            CateogryID.ReadOnly = true;
            CateogryID.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(622, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(177, 31);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit Category";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btncreate
            // 
            btncreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btncreate.Location = new Point(439, 3);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(177, 31);
            btncreate.TabIndex = 2;
            btncreate.Text = "Create Category";
            btncreate.UseVisualStyleBackColor = true;
            btncreate.Click += btncreate_Click;
            // 
            // btndelete
            // 
            btndelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btndelete.Location = new Point(802, 3);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(177, 31);
            btndelete.TabIndex = 3;
            btndelete.Text = "Delete Category";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // CategoriesListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btndelete);
            Controls.Add(btncreate);
            Controls.Add(btnEdit);
            Controls.Add(categoryDatagridview);
            Name = "CategoriesListControl";
            Size = new Size(982, 623);
            Load += CategoriesListControl_Load;
            ((System.ComponentModel.ISupportInitialize)categoryDatagridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView categoryDatagridview;
        private Button btnEdit;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewImageColumn Picture;
        private DataGridViewTextBoxColumn CateogryID;
        private Button btncreate;
        private Button btndelete;
    }
}
