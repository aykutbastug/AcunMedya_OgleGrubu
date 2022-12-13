namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello, World!");
            //Console.Write("Hello, World!2");
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Hello, World!");

            //CTRL + . ile ismi değiştirilen değişkenin ismini tüm satırlarda değiştirmek için kullanabiliriz.
            //CTRL + H ile değişiklik yapmak için kullanılır

            int sayi1 = 45; //sayısal değerler atanabilen bir tip
            string adi = "aykut"; //metinsel değerler atanabilen bir tip
            string soyadi = "baştuğ"; //metinsel değerler atanabilen bir tip
            bool evetHayir = false; //sadece 0 ve 1 değeri alabilen bir tip
            DateTime bugununTarihi = DateTime.Today; //günün tarihini verir saat olmaz
            DateTime bugununSaati = DateTime.Now; //günün tarihini ve saatini verir
            double ondalikliSayi1 = 0.12;
            decimal ondalikliSayi2 = 1.3M;
            float ondalikliSayi3 = 2.3F;

            object obje = "123";

            int? sayi = null;
            string? isim = null;
            int sayi2 = 12;


            //Console.WriteLine("Sayısal Değer : " + sayi1 + " değeri \"girildi");
            //Console.WriteLine($"Sayısal Değer : {sayi1} değeri girildi");


            int sonuc = sayi1 + sayi2;
            int sonuc2 = (sayi1 + sayi2) / 2;
            string adiSoyadi = adi + soyadi;

            //Console.WriteLine("Sayıların Ortalaması : " + sonuc2);
            //Console.WriteLine("Adınız Soyadınız : " + adiSoyadi);

            //Console.WriteLine(bugununSaati);
            //Console.WriteLine(bugununSaati.AddYears(5));
            //Console.WriteLine(bugununSaati.ToString("yyyy.MM.dd"));


            //string sayiMetin = sayi2.ToString();
            int sayiYeni = int.Parse("123");
            int sayiYeni2 = Convert.ToInt32("123");
            int sayiYeni3 = Convert.ToInt32(obje);
            decimal decimalYeni2 = Convert.ToDecimal("123");

            //Console.WriteLine(Convert.ToInt32("123"));
            //Console.WriteLine(obje.ToString());



            //Console.WriteLine("Adınızı Girin :");
            //string _adi = Console.ReadLine();
            //Console.WriteLine("Soyadınızı Girin :");
            //string _soyadi = Console.ReadLine();

            ////Console.WriteLine("");
            //Console.WriteLine("\n\n\nAdınız \nSoyadınız = " + _adi + " " + _soyadi);

            //Console.WriteLine("Bir sayı giriniz:");
            //int girilenSayi = Convert.ToInt32(Console.ReadLine());

            string[] renkler = new string[] { "Sarı", "Laciverrt", "Kırmızı" };
            string[] iller = new string[3] { "Sarı", "Laciverrt", "Kırmızı" };
            int[] sayilar = new int[] { 1, 2, 3, 4 };

            renkler[0] = "Siyah";
            //Console.WriteLine(renkler[0]);

            string[] renkler2 = new string[3];
            Console.WriteLine("1. Rengi Girin");
            renkler2[0] = Console.ReadLine();
            Console.WriteLine("2. Rengi Girin");
            renkler2[1] = Console.ReadLine();
            Console.WriteLine("3. Rengi Girin");
            renkler2[2] = Console.ReadLine();

            Console.ReadKey();
        }

    }
}