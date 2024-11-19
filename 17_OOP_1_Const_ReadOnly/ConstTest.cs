using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_1_Const_ReadOnly
{
    // Const ile işaretlenmiş alanlar otomatik olarak static alanlar haline gelir.
    // Çünkü 3.14 sabit bir değer olup, ConstTest nesnesi için ayrıca saklanmasına gerek yoktur.
    // Bu değer static kullanımında olduğu gibi ConstTest.PiSayisi notasyonuyla erişilebilecek şekilde saklanır. 
    public class ConstTest
    {
        public const double PiSayisi = 3.14;

        public ConstTest()
        {
            // Const'lar yalnızca ve yalnızca field initializer içinde, tanımlandıkları yerde değer alabilirler. Ve bir daha asla ve asla değerleri değiştirilemez!
           //PiSayisi = 4;
        }

    }
}
