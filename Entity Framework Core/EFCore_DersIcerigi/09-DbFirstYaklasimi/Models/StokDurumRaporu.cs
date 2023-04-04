using System;
using System.Collections.Generic;

namespace _09_DbFirstYaklasimi.Models;

public partial class StokDurumRaporu
{
    public int ÜrünId { get; set; }

    public string ÜrünAdı { get; set; } = null!;

    public string KategoriAdı { get; set; } = null!;

    public short? StokMiktarı { get; set; }
}
