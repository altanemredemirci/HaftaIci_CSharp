namespace _12_Methods_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ***** PARAMETRES *****
             
            Parametre; metodu tanımlarken dışarıdan metoda veri geleceğini ve metodun bu veri üzerinde işlem yapacağını anlatır.

            Tanımda verilen parametre sayısı, parametrelerin veri tipleri ve sıraları ÖNEMLİDİR****
             
             
             */
            //Topla();

            Console.WriteLine("1.Sayı:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Topla(sayi1, sayi2);

            //Cikarma(sayi1, sayi2);
        }

        /// <summary>
        ///  Parametresiz Metot
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        //static void Topla()
        //{
        //    Console.WriteLine("1.Sayı:");
        //    int s1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("2.Sayı:");
        //    int s2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Sonuç:"+(s1+s2));
        //}

        //static void Topla(int s1, int s2)
        //{
        //    Console.WriteLine("Sonuç:" + (s1 + s2));
        //}

        static void Cikarma(double s1, int s2)
        {
            Console.WriteLine("Sonuç:" + (s1 - s2));
        }
    }
}
