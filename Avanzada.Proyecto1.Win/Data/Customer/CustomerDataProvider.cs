using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Data.Customer
{
    public class CustomerDataProvider: ICustomerDataProvider
    {
        IEnumerable<DataModel.Customer> ICustomerDataProvider.GetCustomers()
        {
            using (NorthWindContext db = new NorthWindContext())
            {
                return db.Customers.ToList();
            }
        }
    }
}
