using Avanzada.Proyecto1.Win.Data.Categories;
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
    public partial class CategoriesListControl : UserControl
    {
        private BindingList<Category> categoryBindingList;

        public ICategoryDataProvider _categoryDataProvider;
        public FormCategory _formCategory;
        public CategoriesListControl(ICategoryDataProvider categoryDataProvider, FormCategory formCategory)
        {
            _categoryDataProvider = categoryDataProvider;
            _formCategory = formCategory;
            InitializeComponent();
        }

        private void CategoriesListControl_Load(object sender, EventArgs e)
        {
            categoryBindingList = new BindingList<Category>(_categoryDataProvider.GetCategories().ToList());
            categoryDatagridview.DataSource = categoryBindingList;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Category categorySelected = categoryDatagridview.SelectedRows[0].DataBoundItem as Category;
            _formCategory.modalMode = ModalMode.Edit;
            _formCategory.viewmodel = categorySelected;
            if(_formCategory.ShowDialog() == DialogResult.OK)
            {
                categorySelected = _formCategory.viewmodel;
                categoryBindingList.ResetItem(categoryDatagridview.SelectedRows[0].Index);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this item? ", "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                ) == DialogResult.Yes)

            {
                _categoryDataProvider.DeleteCategory((categoryDatagridview.SelectedRows[0].DataBoundItem as Category)
                     .CategoryID);

                categoryBindingList.Remove(categoryDatagridview.SelectedRows[0].DataBoundItem as Category);
            }
            
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            _formCategory.modalMode = ModalMode.Create;
            if (_formCategory.ShowDialog() == DialogResult.OK)
            {
                categoryBindingList.Add(_formCategory.viewmodel);
            }
        }
    }
}
