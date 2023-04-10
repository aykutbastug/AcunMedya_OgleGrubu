using System;
using System.Collections.Generic;

namespace OdevDbFirst.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
