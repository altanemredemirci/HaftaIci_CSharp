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

            List<InsanKaynaklari> IKListesi = new List<InsanKaynaklari>();

            InsanKaynaklari IKObject = new InsanKaynaklari();
            IKObject.Kayit();// kayıt metodu çalıştığında IKObject nesnesinin property bilgileri dolar.
            IKListesi.Add(IKObject); // Bilgileri doldurulmuş IKObject nesnesi InsanKaynaklari tipinde data tutan listeye(IKListesi) eklenir.

         


        }
    }

}
