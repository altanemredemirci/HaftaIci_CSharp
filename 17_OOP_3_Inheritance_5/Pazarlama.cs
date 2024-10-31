using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_3_Inheritance_5
{
    internal class Pazarlama:Personel
    {
        public int TeklifSayisi { get; set; }
       
        internal new void Kayit()
        {
            base.Kayit();
            Console.WriteLine("Teklif Sayısı:");
            this.TeklifSayisi = Convert.ToInt32(Console.ReadLine());
        }
    }
}
