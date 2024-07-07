using Avanzada.Proyecto1.Win.Data.Products;
using Avanzada.Proyecto1.Win.Views;
using Avanzada.Proyecto1.Win.Views.Controls;
using Microsoft.Extensions.Configuration;

namespace Avanzada.Proyecto1.Win
{
    public partial class MainForm : Form
    {
        public IConfiguration _configuration;
        public IProductDataProvider _productDataProvider;
        public FormProduct _formproduct;
        public ProductListControl _productListControl;
        public CategoriesListControl _categoriesListControl;
        public SuppliersListControl _suppliersListControl;
        public FacturationControl _facturationControl;

        public MainForm(
            IConfiguration configuration,
            ProductListControl productListControl,
            CategoriesListControl categoriesListControl,
            SuppliersListControl suppliersListControl,
            FacturationControl facturationControl
            )
        {
            _configuration = configuration;
            _productListControl = productListControl;
            _categoriesListControl = categoriesListControl;
            _suppliersListControl = suppliersListControl;
            _facturationControl = facturationControl;
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            _productListControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(_productListControl);
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            _categoriesListControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(_categoriesListControl);
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            _suppliersListControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(_suppliersListControl);
        }

        private void facturationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            _facturationControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(_facturationControl);
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
        }
    }
}
