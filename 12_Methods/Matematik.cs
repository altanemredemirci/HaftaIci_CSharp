using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Methods
{
    internal class Matematik
    {
        //Erişim keyword tanımlanmaz ise default PRIVATE tanımlanır.
        internal static void StaticToplama()
        {
            Console.WriteLine("1.sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(s1 + s2);
        }

        internal void NonStaticToplama()
        {
            Console.WriteLine("1.sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(s1 + s2);
        }
    }
}
