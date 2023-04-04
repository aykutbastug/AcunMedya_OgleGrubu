using System;
using System.Collections.Generic;

namespace _09_DbFirstYaklasimi.Models;

public partial class KategoriUrunSayisi
{
    public string CategoryName { get; set; } = null!;

    public int? UrunSayisi { get; set; }
}
