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

            //Console.WriteLine("Haftanın kaçıncı günündeyiz?");
            //int gun = Convert.ToInt32(Console.ReadLine());


            //if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (gun == 7)
            //{
            //    Console.WriteLine("Pazar");
            //}
            //else
            //{
            //    Console.WriteLine("Hafta 7 günden oluşur!!!");
            //}
            #endregion


            #region ÖDEV 1

            //Kullanıcıdan iki ürün fiyatı isteyin, ürün fiyat toplamları 2500 tl geçerse ucuz ürüne  % 25 indirim uygulayınız

            //Console.WriteLine("1.ürün fiyatı:");
            //double urun1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.ürün fiyatı:");
            //double urun2 = Convert.ToDouble(Console.ReadLine());

            //double toplam = urun1 + urun2;

            //if (toplam > 2500)
            //{
            //    if (urun1 > urun2)
            //    {
            //        urun2 *= 0.75; //urun2=urun2*0.75; //1000*0.75
            //    }
            //    else
            //    {
            //        urun1 *= 0.75;
            //    }
            //}
            //Console.WriteLine("Ödeme:" + (urun1 + urun2));




            //2.Yol
            //if (toplam > 2500)
            //{
            //    //ternary operand
            //    toplam = urun1 > urun2 ? (urun2 * 0.75) + urun1 : (urun1 * 0.75) + urun2;
            //}
            //Console.WriteLine("Ödeme:" + toplam);

            #endregion



            #region ÖDEV 2
            // Aylık geliri 40000 üstünde ise %12 vergi kesilecek,
            // 40000 ve altında ise %9 vergi kesimi yapılarak 
            // kullanıcıya yeni gelirini bu hesaplamalar sonucunda gösteriniz

            //Console.WriteLine("Aylık Geliriniz:");
            //double gelir = Convert.ToDouble(Console.ReadLine());

            //gelir = gelir > 40000 ? gelir * 0.88 : gelir * 0.91;
            //Console.WriteLine("Yeni Geliriniz:" + gelir);

            //    //2.yol
            //Console.WriteLine("Yeni Geliriniz:" + (gelir > 40000 ? gelir * 0.88 : gelir * 0.91));

            //3.Yol
            //if (gelir > 40000)
            //{
            //    //double vergi = gelir * 0.12;
            //    //gelir = gelir - vergi;

            //    gelir = gelir * 0.88; //1.00 - 0.12
            //}
            //else
            //{
            //    gelir = gelir * 0.91;
            //}

            //Console.WriteLine("Yeni Geliriniz:" + gelir);
            #endregion




            //  Harcanan m3 istenilecek ve
            //0 - 100 harcamışsa 0.35 ile fiyatlandırılacak
            //101 - 250=> 0.38 üzerinde hesaplandırılacak
            //251 - 400=> 0.41 üzerinde
            //401 - 600=> 0.42
            //600 üstü ise 120 tl indirim yapılacak ve fiyatlandırma 0.43 üzerinde verilecek

            #endregion

            //GOTO KOMUTU

            #region Kullanıcıdan haftanın gün sayısını alınız.Girilen rakama göre gün adını ekrana yazdırınız.

            //DON:
            //       Console.WriteLine("Haftanın kaçıncı günündeyiz?");
            //       int gun = Convert.ToInt32(Console.ReadLine());


            //       if (gun == 1)
            //       {
            //           Console.WriteLine("Pazartesi");
            //       }
            //       else if (gun == 2)
            //       {
            //           Console.WriteLine("Salı");
            //       }
            //       else if (gun == 3)
            //       {
            //           Console.WriteLine("Çarşamba");
            //       }
            //       else if (gun == 4)
            //       {
            //           Console.WriteLine("Perşembe");
            //       }
            //       else if (gun == 5)
            //       {
            //           Console.WriteLine("Cuma");
            //       }
            //       else if (gun == 6)
            //       {
            //           Console.WriteLine("Cumartesi");
            //       }
            //       else if (gun == 7)
            //       {
            //           Console.WriteLine("Pazar");
            //       }
            //       else
            //       {
            //           Console.WriteLine("Hafta 7 günden oluşur!!!");
            //           goto DON;
            //       }
            #endregion


            #region Bir üniversite öğrenci vize ve final notlarını sisteme girecek. Vizenin %40, Finalin %60 ile ortalama hesaplanacak. Ortalamaya göre aşağıdaki harf notu ekrana yazdırılacak.
            /*
             0-24  FF
            25-44  DD
            45-54  CC
            55-69  CB
            70-84  BB
            85-100 AA
             */
            //VIZE:
            //     Console.WriteLine("Vize:");
            //     double vize = Convert.ToDouble(Console.ReadLine());

            //     if (vize < 0 || vize > 100)
            //     {
            //         Console.WriteLine("Vize notu hatalı! 0-100 aralığında giriniz");
            //         goto VIZE;
            //     }
            //     else //0<=vize<=100
            //     {
            //    FINAL:
            //         Console.WriteLine("Final:");
            //         double final = Convert.ToDouble(Console.ReadLine());

            //         if (final < 0 || final > 100)
            //         {
            //             Console.WriteLine("Final notu hatalı! 0-100 aralığında giriniz");
            //             goto FINAL;
            //         }
            //         else//0<=final<=100
            //         {
            //             double ortalama = vize * 0.4 + final * 0.6;


            //             if (ortalama > 0 && ortalama < 25)
            //             {
            //                 Console.WriteLine("FF");
            //             }
            //             else if (ortalama >= 25 && ortalama < 45)
            //             {
            //                 Console.WriteLine("DD");
            //             }
            //             else if (ortalama >= 45 && ortalama < 55)
            //             {
            //                 Console.WriteLine("CC");
            //             }
            //             else if (ortalama >= 55 && ortalama < 70)
            //             {
            //                 Console.WriteLine("CB");
            //             }
            //             else if (ortalama >= 70 && ortalama < 85)
            //             {
            //                 Console.WriteLine("BB");
            //             }
            //             else 
            //             {
            //                 Console.WriteLine("AA");
            //             }
            //         }


            //     }


            #endregion

            #region ODEV
            /*
            # Kullanıcıdan isim, yaş, maaş ve çocuk sayısı alınsın.
           
           Eğer kulanıcının yaşı 45'in altındaysa;
               Çocuk sayısına bakılacak. Ve çocuk sayısı 3'ten az ise çocuk başına 2500₺, 3 ve 3'ten çok ise çocuk başına  2000₺ 
                maaşa ekleme yapılacak.
           45 ve üzerinde ise çocuk başına para verilmeyecek ancak 5000₺ ekleme yapılacak.
                Son olarak ekrana : "Nesrin Yılmaz, Maaşınız: 40000₺" yazılacak.  
            */

            //Console.WriteLine("İsim:");
            //string isim = Console.ReadLine();

            //Console.WriteLine("Yaş:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Maaş:");
            //int maas = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Çocuk Sayısı:");
            //int cocukSayisi = Convert.ToInt32(Console.ReadLine());

            //if (yas < 45)
            //{
            //    if (cocukSayisi < 3)
            //    {
            //        maas += cocukSayisi * 2500; // maas = maas+(cocukSayisi*2500)
            //    }
            //    else
            //    {
            //        maas += cocukSayisi * 2000;
            //    }
            //}
            //else
            //{
            //    maas += 5000;
            //}

            //Console.WriteLine($"Sayın {isim} Maaşınız:{maas} ");

            #endregion


        }
    }
}
