namespace _13_GenericInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmailGonderici emailGonderici = new EmailGonderici();
            emailGonderici.Gonder(new EmailIcerik { Kimden = "asad@aa.com" });

            SmsGonderici smsGonderici = new SmsGonderici();
            smsGonderici.Gonder(new SmsIcerik { Telefon = "123132" });
            Console.WriteLine("Hello, World!");
        }
    }
}

public class EmailIcerik
{
    public string Kimden { get; set; }
    public string Kime { get; set; }
    public string Konu { get; set; }
    public string Mesaj { get; set; }
}

public class SmsIcerik
{
    public string Telefon { get; set; }
    public string Mesaj { get; set; }
}

public class MesajIcerik
{
    public string Mesaj { get; set; }
}

interface IGonderici<T>
{
    void Gonder(T icerik);
}

class EmailGonderici : IGonderici<EmailIcerik>
{
    public void Gonder(EmailIcerik icerik)
    {
        throw new NotImplementedException();
    }
}

class SmsGonderici : IGonderici<SmsIcerik>
{
    public void Gonder(SmsIcerik icerik)
    {
        throw new NotImplementedException();
    }
}

class FaxGonderici : IGonderici<SmsIcerik>
{
    public void Gonder(SmsIcerik icerik)
    {
        throw new NotImplementedException();
    }
}

