namespace _05_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cihaz cihaz = new Cihaz();
            //cihaz.Barkod

            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.Barkod = "12344";
            bilgisayar.Markasi = "Asus";

            Telefon telefon = new Telefon();
            telefon.Barkod = "978678";
            telefon.Markasi = "Samsung";


            bilgisayar.BarkodGetir(bilgisayar.Barkod, bilgisayar.Markasi);
            telefon.BarkodGetir(telefon.Barkod, telefon.Markasi);
        }
    }
}


