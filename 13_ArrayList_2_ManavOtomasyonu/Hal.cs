using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ArrayList_2_ManavOtomasyonu
{
    internal class Hal
    {
        internal static List<Meyve> meyves = new List<Meyve>()
        {
            new Meyve() { Ad = "ELMA", Fiyat = 50.75, Stok = 1000 },
            new Meyve() { Ad = "ARMUT", Fiyat = 60.75, Stok = 1000 },
             new Meyve() { Ad = "MUZ", Fiyat = 70.75, Stok = 1000 }
        };
        internal static List<Sebze> sebzes = new List<Sebze>()
        {
             new Sebze() { Ad = "PATATES", Fiyat = 50.75, Stok = 1000 },
            new Sebze() { Ad = "SOGAN", Fiyat = 60.75, Stok = 1000 },
            new Sebze() { Ad = "PIRASA", Fiyat = 70.75, Stok = 1000 }

        };


        internal static void UrunYaz()
        {
            Console.WriteLine("Meyve mi? Sebze mi?(M/S) Çıkış Q");
            string secimHale = Console.ReadLine().ToUpper();

            if (secimHale == "M")
            {
                foreach (Meyve item in meyves)
                {
                    Console.WriteLine(item.Ad + ":" + item.Fiyat);
                }

                MeyveSat();


            }
            else if (secimHale == "S")
            {
                foreach (Sebze item in sebzes)
                {
                    Console.WriteLine(item.Ad + ":" + item.Fiyat);
                }

                SebzeSat();
            }

            else if (secimHale == "Q")
                return;

            else { Console.WriteLine("Hatalı Seçim!!!"); }

            Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
            if (Console.ReadLine().ToUpper() == "E")
            {
                UrunYaz();
            }

        }


        internal static void MeyveSat()
        {
            Console.WriteLine("Ürün Adı Giriniz?");
            string urunAd = Console.ReadLine().ToUpper();
            Meyve meyve = new Meyve();
            foreach (Meyve item in meyves)
            {
                if (item.Ad == urunAd)
                {
                    meyve = item;
                }
            }
            if (meyve.Ad == null)
            {
                Console.WriteLine("Yanlış Meyve Seçimi!!");
                Thread.Sleep(2000);
                Console.Clear();
                UrunYaz(); //Recursive Method
            }

            Console.WriteLine("Kaç Kilo?");
            int kilo = Convert.ToInt32(Console.ReadLine());

            if (kilo <= meyve.Stok)
            {
                //LINQ: İleri Sorgulama Teknikleri
                Meyve urun = Manav.meyves.FirstOrDefault(i => i.Ad == urunAd);


                if (urun==null)
                {
                    Meyve product = new Meyve()
                    {
                        Ad = meyve.Ad,
                        Stok = kilo,
                        Fiyat = meyve.Fiyat + 5
                    };
                    Manav.meyves.Add(product);
                    meyve.Stok -= kilo;
                }
                else
                {
                    urun.Stok += kilo;
                    meyve.Stok -= kilo;
                }

               
            }
            else
            {
                Console.WriteLine($"Elimizde {meyve.Stok} kadar {meyve.Ad}.\nLütfen {kilo} kilodan daha az bir değer giriniz:");
            }

        }

        internal static void SebzeSat()
        {
            Console.WriteLine("Ürün Adı Giriniz?");
            string urunAd = Console.ReadLine().ToUpper();
            Sebze sebze = new Sebze();
            foreach (Sebze item in sebzes)
            {
                if (item.Ad == urunAd)
                {
                    sebze = item;
                }
            }
            if (sebze.Ad == null)
            {
                Console.WriteLine("Yanlış Meyve Seçimi!!");
                Thread.Sleep(2000);
                Console.Clear();
                UrunYaz(); //Recursive Method
            }

            Console.WriteLine("Kaç Kilo?");
            int kilo = Convert.ToInt32(Console.ReadLine());

            if (kilo <= sebze.Stok)
            {
                //LINQ: İleri Sorgulama Teknikleri
                Sebze urun = Manav.sebzes.FirstOrDefault(i => i.Ad == urunAd);


                if (urun == null)
                {
                    Sebze product = new Sebze()
                    {
                        Ad = sebze.Ad,
                        Stok = kilo,
                        Fiyat = sebze.Fiyat + 5
                    };
                    Manav.sebzes.Add(product);
                    sebze.Stok -= kilo;
                }
                else
                {
                    urun.Stok += kilo;
                    sebze.Stok -= kilo;
                }
            }
            else
            {
                Console.WriteLine($"Elimizde {sebze.Stok} kadar {sebze.Ad}.\nLütfen {kilo} kilodan daha az bir değer giriniz:");
            }

        }
    }
}
