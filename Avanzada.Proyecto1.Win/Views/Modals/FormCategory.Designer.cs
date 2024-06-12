namespace Avanzada.Proyecto1.Win.Views.Modals
{
    partial class FormCategory
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
            categorybindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnAccept = new Button();
            btnCancel = new Button();
            LoadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)categorybindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.DataBindings.Add(new Binding("Text", categorybindingSource, "CategoryName", true));
            textBox1.Location = new Point(12, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 23);
            textBox1.TabIndex = 1;
            // 
            // categorybindingSource
            // 
            categorybindingSource.DataSource = typeof(Models.Category);
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.DataBindings.Add(new Binding("Text", categorybindingSource, "Description", true));
            textBox2.Location = new Point(12, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // pictureBox1
            // 
            pictureBox1.DataBindings.Add(new Binding("Image", categorybindingSource, "Picture", true));
            pictureBox1.Location = new Point(12, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 134);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Image";
            // 
            // btnAccept
            // 
            btnAccept.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAccept.Location = new Point(172, 521);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(111, 26);
            btnAccept.TabIndex = 6;
            btnAccept.Text = "Aceptar";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Location = new Point(12, 521);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 26);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // LoadButton
            // 
            LoadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoadButton.Location = new Point(12, 410);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(271, 26);
            LoadButton.TabIndex = 8;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // FormCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 559);
            Controls.Add(LoadButton);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormCategory";
            Text = "Category";
            Load += FormCategory_Load;
            ((System.ComponentModel.ISupportInitialize)categorybindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnAccept;
        private Button btnCancel;
        private BindingSource categorybindingSource;
        private Button LoadButton;
    }
}