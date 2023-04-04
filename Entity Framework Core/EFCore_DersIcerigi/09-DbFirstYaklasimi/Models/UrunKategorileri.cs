using System;
using System.Collections.Generic;

namespace _09_DbFirstYaklasimi.Models;

public partial class UrunKategorileri
{
    public string ÜrünAdı { get; set; } = null!;

    public string KategoriAdı { get; set; } = null!;

    public int ProductId { get; set; }

    public int CategoryId { get; set; }

    public string Örnek { get; set; } = null!;

    public int Örnek2 { get; set; }

    public string Expr1 { get; set; } = null!;
}
