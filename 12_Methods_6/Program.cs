namespace _12_Methods_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OVERLOAD - AŞIRI YÜKLENME

            //Metot tanımlarken ya ismi benzersiz(unique) yada metot imzası(parametre: sayısı,veri tipi,sırası) farklı olmalıdır.

            //Overload: Bir metodun aynı isimle ama farklı işlemle birden fazla kez tanımlanmasına denir.

            //**1.Tanım
            Topla();

            //**2.Tanım
            Console.WriteLine("1.Sayı:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Topla();

        }

        static void Topla()
        {
            Console.WriteLine("1.Sayı:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sonuç="+(sayi1+sayi2));
        }

        static void Topla(int s1, int s2)
        {
            Console.WriteLine("Sonuç=" + (s1 + s2));
        }

        static void Topla(int s1, int s2, int s3)
        {
            Console.WriteLine("Sonuç=" + (s1 + s2 + s3));
        }

        static void Topla(double s1, int s2)
        {
            Console.WriteLine("Sonuç=" + (s1 + s2));
        }

        static void Topla(int s1, double s2)
        {
            Console.WriteLine("Sonuç=" + (s1 + s2));
        }

        static double Topla(int s1, double s2)
        {
           return  (s1 + s2);
        }
    }
}
