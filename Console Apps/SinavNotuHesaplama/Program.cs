namespace SinavNotuHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1. Sınav Notunu Giriniz :");
            //decimal birinciNot = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("2. Sınav Notunu Giriniz :");
            //decimal ikinciNot = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("3. Sınav Notunu Giriniz :");
            //decimal ucuncuNot = Convert.ToDecimal(Console.ReadLine());

            //decimal ortalama = (birinciNot + ikinciNot + ucuncuNot) / 3;

            //Console.WriteLine("Not Ortalamanız = " + ortalama.ToString("n2"));


            Console.WriteLine("1. Sınav Notunu Giriniz :");
            int birinciNot = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sınav Notunu Giriniz :");
            int ikinciNot = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Sınav Notunu Giriniz :");
            int ucuncuNot = Convert.ToInt32(Console.ReadLine());

            decimal ortalama = ((decimal)birinciNot + (decimal)ikinciNot + (decimal)ucuncuNot) / 3;

            Console.WriteLine("Not Ortalamanız = " + ortalama.ToString("n2"));
        }
    }
}