namespace _09_OnemliUcTerim
{
    internal class Program
    {

        //ENCAPSULATION (KAPSÜLLEME) : Property lere karşıllık geliyor. Field'lara değer ataması yada değer alması yaparken araya girerek kod yazabilme yeteniğe denir.

        //INHERITANCE (MİRAS) : class : class
        //POLYMORPHISM (ÇOK BİÇİMLİLİM) : virtual - ovirride

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

public abstract class Dortgen
{
    //encapsulation örneği
    public int KenarA { get; set; }

    //private int _KenarA;

    //public int KenarA
    //{
    //    get { return _KenarA; }
    //    set { _KenarA = value; }
    //}

    public virtual int AlanHesapla()
    {
        return KenarA;
    }
}


//INHERITANCE (MİRAS) örneği
public class Kare : Dortgen
{

    //POLYMORPHISM (Çok biçimlik) : virtual bir metodun override edilerek yeniden kod bloğu oluşturabilmesidir.
    public override int AlanHesapla()
    {
        return KenarA * 4;
    }

}