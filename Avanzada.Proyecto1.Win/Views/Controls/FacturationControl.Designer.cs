namespace Avanzada.Proyecto1.Win.Views.Controls
{
    partial class FacturationControl
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
            kryptonCustomPaletteBase = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            customerComboBox = new Krypton.Toolkit.KryptonComboBox();
            orderBindingSource = new BindingSource(components);
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            employeeComboBox = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonDateTimePicker2 = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonDateTimePicker3 = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox4 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox5 = new Krypton.Toolkit.KryptonTextBox();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            deleteOrderDetail = new Krypton.Toolkit.KryptonButton();
            unitPriceNumeric = new Krypton.Toolkit.KryptonNumericUpDown();
            discountNumeric = new Krypton.Toolkit.KryptonNumericUpDown();
            quantityNumeric = new Krypton.Toolkit.KryptonNumericUpDown();
            productComboBox = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel14 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            orderDetailDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            AddOrderDetailbutton = new Krypton.Toolkit.KryptonButton();
            kryptonManager = new Krypton.Toolkit.KryptonManager(components);
            saveOrderButton = new Krypton.Toolkit.KryptonButton();
            loadOrderButton = new Krypton.Toolkit.KryptonButton();
            kryptonLabel15 = new Krypton.Toolkit.KryptonLabel();
            newOrderButton = new Krypton.Toolkit.KryptonButton();
            kryptonLabel16 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel17 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel18 = new Krypton.Toolkit.KryptonLabel();
            totalLabel = new Krypton.Toolkit.KryptonLabel();
            subtotalLabel = new Krypton.Toolkit.KryptonLabel();
            discountLabel = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)customerComboBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeComboBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productComboBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailDataGridView).BeginInit();
            SuspendLayout();
            // 
            // kryptonCustomPaletteBase
            // 
            kryptonCustomPaletteBase.BaseFont = new Font("Segoe UI", 9F);
            kryptonCustomPaletteBase.BaseFontSize = 9F;
            kryptonCustomPaletteBase.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonCustomPaletteBase.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase.ThemeName = "";
            kryptonCustomPaletteBase.UseKryptonFileDialogs = true;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl;
            kryptonLabel1.Location = new Point(20, 21);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Palette = kryptonCustomPaletteBase;
            kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel1.Size = new Size(113, 31);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Order Form";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            kryptonLabel2.Location = new Point(43, 71);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Palette = kryptonCustomPaletteBase;
            kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel2.Size = new Size(70, 22);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Customer:";
            // 
            // customerComboBox
            // 
            customerComboBox.DataBindings.Add(new Binding("SelectedValue", orderBindingSource, "CustomerId", true));
            customerComboBox.DropDownWidth = 262;
            customerComboBox.IntegralHeight = false;
            customerComboBox.Location = new Point(148, 70);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Palette = kryptonCustomPaletteBase;
            customerComboBox.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            customerComboBox.Size = new Size(262, 21);
            customerComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            customerComboBox.TabIndex = 2;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(DataModel.Order);
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            kryptonLabel3.Location = new Point(43, 114);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Palette = kryptonCustomPaletteBase;
            kryptonLabel3.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel3.Size = new Size(71, 22);
            kryptonLabel3.TabIndex = 3;
            kryptonLabel3.Values.Text = "Employee: ";
            // 
            // employeeComboBox
            // 
            employeeComboBox.DataBindings.Add(new Binding("SelectedValue", orderBindingSource, "EmployeeId", true));
            employeeComboBox.DropDownWidth = 262;
            employeeComboBox.IntegralHeight = false;
            employeeComboBox.Location = new Point(148, 113);
            employeeComboBox.Name = "employeeComboBox";
            employeeComboBox.Palette = kryptonCustomPaletteBase;
            employeeComboBox.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            employeeComboBox.Size = new Size(262, 21);
            employeeComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            employeeComboBox.TabIndex = 4;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            kryptonLabel4.Location = new Point(43, 157);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Palette = kryptonCustomPaletteBase;
            kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel4.Size = new Size(78, 22);
            kryptonLabel4.TabIndex = 5;
            kryptonLabel4.Values.Text = "Order Date: ";
            // 
            // kryptonDateTimePicker1
            // 
            kryptonDateTimePicker1.DataBindings.Add(new Binding("Value", orderBindingSource, "OrderDate", true));
            kryptonDateTimePicker1.Location = new Point(148, 157);
            kryptonDateTimePicker1.MinDate = new DateTime(2004, 1, 1, 0, 0, 0, 0);
            kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            kryptonDateTimePicker1.Palette = kryptonCustomPaletteBase;
            kryptonDateTimePicker1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDateTimePicker1.Size = new Size(262, 21);
            kryptonDateTimePicker1.TabIndex = 6;
            // 
            // kryptonDateTimePicker2
            // 
            kryptonDateTimePicker2.DataBindings.Add(new Binding("Value", orderBindingSource, "RequiredDate", true));
            kryptonDateTimePicker2.Location = new Point(148, 198);
            kryptonDateTimePicker2.MinDate = new DateTime(2004, 1, 1, 0, 0, 0, 0);
            kryptonDateTimePicker2.Name = "kryptonDateTimePicker2";
            kryptonDateTimePicker2.Palette = kryptonCustomPaletteBase;
            kryptonDateTimePicker2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDateTimePicker2.Size = new Size(262, 21);
            kryptonDateTimePicker2.TabIndex = 8;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            kryptonLabel5.Location = new Point(43, 198);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Palette = kryptonCustomPaletteBase;
            kryptonLabel5.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel5.Size = new Size(97, 22);
            kryptonLabel5.TabIndex = 7;
            kryptonLabel5.Values.Text = "Required Date:";
            // 
            // kryptonDateTimePicker3
            // 
            kryptonDateTimePicker3.DataBindings.Add(new Binding("Value", orderBindingSource, "ShippedDate", true));
            kryptonDateTimePicker3.Location = new Point(148, 239);
            kryptonDateTimePicker3.MinDate = new DateTime(2004, 1, 1, 0, 0, 0, 0);
            kryptonDateTimePicker3.Name = "kryptonDateTimePicker3";
            kryptonDateTimePicker3.Palette = kryptonCustomPaletteBase;
            kryptonDateTimePicker3.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonDateTimePicker3.Size = new Size(262, 21);
            kryptonDateTimePicker3.TabIndex = 10;
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            kryptonLabel6.Location = new Point(43, 239);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Palette = kryptonCustomPaletteBase;
            kryptonLabel6.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel6.Size = new Size(92, 22);
            kryptonLabel6.TabIndex = 9;
            kryptonLabel6.Values.Text = "Shipped Date:";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            kryptonLabel7.Location = new Point(469, 237);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Palette = kryptonCustomPaletteBase;
            kryptonLabel7.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel7.Size = new Size(89, 22);
            kryptonLabel7.TabIndex = 19;
            kryptonLabel7.Values.Text = "Ship Country:";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            kryptonLabel8.Location = new Point(469, 196);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Palette = kryptonCustomPaletteBase;
            kryptonLabel8.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel8.Size = new Size(82, 22);
            kryptonLabel8.TabIndex = 17;
            kryptonLabel8.Values.Text = "Postal Code: ";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            kryptonLabel9.Location = new Point(469, 155);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Palette = kryptonCustomPaletteBase;
            kryptonLabel9.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel9.Size = new Size(55, 22);
            kryptonLabel9.TabIndex = 15;
            kryptonLabel9.Values.Text = "Region: ";
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            kryptonLabel10.Location = new Point(469, 112);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Palette = kryptonCustomPaletteBase;
            kryptonLabel10.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel10.Size = new Size(37, 22);
            kryptonLabel10.TabIndex = 13;
            kryptonLabel10.Values.Text = "City: ";
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            kryptonLabel11.Location = new Point(469, 69);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Palette = kryptonCustomPaletteBase;
            kryptonLabel11.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel11.Size = new Size(60, 22);
            kryptonLabel11.TabIndex = 11;
            kryptonLabel11.Values.Text = "Address: ";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.DataBindings.Add(new Binding("Text", orderBindingSource, "ShipAddress", true));
            kryptonTextBox1.Location = new Point(570, 71);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(262, 23);
            kryptonTextBox1.TabIndex = 20;
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.DataBindings.Add(new Binding("Text", orderBindingSource, "ShipCity", true));
            kryptonTextBox2.Location = new Point(570, 111);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(262, 23);
            kryptonTextBox2.TabIndex = 21;
            // 
            // kryptonTextBox3
            // 
            kryptonTextBox3.DataBindings.Add(new Binding("Text", orderBindingSource, "ShipRegion", true));
            kryptonTextBox3.Location = new Point(570, 154);
            kryptonTextBox3.Name = "kryptonTextBox3";
            kryptonTextBox3.Size = new Size(262, 23);
            kryptonTextBox3.TabIndex = 22;
            // 
            // kryptonTextBox4
            // 
            kryptonTextBox4.DataBindings.Add(new Binding("Text", orderBindingSource, "ShipPostalCode", true));
            kryptonTextBox4.Location = new Point(570, 195);
            kryptonTextBox4.Name = "kryptonTextBox4";
            kryptonTextBox4.Size = new Size(262, 23);
            kryptonTextBox4.TabIndex = 23;
            // 
            // kryptonTextBox5
            // 
            kryptonTextBox5.DataBindings.Add(new Binding("Text", orderBindingSource, "ShipCountry", true));
            kryptonTextBox5.Location = new Point(570, 236);
            kryptonTextBox5.Name = "kryptonTextBox5";
            kryptonTextBox5.Size = new Size(262, 23);
            kryptonTextBox5.TabIndex = 24;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(deleteOrderDetail);
            kryptonPanel1.Controls.Add(unitPriceNumeric);
            kryptonPanel1.Controls.Add(discountNumeric);
            kryptonPanel1.Controls.Add(quantityNumeric);
            kryptonPanel1.Controls.Add(productComboBox);
            kryptonPanel1.Controls.Add(kryptonLabel14);
            kryptonPanel1.Controls.Add(kryptonLabel13);
            kryptonPanel1.Controls.Add(orderDetailDataGridView);
            kryptonPanel1.Controls.Add(kryptonLabel12);
            kryptonPanel1.Controls.Add(AddOrderDetailbutton);
            kryptonPanel1.Location = new Point(21, 301);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Palette = kryptonCustomPaletteBase;
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonPanel1.Size = new Size(1189, 373);
            kryptonPanel1.TabIndex = 25;
            // 
            // deleteOrderDetail
            // 
            deleteOrderDetail.Location = new Point(513, 57);
            deleteOrderDetail.Name = "deleteOrderDetail";
            deleteOrderDetail.Palette = kryptonCustomPaletteBase;
            deleteOrderDetail.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            deleteOrderDetail.Size = new Size(204, 21);
            deleteOrderDetail.TabIndex = 34;
            deleteOrderDetail.Values.Text = "Delete Order Detail";
            deleteOrderDetail.Click += deleteOrderDetail_Click;
            // 
            // unitPriceNumeric
            // 
            unitPriceNumeric.AllowDecimals = true;
            unitPriceNumeric.DecimalPlaces = 5;
            unitPriceNumeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            unitPriceNumeric.Location = new Point(825, 16);
            unitPriceNumeric.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            unitPriceNumeric.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            unitPriceNumeric.Name = "unitPriceNumeric";
            unitPriceNumeric.Size = new Size(185, 22);
            unitPriceNumeric.TabIndex = 33;
            unitPriceNumeric.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // discountNumeric
            // 
            discountNumeric.AllowDecimals = true;
            discountNumeric.DecimalPlaces = 1;
            discountNumeric.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            discountNumeric.Location = new Point(584, 16);
            discountNumeric.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            discountNumeric.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            discountNumeric.Name = "discountNumeric";
            discountNumeric.Size = new Size(158, 22);
            discountNumeric.TabIndex = 32;
            discountNumeric.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // quantityNumeric
            // 
            quantityNumeric.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            quantityNumeric.Location = new Point(323, 17);
            quantityNumeric.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            quantityNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantityNumeric.Name = "quantityNumeric";
            quantityNumeric.Size = new Size(185, 22);
            quantityNumeric.TabIndex = 31;
            quantityNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // productComboBox
            // 
            productComboBox.DropDownWidth = 262;
            productComboBox.IntegralHeight = false;
            productComboBox.Location = new Point(29, 57);
            productComboBox.Name = "productComboBox";
            productComboBox.Palette = kryptonCustomPaletteBase;
            productComboBox.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            productComboBox.Size = new Size(465, 21);
            productComboBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            productComboBox.TabIndex = 26;
            productComboBox.SelectedValueChanged += productComboBox_SelectedValueChanged;
            // 
            // kryptonLabel14
            // 
            kryptonLabel14.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            kryptonLabel14.Location = new Point(748, 16);
            kryptonLabel14.Name = "kryptonLabel14";
            kryptonLabel14.Palette = kryptonCustomPaletteBase;
            kryptonLabel14.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel14.Size = new Size(71, 22);
            kryptonLabel14.TabIndex = 30;
            kryptonLabel14.Values.Text = "Unit Price: ";
            // 
            // kryptonLabel13
            // 
            kryptonLabel13.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            kryptonLabel13.Location = new Point(513, 17);
            kryptonLabel13.Name = "kryptonLabel13";
            kryptonLabel13.Palette = kryptonCustomPaletteBase;
            kryptonLabel13.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel13.Size = new Size(65, 22);
            kryptonLabel13.TabIndex = 28;
            kryptonLabel13.Values.Text = "Discount: ";
            // 
            // orderDetailDataGridView
            // 
            orderDetailDataGridView.AllowUserToAddRows = false;
            orderDetailDataGridView.AllowUserToDeleteRows = false;
            orderDetailDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderDetailDataGridView.BorderStyle = BorderStyle.None;
            orderDetailDataGridView.Location = new Point(29, 101);
            orderDetailDataGridView.Name = "orderDetailDataGridView";
            orderDetailDataGridView.Palette = kryptonCustomPaletteBase;
            orderDetailDataGridView.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            orderDetailDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderDetailDataGridView.Size = new Size(1098, 247);
            orderDetailDataGridView.TabIndex = 1;
            // 
            // kryptonLabel12
            // 
            kryptonLabel12.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            kryptonLabel12.Location = new Point(252, 17);
            kryptonLabel12.Name = "kryptonLabel12";
            kryptonLabel12.Palette = kryptonCustomPaletteBase;
            kryptonLabel12.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel12.Size = new Size(65, 22);
            kryptonLabel12.TabIndex = 26;
            kryptonLabel12.Values.Text = "Quantity: ";
            // 
            // AddOrderDetailbutton
            // 
            AddOrderDetailbutton.Location = new Point(29, 16);
            AddOrderDetailbutton.Name = "AddOrderDetailbutton";
            AddOrderDetailbutton.Palette = kryptonCustomPaletteBase;
            AddOrderDetailbutton.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            AddOrderDetailbutton.Size = new Size(204, 25);
            AddOrderDetailbutton.TabIndex = 0;
            AddOrderDetailbutton.Values.Text = "New Order Detail";
            AddOrderDetailbutton.Click += AddOrderDetailbutton_Click;
            // 
            // kryptonManager
            // 
            kryptonManager.GlobalPalette = kryptonCustomPaletteBase;
            kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            // 
            // saveOrderButton
            // 
            saveOrderButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saveOrderButton.Location = new Point(981, 157);
            saveOrderButton.Name = "saveOrderButton";
            saveOrderButton.Palette = kryptonCustomPaletteBase;
            saveOrderButton.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            saveOrderButton.Size = new Size(229, 40);
            saveOrderButton.TabIndex = 32;
            saveOrderButton.Values.Text = "Save";
            saveOrderButton.Click += saveOrderButton_Click;
            // 
            // loadOrderButton
            // 
            loadOrderButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loadOrderButton.Location = new Point(981, 203);
            loadOrderButton.Name = "loadOrderButton";
            loadOrderButton.Palette = kryptonCustomPaletteBase;
            loadOrderButton.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            loadOrderButton.Size = new Size(229, 40);
            loadOrderButton.TabIndex = 33;
            loadOrderButton.Values.Text = "Load";
            loadOrderButton.Click += loadOrderButton_Click;
            // 
            // kryptonLabel15
            // 
            kryptonLabel15.DataBindings.Add(new Binding("Text", orderBindingSource, "OrderId", true));
            kryptonLabel15.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl;
            kryptonLabel15.Location = new Point(139, 21);
            kryptonLabel15.Name = "kryptonLabel15";
            kryptonLabel15.Palette = kryptonCustomPaletteBase;
            kryptonLabel15.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel15.Size = new Size(98, 31);
            kryptonLabel15.TabIndex = 34;
            kryptonLabel15.Values.Text = "00000000";
            // 
            // newOrderButton
            // 
            newOrderButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            newOrderButton.Location = new Point(981, 249);
            newOrderButton.Name = "newOrderButton";
            newOrderButton.Palette = kryptonCustomPaletteBase;
            newOrderButton.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            newOrderButton.Size = new Size(229, 40);
            newOrderButton.TabIndex = 35;
            newOrderButton.Values.Text = "New Order";
            newOrderButton.Click += newOrderButton_Click;
            // 
            // kryptonLabel16
            // 
            kryptonLabel16.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            kryptonLabel16.Location = new Point(981, 21);
            kryptonLabel16.Name = "kryptonLabel16";
            kryptonLabel16.Palette = kryptonCustomPaletteBase;
            kryptonLabel16.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel16.Size = new Size(62, 31);
            kryptonLabel16.TabIndex = 36;
            kryptonLabel16.Values.Text = "Total: ";
            kryptonLabel16.Click += kryptonLabel16_Click;
            // 
            // kryptonLabel17
            // 
            kryptonLabel17.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            kryptonLabel17.Location = new Point(981, 58);
            kryptonLabel17.Name = "kryptonLabel17";
            kryptonLabel17.Palette = kryptonCustomPaletteBase;
            kryptonLabel17.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel17.Size = new Size(95, 31);
            kryptonLabel17.TabIndex = 37;
            kryptonLabel17.Values.Text = "SubTotal: ";
            // 
            // kryptonLabel18
            // 
            kryptonLabel18.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            kryptonLabel18.Location = new Point(981, 95);
            kryptonLabel18.Name = "kryptonLabel18";
            kryptonLabel18.Palette = kryptonCustomPaletteBase;
            kryptonLabel18.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonLabel18.Size = new Size(94, 31);
            kryptonLabel18.TabIndex = 38;
            kryptonLabel18.Values.Text = "Discount:";
            // 
            // totalLabel
            // 
            totalLabel.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            totalLabel.Location = new Point(1086, 21);
            totalLabel.Name = "totalLabel";
            totalLabel.Palette = kryptonCustomPaletteBase;
            totalLabel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            totalLabel.Size = new Size(71, 31);
            totalLabel.TabIndex = 39;
            totalLabel.Values.Text = "$00.00";
            // 
            // subtotalLabel
            // 
            subtotalLabel.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            subtotalLabel.Location = new Point(1086, 58);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Palette = kryptonCustomPaletteBase;
            subtotalLabel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            subtotalLabel.Size = new Size(71, 31);
            subtotalLabel.TabIndex = 40;
            subtotalLabel.Values.Text = "$00.00";
            // 
            // discountLabel
            // 
            discountLabel.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            discountLabel.Location = new Point(1086, 95);
            discountLabel.Name = "discountLabel";
            discountLabel.Palette = kryptonCustomPaletteBase;
            discountLabel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            discountLabel.Size = new Size(71, 31);
            discountLabel.TabIndex = 41;
            discountLabel.Values.Text = "$00.00";
            // 
            // FacturationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(discountLabel);
            Controls.Add(subtotalLabel);
            Controls.Add(totalLabel);
            Controls.Add(kryptonLabel18);
            Controls.Add(kryptonLabel17);
            Controls.Add(kryptonLabel16);
            Controls.Add(newOrderButton);
            Controls.Add(kryptonLabel15);
            Controls.Add(loadOrderButton);
            Controls.Add(saveOrderButton);
            Controls.Add(kryptonPanel1);
            Controls.Add(kryptonTextBox5);
            Controls.Add(kryptonTextBox4);
            Controls.Add(kryptonTextBox3);
            Controls.Add(kryptonTextBox2);
            Controls.Add(kryptonTextBox1);
            Controls.Add(kryptonLabel7);
            Controls.Add(kryptonLabel8);
            Controls.Add(kryptonLabel9);
            Controls.Add(kryptonLabel10);
            Controls.Add(kryptonLabel11);
            Controls.Add(kryptonDateTimePicker3);
            Controls.Add(kryptonLabel6);
            Controls.Add(kryptonDateTimePicker2);
            Controls.Add(kryptonLabel5);
            Controls.Add(kryptonDateTimePicker1);
            Controls.Add(kryptonLabel4);
            Controls.Add(employeeComboBox);
            Controls.Add(kryptonLabel3);
            Controls.Add(customerComboBox);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Name = "FacturationControl";
            Size = new Size(1230, 708);
            Load += FacturationControl_Load;
            ((System.ComponentModel.ISupportInitialize)customerComboBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeComboBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productComboBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonComboBox customerComboBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonComboBox employeeComboBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox4;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox5;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonDataGridView orderDetailDataGridView;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonButton AddOrderDetailbutton;
        private Krypton.Toolkit.KryptonComboBox productComboBox;
        private BindingSource orderBindingSource;
        private Krypton.Toolkit.KryptonButton saveOrderButton;
        private Krypton.Toolkit.KryptonButton loadOrderButton;
        private Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private Krypton.Toolkit.KryptonNumericUpDown unitPriceNumeric;
        private Krypton.Toolkit.KryptonNumericUpDown discountNumeric;
        private Krypton.Toolkit.KryptonNumericUpDown quantityNumeric;
        private Krypton.Toolkit.KryptonButton newOrderButton;
        private Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private Krypton.Toolkit.KryptonLabel kryptonLabel17;
        private Krypton.Toolkit.KryptonLabel kryptonLabel18;
        private Krypton.Toolkit.KryptonLabel totalLabel;
        private Krypton.Toolkit.KryptonLabel subtotalLabel;
        private Krypton.Toolkit.KryptonLabel discountLabel;
        private Krypton.Toolkit.KryptonButton deleteOrderDetail;
    }
}
