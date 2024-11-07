namespace _17_OOP_4_Polymorphism_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*AŞAĞIDAKİ örnekte Daire, Kure ve Dikdörtgen sınıfları Sekil temel sınıfından türetilmişlerdir.
             Daire ve Küre de Sekil sınıfında “virtual” tanımlanan alan metodu yeniden yazılmıştır. Bu
             yeniden yazma (geçersiz kılma) esnasında “override” sözcüğünün kullanıldığına dikkat
             ediniz. Ayrıca burada dikkat edilmesi gereken nokta “virtual” ve “override” metotların imzalarının (dönüş türleri ile birlikte parametrelerinin tür ve sayıları) aynı olması gerekliliğidir.*/

            Daire daire = new Daire(10);
            daire.Alan();
        }
    }

    public class Sekil
    {
        public const double PI = Math.PI; //Constant: Sabit değişken

        protected double x; //Sadece Şekil sınıfını miras alan sınıflar kendi içinde x ve y özelliklerine erişebilir.
        protected double y;

        public Sekil(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Alan()
        {
            return x * y;
        }
    }
    public class DikDortgen : Sekil
    {
        public DikDortgen(double a, double b) : base(a, b)
        {

        }
    }
    public class Daire : Sekil
    {
        public Daire(double r) : base(r, 0)
        {
           
        }

        public override double Alan()
        {
            return PI * x * x;
        }
    }
    public class Kure : Sekil
    {
        public Kure(double r) : base(r, 0)
        {

        }

        public override double Alan()
        {
            return 4 * PI * x * x;
        }
    }


}
