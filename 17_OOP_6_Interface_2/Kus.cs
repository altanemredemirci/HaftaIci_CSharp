using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_6_Interface_2
{
    internal class Kus : IYuruyebilir, IUcabilir
    {
        public void Uc()
        {
            Console.WriteLine("Kuş kanatlarıyla uçabiliyor.");
        }

        public void Yuru()
        {
            Console.WriteLine("Kuş ayaklarıyla yürüyor.");
        }
    }
}
