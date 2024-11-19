using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_3_Partial_8
{
    partial class Partial
    {
        // Partial methodlar, gövdesiz şekilde kod tarafında yazılırlar. Ancak bu yazım şekli abstract methodlar ile karıştırılmamalıdır!
        // abstract method: Gövdesi olmayan method
        // partial method: Gövdesi olmadan yazılır ancak; bu şekilde yazılan methodlar tanımlanmış sayılmazlar! Diğer bir deyişle bu method şu anda hiç yazılmamış gibidir.
        partial void Test1();

        partial void Test2();

        public void ErisilebilirMethod()
        {
            Test1();
            Test2();
        }
    }
}
