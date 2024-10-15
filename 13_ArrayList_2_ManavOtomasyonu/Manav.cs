using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ArrayList_2_ManavOtomasyonu
{
    internal class Manav
    {
        internal static List<Meyve> meyves = new List<Meyve>();
        internal static List<Sebze> sebzes = new List<Sebze>();


        internal static void UrunYaz()
        {
            Console.WriteLine("Meyve mi? Sebze mi?(M/S) Çıkış Q");
            string secimManav = Console.ReadLine().ToUpper();

            if (secimManav == "M")
            {
                foreach (Meyve item in meyves)
                {
                    Console.WriteLine(item.Ad + ":" + item.Fiyat);
                }

                MeyveSat();


            }
            else if (secimManav == "S")
            {
                foreach (Sebze item in sebzes)
                {
                    Console.WriteLine(item.Ad + ":" + item.Fiyat);
                }

                //SebzeSat();
            }

            else if (secimManav == "Q")
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

            foreach (Meyve item in meyves)
            {
                if (item.Ad == urunAd)
                {
                    Console.WriteLine("Kaç Kilo?");
                    int kilo = Convert.ToInt32(Console.ReadLine());
                    if (kilo <= item.Stok)
                    {
                        var urun = Musteri<Meyve>.sepet.FirstOrDefault(i => i.Ad == item.Ad);

                        if (urun == null)
                        {
                            Meyve meyve = new Meyve()
                            {
                                Ad = item.Ad,
                                Stok = kilo,
                                Fiyat = item.Fiyat
                            };
                            item.Stok -= kilo;
                            Musteri<Meyve>.sepet.Add(meyve);
                        }
                        else
                        {
                            urun.Stok += kilo;
                            item.Stok -= kilo;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Elimizde {item.Stok} kilo {item.Ad}.\nLütfen daha bir kilo giriniz");
                    }
                    return;
                }
               
            }
            Console.WriteLine("Yanlış Meyve Seçimi!!");
            Thread.Sleep(2000);
            Console.Clear();
            UrunYaz(); //Recursive Method



        }
    }
}
