namespace _17_OOP_6_Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Balik balik = new Balik();
            balik.Yuz();

            Kus kus = new Kus();
            kus.Yuru();
            kus.Uc();

            Insan insan = new Insan();
            insan.Yuru();
            insan.Yuz();

            IYuzebilir yuzebilenNesne;
            yuzebilenNesne = new Balik();
            yuzebilenNesne.Yuz();

            yuzebilenNesne = new Insan();
            yuzebilenNesne.Yuz();

            // IUcabilir interface'ini implement ettiği için Kus tipinden üretilen nesneyi methoda parametre olarak gönderebildik.
            Ucur(new Kus());

            Yuzdur(new Insan());
            Yuzdur(new Balik());

            Yurut(new Insan());
            Yurut(new Kus());
    
            
        }

        public static void Ucur(IUcabilir ucabilenNesne)
        {
            ucabilenNesne.Uc();
        }

        public static void Yurut(IYuruyebilir yuruyebilenNesne)
        {
            yuruyebilenNesne.Yuru();
        }

        public static void Yuzdur(IYuzebilir yuruyebilenNesne)
        {
            yuruyebilenNesne.Yuz();
        }
    }
}
