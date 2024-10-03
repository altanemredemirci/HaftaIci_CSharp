using System.Collections;
using System.Runtime.ConstrainedExecution;

namespace _13_ArrayList_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ARRAYLIST 

            //int[] sayilar = new int[10];
            // Tanımlanırken veritipi ve uzunluk verme zorunluluğu vardır.

            //ArrayList arrayList = new ArrayList();
            // Tanımlanırken veritipi ve uzunluk verilmez. Çünkü ARRAYLIST her türde veriyi alır ve sınırı yoktur.

            /*
            *******ARRAYLIST * ******
            *Diziden farklı olarak veri tipi ve boyut verme zorunluluğu yoktur.

            * Her veritipinden değer alabilir.

            * Tanımlarken using System.Collections; kütüphanesi kullanılmalıdır.
            */


            //BOŞ ARRAYLIST TANIMI
            //ArrayList arrayList = new ArrayList();

            //DOLU ARRAYLIST TANIMI
            //ArrayList sayilar = new ArrayList() { 11, 22,"Altan", 33, 44,"on",55.65};

            //foreach(var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}



            // *** VERİ EKLEME ***
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Yasemin");
            //arrayList.Add(70000);
            //arrayList.Add("Ecem");
            //arrayList.Add(true);
            //arrayList.Add(50.5);
            //arrayList.Add(50.5f);


            //sayilar.Add("Mahmut");


            // *** COUNT and CAPACITY ***
            //ArrayList arrayList = new ArrayList() {1,2,3,4,5,6,7,8,9};
            //Console.WriteLine(arrayList.Count);
            //Console.WriteLine(arrayList.Capacity);


            // *** Başlangıç Kapasite Tanımı ***
            //ArrayList arrayList = new ArrayList(5);

            //arrayList.Add("Yasemin");
            //arrayList.Add(70000);
            //arrayList.Add("Ecem");
            //arrayList.Add(true);
            //arrayList.Add(50.5);
            //arrayList.Add(50.5f);

            //Console.WriteLine(arrayList.Count);
            //Console.WriteLine(arrayList.Capacity);



            // *** Verileri Yazdırma *** 
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}


            #region METHODS
            //ArrayList list = new ArrayList();

            //list.Add(11);
            //list.Add(12);
            //list.Add(13);

            //INSERT: istenilen index e değer eklemeyi sağlar.

            //list.Insert(1, 14);

            //CLEAR:Bütün elemanları siler.
            //list.Clear();
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //ADDRANGE:Çoklu eleman eklemeyi sağlar. Mutlaka ICollection tipinde bie dataset verilmelidir.

            // ArrayList arrayList = new ArrayList() { 1,2,4};

            //ArrayList sayilar = new ArrayList() { 11, 22, 33 };

            //int[] array = { 66, 77 };

            //arrayList.AddRange(sayilar);
            //arrayList.AddRange(array);

            //INSERTRANGE:İstanilen indexe çoklşu eleman eklemeyi sağlar.
            //arrayList.InsertRange(1, new ArrayList() { "Emre", "Emel" });

            //REMOVE:Verilen değerin ilk kaydı silinir.Bulamadığında hata vermez.
            //arrayList.Remove("Emre");
            //arrayList.Remove("Uğur");

            //REMOVEAT:Verilen index değerindeki kaydı siler.
            //arrayList.RemoveAt(5);


            //REMOVERANGE:Verilen indexden başlayarak istenilen adet kaydı siler.
            //arrayList.RemoveRange(1, 2);

            //INDEXOF: İstenilen değerin ilk indexini bulmayı sağlar.
            //Console.WriteLine(arrayList.IndexOf("Emre"));

            //LASTINDEXOF:İstenilen değerin son indexini bulmayı sağlar.

            //list.Add(11);
            //Console.WriteLine(list.LastIndexOf(11));                        

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}



            //ArrayList sayilar1 = new ArrayList() { 11, 22, 33 };

            //ArrayList sayilar2 = (ArrayList)sayilar1.Clone();

            //sayilar1.Add(44);

            //foreach (var item in sayilar1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("***************");
            //foreach (var item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}




           




            #endregion


            #endregion
        }
    }
}
