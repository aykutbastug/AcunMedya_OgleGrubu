using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_VirtualMetot
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
        public virtual void MarkaYaz()
        {
            Console.WriteLine(this.Markasi);
        }
    }

    public class Bilgisayar : Cihaz
    {
        public override void BarkodGetir(string barkod, string marka)
        {
            throw new NotImplementedException();
        }

        public override void MarkaYaz()
        {
            Console.WriteLine("Bu bilgisayarın markası " + this.Markasi);
        }
    }

    public class Telefon : Cihaz
    {
        public override void BarkodGetir(string barkod, string marka)
        {
            throw new NotImplementedException();
        }
    }
}
