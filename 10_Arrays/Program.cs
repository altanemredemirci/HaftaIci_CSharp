

namespace _10_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ********* ARRAY *********

            /*
             Diziler birden fazla değer tutabilen koleksiyon yapılarından bir tanesidir.
            Dizi tanımlarken MUTLAKA tutacağı değerlerin VERİTİPİ ve ELEMAN SAYISI tanımlanmalıdır.
            Diziler çoklu eleman tutukları için bu elemanları INDEX adı verilen numaralandırma yöntemi ile 0'dan başlayarak 1'er 1'er artan sayılar ile tutar.
             */


            //int sayi = 5;

            //******** Dizi Tanımlama ********
            //veritipi[] diziAdi = new veritipi[elemanSayisi]

            //int[] sayilar = new int[5];

            //string[] isimler = { "Altan", "Emre", "Uras", "Ceylan", "Kerem", "Kıvanç" };


            // ********** Eleman Ekleme ***********
            //sayilar[0] = 12;
            //sayilar[3] = 14;
            //sayilar[5] = 18; //System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'


            //string IBAN = "TR123456789098";
            //Console.WriteLine(IBAN[0]);
            //Console.WriteLine(IBAN[1]);

            //Console.WriteLine(IBAN[0]+IBAN[1]); //ASCII
            //Console.WriteLine($"{IBAN[0]}{IBAN[1]}{IBAN[5]}");

            // ********* Elemanları Yazdırma *********

            //string[] isimler = { "Altan", "Emre", "Uras", "Ceylan", "Kerem", "Kıvanç" };

            //Console.WriteLine(isimler[3]);


            //int i = 0;
            //while (i < isimler.Length) //0,1,2,3,4,5
            //{
            //    Console.WriteLine(isimler[i]);
            //    i++;
            //}


            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            //FOREACH: Koleksiyon içindeki değerleri okumaya yarar.
            //foreach (string item in isimler) //string item="Altan";
            //{
            //    Console.WriteLine(item);
            //}

            //var: variable 
            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            #region Kullanıcıya kaç personeli olduğunu sorunuz. Verilen cevapdan sonra her personelin adını sorup bir diziye ekleyiniz. Dizi tamamlandığında personel isimlerini ekrana yazdırınız.

            //Console.WriteLine("Personel Sayısı:");
            //int personelSayisi = Convert.ToInt32(Console.ReadLine());

            //string[] personeller = new string[personelSayisi];

            //for (int i = 0; i < personelSayisi; i++)
            //{
            //    Console.WriteLine($"{i+1}.Personel Adı:");
            //    personeller[i]=Console.ReadLine();
            //}

            //foreach (string item in personeller)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region ARRAY SINIFININ METOTLARI

            #region Clear()
            //string[] isimler = { "Altan", "Emre", "Uras", "Ceylan", "Kerem", "Kıvanç" };

            ////Array.Clear(isimler);
            //Array.Clear(isimler, 1, 2);

            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Copy()
            //string[] isimler = { "Altan", "Emre", "Uras", "Ceylan", "Kerem", "Kıvanç" };

            //string[] isimler2 = new string[10];


            ////Array.Copy(isimler, isimler2, 2);
            //Array.Copy(isimler,1,isimler2,5,3);


            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------");
            //foreach (var item in isimler2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region IndexOf()
            //İstenilen değerin ilk INDEX numarasını verir.
            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Bahir", "Koray","Umut" ,"Bahir","Kerem","Bahir" };

            //Console.WriteLine(Array.IndexOf(adlar,"Bahir"));

            //int index =Array.IndexOf(adlar, "Bahir", 3);
            //int index =Array.IndexOf(adlar, "Bahir", 5);
            //int index = Array.IndexOf(adlar, "Bahir", 5,2);
            //Console.WriteLine(index);

            #endregion

            #region LastIndexOf()
            //İstenilen değerin son INDEX numarasını verir.
            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Bahir", "Koray","Bahir" };

            //Console.WriteLine(Array.LastIndexOf(adlar, "Bahir"));



            #endregion

            #region Sort()
            //A->Z 0->9 Sıralar.
            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Bahir", "Koray", "Umut", "Bahir", "Kerem", "Bahir","Altan","Altay" };

            //Array.Sort(adlar);

            //foreach (var item in adlar)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Reverse()
            //Diziyi Ters Çevirir.
            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Bahir", "Koray", "Umut", "Bahir", "Kerem", "Bahir", "Altan", "Altay" };

            //Array.Reverse(adlar);

            //foreach (var item in adlar)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region ReSize()
            //Diziye yeni boyut verme


            //string[] adlar = { "Mehmet", "Ercan", "Bahir" };

            ////adlar[3] = "Ecem";
            //Array.Resize(ref adlar, 4);
            //adlar[3] = "Ecem";
            //adlar[1] = "Mehmet";
            //Console.WriteLine(adlar[3]);
            //Console.WriteLine(adlar[1]);


            #endregion

           
            #endregion

            //Aşağıda tanımlı olan dizideki bütün BAHİR değerlerinin index değerlerini ekrana yazdırınız.
            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Bahir", "Koray", "Umut", "Bahir", "Kerem", "Bahir" };

            //int count = 0;

            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    count++;
            //    if (adlar[i] == "Bahir")
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("Tur Sayısı:"+count);




            //int count = 0;
            //int i = -1;
            //while (i < adlar.Length)
            //{
            //    count++;
            //    int index = Array.IndexOf(adlar, "Cafer", i + 1);
            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(index);
            //    i = index;
            //}
            //Console.WriteLine("Tur Sayısı:" + count);








            //RESIZE()


        }
    }
}
