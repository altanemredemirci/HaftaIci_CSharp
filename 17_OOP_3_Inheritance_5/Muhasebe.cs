using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_3_Inheritance_5
{
    internal class Muhasebe:Personel
    {
        public int HesapSayisi { get; set; }

        internal new void Kayit()
        {
            base.Kayit();
            Console.WriteLine("Hesap Sayısı:");
            this.HesapSayisi = Convert.ToInt32(Console.ReadLine());
        }
    }
}
