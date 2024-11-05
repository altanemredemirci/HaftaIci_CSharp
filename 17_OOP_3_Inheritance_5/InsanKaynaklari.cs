using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_3_Inheritance_5
{
    //default Internal Erişim belirteci alır
    internal class InsanKaynaklari:Personel
    {
        public int PersonelSayisi { get; set; }


        internal new void Kayit() //NonStatic
        {
            base.Kayit();
            Console.WriteLine("Personel Sayısı:");
            this.PersonelSayisi = Convert.ToInt32(Console.ReadLine());
        }

        //internal static void Kayit(List<InsanKaynaklari> list)
        //{
        //    InsanKaynaklari IK = new InsanKaynaklari();

        //    Personel.Kayit(IK);
        //    Console.WriteLine("Personel Sayısı:");
        //    IK.PersonelSayisi = Convert.ToInt32(Console.ReadLine());

        //    list.Add(IK);
        //}

        internal static void Listele(List<InsanKaynaklari> liste)
        {
            foreach (InsanKaynaklari item in liste)
            {
                Console.WriteLine($"{item.Id}-{item.Ad}-{item.Soyad}-{item.TC}-{item.SGKGirisTarihi}-{item.PersonelSayisi}");
            }
        }

        internal static void Sil(List<InsanKaynaklari> liste)
        {
            Listele(liste);
            Console.WriteLine("Silinecek Personel Id:");
            int Id = Convert.ToInt32(Console.ReadLine());

            //LINQ İleri Seviye Sorgulama Teknikleri

            InsanKaynaklari SilinecekPersonel = liste.FirstOrDefault(i => i.Id == Id);

            if (SilinecekPersonel == null)
            {
                Console.WriteLine("Girilen Personel Bulunamadı!!");
            }
            else
            {
                bool sonuc = liste.Remove(SilinecekPersonel);
                if (sonuc)
                {
                    Console.WriteLine("Personel Silindi.");
                }
                else
                {
                    Console.WriteLine("Bir Hata Oluştu. Lütfen Sistem Yöneticiniz İle Görüşünüz.");
                }
            }

        }

        internal static void Guncelle(List<InsanKaynaklari> liste)
        {
            Listele(liste);
            Console.WriteLine("Güncellenecek Personel Id:");
            int Id = Convert.ToInt32(Console.ReadLine());

            //LINQ İleri Seviye Sorgulama Teknikleri

            InsanKaynaklari GuncellenecekPersonel = liste.FirstOrDefault(i => i.Id == Id);

            if (GuncellenecekPersonel == null)
            {
                Console.WriteLine("Girilen Personel Bulunamadı!!");
            }
            else
            {
                //Console.WriteLine("Ad:");
                //GuncellenecekPersonel.Ad = Console.ReadLine();
                //Console.WriteLine("Soyad:");
                //GuncellenecekPersonel.Soyad = Console.ReadLine();
                //Console.WriteLine("TC:");
                //GuncellenecekPersonel.TC = Console.ReadLine();
                //Console.WriteLine("Personel Sayısı:");
                //GuncellenecekPersonel.PersonelSayisi = Convert.ToInt32(Console.ReadLine());


                GuncellenecekPersonel.Kayit();
            }

        }
    }
}
