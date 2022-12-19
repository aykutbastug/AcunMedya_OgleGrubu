namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello, World!==" + i);
            //}


            //string[] dizi = new string[] { "Siyah", "Beyaz", "Mavi", "Yeşil", "122" };
            //string[] dizi2 = new string[3];
            //dizi2[0] = "İstanbul";
            //dizi2[1] = "Ankara";
            //dizi2[2] = "İzmir";

            //dizi2 = null;

            //for (int i = 0; i < dizi2.Length; i++)
            //{
            //    Console.WriteLine(dizi2[i]);
            //}


            //foreach (var eleman in dizi)
            //{
            //    Console.WriteLine(eleman);
            //}


            //int[] sayilar = new int[] { 0, 1, 2, 3, 4, 5 };
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}


            //dizinin eleman sayısını kullanıcının girdiği değerden alacak
            //


            //Console.WriteLine("Lütfen dizinin elemen sayısını girin :");
            //int elemanSayisi = Convert.ToInt32(Console.ReadLine());
            //string[] meyveler = new string[elemanSayisi];

            //for (int i = 0; i < meyveler.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ". meyveyi girin:");
            //    meyveler[i] = Console.ReadLine();
            //}

            //Console.WriteLine("\n\n");

            //foreach (var item in meyveler)
            //{
            //    Console.WriteLine(item);
            //}


            //for (int i = 0; i < 10; i++)
            //{
            //    //if (i == 6)
            //    //    break; //döngüden tamamen çıkmayı sağlar

            //    if (i == 6)
            //        continue; //döngüyü bir sonraki adıma geçirerk devam ettirir

            //    Console.WriteLine(i);   
            //}



            //int i  = 0; 
            //while (i < 10)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}


            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Çıkmak için 1'e basınız ?");                

            //    try
            //    {
            //        i = Convert.ToInt32(Console.ReadLine());
            //    }
            //    catch {; }
            //    //catch (Exception ex)
            //    //{
            //    //    Console.WriteLine(ex.Message);
            //    //}

            //} while (i != 1);


            //1.Adım
            //Kaç sayı ile işlem yapmak istiyorsunuz ?
            //karakter girerse tekrar soracak

            //2.Adım
            //Sırasıyla n. sayıyı girin :
            //karkter girerse hata verecek tekrar girmesini isteyecek
            //sayı girdiyse n. sayıyı dizide tutacak

            //3.Adım
            //tüm sayıları girdikten sonra
            //Yapmak istediğiniz işlemi seçiniz (+ - * /)
            //harici bir değer girildi ise 'Yanlış bir seçim yaptınız' uyarısı vererek tekrar seçim yapması sağlanacak

            //4.Adım
            //seçimine göre girlen sayılar üzerinde ilgili işlem uygulanacak ve ekrana sonuç yazılacak


            int islemSayisi = 0;
            do
            {
                Console.WriteLine("Kaç sayı ile işlem yapmak istiyorsunuz ?");

                try
                {
                    islemSayisi = Convert.ToInt32(Console.ReadLine());
                }
                catch {; }  
            } while (islemSayisi == 0);


            int[] sayilar = new int[islemSayisi];

            for (int i = 0; i < sayilar.Length; i++)
            {
                bool sayiMi = false;
                do
                {
                    Console.WriteLine((i + 1) + ". Sayıyı Girin:");
                    try
                    {
                        sayilar[i] = Convert.ToInt32(Console.ReadLine());
                        sayiMi = true;
                    }
                    catch {; } 
                } while (!sayiMi);
            }
            

            bool secimDogrumu = false;
            int islem = 0;
            do
            {
                Console.WriteLine("============");
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz?");
                Console.WriteLine("1 = Toplama");
                Console.WriteLine("2 = Çıkarma");
                Console.WriteLine("3 = Bölme");
                Console.WriteLine("4 = Çarpma");
                Console.WriteLine("============");

                try
                {
                    islem = Convert.ToInt32(Console.ReadLine());
                    if (islem == 1 || islem == 2 || islem == 3 || islem == 4)
                        secimDogrumu = true;
                }
                catch {; } 
            } while (!secimDogrumu);


            int islemSonucu = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (islem == 1)//toplama
                {
                    islemSonucu = islemSonucu + sayilar[i];
                }
                else if (islem == 2)//Çıkarma
                {
                    if (islemSonucu == 0)
                        islemSonucu = sayilar[i];
                    else
                        islemSonucu = islemSonucu - sayilar[i];
                }
                else if (islem == 3)//Bölme
                {
                    if (islemSonucu == 0)
                        islemSonucu = sayilar[i];
                    else
                        islemSonucu = islemSonucu / sayilar[i];
                }
                else if (islem == 4)//Çarpma
                {
                    if (islemSonucu == 0)
                        islemSonucu = sayilar[i];
                    else
                        islemSonucu = islemSonucu * sayilar[i];
                }
            }


            Console.WriteLine("=============\nİşlem Sonucu =" + islemSonucu);

        }
    }
}