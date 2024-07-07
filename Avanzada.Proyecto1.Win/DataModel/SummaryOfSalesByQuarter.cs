using System;
using System.Collections.Generic;

namespace Avanzada.Proyecto1.Win.DataModel;

public partial class SummaryOfSalesByQuarter
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
