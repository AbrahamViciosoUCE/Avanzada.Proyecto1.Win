using Avanzada.Proyecto1.Win.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Data.Order
{
    public class OrderDataProvider : IOrderDataProvider
    {
        NorthWindContext _northWindContext { get; set; }
        public OrderDataProvider(NorthWindContext northWindContext) 
        { 
            _northWindContext = northWindContext;
        }
        public DataModel.Order CreateOrder(DataModel.Order order)
        {
            _northWindContext.Orders.Add(order);
            _northWindContext.SaveChanges();
            return order;
        }

        public IEnumerable<DataModel.Order> GetOrders()
        {
            return _northWindContext.Orders;
        }

        public DataModel.Order UpdateOrder(DataModel.Order order)
        {
            _northWindContext.Orders.Update(order);
            _northWindContext.SaveChanges();
            return order;
        }

        public void DeleteOrder(DataModel.Order order)
        {
            _northWindContext.Orders.Remove(order);
            _northWindContext.SaveChanges();
        }
    }
}
