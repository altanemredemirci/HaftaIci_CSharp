using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_3_Inheritance_3
{
    internal class Kopek:Memeli
    {
        public string Cins;

        public Kopek(double Boy, double Agirlik, string Cins):base(Boy,Agirlik)
        {
            this.Cins = Cins;
        }
    }
}
