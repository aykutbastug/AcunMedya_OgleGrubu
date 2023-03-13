namespace _06_VirtualMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.Markasi = "Asus";
            bilgisayar.Barkod = "123123";


            Telefon telefon = new Telefon();
            telefon.Markasi = "Samsung";
            telefon.Barkod = "079789";


            bilgisayar.MarkaYaz();
            telefon.MarkaYaz();
        }
    }
}