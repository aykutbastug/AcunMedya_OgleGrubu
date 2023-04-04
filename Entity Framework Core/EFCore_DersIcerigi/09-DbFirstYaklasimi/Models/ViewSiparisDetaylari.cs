using System;
using System.Collections.Generic;

namespace _09_DbFirstYaklasimi.Models;

public partial class ViewSiparisDetaylari
{
    public int OrderId { get; set; }

    public string ÜrünAdı { get; set; } = null!;

    public decimal BirimFiyatı { get; set; }

    public short Miktar { get; set; }

    public decimal? ToplamTutar { get; set; }
}
