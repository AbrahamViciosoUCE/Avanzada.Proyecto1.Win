using Avanzada.Proyecto1.Win.Data.Customer;
using Avanzada.Proyecto1.Win.Data.Employee;
using Avanzada.Proyecto1.Win.Data.Order;
using Avanzada.Proyecto1.Win.Data.OrderDetails;
using Avanzada.Proyecto1.Win.Data.Products;
using Avanzada.Proyecto1.Win.Data.Suppliers;
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
    public partial class FacturationControlCopy : UserControl
    {
        public DataModel.Order orderViewModel;
        public BindingList<Models.OrderDetail> orderDetailsBindingList;

        public FormSelectOrder _formSelectOrder;

        public ModalMode modalMode = ModalMode.Create;

        //DATASOURCE
        IProductDataProvider _productDataProvider;
        IOrderDataProvider _orderDataProvider;
        ISupplierDataProvider _supplierDataProvider;
        IEmployeeDataProvider _employeeDataProvider;
        ICustomerDataProvider _customerDataProvider;
        IOrderDetailDataProvider _orderDetailDataProvider;

        public FacturationControlCopy(
            IProductDataProvider productDataProvider,
            IOrderDataProvider orderDataProvider,
            ISupplierDataProvider supplierDataProvider,
            IEmployeeDataProvider employeeDataProvider,
            ICustomerDataProvider customerDataProvider,
            IOrderDetailDataProvider orderDetailDataProvider,
            FormSelectOrder formSelectOrder
            )
        {
            _orderDetailDataProvider = orderDetailDataProvider;
            _formSelectOrder = formSelectOrder;
            _productDataProvider = productDataProvider;
            _orderDataProvider = orderDataProvider;
            _supplierDataProvider = supplierDataProvider;
            _employeeDataProvider = employeeDataProvider;
            _customerDataProvider = customerDataProvider;

            InitializeComponent();
        }

        private void FacturationControlCopy_Load(object sender, EventArgs e)
        {
            //ORDER DETAIL
            orderDetailsBindingList = new BindingList<Models.OrderDetail>();
            orderDetaildataGridView.DataSource = orderDetailsBindingList;

            //ORDER BINDING SOURCE
            orderViewModel = new DataModel.Order();
            OrderbindingSource.DataSource = orderViewModel;

            //LOAD COMBOBOX PRODUCTS ADD
            productComboBox.DataSource = _productDataProvider.GetProductsWithEF();
            productComboBox.ValueMember = nameof(DataModel.Product.ProductId);
            productComboBox.DisplayMember = nameof(DataModel.Product.ProductName);

            //LOAD COMBOBOX CUSTOMER ORDER
            customerComboBox.DataSource = _customerDataProvider.GetCustomers();
            customerComboBox.DisplayMember = nameof(DataModel.Customer.CompanyName);
            customerComboBox.ValueMember = nameof(DataModel.Customer.CustomerId);

            //LOAD COMBOBOX EMPLOYEE ORDER
            employeeComboBox.DataSource = _employeeDataProvider.GetEmployees();
            employeeComboBox.DisplayMember = nameof(DataModel.Employee.FirstName);
            employeeComboBox.ValueMember = nameof(DataModel.Employee.EmployeeId);
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            int ProductIdSelected = int.Parse(productComboBox.SelectedValue.ToString());

            Models.Product productSelected = _productDataProvider.GetProductByIdFullyColumns(ProductIdSelected).First();

            if (orderDetailsBindingList.Where(x => x.ProductId == ProductIdSelected).Count() == 1)
            {
                orderDetailsBindingList.Where(x => x.ProductId == ProductIdSelected).First().Quantity += short.Parse(quantityTextBox.Text);
            }
            else
            {
                orderDetailsBindingList.Add(new Models.OrderDetail()
                {
                    ProductId = ProductIdSelected,
                    ProductName = productSelected.ProductName,
                    Discount = float.Parse(discountTextBox.Text),
                    Quantity = short.Parse(quantityTextBox.Text),
                    CategoryName = productSelected.CategoryName,
                    OrderId = orderViewModel.OrderId,
                    UnitPrice = decimal.Parse(PricetextBox.Text),
                });
            }

            orderDetailsBindingList.ResetBindings();
            CalculateAmount();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            orderViewModel.OrderDetails = orderDetailsBindingList.Select(x => new DataModel.OrderDetail()
            {
                ProductId = x.ProductId,
                Quantity = x.Quantity,
                Discount = x.Discount,
                UnitPrice = x.UnitPrice,
                OrderId = x.OrderId,
                Order = orderViewModel
            }).ToList();

            if (modalMode == ModalMode.Create)
            {
                orderViewModel = _orderDataProvider.CreateOrder(orderViewModel);
            }
            else
            {
                orderViewModel = _orderDataProvider.UpdateOrder(orderViewModel);
            }

            orderDetailsBindingList = new BindingList<Models.OrderDetail>(
                orderViewModel.OrderDetails.Select(x => new Models.OrderDetail()
                {
                    OrderId = x.OrderId,
                    ProductId = x.ProductId,
                    ProductName = x.Product.ProductName,
                    Discount = x.Discount,
                    Quantity = x.Quantity
                })
                .ToList()
             );

            orderDetailsBindingList.ResetBindings();
            OrderbindingSource.ResetBindings(false);

            modalMode = ModalMode.Edit;
        }

        private void loadOrderButton_Click(object sender, EventArgs e)
        {
            if (_formSelectOrder.ShowDialog() == DialogResult.OK)
            {
                orderViewModel = _formSelectOrder.orderViewModel;
                OrderbindingSource.DataSource = orderViewModel;
                OrderbindingSource.ResetBindings(false);

                orderDetailsBindingList = new BindingList<Models.OrderDetail>
                    (
                        _orderDetailDataProvider.GetOrderDetailsByOrderId(orderViewModel.OrderId).ToList()
                    );
                orderDetaildataGridView.DataSource = orderDetailsBindingList;
                orderDetailsBindingList.ResetBindings();
                modalMode = ModalMode.Edit;
            }
            CalculateAmount();
        }

        private void LoadDataInBindingList(ICollection<Models.OrderDetail> orderDetails)
        {
            //<summary>
            //  Load order detail passing between objects, -SIMILAR A UN DTO ME DA PEREZA  USAR MAPPER-
            //</summary>
            orderDetailsBindingList = new BindingList<Models.OrderDetail>(
                orderDetails.Select(x => new Models.OrderDetail()
                {
                    OrderId = x.OrderId,
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    Discount = x.Discount,
                    Quantity = x.Quantity
                }).ToList()
             );
            orderDetailsBindingList.ResetBindings();
        }

        private List<DataModel.OrderDetail> ViewModelOrderDetailToOrderDetailData(List<Models.OrderDetail> orderDetails)
        {
            return orderDetails.Select(x => new DataModel.OrderDetail()
            {
                ProductId = x.ProductId,
                Discount = x.Discount,
                Quantity = x.Quantity,
                OrderId = x.OrderId,
                UnitPrice = x.UnitPrice
            }).ToList();
        }

        private void productComboBox_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(productComboBox.SelectedValue.ToString(), out int value))
            {
                PricetextBox.Text = _productDataProvider.GetProductByIdFullyColumns(value).First().UnitPrice.ToString();
            }

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            orderViewModel = new Order();
            OrderbindingSource.DataSource = orderViewModel;
            orderDetailsBindingList.Clear();
            orderDetailsBindingList.ResetBindings();
            OrderbindingSource.ResetBindings(false);
        }

        private void CalculateAmount()
        {
            subTotalLabel.Text = orderDetailsBindingList.Sum(x => x.UnitPrice * x.Quantity).ToString();
            discountLabel.Text = orderDetailsBindingList.Sum(x => (x.UnitPrice * decimal.Parse(x.Discount.ToString())) * x.Quantity).ToString();
            totalLabel.Text = orderDetailsBindingList.Sum(x => (x.UnitPrice * x.Quantity) - (x.UnitPrice * decimal.Parse(x.Discount.ToString())) * x.Quantity).ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            orderDetailsBindingList.RemoveAt(orderDetaildataGridView.SelectedRows[0].Index);
        }
    }
}
