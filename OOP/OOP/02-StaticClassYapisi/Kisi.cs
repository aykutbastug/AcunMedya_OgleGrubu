using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StaticClassYapisi
{
    public static class Kisi
    {
        public static string Ad { get; set; }
        public static string Soyadi { get; set; }

        public static string TamAdiGetir()
        {
            return Ad + " " + Soyadi;
        }
    }
}
