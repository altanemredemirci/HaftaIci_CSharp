using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_3_Inheritance_5
{
    internal class InsanKaynaklari:Personel
    {
        public int PersonelSayisi { get; set; }

        
        internal new void Kayit()
        {
            base.Kayit();
            Console.WriteLine("Personel Sayısı:");
            this.PersonelSayisi = Convert.ToInt32(Console.ReadLine());

        }

    }
}
