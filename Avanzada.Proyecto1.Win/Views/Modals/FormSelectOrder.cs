using Avanzada.Proyecto1.Win.Data.Order;
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

namespace Avanzada.Proyecto1.Win.Views.Modals
{
    public partial class FormSelectOrder : Form
    {
        public Order orderViewModel;
        BindingList<Order> bindingOrderList;
        IOrderDataProvider _orderDataProvider;
        public FormSelectOrder(IOrderDataProvider orderDataProvider)
        {
            _orderDataProvider = orderDataProvider;
            InitializeComponent();
            refreshData();
        }

        private void FormSelectOrder_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            orderViewModel = OrderdataGridView.SelectedRows[0].DataBoundItem as Order;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
            bindingOrderList = new BindingList<Order>(_orderDataProvider.GetOrders().ToList());
            OrderdataGridView.DataSource = bindingOrderList;
        }
    }
}
