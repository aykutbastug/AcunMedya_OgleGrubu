using System.ComponentModel;

namespace WebApplication1.Models
{
    public class Musteri
    {
        [DisplayName("Müşteri No")]
        public int Id { get; set; }

        [DisplayName("Adı Soyadı")]
        public string AdiSoyadi { get; set; }

        [DisplayName("Ünvan")]
        public string Unvan { get; set; }

        [DisplayName("Kayıt Tarihi")]
        public DateTime KayitTarihi { get; set; } = DateTime.Now;

        [DisplayName("E-Fatura Mükellefi")]
        public bool EFatura { get; set; }

        [DisplayName("Şehir")]
        public string Sehir { get; set; }

        [DisplayName("Adres")]
        public string Adres { get; set; }

        [DisplayName("Toplam Borç")]
        public double ToplamBorc { get; set; }

        [DisplayName("Toplam Alacak")]
        public double ToplamAlacak { get; set; }
    }
}
