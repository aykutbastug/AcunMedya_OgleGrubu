using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_InheritanceKalitim
{
    public class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KimlikNo { get; set; }
    }

    public class Ogrenci:Insan
    {
        public int NotOrtalamasi { get; set; }

        public void DersCalis()
        {

        }

        public void OdevYap()
        {

        }
    }

    public class Personel : Insan
    {
        public int Maas { get; set; }

        public string Unvan { get; set; }
    }

    public class Ogretmen : Personel
    {
        

        public void DerseHazirlan()
        {

        }
    }

    public class Yonetici : Personel
    {
        public void MaasOde()
        {

        }
    }


}
