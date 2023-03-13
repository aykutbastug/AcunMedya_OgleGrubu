namespace _08_PartialKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koorninat koorninat = new Koorninat();
            koorninat.X = 1250;
            koorninat.Y = 345;

            //koorninat.KoordinatYaz();
        }
    }

    //Partial Class Örneği

    //partial class Koorninat
    //{
    //    public int X { get; set; }

    //    public int Y { get; set; }
    //}

    //partial class Koorninat
    //{
    //    public void KoordinatYaz()
    //    {
    //        Console.WriteLine($"X: {X} - Y: {Y}");
    //    }
    //}


    partial class Koorninat : IKoordinatGoster
    {
        public int X { get; set; }

        public int Y { get; set; }

        public void Goster()
        {
            throw new NotImplementedException();
        }

        public void Yaz()
        {
            throw new NotImplementedException();
        }
    }

    partial interface IKoordinatGoster
    {
        void Goster();
    }

    partial interface IKoordinatGoster
    { 
        void Yaz();
    }
}