﻿using System;
using System.Collections.Generic;

namespace EfCore_ExplicitLoading.Entites;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
