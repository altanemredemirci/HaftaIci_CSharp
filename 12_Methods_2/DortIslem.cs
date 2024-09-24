using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Methods_2
{
    internal class DortIslem
    {
        internal static double Toplama()
        {
            Console.WriteLine("1.Sayı:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            double toplam = sayi1 + sayi2;

            return toplam;
        }

        //internal static void Cikarma()
        //{
        //    Console.WriteLine("1.Sayı:");
        //    double sayi1 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("2.Sayı:");
        //    double sayi2 = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine(sayi1 - sayi2);
        //}

        //internal static void Carpma()
        //{
        //    Console.WriteLine("1.Sayı:");
        //    double sayi1 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("2.Sayı:");
        //    double sayi2 = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine(sayi1 * sayi2);
        //}

        //internal static void Bolme()
        //{
        //    Console.WriteLine("1.Sayı:");
        //    double sayi1 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("2.Sayı:");
        //    double sayi2 = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine(sayi1 / sayi2);
        //}
    }
}
