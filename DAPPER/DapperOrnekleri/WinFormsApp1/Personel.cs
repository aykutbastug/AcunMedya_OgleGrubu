public class Personel
{
    public int PersonelId { get; set; }
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public DateTime DogumTarihi { get; set; }
    public string Email { get; set; }
    public int Sifre { get; set; }
    public string Telefon { get; set; }
    public Gorevler Gorevi { get; set; }
}

public enum Gorevler { Personel, Yonetici}