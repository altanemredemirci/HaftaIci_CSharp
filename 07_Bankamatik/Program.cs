﻿namespace _07_Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BANKAMATİK
            /*

            *   2500 tl parası olacak 
           Bir bankamatik düşünülerek tasarlanacak bir program  için 
           Kartlı işlem    1
           Kartsız işlem   2
           //********Kartlı işlem bölümü
           Şifre istenecek=> Şifre:ab18
           ==> şifrenin 3 defa yanlış olması halinde sistemden atılacak,değilse Ana Menü
           //*******************Ana Menü 
           Para Çekmek için    1
           Para yatırmak için  2
           Para Transferleri   3
           Eğitim Ödemeleri    4
           Ödemeler            5
           Bilgi Güncelleme    6
           //*********************Seçim 1************
           Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye
           Ana menüye dönmek için   9
           Çıkmak için             0
           //******************Seçim 2***********************
           Kredi Kartına   1
           Kendi Hesabınıza yatırmak için  2
           Ana Menü        9
           Çıkmak için     0
           //------------------------------------
           //----1
           Kredi kardı için en az 12 haneli kart numarasını girsin
           bakiye yeterli ise hesaptan kredi kartına para yatırılaca
           Ana Menü        9
           Çıkmak için     0
           //--------------------------
           //---2
           hesaba yatırılacak para değeri istenir veişlem gerçekleştirilir
           Ana Menü        9
           Çıkmak için     0
           //*****************************Seçim 3
           Başka Hesaba EFT    1
           Başka Hesaba Havale 2
           //---------------------------------
           //--1
           EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
           yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse
           Ana Menü        9
           Çıkmak için     0
           //-----------------------------
           //---2
           hesap için 11 haneli hesap numarası işlemler doğru ise
           gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
           Ana Menü        9
           Çıkmak için     0
           //****************Seçim 4
           Eğitim Ödemeleri sayfası arızalı
           Ana Menü        9
           Çıkmak için     0
           //****************************Seçim 5
           Elektrik Faturası       1
           Telefon Faturası        2
           İnternet faturası       3
           Su Faturası             4
           OGS Ödemeleri           5
           //-----------------------------------------
           //---1 => bütün faturala için aşağıdaki şart yeterli
           fatura tutarı istenir, hesap uygun ise yatırılır değilse
           Ana Menü        9
           Çıkmak için     0
           //-----------------------------------
           //***************Seçim 6
           Şifre değiştirmek için 1
           Şifre değiştirme işlemi gerçekleştirilir
           Ana Menü        9
           Çıkmak için     0


          //********Kartsız işlem bölümü

          //*******************Ana Menü 
          CepBank Para Çekmek 1
           Para yatırmak için  2
           Kredi Kartı Ödeme   3
           Eğitim Ödemeleri    4
           Ödemeler            5

           //*********************Seçim 1************
           TC kimlik no ve cep telefonu numarasını girsin doğruysa kişiye 1000 ödeme
           Yapın yanlış ise 3 kere daha denetin Hakkı bittiğinde 1 saat kilitleyin.
Ana menüye dönmek için   9
           Çıkmak için              0
           //******************Seçim 2***********************
           Nakit ödeme     1
           Hesaptan ödeme  2
           Ana Menü        9
           Çıkmak için     0
           //------------------------------------
           //----1
        Kredi kartı için en az 12 haneli kart numarasını girsin

        Tc kimlik numarasını girsin. 11 hane olup olmadığını kontrol edin.
           Nakit olarak ödeme gerçekleştirin.
           Ana Menü        9
           Çıkmak için     0
           //--------------------------
           //---2
           Kredi kartı için en az 12 haneli kart numarasını girsin
Hesap numarasını girsin

           Ana Menü        9
           Çıkmak için     0
           //*****************************Seçim 3
           Başka Hesaba EFT    1
           Başka Hesaba Havale 2
           //---------------------------------
           //--1
           EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
           yatılacak para istenir, hesap uygun ise işlem gerçekleşir değilse
           Ana Menü        9
           Çıkmak için     0
           //-----------------------------
           //---2
           hesap için 11 haneli hesap numarası işlemler doğru ise
           gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
           Ana Menü        9
           Çıkmak için     0
           //****************Seçim 4
           Eğitim Ödemeleri sayfası arızalı
           Ana Menü        9
           Çıkmak için     0
           //****************************Seçim 5
           Elektrik Faturası       1
           Telefon Faturası        2
           İnternet faturası       3
           Su Faturası             4
           OGS Ödemeleri           5
           //-----------------------------------------
           //---1 => bütün faturala için aşağıdaki şart yeterli
           fatura tutarı istenir, hesap uygun ise yatırılır değilse
           */
            #endregion

            string sifre = "ab18";
            double bakiye = 25000;
            int hak = 3;
            string anamenu = "";

            while (true)
            {
                Console.WriteLine("******* BANKAMATİK ********");
                Console.WriteLine("Kartlı İşlem İçin 1\nKartlı İşlem İçin 2\nÇıkış İçin 0\nSeçiminiz:");
                string kartliIslem=Console.ReadLine();
                if (kartliIslem == "0")
                {
                    Console.WriteLine("Bankamatik Kapatılıyor");
                    Environment.Exit(0);
                }
                int kartliSecim;
                if (int.TryParse(kartliIslem, out kartliSecim))
                {
                    if (kartliSecim == 1) 
                    {
                        while (hak>0 && anamenu!="Q")
                        {
                            Console.WriteLine("Şifre Giriniz:");
                            string sfr = Console.ReadLine();
                            hak--;
                            if (sfr == sifre) 
                            {
                                Console.Clear();
                                while (true)
                                {
                                    Console.WriteLine("******** ANA MENÜ *********");
                                    Console.WriteLine("Para Çekme - 1\nPara Yatırma - 2\nPara Transfer - 3\nEğitim Ödemeleri - 4\nFatura Ödemeleri - 5\nBilgi Güncelleme - 6\nÇıkış - Q\nSeçiminiz:");
                                    anamenu = Console.ReadLine().ToUpper();

                                    if (anamenu == "1") 
                                    {
                                        Console.WriteLine("Çekmek İstediğiniz Miktar:");
                                        int miktar = Convert.ToInt32(Console.ReadLine());

                                        if (bakiye >= miktar) 
                                        {
                                            bakiye -= miktar;
                                            Console.WriteLine($"{miktar} lira çektiniz. Yeni Bakiyeniz:{bakiye}");
                                            Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye!");
                                            Thread.Sleep(2000);
                                            Console.Clear();  
                                        }

                                    }
                                    else if (anamenu == "2") { }
                                    else if (anamenu == "3") { }
                                    else if (anamenu == "4") 
                                    {
                                        Console.WriteLine("Eğitim Bölümü Arızalı!!");
                                    }
                                    else if (anamenu == "5") { }
                                    else if (anamenu == "6") { }
                                    else if (anamenu == "Q") 
                                    {
                                        Console.WriteLine("Ana Menüden Çıkılıyor!!");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Seçim!!");
                                    }
                                }
                              

                            }
                            else if (hak == 0)
                            {
                                Console.WriteLine("Hakkınız Bitti.");
                                Thread.Sleep(2000);
                                hak = 3;
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Şifre Hatalı!!");
                            }
                            
                        }
                       

                    }
                    else if (kartliSecim == 2) { }
                    //else if (kartliSecim == 0) 
                    //{
                    //    Console.WriteLine("Bankamatik Kapatılıyor");
                    //    break;
                    //}
                    else
                    {
                        Console.WriteLine("Hatalı Seçim!!");
                    }
                }
                else
                {
                    Console.WriteLine("HATA!! Lütfen Seçiminizi Rakam olarak Giriniz.");
                }
               
            }
           

        }
    }
}
