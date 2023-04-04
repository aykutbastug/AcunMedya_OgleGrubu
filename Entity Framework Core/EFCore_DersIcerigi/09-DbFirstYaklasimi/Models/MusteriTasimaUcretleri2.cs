using System;
using System.Collections.Generic;

namespace _09_DbFirstYaklasimi.Models;

public partial class MusteriTasimaUcretleri2
{
    public string MüşteriAdı { get; set; } = null!;

    public string MüşteriId { get; set; } = null!;

    public int SiparişNo { get; set; }

    public DateTime? SiparişTarihi { get; set; }

    public decimal? TaşımaÜcreti { get; set; }
}
