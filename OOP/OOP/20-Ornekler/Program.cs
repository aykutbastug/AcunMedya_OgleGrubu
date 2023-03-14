namespace _20_Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kus kus = new Kus(4, "Misket");

            Console.WriteLine($"{kus.Adi} kuşu {kus.Yas} yaşında.");
        }
    }
}

class Kus
{
    public int Yas { get; set; }
    public string Adi { get; set; }


    public void metot1()
    {

    }

    public int metot2()
    {
        return 0;
    }

    public Kus(int yas, string adi)
    {
        Yas = yas;
        Adi = adi;
    }
}

abstract class Insan
{

}