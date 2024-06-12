using Avanzada.Proyecto1.Win.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Data.Suppliers
{
    public interface ISupplierDataProvider
    {
        IEnumerable<Supplier> GetSuppliers();
        IEnumerable<Supplier> GetSupplierById(int id);
        IEnumerable<Supplier> UpdateSupplier(Supplier supplier);
        IEnumerable<int> CreateSupplier(Supplier supplier);
        IEnumerable<Supplier> DeleteSupplier(int id);
    }
}
