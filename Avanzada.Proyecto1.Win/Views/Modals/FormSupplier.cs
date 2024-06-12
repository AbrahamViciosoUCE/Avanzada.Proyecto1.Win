using Avanzada.Proyecto1.Win.Data.Suppliers;
using Avanzada.Proyecto1.Win.Models;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avanzada.Proyecto1.Win.Views.Modals
{
    public partial class FormSupplier : Form
    {
        public Supplier viewmodel = new Supplier();
        public ModalMode modalMode;
        private IValidator<Supplier> _validator;
        private ISupplierDataProvider _supplierDataProvider;

        public FormSupplier(ISupplierDataProvider supplierDataProvider, IValidator<Supplier> validator)
        {
            _validator = validator;
            _supplierDataProvider = supplierDataProvider;
            InitializeComponent();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            if (modalMode == ModalMode.Create)
            {
                viewmodel = new Supplier();
            }
            supplierbindingSource.Clear();
            supplierbindingSource.Add(viewmodel);
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            ValidationResult validationResult = _validator.Validate(viewmodel);
            if (validationResult.IsValid)
            {
                if (modalMode == ModalMode.Edit)
                {
                    _supplierDataProvider.UpdateSupplier(viewmodel);
                }
                else if (modalMode == ModalMode.Create)
                {
                    viewmodel.SupplierID = _supplierDataProvider.CreateSupplier(viewmodel).First();
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(string.Join("\n",
                validationResult.Errors.ToList()), "Errors in fields",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
