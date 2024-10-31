using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_3_Inheritance_3
{
    internal class Memeli:Hayvan
    {        
        protected double Boy;
        public double Agirlik;

        public Memeli(double boy, double agirlik)
        {
            this.Boy = boy;
            this.Agirlik = agirlik;
        }
    }
}
