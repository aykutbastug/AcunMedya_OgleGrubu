using System.ComponentModel;

namespace WebApplication2.Models
{
    public class Personel
    {
        [DisplayName("Personel Id")]
        public int Id { get; set; }

        [DisplayName("Adı Soyadı")]
        public string AdiSoyadi { get; set; }

        [DisplayName("Departman")]
        public string Departman { get; set; }
    }
}
