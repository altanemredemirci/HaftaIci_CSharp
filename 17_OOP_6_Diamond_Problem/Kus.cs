using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_6_Diamond_Problem
{
    // Çoklu kalıtım desteklemediği için hem UcanNesne hem de YuruyenNesne özelliklerini kullanamadık. 
    public class Kus : UcanNesne //,YuruyenNesne
    {
        public override void Uc()
        {
            Console.WriteLine("Kuş kanatlarıyla uçuyor...");
        }
    }
}
