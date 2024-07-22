using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Data.OrderDetails
{
    public interface IOrderDetailDataProvider
    {
        IEnumerable<DataModel.OrderDetail> GetOrderDetailsByOrderId(int id);  
    }
}
