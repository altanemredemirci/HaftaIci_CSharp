namespace _17_OOP_3_Inheritance_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        class A
        {
            public virtual void VirtualMethod()
            {
                Console.WriteLine("A tarafından yazıldı.");
            }
        }

        class B : A
        {
            // Bir method override edilirken sealed olarak işaretlenirse bu tipten kalıtım alan tipler ilgili methodu override edemezler!
            public sealed override void VirtualMethod()
            {
                Console.WriteLine("B tarafından yazıldı.");
            }
        }

        class C : B
        {
            // C sınıfı VirtualMethod methodunu override edemez! Çünkü VirtualMEthod, B tipinde sealed olarak işaretlenmiştir.
            //public override void VirtualMethod()
            //{
            //    Console.WriteLine("B tarafından yazıldı.");
            //}
        }

        // Eğer bir class sealed olarak işaretlenmişse o class'dan artık kalıtım yapılamaz!
        sealed class D : C
        {
            
        }

        // D class'ı sealed olduğu için kalıtım yapılamaz! Derleme zamanında hata verir.
        //class E : D
        //{

        //}
    }
}
