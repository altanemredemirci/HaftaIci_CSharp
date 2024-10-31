namespace _17_OOP_3_Inheritance_3
{
    internal class Program:Hayvan
    {
        static void Main(string[] args)
        {
            //public:Aynı Solution altındaki her projenin kullanımına açık
            //internal:Tanımlandığı projenin içinde kullanıma açık
            //private:Tanımlandığı class içinde kullanıma açık
            //protected:Tanımladığı classı miras alan classların kullanımına açık


            Kedi kedi = new Kedi(20,10,"Sarman");

            Console.WriteLine(kedi.Turu);
            Console.WriteLine(kedi.Agirlik);
            //Console.WriteLine(kedi.Boy);

            //kedi.Yas = 10; //protected özellikte bir tanım sadece türediği classta kullanılabilir.


            Memeli memeli = new Memeli(20,10.5);

            //memeli.Yas = 10;
        }
    }
}
