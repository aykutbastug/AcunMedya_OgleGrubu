using System;
using System.Collections.Generic;

namespace OdevDbFirst.Models;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string? CompanyName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
