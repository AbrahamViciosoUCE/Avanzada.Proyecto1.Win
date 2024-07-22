using Avanzada.Proyecto1.Win.Data.Customer;
using Avanzada.Proyecto1.Win.Data.Employee;
using Avanzada.Proyecto1.Win.Data.Order;
using Avanzada.Proyecto1.Win.Data.OrderDetails;
using Avanzada.Proyecto1.Win.Data.Products;
using Avanzada.Proyecto1.Win.DataModel;
using Avanzada.Proyecto1.Win.Models;
using Avanzada.Proyecto1.Win.Views.Modals;
using System;
using System.Collections.Frozen;
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
        //DATA SOURCE
        private IOrderDataProvider _orderDataProvider;
        private ICustomerDataProvider _customerDataProvider;
        private IEmployeeDataProvider _employeeDataProvider;
        private IProductDataProvider _productDataProvider;
        private IOrderDetailDataProvider _orderDetailDataProvider;

        private FormSelectOrder formSelectOrder;

        // Control Properties
        public Order orderViewModel = new Order()
        {
            OrderDate = DateTime.Now,
            RequiredDate = DateTime.Now,
            ShippedDate = DateTime.Now,
        };
        public ModalMode modalMode = ModalMode.Create;

        public BindingList<DataModel.OrderDetail> orderDetailsBindingList;

        public FacturationControl(
            IOrderDataProvider orderDataProvider,
            ICustomerDataProvider customerDataProvider,
            IEmployeeDataProvider employeeDataProvider,
            IProductDataProvider productDataProvider,
            IOrderDetailDataProvider orderDetailDataProvider,
            FormSelectOrder formSelectOrder
            )
        {
            _orderDetailDataProvider = orderDetailDataProvider;
            _employeeDataProvider = employeeDataProvider;
            _orderDataProvider = orderDataProvider;
            _customerDataProvider = customerDataProvider;
            _productDataProvider = productDataProvider;
            this.formSelectOrder = formSelectOrder;
            InitializeComponent();
        }

        private void FacturationControl_Load(object sender, EventArgs e)
        {
            //--------------

            orderBindingSource.DataSource = orderViewModel;

            orderDetailsBindingList = new BindingList<DataModel.OrderDetail>(orderViewModel.OrderDetails.ToList());

            orderDetailDataGridView.DataSource = orderDetailsBindingList;
            //--------------

            //LOAD CUSTOMER DATA IN COMBOBOX 
            customerComboBox.DataSource = _customerDataProvider.GetCustomers();
            customerComboBox.DisplayMember = nameof(Customer.CompanyName);
            customerComboBox.ValueMember = nameof(Customer.CustomerId);

            //LOAD EMPLOYEE DATA IN COMBOBOX
            employeeComboBox.DataSource = _employeeDataProvider.GetEmployees();
            employeeComboBox.DisplayMember = nameof(Employee.FirstName);
            employeeComboBox.ValueMember = nameof(Employee.EmployeeId);

            // LOAD PRODUCT DATA IN COMBOBOX
            productComboBox.DataSource = _productDataProvider.GetProducts().ToList();
            productComboBox.DisplayMember = nameof(Models.Product.ProductName);
            productComboBox.ValueMember = nameof(Models.Product.ProductId);
        }

        private void AddOrderDetailbutton_Click(object sender, EventArgs e)
        {
            DataModel.Product productSelected = _productDataProvider.GetProductByID(int.Parse(productComboBox.SelectedValue.ToString()))
                .Select(x => new DataModel.Product()
                {
                    ProductId = x.ProductId,
                    UnitPrice = x.UnitPrice,
                })
                .First();

            if (orderDetailsBindingList.Where(x => x.ProductId == productSelected.ProductId).Count() == 0)
            {
                orderDetailsBindingList.Add(new DataModel.OrderDetail()
                {
                    ProductId = productSelected.ProductId,
                    Quantity = short.Parse(quantityNumeric.Text),
                    Discount = float.Parse(discountNumeric.Text),
                    UnitPrice = decimal.Parse(unitPriceNumeric.Text),
                    OrderId = orderViewModel.OrderId,
                });
            }
            else
            {
                orderDetailsBindingList.Where(x => x.ProductId == productSelected.ProductId)
                    .First().Quantity += short.Parse(quantityNumeric.Text);
                orderDetailsBindingList.ResetBindings();
            }
            calculateMonery();
        }

        private void saveOrderButton_Click(object sender, EventArgs e)
        {
            orderViewModel.OrderDetails = orderDetailsBindingList.ToList();
            if (modalMode == ModalMode.Create)
            {
                orderViewModel = _orderDataProvider.CreateOrder(orderViewModel);
            }
            else if (modalMode == ModalMode.Edit)
            {
                orderViewModel = _orderDataProvider.UpdateOrder(orderViewModel);
            }
            orderBindingSource.ResetBindings(false);
            orderDetailsBindingList.ResetBindings();
            modalMode = ModalMode.Edit;
            calculateMonery();
        }

        private void productComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(productComboBox.SelectedValue.ToString(), out int value))
            {
                unitPriceNumeric.Text = _productDataProvider.GetProductByID(value)
                    .First().UnitPrice
                    .ToString();
            }
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            orderViewModel = new Order();
            orderBindingSource.DataSource = orderViewModel;
            reloadOrderDetail();
        }

        private void reloadOrderDetail()
        {
            orderDetailsBindingList = new BindingList<DataModel.OrderDetail>(orderViewModel.OrderDetails.ToList());
            orderDetailDataGridView.DataSource = orderDetailsBindingList;
            calculateMonery();
        }

        private void loadOrderButton_Click(object sender, EventArgs e)
        {
            if (formSelectOrder.ShowDialog() == DialogResult.OK)
            {
                orderViewModel = formSelectOrder.orderViewModel;
                orderViewModel.OrderDetails = _orderDetailDataProvider.GetOrderDetailsByOrderId(orderViewModel.OrderId).ToList();

                orderBindingSource.DataSource = orderViewModel;

                reloadOrderDetail();
            }
            modalMode = ModalMode.Edit;
        }

        private void calculateMonery()
        {
            subtotalLabel.Text = orderDetailsBindingList.Sum(x => x.UnitPrice * x.Quantity).ToString();
            discountLabel.Text = orderDetailsBindingList.Sum(x => (float.Parse(x.UnitPrice.ToString()) * x.Discount) * x.Quantity).ToString();
            totalLabel.Text = (decimal.Parse(subtotalLabel.Text) - decimal.Parse(discountLabel.Text)).ToString();
        }

        private void kryptonLabel16_Click(object sender, EventArgs e)
        {

        }
    }
}
