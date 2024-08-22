namespace _03_Operatorler_VeriTipiDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ATAMA OPERATÖRÜ(=)
            /*
            int sayi = 5;


            //İşlemli Atama

            sayi += 1;  //sayi = sayi + 1;
            sayi -= 1;  //sayi = sayi - 1;
            sayi *= 1;  //sayi = sayi * 1;
            sayi /= 1;  //sayi = sayi / 1;

            Console.WriteLine(sayi);

            */
            #endregion

            #region ARTTIRMA-AZALTMA OPERATÖRÜ(++ , --)
            //1 arttırma veya 1 azaltma yapılabilir.
            //int sayi = 5;

            //sayi++;
            //Console.WriteLine(sayi);

            //sayi--;
            //Console.WriteLine(sayi);

            #endregion

            #region ARİTMATİK OPERATÖRLER(+,-,*,/,%)

            /*
             int sayi = 1;
             int sayi2 = 3;

             int sonuc1 = sayi + sayi2;
             int sonuc2 = sayi - sayi2;
             int sonuc3 = sayi * sayi2;
             int sonuc4 = sayi / sayi2;


             int modAlma = sayi % sayi2;

             Console.WriteLine(modAlma);
             

            int sayi = 10;
            double bolen = 2;

            //Console.WriteLine(sayi/bolen);


            //int sonuc = (int)(sayi/bolen);
            //double sonuc = sayi/bolen;
            //Console.WriteLine(sonuc);

            double sonuc2 = sayi / bolen;
            Console.WriteLine(sonuc2);
            */


            #endregion

            #region KIYAS OPERATÖRÜ (? :)

            // Karşılaştırma sonucu TRUE ise ?, FALSE ise : tarafı atanır.

            //int sayi = 7;

            //string sonuc = sayi < 5 ? "Küçük" : "Büyük";

            //int sonuc2 = sayi < 5 ? 0 : 1;

            //bool sonuc3 = sayi < 5 ? true : false;


            //Console.WriteLine(sonuc);


            #endregion

            #region KARŞILAŞTIRMA OPERATÖRLERİ

            /*
            >
            <
            >=
            <=
            ==  eşit mi?
            ! = eşit değil mi?
             */


            #endregion


            #region MANTIKSAL OPERATÖRLER
            /* AND Operatörü (&&)
            Bİr sorguda bir fazla şartın kontrol edilmesi ve bütün şartların sağlanması (TRUE) gerekiyor ise AND && oparatörü kullanılır.  

            1.Koşul  2.Koşul      Sonuc
                F       F           F
                T       F           F
                F       T           F
                T       T           T

           1.Koşul  2.Koşul      Sonuc
                0       0           0
                1       0           0
                0       1           0
                1       1           1


            string username = "admin";
            string password = "123";


            bool result = username == "admin12" && password == "123" && ;



            int sayi = 15;

            bool cevap = sayi > 10 && sayi < 20;

            Console.WriteLine("Sayı 10-20 aralığında mı:"+cevap);


            //OR Operatörü (||)
            Bir sorguda bir fazla şartın kontrol edilmesi ve herhangi bir şartın True olaması yeterli ise OR || operator kullanılır.  

            //Instagram giriş durumu : Username/Email/Phone
            //                         Password

            //string username = "admin";
            //string email = "admin@gmail.com";
            //string password = "123";


            //Console.WriteLine("Username/Email:");
            //string kullanici = Console.ReadLine();

            //Console.WriteLine("Password:");
            //string sifre = Console.ReadLine();


            //bool login = (kullanici == username || kullanici == email) && sifre == password;
           
            */


            //Kullanıcıdan bir şehir adı alınız ve almış olduğunuz şehir adı adana,mersin,hatay dan biri ise True yazılsın


            //Değişken Tanımlama
            

            //Console.WriteLine("Şehir Giriniz:");
            //string sehir = Console.ReadLine();

            //bool cevap = sehir == "Adana" || sehir == "Mersin" || sehir == "Hatay";

            //Console.WriteLine(cevap);
            #endregion



            //ERİŞİM OPERATÖRÜ

            //Console.ReadLine();


            // 5 sayısının tek mi çift mi olduğunu kıyas operatörü(? :) ile ekrana yazdırınız.

            //int sayi = 5;

            //string cevap = sayi % 2 == 0 ? "ÇİFT SAYI" : "TEK SAYI";

            //Console.WriteLine(cevap);

        }
    }
}
