namespace _17_OOP_1_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
           ********* Object Oriented Programming - Nesne Yönelimli Programlama **********
           İlk yazılım sıralı satırlar olarak geliştiriliyordu.Sonrasında Class yapısı üzerinden geliştirilmeye başlandı ama hala büyük çaplı projeler yazılamıyordu.
            
            C dili => OOP geliştirilmesi ile C++ dili ortaya çıktı.
            C++ gün geçtikce popüleritesini kaybeden ama önceki yıllarda yazılmış projeler üzerinde hala geliştirilen çok güçlü bir dildir. Makine programlama, siber güvenlik, otomobil beyni, vb işler de kullanılır.

            İnternet icadıyla birlikte JAVA ve C# dilleri ortaya çıkmıştır.

            OOP 4 Temeli vardır.
            1-Encapsulation - Kapsülleme
            2-Inheritance - Kalıtım
            3-Polymorphism - Çok Biçimlilik
            4-Abstraction - Soyutlama
           */

            /* 
              ********* ENCAPSULATION *********
              
            Bir nesnenin propertylerinde doğruluk kontrolü yapılması gerektiğinde kullanılan bir OOP yapısıdır.

            Property PRIVATE olarak tanımlanır ve dışarıdan direk kullanıma kapatılır.
            Aynı property'in benzer isimde PUBLIC olarak bir tanımı yapılır ve kullanıcıdan bu property'e data girişi yapması istenir. 
            Girilen Data SET keyword ile kontrol edilerek asıl property e atanır.
            Get keyword ü ile de asıl property okunur.
              
             */

            Vatandas vatandas = new Vatandas();
            vatandas.AdSoyad = "Yasemin";
            Console.WriteLine(vatandas._TC);
            vatandas._TC = 12345678907;
            Console.WriteLine(vatandas._TC);

        }
    }

    class Vatandas
    {
        internal string AdSoyad;
        private long TC; //Çünkü bu property datası 11 rakamdan oluşmalıdır.

        public long _TC
        {
            get { return TC; }
            set
            {
                if (value.ToString().Length == 11)
                {
                    TC = value;
                }
                else
                {
                    TC = 0;
                }
            }
        }
    }
}
