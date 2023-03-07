using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ClassYapisi
{
    public class Araba
    {
        //Fileds (Değişkenler)
        public int _suankiHizi;
        public int _suankiyolcuSayisi;


        //Property (Özellikler)

        public string Marka { get; set; }
        public string Model { get; set; }


        //Events (Olaylar)
        public event EventHandler Calisitirildi;
        public event EventHandler Ilerle_;


        //Consructor (Yapıcı metot)
        public Araba()
        {
            
        }

        public Araba(string marka)
        {
            Marka = marka;
        }


        //Methods (Eylemler)
        public void Ilerle()
        {
            Console.WriteLine("Araba ilerlerdi");
        }

        public void Ilerle(bool vitesBostami)
        {
            if (vitesBostami)
                Console.WriteLine("Vitesi 1'e alın");
            else
                Console.WriteLine("Araba ilerledi");
        }

        public void KapilariKilitle(bool anahtarKontaktami)
        {

        }

        public int OnrnekMethot()
        {
            return 0;
        }


        //Destructor (Yok Edici metot)
        ~Araba()
        {

        }

    }
}
