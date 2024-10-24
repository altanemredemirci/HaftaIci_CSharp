using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Restaurant_Otomasyonu
{    
    internal class Masa
    {
        public int No { get; set; }
        public int Kapasite  { get; set; }
        public bool Durum = false;
        public double Hesap = 0;
        public List<Siparis> Siparisler { get; set; }

        public Masa()
        {
            Siparisler = new List<Siparis>();
        }

        public void Hesapla()
        {
            Hesap = Siparisler.Select(siparis=> siparis.Yemek.Fiyat).Sum();

            //Hesap = 0;
            //foreach (Siparis siparis in Siparisler)
            //{
            //    Hesap += siparis.Yemek.Fiyat;
            //}
        }

        public static List<Masa> Masalar = new List<Masa>()
        {
            new Masa(){No=1,Kapasite=2},
            new Masa(){No=2,Kapasite=5},
            new Masa(){No=3,Kapasite=5},
            new Masa(){No=4,Kapasite=5},
            new Masa(){No=5,Kapasite=5}
        };

        public static Masa MasaDoldur(int kisi)
        {
            foreach (Masa masa in Masalar)
            {
                if (masa.Durum == false && masa.Kapasite >= kisi)
                {
                    masa.Durum = true;
                    return masa;
                }
            }
            return null;
        }
    }

    
}
