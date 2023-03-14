namespace _12_GenericKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(1);

            List<string> kelimeler = new List<string>();
            kelimeler.Add("kelime1");
            kelimeler.Add("kelime2");

            Dictionary<int, string> liste = new Dictionary<int, string>();
            liste.Add(1, "elma");
            liste.Add(28, "armut");

            foreach (KeyValuePair<int, string> item in liste)
            {
                Console.WriteLine("Anahtar Değer : " + item.Key + " - Değer : " + item.Value);
            }

            Tuple<int, int> tuple = new Tuple<int, int>(123, 435);

            AnahtarDeger<int, DateTime> anahtarDeger = new AnahtarDeger<int, DateTime>();
            anahtarDeger.Anahtar = 1;
            anahtarDeger.Deger = DateTime.Now;


            AnahtarDeger<int, Insan> insan = new AnahtarDeger<int, Insan>();
            insan.Anahtar = 12;
            insan.Deger = new Insan { Adi = "xxx", Soyadi = "asaa" };

            AnahtarDeger<int, Insan> insan2 = new AnahtarDeger<int, Insan>(34, new Insan { Adi = "aaaa", Soyadi = "bbbb" });

            AnahtarDeger<int, string> anahtarDeger1 = new AnahtarDeger<int, string>(222, "yeniDeger");
            Console.WriteLine($"Anahtar = {anahtarDeger1.Anahtar} - Değer= {anahtarDeger1.Deger}");


            Console.WriteLine($"Anahtar={insan.Anahtar} - Değer = Adı :{insan.Deger.Adi}, Soyadı: {insan.Deger.Soyadi}");

            Console.WriteLine($"Anahtar={insan2.Anahtar} - Değer = Adı :{insan2.Deger.Adi}, Soyadı: {insan2.Deger.Soyadi}");


            Liste<int> yeniListe = new Liste<int>();
            yeniListe.Ekle(2);
            yeniListe.Ekle(5);
            //yeniListe.Ekle(1);


            //int[] dizi = new int[3];
            //dizi[0] = 1;
            //dizi[1] = 13;
            //dizi[2] = 158;


            Insan insan1 = new Insan { Adi = "Aykut1", Soyadi = "Baştuğ1" };
            Insan insan3 = new Insan();
            insan3.Adi = "Aykut3";
            insan3.Soyadi = "Baştuğ3";

            Liste<Insan> insanlar = new Liste<Insan>();
            insanlar.Ekle(new Insan { Adi = "Aykut", Soyadi = "Baştuğ" });
            insanlar.Ekle(insan1);
            insanlar.Ekle(insan3);

            Insan[] yeniDizi = insanlar.Listele();
            foreach (var item in yeniDizi)
            {
                Console.WriteLine(item.Adi + " " + item.Soyadi);
            }

            Insan birinciInsan = insanlar.Getir(1);
            Console.WriteLine(birinciInsan.Adi + " " + birinciInsan.Soyadi);

            insanlar.Degistir(1, insan3);
        }
    }


    class AnahtarDeger<TAnahtar, TDeger>
                        //where TAnahtar : struct
                        //where TDeger : class
    {
        public TAnahtar Anahtar { get; set; }

        public TDeger Deger { get; set; }

        public AnahtarDeger()
        {
            
        }

        public AnahtarDeger(TAnahtar anahtar, TDeger deger)
        {
            Anahtar = anahtar;
            Deger = deger;
        }

    }


    class Insan
    {
        public string Adi { get; set; }

        public string Soyadi { get; set; }
    }


    //GENERIC CONSTRAINT

    //basit tipleri almasını istiyorsak struct filtresini kullanabiliriz. (int, string, bool...)
    //class Liste<T> where T : struct


    //eğer sadece class tipinde tanımlama tapılmasını istiyorsak class keyword'ünü kullanıyoruz
    //class Liste<T> where T : class

    //eğer sadece nesnesi oluşturulabilen bir class tipinde tanımlama tapılmasını istiyorsak new() keyword'ünü kullanıyoruz
    //class Liste<T> where T : new()


    //sadece interface almasını istediğimizde interface ismini yazabiliriz
    //class Liste<T> where T : IGonderici

    class Liste<T>
    {
        private T[] dizi = new T[0];

        public void Ekle(T deger)
        {
            Array.Resize(ref dizi, dizi.Length + 1);
            dizi[dizi.Length - 1] = deger;
        }

        public T[] Listele()
        {
            return dizi;
        }

        public T Getir(int index)
        {
            return dizi[index];
        }

        public void Degistir(int index, T deger)
        {
            dizi[index] = deger;
        }
    }
}