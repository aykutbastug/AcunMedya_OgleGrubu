using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_InterfaceClass
{
    public abstract class Calisan
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KimlikNo { get; set; }
    }

    public interface IGorev
    {
        void GorevYap();
    }

    public interface IToplanti
    {
        void ToplantiYap();
    }


    public class Personel : Calisan, IGorev
    {
        public void GorevYap()
        {
            Console.WriteLine(this.Adi + " isimli Personel görevi yaptı.");
        }
    }

    public class Koordinator : Calisan, IGorev, IToplanti
    {
        public void GorevYap()
        {
            Console.WriteLine(Adi + " isimli Koordinatör görevini yaptı.");
        }

        public void GorevAta()
        {
            Console.WriteLine(Adi + " isimli Koordinatör görev ataması yaptı");
        }

        public void ToplantiPlanla()
        {
            Console.WriteLine(base.Adi + " isimli Koordinatör Toplantı planladı");
        }

        public void ToplantiYap()
        {
            Console.WriteLine(base.Adi + " isimli Koordinatör toplantı yaptı");
        }
    }

    public class Yonetici : Calisan, IToplanti
    {
        public void ToplantiYap()
        {
            Console.WriteLine(this.Adi + " isimli yönetici toplantı yaptı");
        }
    }
}
