using System.ComponentModel;

namespace WebApplication1.Models
{
    public class Ogrenci
    {

        [DisplayName("Öğrenci Numaranız")]
        public int Id { get; set; }

        [DisplayName("Adınız")]
        public string Adi { get; set; }


        [DisplayName("Soyadınız")]
        public string Soyadi { get; set; }    
    }
}
