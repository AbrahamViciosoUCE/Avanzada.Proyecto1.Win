namespace Avanzada.Proyecto1.Win.Views.Modals
{
    partial class FormSupplier
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
            textBox1 = new TextBox();
            supplierbindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            textBox10 = new TextBox();
            label10 = new Label();
            textBox11 = new TextBox();
            label11 = new Label();
            textBox12 = new TextBox();
            label12 = new Label();
            button2 = new Button();
            SubmitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)supplierbindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "CompanyName";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.DataBindings.Add(new Binding("Text", supplierbindingSource, "CompanyName", true));
            textBox1.Location = new Point(12, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 23);
            textBox1.TabIndex = 1;
            // 
            // supplierbindingSource
            // 
            supplierbindingSource.DataSource = typeof(Models.Supplier);
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.DataBindings.Add(new Binding("Text", supplierbindingSource, "ContactName", true));
            textBox2.Location = new Point(12, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(294, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "ContactName";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.DataBindings.Add(new Binding("Text", supplierbindingSource, "Address", true));
            textBox3.Location = new Point(12, 197);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(294, 23);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Address";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.DataBindings.Add(new Binding("Text", supplierbindingSource, "ContactTitle", true));
            textBox4.Location = new Point(12, 145);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(294, 23);
            textBox4.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(12, 123);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 4;
            label4.Text = "ContactTitle";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.DataBindings.Add(new Binding("Text", supplierbindingSource, "Country", true));
            textBox5.Location = new Point(12, 405);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(294, 23);
            textBox5.TabIndex = 15;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(12, 383);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 14;
            label5.Text = "Country";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.DataBindings.Add(new Binding("Text", supplierbindingSource, "PostalCode", true));
            textBox6.Location = new Point(12, 353);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(294, 23);
            textBox6.TabIndex = 13;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(12, 331);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 12;
            label6.Text = "PostalCode";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.DataBindings.Add(new Binding("Text", supplierbindingSource, "Region", true));
            textBox7.Location = new Point(12, 301);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(294, 23);
            textBox7.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(12, 279);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 10;
            label7.Text = "Region";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox8.DataBindings.Add(new Binding("Text", supplierbindingSource, "City", true));
            textBox8.Location = new Point(12, 249);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(294, 23);
            textBox8.TabIndex = 9;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(12, 227);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 8;
            label8.Text = "City";
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox10.DataBindings.Add(new Binding("Text", supplierbindingSource, "HomePage", true));
            textBox10.Location = new Point(12, 561);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(294, 23);
            textBox10.TabIndex = 21;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(12, 539);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 20;
            label10.Text = "HomePage";
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox11.DataBindings.Add(new Binding("Text", supplierbindingSource, "Fax", true));
            textBox11.Location = new Point(12, 509);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(294, 23);
            textBox11.TabIndex = 19;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(12, 487);
            label11.Name = "label11";
            label11.Size = new Size(25, 15);
            label11.TabIndex = 18;
            label11.Text = "Fax";
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox12.DataBindings.Add(new Binding("Text", supplierbindingSource, "Phone", true));
            textBox12.Location = new Point(12, 457);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(294, 23);
            textBox12.TabIndex = 17;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(12, 435);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 16;
            label12.Text = "Phone";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(12, 609);
            button2.Name = "button2";
            button2.Size = new Size(104, 28);
            button2.TabIndex = 26;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SubmitBtn.Location = new Point(202, 609);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(104, 28);
            SubmitBtn.TabIndex = 25;
            SubmitBtn.Text = "Accept";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // FormSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 649);
            Controls.Add(button2);
            Controls.Add(SubmitBtn);
            Controls.Add(textBox10);
            Controls.Add(label10);
            Controls.Add(textBox11);
            Controls.Add(label11);
            Controls.Add(textBox12);
            Controls.Add(label12);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormSupplier";
            Text = "FormSupplier";
            Load += FormSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)supplierbindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox10;
        private Label label10;
        private TextBox textBox11;
        private Label label11;
        private TextBox textBox12;
        private Label label12;
        private Button button2;
        private Button SubmitBtn;
        private BindingSource supplierbindingSource;
    }
}