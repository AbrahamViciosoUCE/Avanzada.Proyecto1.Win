using Avanzada.Proyecto1.Win.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Models
{
    public class OrderDetail
    {


        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        public float Discount { get; set; }

        public string ProductName { get; set; }

        public string CategoryName { get; set; }

    }
}
