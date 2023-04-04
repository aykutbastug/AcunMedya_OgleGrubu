using System;
using System.Collections.Generic;

namespace _09_DbFirstYaklasimi.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
