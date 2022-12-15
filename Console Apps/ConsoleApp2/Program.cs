namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi = "aykut";
            string sifre = "123";

            Console.WriteLine("Kullanıcı Adınızı Giriniz :");
            string _kullaniciAdi = Console.ReadLine();

            Console.WriteLine("Şifrenizi giriniz :");
            string _sifre = Console.ReadLine();

            if (kullaniciAdi == _kullaniciAdi && sifre == _sifre)
            {
                Console.WriteLine("Giriş başarılı");
            }
            else
                Console.WriteLine("Kullanıcı adı veya şifresi hatalı.");
        }
    }
}