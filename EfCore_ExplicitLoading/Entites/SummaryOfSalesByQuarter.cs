using System;
using System.Collections.Generic;

namespace EfCore_ExplicitLoading.Entites;

public partial class SummaryOfSalesByQuarter
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
