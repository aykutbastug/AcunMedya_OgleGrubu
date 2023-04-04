using System;
using System.Collections.Generic;

namespace _09_DbFirstYaklasimi.Models;

public partial class View1
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int ShipperId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public int CategoryId { get; set; }
}
