using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Data.Order
{
    public interface IOrderDataProvider
    {
        public DataModel.Order CreateOrder(DataModel.Order order);
        public IEnumerable<DataModel.Order> GetOrders();
        public DataModel.Order UpdateOrder(DataModel.Order order);
        public void DeleteOrder(DataModel.Order order);
    }
}
