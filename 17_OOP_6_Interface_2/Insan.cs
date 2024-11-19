using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_6_Interface_2
{
    internal class Insan : IYuruyebilir, IYuzebilir
    {
        public void Yuru()
        {
            Console.WriteLine("Insan ayaklarıyla yürüyor.");
        }

        public void Yuz()
        {
            Console.WriteLine("Insan kulaç atarak yüzüyor.");
        }
    }
}
