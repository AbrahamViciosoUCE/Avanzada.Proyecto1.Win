using Avanzada.Proyecto1.Win.Data.Customer;
using Avanzada.Proyecto1.Win.DataModel;
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
    public partial class FacturationControl : UserControl
    {
        private ICustomerDataProvider _customerDataProvider;
        public FacturationControl(
                ICustomerDataProvider customerDataProvider
            )
        {
            _customerDataProvider = customerDataProvider;
            InitializeComponent();
        }

        private void FacturationControl_Load(object sender, EventArgs e)
        {
            CustomercomboBox.DataSource = _customerDataProvider.GetCustomers();
            CustomercomboBox.DisplayMember = nameof(Customer.CompanyName);
            CustomercomboBox.ValueMember = nameof(Customer.CustomerId);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
