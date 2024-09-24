namespace _12_Methods_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 2 sayı 1 işlem(+,-,*,/) alan ve seçilen işleme göre sayılara işlme yaparak sonucu ekrana yazdıran metot

            DortIslem dortIslem = new DortIslem();
            dortIslem.DortIslemMetot();

            Console.WriteLine("Metot Sonrası...");

        }
       

    }
}
