namespace _04_InheritanceKalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cihaz cihaz = new Cihaz();
            cihaz.Barkod = "1111";      
            Console.WriteLine(cihaz.BarkodYaz());

            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.Barkod = "2222";
            Console.WriteLine(bilgisayar.BarkodYaz());


            Ogrenci ogrenci = new Ogrenci();    
            //ogrenci.

            Ogretmen ogretmen = new Ogretmen();
            //ogretmen.der

            Yonetici yonetici = new Yonetici(); 
            //yonetici.
        }
    }
}