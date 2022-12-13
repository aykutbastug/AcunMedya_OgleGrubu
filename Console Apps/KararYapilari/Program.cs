using System.Diagnostics;
using System.Linq.Expressions;

namespace KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;
            //int sayi2 = 20;

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Sayı 1 büyük");
            //}
            //else if (sayi1 == sayi2)
            //{
            //    Console.WriteLine("Sayılar eşit");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 2 büyük");
            //}


            //if (sayi1 > sayi2)
            //    Console.WriteLine("Sayı 1 büyük");
            //else if (sayi1 == sayi2)
            //    Console.WriteLine("Sayılar eşit");
            //else
            //    Console.WriteLine("Sayı 2 büyük");


            //if (sayi1 > sayi2 && sayi1 != null)
            //    Console.WriteLine("Sayı 1 büyük");
            //else
            //    Console.WriteLine("Sayı 2 büyük");


            //Console.WriteLine(sayi1 > sayi2 ? "Sayı 1 büyük" : "Sayı 2 büyük");


            //if (sayi1 > sayi2 && sayi1 != null)
            //if (sayi1 > sayi2 || sayi1 != null)



            //0-44 > FF
            //45-50 > FD
            //51-60 > CC
            //61-70 > CB
            //71-80 > BB
            //81-90 > BA
            //91-100 > AA

            //Console.WriteLine("1. Sınav Notunu Giriniz :");
            //int not1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. Sınav Notunu Giriniz :");
            //int not2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("3. Sınav Notunu Giriniz :");
            //int not3 = Convert.ToInt32(Console.ReadLine());

            //int ortalama = (not1 + not2 + not3) / 3;

            //if (ortalama <= 44)
            //    Console.WriteLine("FF");
            //else if (ortalama > 44 && ortalama <= 50)
            //    Console.WriteLine("FD");
            //else if (ortalama > 50 && ortalama <= 60)
            //    Console.WriteLine("CC");
            //else if (ortalama > 60 && ortalama <= 70)
            //    Console.WriteLine("CB");
            //else if (ortalama > 70 && ortalama <= 80)
            //    Console.WriteLine("BB");
            //else if (ortalama > 80 && ortalama <= 90)
            //    Console.WriteLine("BA");
            //else
            //    Console.WriteLine("AA");



            Console.WriteLine("Renk giriniz:");
            string renk = Console.ReadLine();

            switch (renk)
            {
                case "kirmizi":
                    Console.WriteLine("Lütfen bekleyiniz");
                      break;  

                case "sari":
                    Console.WriteLine("Hazırlanın");
                    break;

                case "yeşil":
                    Console.WriteLine("geçiniz");
                    break;

                default:
                    Console.WriteLine("hatalı renk girdiniz");
                    break;

            }


        }
    }
}