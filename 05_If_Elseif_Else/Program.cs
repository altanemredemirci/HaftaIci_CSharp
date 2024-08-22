namespace _05_If_Elseif_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSEIF ELSE

            /*
            ** Kodun akışı belirli şartlara göre yönlendirilecek ise CONDITION-KoşulYapıları kullanılır.

            *If Elseif Else
            *Switch Case

            Bir sorguda ilk koşul if ile kontrol edilir.Alternatif koşullar else if deyimleri ile kontrol edilir ve bütün durumlar-koşullar kontrol edildiktan sonra geriye kalan koşullar için else deyimi kullanılır.
            Bir kara yapısında if ve else bir defa tanımlanır ve else geriye kalan bütün durumlar olduğu için koşul ALMAZ.


            
            1-Başla
            2-sayi=Bir sayı giriniz
            3-Eğer sayi>0 ise Ekrana "Pozitif" yaz
            4-Değilse Eğer sayi<0 ise Ekrana "Negatif" yaz
            5-Değilse Ekrana "Sayı 0'a eşittir" yaz
            6-Bitti

              Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)
            {
                Console.WriteLine("Pozitif");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Negatif");
            }
            else
            {
                Console.WriteLine("Sayı 0'a eşittir");
            }





            */

            #region Kullanıcıdan haftanın gün sayısını alınız.Girilen rakama göre gün adını ekrana yazdırınız.

            Console.WriteLine("Haftanın kaçıncı günündeyiz?");
            int gun = Convert.ToInt32(Console.ReadLine());


            if (gun == 1)
            {
                Console.WriteLine("Pazartesi");
            }
            else if (gun == 2)
            {
                Console.WriteLine("Salı");
            }
            else if (gun == 3)
            {
                Console.WriteLine("Çarşamba");
            }
            else if (gun == 4)
            {
                Console.WriteLine("Perşembe");
            }
            else if (gun == 5)
            {
                Console.WriteLine("Cuma");
            }
            else if (gun == 6)
            {
                Console.WriteLine("Cumartesi");
            }
            else if (gun == 7)
            {
                Console.WriteLine("Pazar");
            }
            else
            {
                Console.WriteLine("Hafta 7 günden oluşur!!!");
            }
            #endregion


            //Kullanıcıdan iki ürün fiyatı isteyin, ürün fiyat toplamları 2500 tl geçerse ucuz ürüne  % 25 indirim uygulayınız





            // Aylık geliri 40000 üstünde ise %12 vergi kesilecek,
            // 40000 ve altında ise %9 vergi kesimi yapılarak 
            // kullanıcıya yeni gelirini bu hesaplamalar sonucunda gösteriniz



            /*  Harcanan m3 istenilecek ve 
          0-100 harcamışsa 0.35 ile fiyatlandırılacak
          101-250=> 0.38 üzerinde hesaplandırılacak
          251-400=> 0.41 üzerinde 
          401-600=> 0.42
          600 üstü ise 120 tl indirim yapılacak ve fiyatlandırma 0.43 üzerinde verilecek
          */


            #endregion
        }
    }
}
