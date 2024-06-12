using Avanzada.Proyecto1.Win.Data.Categories;
using Avanzada.Proyecto1.Win.Models;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avanzada.Proyecto1.Win.Views.Modals
{
    public partial class FormCategory : Form
    {
        public Category viewmodel = new Category();
        public ModalMode modalMode;
        private ICategoryDataProvider _categoryDataProvider;
        private IValidator<Category> _validator;
        public FormCategory(ICategoryDataProvider categoryDataProvider, IValidator<Category> validator)
        {
            _categoryDataProvider = categoryDataProvider;
            _validator = validator;
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            if (modalMode == ModalMode.Create)
            {
                this.viewmodel = new Category();
            }
            categorybindingSource.DataSource = viewmodel;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ValidationResult validationResult = _validator.Validate(viewmodel);
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, ImageFormat.Png);
                    viewmodel.Picture = ms.ToArray();
                }
            }
            if (validationResult.IsValid)
            {
                if (modalMode == ModalMode.Edit)
                {
                    _categoryDataProvider.UpdateCategory(viewmodel);

                }
                else if (modalMode == ModalMode.Create)
                {
                    int IdCategoryCreated = _categoryDataProvider.CreateCategory(viewmodel).First();
                    viewmodel = _categoryDataProvider.GetCategoryById(IdCategoryCreated).First();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Join("\n",
                validationResult.Errors.ToList()), "Errors in fields",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
