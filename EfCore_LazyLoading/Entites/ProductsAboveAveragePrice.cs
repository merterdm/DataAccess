using System;
using System.Collections.Generic;

namespace EfCore_LazyLoading.Entites;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
