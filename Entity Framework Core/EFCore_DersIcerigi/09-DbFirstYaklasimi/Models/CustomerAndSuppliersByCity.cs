﻿using System;
using System.Collections.Generic;

namespace _09_DbFirstYaklasimi.Models;

public partial class CustomerAndSuppliersByCity
{
    public string? City { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? ContactName { get; set; }

    public string Relationship { get; set; } = null!;
}
