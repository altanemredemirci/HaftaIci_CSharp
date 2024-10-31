using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_3_Inheritance_3
{
    internal class Kedi:Memeli
    {      
        public string Turu;

        public Kedi(double Agirlik, double Boy, string Turu):base(Boy,Agirlik)
        {
            this.Yas = 10; //Miras yoluyla memeliden, memeliye de miras yoluyla hayvan classından aktarıldı.
            this.Turu = Turu;
        }
    }
}
