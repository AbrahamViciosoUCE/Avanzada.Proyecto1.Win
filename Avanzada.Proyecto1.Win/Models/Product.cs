using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public int SupplierID { get; set; }
        public string? SupplierName { get; set; }
        public string? CategoryName { get; set; }
        public int CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
        public string? QuantityPerUnit { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
