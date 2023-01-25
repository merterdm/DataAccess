﻿using System;
using System.Collections.Generic;

namespace EfCore_ExplicitLoading.Entites;

public partial class CustomerDemographic
{
    public string CustomerTypeId { get; set; } = null!;

    public string? CustomerDesc { get; set; }

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();
}
