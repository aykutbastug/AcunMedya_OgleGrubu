namespace _10_StructKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ucgen ucgen = new Ucgen();
            ucgen.KenarA = 123;

            Ucgen ucgen2 = new Ucgen(23, 56);

            Console.WriteLine("Hello, World!");
        }
    }
}


struct Ucgen
{
    public int KenarA { get; set; }
    public int KenarB { get; set; }

    public int AlanHesapla()
    {
        return KenarA;
    }

    //public Ucgen()
    //{

    //}
    public Ucgen(int kenarA, int kenarB)
    {
        KenarA = kenarA;
        KenarB = kenarB;
    }
}

public class Deneme
{
    public int MyProperty { get; set; }

    public Deneme()
    {
        
    }
}


//1 : classlar ram'de heap alanında tutulur, struct ise stack. (Siz ramdan silmediğiniz sürece ramda saklanır.)
//2 : stack alanında tutulduğu için class'lardan daha hızlı çalışır.
//3 : Herhangi bir class miras alamaz, aynı zamanda miras alınamaz
//4 : parametresiz consructor olamaz