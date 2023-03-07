using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_InheritanceKalitim
{
    public class Cihaz
    {
        public string Barkod { get; set; }

        public string BarkodYaz()
        {
            return "Barkod : " + Barkod;
        }
    }

    public sealed class Bilgisayar: Cihaz
    {
        
    }    

    public class Telefon: Cihaz
    {
        public string EkranGenisligi { get; set; }

        public void AramaYap()
        {
            base.BarkodYaz();
        }
    }

}

//Öğrenci, Öğretmen, Yönetici,
//Ortak özellikler... Adı, Soyadı, KimlikNumarası
//Öğrencinin ders çalışma, ödev yapma, tekrar etme gibi eylemleri
//öğrencinin NotOrtalaması özelliği

//Öğretmen: DerseHazirlan(), DersAnlat eylemlerine sahip

//Yönetici: Maaş ödeme eylemi var.

//Öğretmen ve Yöneticinin Maaş ve Ünvan özelliklerine sahip

