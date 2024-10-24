using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Restaurant_Otomasyonu
{
    internal class Siparis
    {
        public int Id { get; set; }
        public Yemek Yemek { get; set; }

        public static bool SiparisAl(Masa musteriMasa)
        {
            var yemek = Menu.MenuYaz();

            Siparis siparis = new Siparis();
            siparis.Yemek = yemek;

            musteriMasa.Siparisler.Add(siparis);
            musteriMasa.Hesapla();
            Console.WriteLine("Başka Arzunuz Var Mı? E/H");
            string cevap = Console.ReadLine().ToUpper();

            return cevap == "E" ? true : false;
        }
    }
}
