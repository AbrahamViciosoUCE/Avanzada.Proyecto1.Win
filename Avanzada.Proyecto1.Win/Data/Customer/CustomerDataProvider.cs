using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Data.Customer
{
    public class CustomerDataProvider: ICustomerDataProvider
    {
        NorthWindContext _NorthWindContext;
        public CustomerDataProvider(NorthWindContext northWindContext) { 
            _NorthWindContext = northWindContext;
        }
        IEnumerable<DataModel.Customer> ICustomerDataProvider.GetCustomers()
        {
           return _NorthWindContext.Customers.ToList();
        }
    }
}
