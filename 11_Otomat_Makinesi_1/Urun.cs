using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Otomat_Makinesi_1
{
    internal class Urun
    {
        static double balance = 0;

        internal static string[] products = { "Kola", "Fanta", "Ayran" };
        internal static double[] prices = { 15.5, 15, 9.75 };

        internal static void UrunListele()
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{i}-{products[i]}:{prices[i]}");
            }
        }

        internal static void UrunSat()
        {
            Console.WriteLine("Seçilen Ürün No:");
            int productNo;
            if (int.TryParse(Console.ReadLine(), out productNo))
            {
                if (productNo >= 0 && productNo < products.Length)
                {
                    while (true)
                    {
                        Console.WriteLine("Para Giriniz:");
                        balance += Convert.ToDouble(Console.ReadLine());

                        if (balance >= Urun.prices[productNo])
                        {
                            Console.Clear();
                            Console.WriteLine($"Afiyet Olsun. Para Üstü:{balance - Urun.prices[productNo]}");
                            balance = 0;

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Bakiye!");
                            Console.WriteLine("1-Para Ekle\n2-Çıkış");
                            string result = Console.ReadLine();
                            if (result != "1")
                            {
                                Console.Clear();
                                balance = 0;
                                break;
                            }

                        }
                    }
                }
                   
                else if (productNo == -1)
                {
                    Admin();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hatalı Ürün Numarası!!");
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ürün Numarasını Rakam Giriniz!!");
            }
        }

        internal static void Admin()
        {
            Console.WriteLine("1-Ürün Ekle\n2-Ürün Güncelle\n3-Ürün Sil");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                UrunEkle();
            }
            else if (secim == "2")
            {
                UrunGuncelle();

            }
            else if (secim == "3")
            {
                UrunSil();
            }
            else
            {
                Console.WriteLine("Hatalı Tuşlama!!");
            }

        }

        internal static void UrunEkle()
        {
            Console.WriteLine("Ürün Adı:");
            string urunAd = Console.ReadLine();
            Console.WriteLine("Ürün Fiyatı:");
            double fiyat = Convert.ToDouble(Console.ReadLine());

            int bosIndex = -1;
            for (int i = 0; i < products.Length; i++)
            {
                if (prices[i] == 0) { bosIndex = i; break; }
            }

            if (bosIndex != -1)
            {
                products[bosIndex] = urunAd;
                prices[bosIndex] = fiyat;
            }
            else
            {
                Array.Resize(ref products, products.Length + 1);
                Array.Resize(ref prices, prices.Length + 1);

                products[products.Length - 1] = urunAd;
                prices[prices.Length - 1] = fiyat;
            }
            Console.Clear();
        }

        internal static void UrunGuncelle()
        {
            UrunListele();

            Console.WriteLine("Seçilen Ürün No:");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index >= 0 && index < products.Length)
            {
                Console.WriteLine("Yeni Ürün Adı:");
                string urunAd = Console.ReadLine();
                Console.WriteLine("Yeni Ürün Fiyatı:");
                double fiyat = Convert.ToDouble(Console.ReadLine());

                products[index] = urunAd;
                prices[index] = fiyat;
                Console.Clear();
                Console.WriteLine("Ürün Güncellendi");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Hatalı Ürün Numarası!");
            }
        }

        internal static void UrunSil()
        {
            UrunListele();

            Console.WriteLine("Seçilen Ürün No:");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index >= 0 && index < products.Length)
            {
                Array.Clear(products, index, 1);
                Array.Clear(prices, index, 1);
                Console.Clear();
                Console.WriteLine("Silme Başarılı");
            }
            else
            {
                Console.WriteLine("Hatalı Ürün Numarası!");
            }
        }
    
    }
}
