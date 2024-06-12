using Avanzada.Proyecto1.Win.Data.Suppliers;
using Avanzada.Proyecto1.Win.Models;
using Avanzada.Proyecto1.Win.Views.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avanzada.Proyecto1.Win.Views.Controls
{
    public partial class SuppliersListControl : UserControl
    {
        BindingList<Supplier> suppliersBindingList;

        ISupplierDataProvider _supplierDataProvider;

        FormSupplier _formSupplier;

        public SuppliersListControl(ISupplierDataProvider supplierDataProvider, FormSupplier formSupplier)
        {
            _formSupplier = formSupplier;
            _supplierDataProvider = supplierDataProvider;
            InitializeComponent();
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            _formSupplier.modalMode = ModalMode.Create;
            if (_formSupplier.ShowDialog() == DialogResult.OK)
            {
                suppliersBindingList.Add(
                    _supplierDataProvider.GetSupplierById(_formSupplier.viewmodel.SupplierID)
                    .First()
                );
            }
        }

        private void SuppliersListControl_Load(object sender, EventArgs e)
        {
            suppliersBindingList = new BindingList<Supplier>(_supplierDataProvider.GetSuppliers().ToList());
            dataGridSuppliers.DataSource = suppliersBindingList;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Supplier supplierSelected = dataGridSuppliers.SelectedRows[0].DataBoundItem as Supplier;
            _formSupplier.modalMode = ModalMode.Edit;
            _formSupplier.viewmodel = supplierSelected;
            if (_formSupplier.ShowDialog() == DialogResult.OK)
            {
                supplierSelected = _formSupplier.viewmodel;
                suppliersBindingList.ResetItem(dataGridSuppliers.SelectedRows[0].Index);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this item? ", "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                ) == DialogResult.Yes)

            {
                _supplierDataProvider.DeleteSupplier((dataGridSuppliers.SelectedRows[0].DataBoundItem as Supplier)
                    .SupplierID);

                suppliersBindingList.Remove(dataGridSuppliers.SelectedRows[0].DataBoundItem as Supplier);

            }
        }
    }
}
