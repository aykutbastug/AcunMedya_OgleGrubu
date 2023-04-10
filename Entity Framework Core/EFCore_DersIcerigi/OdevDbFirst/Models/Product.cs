using System;
using System.Collections.Generic;

namespace OdevDbFirst.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public int? CategoryId { get; set; }

    public int? SupplierId { get; set; }

    public string? Name { get; set; }

    public decimal? UnitePrice { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Supplier? Supplier { get; set; }
}
