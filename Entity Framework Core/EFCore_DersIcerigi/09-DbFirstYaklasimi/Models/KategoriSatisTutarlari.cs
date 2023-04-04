using System;
using System.Collections.Generic;

namespace _09_DbFirstYaklasimi.Models;

public partial class KategoriSatisTutarlari
{
    public string CategoryName { get; set; } = null!;

    public decimal? SiparisToplami { get; set; }
}
