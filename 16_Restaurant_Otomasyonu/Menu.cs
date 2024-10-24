using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Restaurant_Otomasyonu
{
    /*
     Çorbalar,Salatalar,Makarnalar,Etler,Balıklar,İçecekler
     */
    internal class Menu
    {
        public static List<Yemek> Corbalar = new List<Yemek>()
        {
            new Yemek() { Id = 1, Ad = "Mercimek", Fiyat = 150 },
            new Yemek() { Id = 2, Ad = "Yayla", Fiyat = 150.5 },
            new Yemek() { Id = 3, Ad = "Ezogelin", Fiyat = 150 }
        };
        public static List<Yemek> Salatalar = new List<Yemek>(){


            new Yemek() { Id = 1, Ad = "Sezar", Fiyat = 150 },
            new Yemek() { Id = 2, Ad = "Tavuklu", Fiyat = 150.75 },
            new Yemek() { Id = 3, Ad = "Çoban", Fiyat = 250 }
        };
        public static List<Yemek> Makarnalar = new List<Yemek>()
        {
            new Yemek() { Id = 1, Ad = "Bolanezli", Fiyat = 150 },
            new Yemek() { Id = 2, Ad = "Körili", Fiyat = 150 },
            new Yemek() { Id = 3, Ad = "Spagetti", Fiyat = 150 },
        };
        public static List<Yemek> Etler = new List<Yemek>()
        {
            new Yemek() { Id = 1, Ad = "Pirzola", Fiyat = 150 },
            new Yemek() { Id = 2, Ad = "Biftek", Fiyat = 175.5 },
            new Yemek() { Id = 3, Ad = "Lokum", Fiyat = 100 }
        };
        public static List<Yemek> Baliklar = new List<Yemek>()
        {
            new Yemek() { Id = 1, Ad = "Lüfer", Fiyat = 150 },
            new Yemek() { Id = 2, Ad = "Kefal", Fiyat = 175.5 },
            new Yemek() { Id = 3, Ad = "Sazan", Fiyat = 100 }
        };
        public static List<Yemek> Icecikler = new List<Yemek>()
        {
            new Yemek() { Id = 1, Ad = "Şalgam", Fiyat = 150 },
            new Yemek() { Id = 2, Ad = "Ayran", Fiyat = 175.5 },
            new Yemek() { Id = 3, Ad = "Kola", Fiyat = 100 }
        };
           

               
        public static Yemek MenuYaz()
        {
            ArrayList menuler = new ArrayList() { Corbalar, Makarnalar, Etler, Baliklar, Salatalar, Icecikler };
            Console.WriteLine("1-Çorbalar\n2-Makarnalar\n3-Etler\n4-Balıklar\n5-Salatalar\n6-İçecekler\nSeçim:");
            int menuSecim = Convert.ToInt32(Console.ReadLine());
            if(menuSecim>0 && menuSecim < 7)
            {
                foreach (Yemek menu in (List<Yemek>)menuler[menuSecim-1])
                {
                    Console.WriteLine(menu.Id+"-"+menu.Ad+":"+menu.Fiyat);
                }
                Console.WriteLine("Seçiminiz:");
                int secimYemek = Convert.ToInt32(Console.ReadLine());
                var yemek = ((List<Yemek>)menuler[menuSecim - 1])[secimYemek-1];
                if (yemek == null)
                {
                    Console.WriteLine("Hatalı Yemek Seçimi!!");
                    return null;
                }
                return yemek;
            }
            else
            {
                Console.WriteLine("Hatalı Menü Seçildi!!");
            }

            return null;
        }
    }

}

