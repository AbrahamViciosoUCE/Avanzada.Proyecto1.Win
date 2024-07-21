using Avanzada.Proyecto1.Win.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Data.OrderDetails
{
    public class OrderDetailDataProvider : IOrderDetailDataProvider
    {
        NorthWindContext _northwindContext;
        public OrderDetailDataProvider(NorthWindContext northWindContext) { 
            _northwindContext = northWindContext;
        }
        public IEnumerable<Models.OrderDetail> GetOrderDetailsByOrderId(int id)
        {
            return _northwindContext.OrderDetails
                .Where(x => x.OrderId == id)
                .Select(x => new Models.OrderDetail()
            {
                OrderId = x.OrderId,
                ProductId = x.ProductId,
                Discount = x.Discount,
                ProductName = x.Product.ProductName,
                Quantity = x.Quantity,
                UnitPrice = x.UnitPrice,
            });
        }
    }
}
