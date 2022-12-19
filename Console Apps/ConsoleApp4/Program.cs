namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EkranaYaz();

            //Console.WriteLine("Mesaj 2");

            //SayilariTopla();
            //SayilariTopla(10, 20);
            //SayilariTopla(10, 20, 30);


            //int sonuc = SonucuGoster(10, 20);
            //Console.WriteLine(sonuc);

            //Console.WriteLine(SonucuGoster(3,6));


            //DateTime dateTime= DateTime.Now.AddDays(-4);
            //Console.WriteLine(dateTime);

            //string[] dizi = { "elma", "armut", "kiraz" };
            //dizi = dizi.Reverse().ToArray();

            //char[] dizi2 = { 'B', 'G', 'A' };
            //dizi2.Reverse();

            //string adiSoyadi = " aykut baştuğ ";

            //Console.WriteLine(adiSoyadi.ToLower());
            //Console.WriteLine(adiSoyadi.ToUpper());
            //Console.WriteLine(adiSoyadi.Trim());
            //Console.WriteLine(adiSoyadi.TrimStart());
            //Console.WriteLine(adiSoyadi.TrimEnd());

            //char[] harfler = adiSoyadi.ToCharArray();


            //string yeniIsim = adiSoyadi.Replace(" ", "");
            //var deneme = adiSoyadi.Split(' ');  

            //adiSoyadi.Substring(0, 2);

            //string faturaNo = "45";
            //faturaNo = faturaNo.PadLeft(10, '0');


            Console.WriteLine("Adınızı Soyadınızı girin:");
            string adiSoyadi = Console.ReadLine();
            char[] tersten = adiSoyadi.ToCharArray().Reverse().ToArray();
            Console.WriteLine(tersten);
            
        }

        static void EkranaYaz()
        {
            Console.WriteLine("Hello, World!");
        }

        //static void SayilariTopla(int sayi1, int sayi2)
        //{
        //    int sonuc = sayi1 + sayi2;

        //    Console.WriteLine("Sonuç = " + sonuc);
        //}

        //static void SayilariTopla(int sayi1, int sayi2, int sayi3)
        //{
        //    int sonuc = sayi1 + sayi2 + sayi3;

        //    Console.WriteLine("Sonuç = " + sonuc);
        //}

        static void SayilariTopla(int sayi1 = 10, int sayi2 =15, int sayi3 = 10)
        {
            int sonuc = sayi1 + sayi2 + sayi3;

            Console.WriteLine("Sonuç = " + sonuc);
        }

        static int SonucuGoster(int sayi1, int sayi2)
        {
            EkranaYaz();

            return sayi1 + sayi2;
        }
    }
}