using BankaKartiOrnegi;

namespace BankaKartiOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bankamatik bankamatik = new Bankamatik();
            bankamatik.KartTuru = KartTurleri.Master;


            Console.WriteLine("Hello, World!");
        }
    }
}


public enum KartTurleri { Visa, Master }

public enum HesapTurleri { TL, USD, EURO, AUX }

public abstract class Kart
{
    public string BankaAdi { get; set; }

    public string KartAdi { get; set; }

    public KartTurleri KartTuru { get; set; }

    public int CVV { get; set; }

    public void ParaCek(decimal tutar)
    {
        Console.WriteLine(tutar +  " TL Para Çekildi");
    }

    public void ParaYatir(decimal tutar)
    {
        Console.WriteLine(tutar + " TL Para Yatırıldı");
    }
}

public class Bankamatik : Kart, IHavale
{
    public HesapTurleri HesapTuru { get; set; }
    public decimal Bakiye { get; set; }

    public void HavaleGonder(string iban, decimal tutar)
    {
        Console.WriteLine($"{iban} IBAN adresine {tutar} TL gönderildi.");
    }

    public void LimitTanimla(decimal tutar)
    {
        Console.WriteLine($"Kart limiti {tutar} TL olarak güncellendi.");
    }
}

public class Platinuim: Kart, IPuan, IDiger, IHavale, IEft
{
    public bool ClubUyeligiVarMi { get; set; }
    public DateTime UyelikBaslangicTarihi { get; set; }
    public DateTime? UyelikBitisTarihi { get; set; }   
    public decimal KazanilanPuan { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool EkKartMi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public DateTime SonKullanimTarihi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void UyeligiYenile()
    {

    }

    public void UyeligiBitir()
    {

    }

    public void HavaleGonder(string iban, decimal tutar)
    {
        throw new NotImplementedException();
    }

    public void EftGonder(string iban, decimal tutar)
    {
        throw new NotImplementedException();
    }

    public void BorcOde()
    {
        throw new NotImplementedException();
    }
}

public class Gold: Kart, IPuan, IDiger, ITaksit, IHavale
{
    public bool IndirimOzelligiVarMi { get; set; }
    public bool KampanyaTanimliMi { get; set; }
    public DateTime KampanyaBaslangicTarihi { get; set; }
    public decimal KazanilanPuan { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public DateTime KampanyaBitisTarihi { get; set; }
    public bool EkKartMi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public DateTime SonKullanimTarihi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void BorcOde()
    {
        throw new NotImplementedException();
    }

    public void HavaleGonder(string iban, decimal tutar)
    {
        throw new NotImplementedException();
    }

    public void KampanyaTanimla()
    {

    }

    public void KapmanyaBitir()
    {

    }

    public void TaksitYap(decimal tutar, int taksitSayisi)
    {
        throw new NotImplementedException();
    }
}

public class Silver: Kart, IDiger, IEft, ITaksit
{
    public bool KisitlamaVarMi { get; set; }
    public DateTime KisitlamaTarihi { get; set; }
    public bool EkKartMi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public DateTime SonKullanimTarihi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void BorcOde()
    {
        throw new NotImplementedException();
    }

    public void EftGonder(string iban, decimal tutar)
    {
        throw new NotImplementedException();
    }

    public void TaksitYap(decimal tutar, int taksitSayisi)
    {
        throw new NotImplementedException();
    }
}