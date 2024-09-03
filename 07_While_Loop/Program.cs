namespace _07_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                LOOPS - DÖNGÜLER
              Döngüler tekrarlı işlemleri yapmaya yarar. Bir geliştirme içerisinde belili kod bloklarının bir şarta bağlı veya şartsız tekrar tekrar çalışması gerekiyor ise DÖNGÜLER kullanılır.

                * WHILE
                * FOR
                * DO While
                * FOREACH


            ********* WHILE ***********
            
            int i = 1;                  //sayac
            while (i < 6) //koşul
            {
                Console.WriteLine(i); //kod bloğu
                i++;                   //step
            }
            

            ** BREAK: Okunduğu satırda döngüyü kırar.
            ** CONTINUE : Okunduğu satırdan döngü koşuluna geri dönmeyi sağlar.


          

            //1-5 aralığında sayıları ekrana alt alta yazdırınız
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);



            int i = 1;
            while (i < 6)
            {
                Console.WriteLine(i);
                //if (i == 3)
                //{
                //    break;
                //}

                if (i == 4)
                {
                    continue;
                }

                i++; //i=i+1;  i+=1
            }
               */
            #region 200 den başlayarak 0 a kadar olan sayıları ekrana yazdırınız.

            //int i = 200;
            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            #endregion

            #region 200 den başlayarak 0 a kadar olan sayılardan 3'ün katları olan sayıları ekrana yazdırınız.

            //int i = 200;
            //while (i > 0)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }                
            //    i--;
            //}

            #endregion

            #region 1 ile 5 arasındaki sayıların toplamını ekrana yazdırınız

            //int i = 1;
            //int toplam = 0;

            //while (i < 6)
            //{
            //    toplam = toplam + i;
            //    i++;
            //}

            //Console.WriteLine("Toplam:"+toplam);

            #endregion

            #region Örnek
            //string sifre = "ab18";

            //int hak = 3;

            //while (hak > 0)
            //{
            //    Console.WriteLine("Şifreniz");
            //    string sfr = Console.ReadLine();

            //    if (sifre == sfr)
            //    {
            //        Console.WriteLine("Giriş Başarılı");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tekrar Deneyiniz");
            //        hak--;
            //    }
            //    //hak--
            //}

            //Console.WriteLine("ANAMENÜ\n1-Para Çekme\n2-Para Yatırma");


            //Console.WriteLine("ANAMENÜ");
            //Console.WriteLine("1-Para Çekme");
            #endregion
            #region Kullanıcıdan 0 girilene kadar pozitif sayılar istensin. 0 girilene kadar girilen her sayı toplansın ve 0 girildiğin sayı istenmesin, toplam ve ortalama ekrana yazdırılsın.
            //** Kullanıcı ilk sayıyı 0 girerse tekrar sayı istensin
            //** Kullanıcı negatif sayı girerse "Lütfen Pozitif Bir Sayı Giriniz!!" uyarısı verilsin.
            //int toplam = 0;
            //int adet = 0;
            //while (true)
            //{               

            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0) 
            //    {
            //        Console.WriteLine("Toplam:" + toplam);
            //        Console.WriteLine("Ortalama:" + (toplam/adet));
            //        break;
            //    }
            //    else if (sayi < 0)
            //    {
            //        Console.WriteLine("Pozitif sayı giriniz!!");
            //    }
            //    else
            //    {
            //        adet++;
            //        toplam += sayi; // toplam= toplam+sayi;
            //    }
            //}





            #endregion
            #region Kullanıcıya kayıtlı username ve şifre giriş paneli için 3 hak veriniz ve 3 hak giriş yapamaz ise sistemi 10 saniye kitleyiniz. Kullanıcıya gerekli bütün uyarıları yapınız.

            //string username = "admin";
            //string pass = "123";
            //int hak = 3;
            //int girisSayisi = 0;

            //while (hak > 0)
            //{
            //    Console.WriteLine("Username:");
            //    string kullaniciAdi = Console.ReadLine();
            //    Console.WriteLine("Password:");
            //    string sifre = Console.ReadLine();

            //    hak--;
            //    girisSayisi++;
            //    if (sifre == pass && username == kullaniciAdi)
            //    {
            //        Console.WriteLine("Giriş Başarılı");
            //        break;
            //    }
            //    else if (hak == 0)
            //    {
            //        Console.WriteLine("Hakkınız bitti!");
            //        Thread.Sleep(1000*girisSayisi);
            //        hak = 3;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tekrar Deneyiniz");
            //    }
               
            //}
           



            #endregion


        }
    }
}
