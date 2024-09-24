using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Methods_1
{
    public class DortIslem
    {
        internal void DortIslemMetot()
        {
            Console.WriteLine("İşlem(+,-,*,/):");
            string islem = Console.ReadLine();

            if (islem == "+")
            {
                Toplama();
            }
            else if (islem == "-")
            {
                Cikarma();
            }
            else if (islem == "*")
            {
                Carpma();
            }
            else if (islem == "/")
            {
                Bolme();
            }
            else
            {
                Console.WriteLine("Hatalı İşlem!!");
            }
        }

        internal static void Toplama()
        {
            Console.WriteLine("1.Sayı:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(sayi1+sayi2);
        }

        internal static void Cikarma()
        {
            Console.WriteLine("1.Sayı:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(sayi1 - sayi2);
        }

        internal static void Carpma()
        {
            Console.WriteLine("1.Sayı:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(sayi1 * sayi2);
        }

        internal static void Bolme()
        {
            Console.WriteLine("1.Sayı:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(sayi1 / sayi2);
        }
    }
}
