using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_3_Partial_8
{
    partial class Partial
    {
        partial void Test1()
        {
            Console.WriteLine("Test-1 çalıştı");
        }

        partial void Test2()
        {
            Console.WriteLine("Test-2 çalıştı.");
        }

        public void ErisilebilirMethod2()
        {
            Test1();
            Test2();
        }
    }
}
