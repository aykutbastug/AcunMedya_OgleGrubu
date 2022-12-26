using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakipUygulamasi
{
    public class Musteri
    {
        public int Id { get; set; }
        public DateTime KayitTarihi { get; set; } = DateTime.Now;

        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public string Telefon { get; set; }
        public string Email { get; set; }

        public string Adres { get; set; }

        public string GorunenIsim { get { return Adi + " " + Soyadi; } }

        public FaturaBilgisi FaturaBilgisi { get; set; } = new FaturaBilgisi();
    }
}
