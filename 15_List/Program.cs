using System.Collections;

namespace _15_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List Tanımı
            // ******* LIST *******
            //int[] array = new int[10]; //Veritipi ve uzunluk belirtilmelidir.

            //ArrayList arrayList = new ArrayList(); //Veritipi ve uzunluk belirtilmesi zorunlu değildir.


            //List<int> sayilar = new List<int>();
            //sayilar.Add(11);
            //sayilar.Add(12);

            //List<string> isimler = new List<string>() { "Ecem", "İsmail", "Merve", "Ebubekir" };

            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            //Ogrenci bir classtır.
            //ogrenci bir objectdir.
            Ogrenci ogrenci = new Ogrenci();  //Instance - Örneklem

            ogrenci.Ad = "Altan";
            ogrenci.Soyad = "Demirci";
            ogrenci.Numara = 154;

            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            ogrenciler.Add(ogrenci);

            Ogrenci ogrenci2 = new Ogrenci();  //Instance - Örneklem

            ogrenci2.Ad = "İbrahim";
            ogrenci2.Soyad = "Çakır";
            ogrenci2.Numara = 155;

            ogrenciler.Add(ogrenci2);

            //ogrenci.Yaz();

            //Ogrenci.Oku();


        }
    }
}
