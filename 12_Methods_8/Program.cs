namespace _12_Methods_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Default Parametre Değeri

            Console.WriteLine(Yazdir("Altan"));
            Console.WriteLine(Yazdir("Altan", "Elönü"));
        }

        static string Yazdir(string ad, string soyad = "Demirci")
        {
            return ad + " " + soyad;
        }
    }
}
