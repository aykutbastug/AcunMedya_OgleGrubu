namespace _11_EnumKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ToString : " + Gunler.Pazartesi.ToString());
            Console.WriteLine(Gunler.Sali);
            Console.WriteLine((int)Gunler.Carsamba);
            Console.WriteLine((int)GunlerYeni2.Cuma);


            int[] degerler = (int[])Enum.GetValues(typeof(Gunler));
            foreach (var deger in degerler)
            {
                Console.WriteLine($"{Enum.GetName(typeof(Gunler), deger)} - {deger}");
            }


            string[] isimler = Enum.GetNames(typeof(Gunler));
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
        }
    }
}

enum Gunler
{
    Pazartesi,
    Sali,
    Carsamba,
    Persembe,
    Cuma,
    Cumartesi,
    Pazar
}

enum GunlerYeni
{
    Pazartesi = 1,
    Sali = 2,
    Carsamba = 3,
    Persembe = 8,
    Cuma = 10,
    Cumartesi = 11,
    Pazar = 12
}

enum GunlerYeni2
{
    Pazartesi = 10,
    Sali = 20,
    Carsamba = 30,
    Persembe,
    Cuma,
    Cumartesi,
    Pazar
}