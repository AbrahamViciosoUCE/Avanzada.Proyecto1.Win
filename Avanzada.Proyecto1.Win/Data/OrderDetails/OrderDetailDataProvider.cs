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
        public IEnumerable<DataModel.OrderDetail> GetOrderDetailsByOrderId(int id)
        {
            return _northwindContext.OrderDetails
                .Where(x => x.OrderId == id);
        }
    }
}
