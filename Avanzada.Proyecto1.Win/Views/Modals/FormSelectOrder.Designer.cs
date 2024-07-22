namespace Avanzada.Proyecto1.Win.Views.Modals
{
    partial class FormSelectOrder
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
            OrderdataGridView = new DataGridView();
            acceptButton = new Button();
            cancelButton = new Button();
            refreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)OrderdataGridView).BeginInit();
            SuspendLayout();
            // 
            // OrderdataGridView
            // 
            OrderdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderdataGridView.Location = new Point(12, 12);
            OrderdataGridView.Name = "OrderdataGridView";
            OrderdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderdataGridView.Size = new Size(328, 503);
            OrderdataGridView.TabIndex = 1;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(191, 566);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(149, 34);
            acceptButton.TabIndex = 2;
            acceptButton.Text = "Accept";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(12, 566);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(149, 34);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(12, 521);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(328, 34);
            refreshButton.TabIndex = 4;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // FormSelectOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 614);
            Controls.Add(refreshButton);
            Controls.Add(cancelButton);
            Controls.Add(acceptButton);
            Controls.Add(OrderdataGridView);
            Name = "FormSelectOrder";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormSelectOrder";
            Load += FormSelectOrder_Load;
            ((System.ComponentModel.ISupportInitialize)OrderdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView OrderdataGridView;
        private Button acceptButton;
        private Button cancelButton;
        private Button refreshButton;
    }
}