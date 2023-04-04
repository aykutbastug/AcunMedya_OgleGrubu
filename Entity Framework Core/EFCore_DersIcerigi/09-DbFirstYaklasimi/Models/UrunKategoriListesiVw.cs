using System;
using System.Collections.Generic;

namespace _09_DbFirstYaklasimi.Models;

public partial class UrunKategoriListesiVw
{
    public int Ürün { get; set; }

    public string ÜrünAdı { get; set; } = null!;

    public string KategoriAdı { get; set; } = null!;

    public string? Description { get; set; }
}
