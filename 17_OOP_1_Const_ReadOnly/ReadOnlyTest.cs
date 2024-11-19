using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_1_Const_ReadOnly
{
    public class ReadOnlyTest
    {
        // Readnonly bir alanın değeri yalnızca ctor ve initializer içinde atanabilir ! Daha sonra atanma şansı yoktur.
        public readonly int YalnizcaOkunanDeger = 5;

        public ReadOnlyTest()
        {
            YalnizcaOkunanDeger = 10;
            YalnizcaOkunanDeger = 15;
            YalnizcaOkunanDeger = 20;
        }

        void DegeriDegistiremem()
        {
            // Nesnenin kendisi dahil, bu field'ı kimse değiştiremez!
            // YalnizcaOkunanDeger = 14;
        }
    }
}
