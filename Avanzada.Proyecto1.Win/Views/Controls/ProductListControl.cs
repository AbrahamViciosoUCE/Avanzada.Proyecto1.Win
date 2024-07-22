using Avanzada.Proyecto1.Win.Data.Products;
using Avanzada.Proyecto1.Win.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avanzada.Proyecto1.Win.Views.Controls
{
    public partial class ProductListControl : UserControl
    {
        FormProduct _formproduct;
        IProductDataProvider _productDataProvider;

        private new BindingList<Product> productsBindingList = null;
        public ProductListControl(FormProduct formProduct, IProductDataProvider productDataProvider)
        {
            InitializeComponent();
            _productDataProvider = productDataProvider;
            _formproduct = formProduct;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Product selectedProduct = ProductsDataGrid.SelectedRows[0].DataBoundItem as Product;
            _formproduct.modalMode = ModalMode.Edit;
            _formproduct.viewmodel = selectedProduct;
            if (this._formproduct.ShowDialog() == DialogResult.OK)
            {
                selectedProduct = _formproduct.viewmodel;
                productsBindingList.ResetItem(ProductsDataGrid.SelectedRows[0].Index);
            }
        }

        private void ProductListControl_Load(object sender, EventArgs e)
        {
            productsBindingList = new BindingList<Product>(_productDataProvider.GetProducts().ToList());
            ProductsDataGrid.DataSource = productsBindingList;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            this._formproduct.modalMode = Models.ModalMode.Create;
            if (this._formproduct.ShowDialog() == DialogResult.OK)
            {
                productsBindingList.Add(
                    _productDataProvider.GetProductByID(_formproduct.viewmodel.ProductId)
                    .First()
                );
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this item? ", "Confirmation", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                ) == DialogResult.Yes)
            {
                _productDataProvider.DeleteProduct((ProductsDataGrid.SelectedRows[0].DataBoundItem as Product).ProductId);
                productsBindingList.Remove(ProductsDataGrid.SelectedRows[0].DataBoundItem as Product);
            }
        }
    }
}
