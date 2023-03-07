namespace _03_PropertyOzellik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sirket sirket = new Sirket();
            sirket.Ciro = 50;

            Console.WriteLine("Ciro = " + sirket.Ciro);
        }
    }
}