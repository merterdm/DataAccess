using System;
using System.Collections.Generic;

namespace EfCore_RelatedData.Entites;

public partial class CategorySalesFor1997
{
    public string CategoryName { get; set; } = null!;

    public decimal? CategorySales { get; set; }
}
