namespace Avanzada.Proyecto1.Win.Views.Controls
{
    partial class FacturationControlCopy
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            totalLabel = new Label();
            label20 = new Label();
            discountLabel = new Label();
            label = new Label();
            subTotalLabel = new Label();
            label16 = new Label();
            newOrderButton = new Button();
            loadOrderButton = new Button();
            textBox4 = new TextBox();
            OrderbindingSource = new BindingSource(components);
            label12 = new Label();
            textBox5 = new TextBox();
            label13 = new Label();
            textBox6 = new TextBox();
            label14 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label8 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            employeeComboBox = new ComboBox();
            label4 = new Label();
            customerComboBox = new ComboBox();
            OrderIdLabel = new Label();
            label3 = new Label();
            saveButton = new Button();
            deleteButton = new Button();
            label15 = new Label();
            PricetextBox = new TextBox();
            label2 = new Label();
            discountTextBox = new TextBox();
            label1 = new Label();
            quantityTextBox = new TextBox();
            AddProductButton = new Button();
            labelProduct = new Label();
            productComboBox = new ComboBox();
            orderDetaildataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderbindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetaildataGridView).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(totalLabel);
            splitContainer1.Panel1.Controls.Add(label20);
            splitContainer1.Panel1.Controls.Add(discountLabel);
            splitContainer1.Panel1.Controls.Add(label);
            splitContainer1.Panel1.Controls.Add(subTotalLabel);
            splitContainer1.Panel1.Controls.Add(label16);
            splitContainer1.Panel1.Controls.Add(newOrderButton);
            splitContainer1.Panel1.Controls.Add(loadOrderButton);
            splitContainer1.Panel1.Controls.Add(textBox4);
            splitContainer1.Panel1.Controls.Add(label12);
            splitContainer1.Panel1.Controls.Add(textBox5);
            splitContainer1.Panel1.Controls.Add(label13);
            splitContainer1.Panel1.Controls.Add(textBox6);
            splitContainer1.Panel1.Controls.Add(label14);
            splitContainer1.Panel1.Controls.Add(textBox3);
            splitContainer1.Panel1.Controls.Add(label11);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label10);
            splitContainer1.Panel1.Controls.Add(dateTimePicker3);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(dateTimePicker2);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(dateTimePicker1);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(employeeComboBox);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(customerComboBox);
            splitContainer1.Panel1.Controls.Add(OrderIdLabel);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(saveButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(deleteButton);
            splitContainer1.Panel2.Controls.Add(label15);
            splitContainer1.Panel2.Controls.Add(PricetextBox);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(discountTextBox);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(quantityTextBox);
            splitContainer1.Panel2.Controls.Add(AddProductButton);
            splitContainer1.Panel2.Controls.Add(labelProduct);
            splitContainer1.Panel2.Controls.Add(productComboBox);
            splitContainer1.Panel2.Controls.Add(orderDetaildataGridView);
            splitContainer1.Size = new Size(1236, 659);
            splitContainer1.SplitterDistance = 360;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // totalLabel
            // 
            totalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(1097, 79);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(62, 20);
            totalLabel.TabIndex = 33;
            totalLabel.Text = "$ 00.00";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(1008, 79);
            label20.Name = "label20";
            label20.Size = new Size(48, 20);
            label20.TabIndex = 32;
            label20.Text = "Total:";
            // 
            // discountLabel
            // 
            discountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            discountLabel.AutoSize = true;
            discountLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountLabel.Location = new Point(1097, 47);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(62, 20);
            discountLabel.TabIndex = 31;
            discountLabel.Text = "$ 00.00";
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(1008, 47);
            label.Name = "label";
            label.Size = new Size(79, 20);
            label.TabIndex = 30;
            label.Text = "Discount: ";
            // 
            // subTotalLabel
            // 
            subTotalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            subTotalLabel.AutoSize = true;
            subTotalLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subTotalLabel.Location = new Point(1097, 16);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new Size(62, 20);
            subTotalLabel.TabIndex = 29;
            subTotalLabel.Text = "$ 00.00";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(1008, 16);
            label16.Name = "label16";
            label16.Size = new Size(74, 20);
            label16.TabIndex = 28;
            label16.Text = "SubTotal:";
            // 
            // newOrderButton
            // 
            newOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            newOrderButton.Location = new Point(1057, 239);
            newOrderButton.Name = "newOrderButton";
            newOrderButton.Size = new Size(163, 33);
            newOrderButton.TabIndex = 27;
            newOrderButton.Text = "New Order";
            newOrderButton.UseVisualStyleBackColor = true;
            newOrderButton.Click += newOrderButton_Click;
            // 
            // loadOrderButton
            // 
            loadOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            loadOrderButton.Location = new Point(1057, 275);
            loadOrderButton.Name = "loadOrderButton";
            loadOrderButton.Size = new Size(163, 33);
            loadOrderButton.TabIndex = 26;
            loadOrderButton.Text = "Load Order";
            loadOrderButton.UseVisualStyleBackColor = true;
            loadOrderButton.Click += loadOrderButton_Click;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", OrderbindingSource, "ShipCountry", true));
            textBox4.Location = new Point(681, 288);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(298, 23);
            textBox4.TabIndex = 25;
            // 
            // OrderbindingSource
            // 
            OrderbindingSource.DataSource = typeof(DataModel.Order);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F);
            label12.Location = new Point(683, 265);
            label12.Name = "label12";
            label12.Size = new Size(60, 20);
            label12.TabIndex = 24;
            label12.Text = "Country";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", OrderbindingSource, "ShipPostalCode", true));
            textBox5.Location = new Point(679, 221);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(298, 23);
            textBox5.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F);
            label13.Location = new Point(681, 198);
            label13.Name = "label13";
            label13.Size = new Size(87, 20);
            label13.TabIndex = 22;
            label13.Text = "Postal Code";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", OrderbindingSource, "ShipRegion", true));
            textBox6.Location = new Point(679, 161);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(298, 23);
            textBox6.TabIndex = 21;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F);
            label14.Location = new Point(681, 138);
            label14.Name = "label14";
            label14.Size = new Size(56, 20);
            label14.TabIndex = 20;
            label14.Text = "Region";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", OrderbindingSource, "ShipCity", true));
            textBox3.Location = new Point(348, 288);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(298, 23);
            textBox3.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F);
            label11.Location = new Point(350, 265);
            label11.Name = "label11";
            label11.Size = new Size(34, 20);
            label11.TabIndex = 18;
            label11.Text = "City";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", OrderbindingSource, "ShipAddress", true));
            textBox2.Location = new Point(346, 221);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(298, 23);
            textBox2.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(348, 198);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 16;
            label9.Text = "Address";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", OrderbindingSource, "ShipName", true));
            textBox1.Location = new Point(346, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 23);
            textBox1.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F);
            label10.Location = new Point(348, 138);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 14;
            label10.Text = "Name";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.DataBindings.Add(new Binding("Text", OrderbindingSource, "ShippedDate", true));
            dateTimePicker3.Location = new Point(348, 102);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(296, 23);
            dateTimePicker3.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(347, 79);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 12;
            label8.Text = "Shipped Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.DataBindings.Add(new Binding("Text", OrderbindingSource, "RequiredDate", true));
            dateTimePicker2.Location = new Point(17, 288);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(296, 23);
            dateTimePicker2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(16, 265);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 10;
            label7.Text = "Required Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Text", OrderbindingSource, "OrderDate", true));
            dateTimePicker1.Location = new Point(18, 221);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(296, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(17, 198);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 8;
            label6.Text = "Order Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(17, 138);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 6;
            label5.Text = "Employee";
            // 
            // employeeComboBox
            // 
            employeeComboBox.DataBindings.Add(new Binding("SelectedValue", OrderbindingSource, "EmployeeId", true));
            employeeComboBox.FormattingEnabled = true;
            employeeComboBox.Location = new Point(18, 161);
            employeeComboBox.Name = "employeeComboBox";
            employeeComboBox.Size = new Size(296, 23);
            employeeComboBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(17, 79);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 4;
            label4.Text = "Customer";
            // 
            // customerComboBox
            // 
            customerComboBox.DataBindings.Add(new Binding("SelectedValue", OrderbindingSource, "CustomerId", true));
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(18, 102);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(296, 23);
            customerComboBox.TabIndex = 3;
            // 
            // OrderIdLabel
            // 
            OrderIdLabel.AutoSize = true;
            OrderIdLabel.DataBindings.Add(new Binding("Text", OrderbindingSource, "OrderId", true));
            OrderIdLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderIdLabel.Location = new Point(83, 21);
            OrderIdLabel.Name = "OrderIdLabel";
            OrderIdLabel.Size = new Size(45, 20);
            OrderIdLabel.TabIndex = 2;
            OrderIdLabel.Text = "0000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 21);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 1;
            label3.Text = "OrderId: ";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(1057, 311);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(163, 33);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(476, 48);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(97, 24);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(1017, 33);
            label15.Name = "label15";
            label15.Size = new Size(52, 21);
            label15.TabIndex = 9;
            label15.Text = "Price:";
            // 
            // PricetextBox
            // 
            PricetextBox.Location = new Point(1092, 31);
            PricetextBox.Name = "PricetextBox";
            PricetextBox.Size = new Size(120, 23);
            PricetextBox.TabIndex = 8;
            PricetextBox.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(792, 33);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 7;
            label2.Text = "Discount:";
            // 
            // discountTextBox
            // 
            discountTextBox.Location = new Point(879, 31);
            discountTextBox.Name = "discountTextBox";
            discountTextBox.Size = new Size(120, 23);
            discountTextBox.TabIndex = 6;
            discountTextBox.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(579, 33);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 5;
            label1.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(666, 31);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(120, 23);
            quantityTextBox.TabIndex = 4;
            quantityTextBox.Text = "1";
            // 
            // AddProductButton
            // 
            AddProductButton.Location = new Point(476, 18);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(97, 24);
            AddProductButton.TabIndex = 3;
            AddProductButton.Text = "Add";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProduct.Location = new Point(17, 33);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(78, 21);
            labelProduct.TabIndex = 2;
            labelProduct.Text = "Product: ";
            // 
            // productComboBox
            // 
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(103, 31);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(367, 23);
            productComboBox.TabIndex = 1;
            productComboBox.SelectedIndexChanged += productComboBox_SelectedIndexChanged;
            // 
            // orderDetaildataGridView
            // 
            orderDetaildataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderDetaildataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDetaildataGridView.Location = new Point(3, 95);
            orderDetaildataGridView.Name = "orderDetaildataGridView";
            orderDetaildataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderDetaildataGridView.Size = new Size(1230, 338);
            orderDetaildataGridView.TabIndex = 0;
            // 
            // FacturationControlCopy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "FacturationControlCopy";
            Size = new Size(1236, 659);
            Load += FacturationControlCopy_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrderbindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetaildataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private BindingSource OrderbindingSource;
        private DataGridView orderDetaildataGridView;
        private ComboBox productComboBox;
        private Label labelProduct;
        private Button AddProductButton;
        private Label label2;
        private TextBox discountTextBox;
        private Label label1;
        private TextBox quantityTextBox;
        private Button saveButton;
        private Label OrderIdLabel;
        private Label label3;
        private Label label4;
        private ComboBox customerComboBox;
        private Label label5;
        private ComboBox employeeComboBox;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private DateTimePicker dateTimePicker3;
        private Label label8;
        private TextBox textBox3;
        private Label label11;
        private TextBox textBox2;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label12;
        private TextBox textBox5;
        private Label label13;
        private TextBox textBox6;
        private Label label14;
        private Button loadOrderButton;
        private Label label15;
        private TextBox PricetextBox;
        private Button newOrderButton;
        private Label totalLabel;
        private Label label20;
        private Label discountLabel;
        private Label label;
        private Label subTotalLabel;
        private Label label16;
        private Button deleteButton;
    }
}
