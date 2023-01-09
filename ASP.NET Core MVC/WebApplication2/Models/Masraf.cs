using System.ComponentModel;

namespace WebApplication2.Models
{
    public class Masraf
    {
        [DisplayName("Masraf No")]
        public int Id { get; set; }


        [DisplayName("Kayıt Tarihi")]
        public DateTime KayitTarihi { get; set; } = DateTime.Now;


        [DisplayName("Personel No")]
        public int PersonelId { get; set; }

        [DisplayName("Masraf Tarihi")]
        public DateTime MasrafTarihi { get; set; }


        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }


        [DisplayName("Tutar")]
        public double Tutar { get; set; }


        [DisplayName("Masraf Durumu")]
        public MasrafDurumu Durumu { get; set; } = MasrafDurumu.OnayBekliyor;

    }

    public enum MasrafDurumu
    {
        OnayBekliyor = 0,
        RedEdildi = 1,
        Onaylandi = 2,
        OdemeYapildi = 3
    }

}
