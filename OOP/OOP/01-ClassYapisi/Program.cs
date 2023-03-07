namespace _01_ClassYapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Araba> arabalar = new List<Araba>();

            Araba araba = new Araba() {
                Marka = "BMV",
                _suankiyolcuSayisi = 3
            };

            araba._suankiHizi = 150;
            araba.Marka = "Opel";
            araba.Model = "Corsa";

            if (araba._suankiHizi > 130)
                araba.Marka = "mmmm";

            //araba.Ilerle();
            araba.Ilerle(true);

            //arabalar.Add(araba);
            //Araba araba2 = new Araba("yeniMarka");
            //arabalar.Add(araba2);

            //arabalar.Add(new Araba("Araba 2"));

            //foreach (var _araba in arabalar)
            //{

            //    //Console.WriteLine(_araba.Marka + " - " + _araba.Model);
            //    Console.WriteLine($"{_araba.Marka} - {_araba.Model}");
            //}

            ////Console.WriteLine(araba2.Marka);



            Kisi kisi = new Kisi();
            kisi.Ad = "Aykut";
            kisi.Soyad = "BAŞTUĞ";
            Console.WriteLine(kisi.TamAdiGetir());

            Console.Read();
        }
    }
}