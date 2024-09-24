
using _12_Methods_1;

namespace _12_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Static: Farklı classta tanımlanan metodun class adı üzerinden direk erişilerek çağrılmasını sağlar.Static bir class içinde static methodlar kullanılır.



             DataAccessModifier:Tanımlanan yapıların erişilebilirliğini tanımlar.
                 *public: Solution altındaki bütün projelerin ve proje altındaki tanımların hepsinin erişimine açık demektir.
                 *internal: Kendi tanımlı olduğu proje altında erişime açık demektir.
                 *private: Kendi tanımlı olduğu class altında erişime açık demektir. Bir erişşim belirteci verilmezse yapılar default PRIVATE tanımını alır.
                 *protected: Miras alınan classlar altında erişime açık demektir.
                 
             
              Metotlar 2'ye ayrılır:
                *Değer Döndürmeyen Metot-void 
                *Değer Döndüren Metot-return
                 
                 
       */

            //Static Method Called
            Matematik.StaticToplama();

            //NonStatic Method Called
            Matematik m = new Matematik();
            m.NonStaticToplama();


            Random rnd = new Random(); // Nonstatic

            Console.WriteLine();

            //Giriş Kontrol İşlemi

            Login();

            Console.WriteLine("Bitti");
            Login();

            Console.WriteLine("Bitti");
            Login();


            DortIslem dortIslem = new DortIslem();
            dortIslem.DortIslemMetot();

        }

        static void Login()
        {
            string username = "altanemre";
            string password = "ab18";

            int hak = 3;
            for (int i = 0; i < hak; i++)
            {
                Console.WriteLine("Kullanıcı Adı:");
                string kullaniciAdi = Console.ReadLine();
                Console.WriteLine("Şifre:");
                string sifre = Console.ReadLine();

                if (kullaniciAdi == username && sifre == password)
                {
                    Console.WriteLine("Giriş Başarılı");
                    break;
                }
                else
                {
                    Console.WriteLine("Giriş Başarısız!!");
                }


            }
        }

    }
}
