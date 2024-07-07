using System;
using System.Collections.Generic;

namespace Avanzada.Proyecto1.Win.DataModel;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
