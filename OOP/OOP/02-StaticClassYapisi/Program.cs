namespace _02_StaticClassYapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kisi kisi = new Kisi();
            //kisi.Ad = "Aykut";
            ////kisi.Soyadi = "BAŞTUĞ";
            //Kisi.Soyadi = "asdasd";

            Kisi.Ad = "Aykut";
            Kisi.Soyadi = "BAŞTUĞ";

            Console.WriteLine(Kisi.TamAdiGetir());
        }
    }
}