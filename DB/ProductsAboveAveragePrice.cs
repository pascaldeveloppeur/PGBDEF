using System;
using System.Collections.Generic;

namespace PGBDEF.DB;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
