public class Kisi
{
    public string Ad { get; set; }

    public string Soyad { get; set; }

    internal string TamAdiGetir()
    {
        return this.Ad + " " + this.Soyad;
    }

    public Kisi()
    {
        
    }
    public Kisi(string soyad)
    {
        Soyad = soyad;
    }


    //private (özel) = sadece ilgili clasın içerisinde ilgili üyelere erişebilir.
    //public = herhangi bir clastan yada farklı bir dosyadan ilgili classın ilgili üyelerinden her yerden erişilebilir.
    //internal = sadece bu proje içerisinden erişilebilir, referans alındığı projeden erişim sağlanamaz


}