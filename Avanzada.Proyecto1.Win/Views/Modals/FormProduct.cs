using Avanzada.Proyecto1.Win.Data.Categories;
using Avanzada.Proyecto1.Win.Data.Products;
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
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avanzada.Proyecto1.Win.Views
{
    public partial class FormProduct : Form
    {
        private List<Category> categories;
        private ICategoryDataProvider _categoryDataProvider;
        private ISupplierDataProvider _supplierDataProvider;
        private IProductDataProvider _productDataProvider;
        private IValidator<Product> _validator;

        public ModalMode modalMode;

        public Product viewmodel = new Product();

        public FormProduct(ICategoryDataProvider categoryDataProvider, ISupplierDataProvider supplierDataProvider, IValidator<Product> validator, IProductDataProvider productDataProvider)
        {
            InitializeComponent();
            this._categoryDataProvider = categoryDataProvider;
            this._supplierDataProvider = supplierDataProvider;
            this._productDataProvider = productDataProvider;
            this._validator = validator;
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            if (this.modalMode == ModalMode.Create)
            {
                viewmodel = new Product();
            }

            productBindingSource.Clear();

            categoryCombobox.DataSource = _categoryDataProvider.GetCategories().ToList();
            categoryCombobox.DisplayMember = nameof(Category.CategoryName);
            categoryCombobox.ValueMember = nameof(Category.CategoryID);

            supplierCombobox.DataSource = _supplierDataProvider.GetSuppliers().ToList();
            supplierCombobox.DisplayMember = nameof(Supplier.CompanyName);
            supplierCombobox.ValueMember = nameof(Supplier.SupplierID);

            productBindingSource.Add(viewmodel);

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            viewmodel.SupplierName = supplierCombobox.Text;
            viewmodel.CategoryName = categoryCombobox.Text;
            ValidationResult resultsValidation = _validator.Validate(viewmodel);
            if (resultsValidation.IsValid)
            {
                if (modalMode == ModalMode.Edit)
                {
                    _productDataProvider.UpdateProduct(viewmodel);

                }
                else if (modalMode == ModalMode.Create)
                {
                    viewmodel.ProductID = _productDataProvider.CreateProduct(viewmodel).First();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Join("\n",
                resultsValidation.Errors.ToList()), "Errors in fields",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void FormProduct_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
