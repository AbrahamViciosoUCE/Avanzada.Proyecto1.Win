namespace Avanzada.Proyecto1.Win.Views
{
    partial class FormProduct
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            tbproductName = new TextBox();
            productBindingSource = new BindingSource(components);
            label2 = new Label();
            supplierCombobox = new ComboBox();
            categoryCombobox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            tbQuantityPUnity = new TextBox();
            tbUnitPrice = new TextBox();
            label5 = new Label();
            tbUnitsinStock = new TextBox();
            label6 = new Label();
            tbUntisOnOrder = new TextBox();
            label7 = new Label();
            tbReorderLevel = new TextBox();
            label8 = new Label();
            checkBox1 = new CheckBox();
            SubmitBtn = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(11, 24);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // tbproductName
            // 
            tbproductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbproductName.DataBindings.Add(new Binding("Text", productBindingSource, "ProductName", true));
            tbproductName.Location = new Point(11, 50);
            tbproductName.Name = "tbproductName";
            tbproductName.Size = new Size(260, 23);
            tbproductName.TabIndex = 1;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(11, 84);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Supplier";
            // 
            // supplierCombobox
            // 
            supplierCombobox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            supplierCombobox.DataBindings.Add(new Binding("SelectedValue", productBindingSource, "SupplierID", true));
            supplierCombobox.FormattingEnabled = true;
            supplierCombobox.Location = new Point(11, 110);
            supplierCombobox.Name = "supplierCombobox";
            supplierCombobox.Size = new Size(260, 23);
            supplierCombobox.TabIndex = 8;
            // 
            // categoryCombobox
            // 
            categoryCombobox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoryCombobox.DataBindings.Add(new Binding("SelectedValue", productBindingSource, "CategoryID", true));
            categoryCombobox.FormattingEnabled = true;
            categoryCombobox.Location = new Point(11, 170);
            categoryCombobox.Name = "categoryCombobox";
            categoryCombobox.Size = new Size(260, 23);
            categoryCombobox.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(11, 144);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 9;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 212);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 11;
            label4.Text = "Quantity Per Unity";
            // 
            // tbQuantityPUnity
            // 
            tbQuantityPUnity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbQuantityPUnity.DataBindings.Add(new Binding("Text", productBindingSource, "QuantityPerUnit", true));
            tbQuantityPUnity.Location = new Point(11, 239);
            tbQuantityPUnity.Name = "tbQuantityPUnity";
            tbQuantityPUnity.Size = new Size(260, 23);
            tbQuantityPUnity.TabIndex = 12;
            // 
            // tbUnitPrice
            // 
            tbUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbUnitPrice.DataBindings.Add(new Binding("Text", productBindingSource, "UnitPrice", true));
            tbUnitPrice.Location = new Point(11, 304);
            tbUnitPrice.Name = "tbUnitPrice";
            tbUnitPrice.Size = new Size(260, 23);
            tbUnitPrice.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 286);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 13;
            label5.Text = "UnitPrice";
            // 
            // tbUnitsinStock
            // 
            tbUnitsinStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbUnitsinStock.DataBindings.Add(new Binding("Text", productBindingSource, "UnitsInStock", true));
            tbUnitsinStock.Location = new Point(11, 375);
            tbUnitsinStock.Name = "tbUnitsinStock";
            tbUnitsinStock.Size = new Size(260, 23);
            tbUnitsinStock.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 357);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 15;
            label6.Text = "Units in Stock";
            // 
            // tbUntisOnOrder
            // 
            tbUntisOnOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbUntisOnOrder.DataBindings.Add(new Binding("Text", productBindingSource, "UnitsOnOrder", true));
            tbUntisOnOrder.Location = new Point(11, 445);
            tbUntisOnOrder.Name = "tbUntisOnOrder";
            tbUntisOnOrder.Size = new Size(260, 23);
            tbUntisOnOrder.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 418);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 17;
            label7.Text = "Untis On Order";
            // 
            // tbReorderLevel
            // 
            tbReorderLevel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbReorderLevel.DataBindings.Add(new Binding("Text", productBindingSource, "ReorderLevel", true));
            tbReorderLevel.Location = new Point(11, 517);
            tbReorderLevel.Name = "tbReorderLevel";
            tbReorderLevel.Size = new Size(260, 23);
            tbReorderLevel.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 490);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 19;
            label8.Text = "Reorder Level";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.DataBindings.Add(new Binding("Checked", productBindingSource, "Discontinued", true));
            checkBox1.Location = new Point(11, 571);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(96, 19);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Discontinued";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SubmitBtn.Location = new Point(171, 622);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(104, 28);
            SubmitBtn.TabIndex = 23;
            SubmitBtn.Text = "Aceptar";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(9, 622);
            button2.Name = "button2";
            button2.Size = new Size(104, 28);
            button2.TabIndex = 24;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 662);
            Controls.Add(button2);
            Controls.Add(SubmitBtn);
            Controls.Add(checkBox1);
            Controls.Add(tbReorderLevel);
            Controls.Add(label8);
            Controls.Add(tbUntisOnOrder);
            Controls.Add(label7);
            Controls.Add(tbUnitsinStock);
            Controls.Add(label6);
            Controls.Add(tbUnitPrice);
            Controls.Add(label5);
            Controls.Add(tbQuantityPUnity);
            Controls.Add(label4);
            Controls.Add(categoryCombobox);
            Controls.Add(label3);
            Controls.Add(supplierCombobox);
            Controls.Add(label2);
            Controls.Add(tbproductName);
            Controls.Add(label1);
            Name = "FormProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Product";
            FormClosed += FormProduct_FormClosed;
            Load += FormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbproductName;
        private Label label2;
        private ComboBox supplierCombobox;
        private ComboBox categoryCombobox;
        private Label label3;
        private Label label4;
        private TextBox tbQuantityPUnity;
        private TextBox tbUnitPrice;
        private Label label5;
        private TextBox tbUnitsinStock;
        private Label label6;
        private TextBox tbUntisOnOrder;
        private Label label7;
        private TextBox tbReorderLevel;
        private Label label8;
        private CheckBox checkBox1;
        private Button SubmitBtn;
        private Button button2;
        private BindingSource productBindingSource;
    }
}