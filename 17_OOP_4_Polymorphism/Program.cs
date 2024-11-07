namespace _17_OOP_4_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             POLYMORPHISM NEDİR? 

             Çokbiçimlilik (Polymorphism) bir nesnenin farklı amaçlar için de kullanılabileceği anlamına gelir ve statik, dinamik olmak üzere ikiye ayrılır.

                * Statik çokbiçimlilik; metot ve operatörlerin aşırı yüklenmesi (overload) olarak belirtilir.
                * Dinamik çokbiçimlilik; özet sınıflardan miras alma yoluyla işlemlerin gerçekleştirilmesi işlemine verilen isimdir.

            Statik çokbiçimlilik türünden, metotların aşırı yüklenmesine yönelik bir çalışma yapacağız.
                                  
            Dinamik çokbiçimlilik türünden, metodu override etmeliyiz.

            VIRTUAL() METODU

            *Temel sınıfa ait bir metodun bazen türemiş sınıfta farklı bir şekilde kullanılması gerekebilir. Bu durumda temel sınıfın söz konusu metodu türemiş sınıfın değiştirip kullanabileceği yönünde izin vermesi gerekir. Bu izin, metodun temel sınıfta “virtual” olarak tanımlanması sonucu verilmektedir. Diğer bir ifadeyle temel sınıfta “virtual” olarak tanımlanmış bir metodun türemiş sınıfta yeniden yazılabileceği belirtilmiş olunuyor.


            METODU OVERRIDE ETMEK, OVERRIDE NEDİR?METOTUN EZİLMESİ

            *Temel sınıfta “virtual” tanımlanmış bir metodun türemiş sınıfta yeniden yazılması için (geçersiz kılma) “override” sözcüğü kullanılır. 
             *Temel sınıfta “virtual” tanımlanmamış ya da “static” tanımlanmış olan üyeler (metot, özellik, dizinleyici ya da olay) türemiş sınıfta yeniden yazılamaz (Geçersiz kılınamaz.).

            Ayrıca temel sınıfta “virtual”, “abstract” ya da “override” olarak tanımlanmış
            metotlar türemiş sınıfta geçersiz kılınabilir.
            Bir diğer önemli nokta da “override” metotlar “new”, “static” ya da “virtual”
            sözcükleri ile tanımlanamaz.

            Son olarak “virtual” metodun erişim belirteci “override” sırasında değiştirilemez.
            Yani temel sınıfta metot “public” ise türemiş sınıfta da “public”, “protected” ise “protected” kalmalıdır.
            */


            //Ogrenci class'ın da NotAl() metodu Statik Polymorphism oldu.
            //Ogrenci ogrenci = new Ogrenci(); //Instance
            //ogrenci.NotAl();
            //ogrenci.NotAl(100,80);


            //Ogretmen class'ın da Kalıtım ile gelen Kayit() metodu override keyword ü ile ezilerek yeniden tanımlandı.
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Kayit();
        }
    }

    class LiseOgrenci : Ogrenci
    {
        internal override void Kayit()
        {
            base.Kayit();
        }
    }


    class Ogrenci:Insan //internal
    {
        public int Numara { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }

        internal void NotAl() //private
        {
            Console.WriteLine("Vize:");
            Vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final:");
            Final = Convert.ToInt32(Console.ReadLine());
        }

        internal void NotAl(int Vize, int final) //private
        {
            this.Vize = Vize;
            Final = final;
        }

        internal override void Kayit()
        {
            base.Kayit();
            Console.WriteLine("Numara:");
            Numara =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vize:");
            Vize= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final:");
            Final=Convert.ToInt32(Console.ReadLine());

        }

    }

    class Ogretmen:Insan
    {
        public string Brans { get; set; }

        internal override void Kayit()
        {
            base.Kayit();
            Console.WriteLine("Branşı:");
            Brans = Console.ReadLine();
        }
    }

    class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        internal virtual void Kayit()
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
            Console.WriteLine("Yaş:");
            Yas = Convert.ToInt32(Console.ReadLine());
        }

    }
}
