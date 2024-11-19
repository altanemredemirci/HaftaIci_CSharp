using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_6_Diamond_Problem
{
    // Çoklu kalıtım desteklenmediği için kurduğumuz yapıda Insan'a YuzenNesne özelliklerini ekleyemedik!
    public class Insan : YuruyenNesne //YuzenNesne
    {
        public override void Yuru()
        {
            Console.WriteLine("Insan ayaklarıyla yürüyor.");
        }
    }
}
