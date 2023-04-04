using System;
using System.Collections.Generic;

namespace _09_DbFirstYaklasimi.Models;

public partial class ViewMusteriSiparisListesi
{
    public int SiparişNo { get; set; }

    public DateTime? SiparişTarihi { get; set; }

    public DateTime? KargoTarihi { get; set; }

    public decimal? KargoÜcreti { get; set; }

    public decimal? ToplamTutar { get; set; }

    public int? ÜrünAdedi { get; set; }

    public string? CustomerId { get; set; }
}
