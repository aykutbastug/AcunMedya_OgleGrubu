namespace EtutOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Sayıyı Girin:
            //1. sayıyı alalım
            //2. Sayıyı Girin:
            //2. sayıyı alalım
            //Yapmak istediğiniz işlem nedir ? (1=Toplamam, 2=Çarpma, 3=Çıkarma, 4=Bölme)
            //seçime göre işlemi yapıp sonucu ekranda gösterelim

            try
            {
                //hata alınma ihtimali olan kod blogları buraya yazılır.
            }
            catch (Exception hataMesaji)
            {
                //hata alındığında çalışmasını istediğimiz kodlar buraya yazılır
            }
            finally
            {
                //hata alınsa da alınması her halukarda çalışmasını istediğiniz kodları buraya yazabilirsiniz
            }


            int sayi1 = 0;
            int sayi2 = 0;

            try
            {
                Console.WriteLine("1. Sayıyı Giriniz :");
                sayi1 = int.Parse(Console.ReadLine());

                Console.WriteLine("2. Sayıyı Giriniz :");
                sayi2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Yapmak istediğiniz işlemi seçin.\n(1=Toplamam, 2=Çarpma, 3=Çıkarma, 4=Bölme)");
                string islem = Console.ReadLine();
                int sonuc = 0;

                switch (islem)
                {
                    case "1":
                        sonuc = sayi1 + sayi2;
                        break;

                    case "2":
                        sonuc = sayi1 * sayi2;
                        break;

                    case "3":
                        sonuc = sayi1 - sayi2;
                        break;

                    case "4":
                        sonuc = sayi1 / sayi2;
                        break;

                    default:
                        Console.WriteLine("Hatalı bir seçim yaptınız..");
                        break;
                }

                Console.WriteLine("İşlem Sonucu = " + sonuc);
            }
            catch (Exception hata)
            {
                Console.WriteLine("İşlem sırasında hata oluştu. ("+hata.Message+")");
                Console.WriteLine(hata.StackTrace);
            }          

        }
    }
}