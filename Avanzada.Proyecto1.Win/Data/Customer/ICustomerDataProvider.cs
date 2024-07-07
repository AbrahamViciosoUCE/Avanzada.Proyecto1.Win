using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Data.Customer
{
    public interface ICustomerDataProvider
    {
        IEnumerable<DataModel.Customer> GetCustomers();
    }
}
