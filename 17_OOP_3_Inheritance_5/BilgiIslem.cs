using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_3_Inheritance_5
{
    internal class BilgiIslem : Personel
    {
        public int ProgramSayisi { get; set; }

        internal new void Kayit()
        {
            base.Kayit();
            Console.WriteLine("Program Sayısı:");
            this.ProgramSayisi = Convert.ToInt32(Console.ReadLine());
        }
    }
}
