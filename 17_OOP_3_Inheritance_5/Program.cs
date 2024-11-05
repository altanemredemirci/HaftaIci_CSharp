using System.Collections;

namespace _17_OOP_3_Inheritance_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ÖDEV
            /*
         ﻿*******************************************************************
            *****************     Ödev2   	**************************
*******************************************************************

Çeşitli seviyelerdeki öğrenci bilgilerini tutan ve aşağıda verilen işlemleri yapan programı; 
Kalıtım, kapsülleme ve isimlendirme standartlarını dikkate alarak yazınız.
Kullanılacak bilgiler: Sınıf tanımlama,yapıcı metot kullanımı ve kalıtımı, kalıtım, kapsülleme, arraylist kullanımı, akış kontrol mekanizmaları kullanımı,

Soru: 
Tüm öğrenciler(Ogrenci) için saklanacak bilgiler:
----------------------------------------
* Ad Soyad(tek özellikte tutulacak)
* Okul Numarası
* Okul Adı = "Açıktan Eğitim"	(Alt sınıflarda tanımlanırsa değişecek)
* Ögretim Duzeyi(IlkOgretim,OrtaOgretim,Lise,Lisans) enum tipinde  4 elemanlı

NOT: Yukarıdaki bilgileri tutmak için bir ArrayList tanımlanacak(sadece bu 4 bilgi tutacak)

Tüm öğrenciler(Ogrenci) için uygulanacak işlemler:
-----------------------------------------
* Yapıcı metot ile nesne tanımlandığında notlar otomatik olarak ArrayListe eklenecek.(constructer 4 parametre ile çağırılacak.)
* NotHesapla(): Ekrana "Not Bilgisi Eksik !" yazdıracak.(Alt sınıflarda tanımlanırsa değişecek)


LiseOgrencisi için saklanacak bilgiler:
---------------------------------------
* Okul Adı
* Not1 (1. sınav notu)
* Not2 (2. sınav notu)


LiseOgrencisi için uygulanacak işlemler:
----------------------------------------
* Constructer metot 3 özelliği parametre olarak isteyecek.
* NotHesapla(): 2 notun aritmetik ortalamasını alacak ekrana yazdıracak.

5	85.00-100	Pekiyi
4	70.00-84.99	İyi
3	60.00-69.99	Orta
2	50.00-59.99	Geçer	
1	0 - 49.99	Tekrar

LisansOgrencisi için saklanacak bilgiler:
-----------------------------------------
* Fakülte
* VizeNotu
* FinalNotu

LisansOgrencisi için uygulanacak işlemler:
------------------------------------------
* Constructer metot 3 özelliği parametre olarak isteyecek.
* NotHesapla(): vizenin %40 ını finalin %60 ını alıp ortalamayı aşağıdaki gibi derecelendirerek ekrana yazdıracak.

85.00-100	A
70.00-84.99	B
60.00-69.99	C
50.00-59.99	D
45- 49.99	E
0 - 44.99	F
Program sınıfında tanımlanacak metot:

OgrenciNotHesapla(Ogrenci ogr)
ogr.NotHesapla

Main metodunda yapılacak işlemler:
----------------------------------
Lise ve Lisans tipinde ayrı nesne bilgileri girilerek tanımlanacak.
Nesneler OgrenciNotHesapla metoduna parametre olarak gönderilerek not hesaplama metotları çalıştırılacak.

*******************************************************************
*****************    	   Başarılar	**************************
*******************************************************************

         */
            #endregion
            
            /*
              Şirket Otomasyonu

             IK:Ad,Soyad,TC,SGKGirisTarihi,PersonelSayisi
             IT:Ad,Soyad,TC,SGKGirisTarihi,ProgramSayisi
             MUH:Ad,Soyad,TC,SGKGirisTarihi,HesapSayisi
             PAZ:Ad,Soyad,TC,SGKGirisTarihi,TeklifSayisi

             PersonelEkle(),PersonelListele(),PersonelSil(),PersonelGuncelle()
             */

            List<InsanKaynaklari> IKListesi = new List<InsanKaynaklari>()
            {
                new InsanKaynaklari(){Id=1,Ad="Altan",Soyad="Demirci",TC="111",PersonelSayisi=5},
                new InsanKaynaklari(){Id=2,Ad="Uras",Soyad="Demirci",TC="112",PersonelSayisi=15},
                new InsanKaynaklari(){Id=3,Ad="Kıvanç",Soyad="Demirci",TC="113",PersonelSayisi=25},
                new InsanKaynaklari(){Id=4,Ad="Kerem",Soyad="Demirci",TC="114",PersonelSayisi=35}
            };

            List<BilgiIslem> ITListesi = new List<BilgiIslem>();

            //1.Yöntem
            BilgiIslem it2 = new BilgiIslem()
            {
                Id=12,  Ad="Mahmut",  Soyad="Kurt",  TC="223", ProgramSayisi=2
            };

            ITListesi.Add(it2);



            //2.Yöntem 
            BilgiIslem it = new BilgiIslem();
            it.Ad = "Berkay";
            it.TC = "222";
            it.Id = 11;
            it.ProgramSayisi = 1;
            it.Soyad = "Kerem";

            ITListesi.Add(it);

            

            #region NonStatic Kayit Metodu

            /*
             IK sınıfından bir nesne(IKObject) oluşturarak o nesne üzerinden kayıt işlemini yaptık.
             
             */

            //InsanKaynaklari IKObject = new InsanKaynaklari();
            //IKObject.Kayit();// kayıt metodu çalıştığında IKObject nesnesinin property bilgileri dolar.
            //IKListesi.Add(IKObject); // Bilgileri doldurulmuş IKObject nesnesi InsanKaynaklari tipinde data tutan listeye(IKListesi) eklenir.
            #endregion


            #region Static Kayit Metodu
            //// IK classı içinde parametre olarak IK tipinde liste alan Kayit() metodu tanımladım. Metot kendisi nesne oluşturdu, bu nesnenin özelliklerini kullanıcıdan aldı ve benim parametre olarak gönderdiğim listeye ekledi.
            //InsanKaynaklari.Kayit(IKListesi);
            #endregion

            while (true)
            {
                Console.WriteLine("Lütfen Birim Seçiniz:\n1-Insan Kaynaklari\n2-Bilgi İşlem\n3-Muhasebe\n4-Pazarlama");
                string secim = Console.ReadLine();

                if (secim == "1") 
                {
                    Console.WriteLine("İşlem Seçiniz:\n1-Ekle\n2-Güncelle\n3-Sil\n4-Listele");
                    string islem = Console.ReadLine();

                    if (islem == "1") 
                    {
                        InsanKaynaklari IK = new InsanKaynaklari();
                        IK.Kayit();
                        IKListesi.Add(IK);
                    }
                    else if (islem == "2") 
                    {
                        InsanKaynaklari.Guncelle(IKListesi);
                    }
                    else if (islem == "3") 
                    {
                        InsanKaynaklari.Sil(IKListesi);
                    }
                    else if (islem == "4") 
                    {
                        InsanKaynaklari.Listele(IKListesi);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı İşlem!!");
                    }

                }
                else if (secim == "2") { }
                else if (secim == "3") { }
                else if (secim == "4") { }
                else
                {
                    Console.WriteLine("Hatalı Birim!!");
                }

            }

        }
    }

}
