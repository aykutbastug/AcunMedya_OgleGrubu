using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AbstractClass
{
    public abstract class Cihaz
    {
        public string Barkod { get; set; }

        public string Markasi { get; set; }

        public void BarkodYaz()
        {
            Console.WriteLine("Barkod : " + this.Barkod);
        }

        public abstract void BarkodGetir(string barkod, string marka);
        public abstract void MarkaYaz();
    }

    public class Bilgisayar : Cihaz
    {
        public override void BarkodGetir(string barkod, string marka)
        {
            Console.WriteLine("Bilgisayar Barkod : " + barkod + "-" + marka);
        }

        public override void MarkaYaz()
        {
            throw new NotImplementedException();
        }
    }

    public class Telefon : Cihaz
    {
        public override void BarkodGetir(string barkod, string marka)
        {
            Console.WriteLine("Telefon Barkod : " + barkod + "-" + marka);
        }

        public override void MarkaYaz()
        {
            throw new NotImplementedException();
        }
    }
}
