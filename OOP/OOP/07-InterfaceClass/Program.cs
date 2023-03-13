using _07_InterfaceClass;

namespace _07_InterfaceClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calisan calisan = new Calisan();

            Personel personel = new Personel();
            personel.Adi = "Ali";
            personel.GorevYap();


            Koordinator koordinator = new Koordinator();
            koordinator.Adi = "Aykut";
            koordinator.GorevAta();
            koordinator.ToplantiPlanla();
            koordinator.ToplantiYap();

            Yonetici yonetici = new Yonetici();
            yonetici.Adi = "Hasan";
            yonetici.ToplantiYap();
        }
    }
}


public abstract class Hayvan
{
    public int AyakSayisi { get; set; }
    public string DisSayisi { get; set; }


}

public interface IKuyrukluHayvan
{
    void KuyrukSalla();
    bool SesCikart(string param1, int param2);
}

public class Kedi : Hayvan, IKuyrukluHayvan, IKulakliHayvan
{
    public void KulakOynat()
    {
        throw new NotImplementedException();
    }

    public void KuyrukSalla()
    {
        throw new NotImplementedException();
    }

    public bool SesCikart(string param1, int param2)
    {
        throw new NotImplementedException();
    }
}