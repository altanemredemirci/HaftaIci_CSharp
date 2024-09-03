namespace _07_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-10 arasındaki sayıları ekrana yazdırın.

            //int i = 1;
            //while (i<11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            /*
            ilk değer verilir.
            *   koşul kontrolü->T
                yapılacak işlem kod bloğu çalış
                değer revize edilir.

            *   koşul kontrolü->T
                yapılacak işlem kod bloğu çalış
                değer revize edilir.

            *   koşul kontrolü->T
                yapılacak işlem kod bloğu çalış
                değer revize edilir.

            *   koşul kontrolü->F
                Döngü biter
             */


            //int i = 1;
            //while (i<11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #region 20'den 0'a doğru sayıları ekrana yazdırınız

            //for (int i = 20; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion


            #region Ekrana kullanıcıdan alınan başlangıç ve bitiş değeri arasındaki 3'ün katları olan sayıları yazdırınız

            //Console.WriteLine("Başlangıç Değeri:");
            //int basla = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitiş Değeri:");
            //int bitis = Convert.ToInt32(Console.ReadLine());

            //if (basla > bitis)
            //{
            //    int takas = basla;
            //    basla = bitis;
            //    bitis = takas;

            //}
            //int adet = 0;
            //for (int i = basla; i < bitis; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        adet++;
            //        Console.WriteLine(i);
            //    }

            //}

            //Console.WriteLine("Adet:"+adet);





            #endregion


            #region Kullanıcıdan alınan bir sayının faktörüyeli hesaplayan for döngüsünü yazınız.
            // 5 => 1*2*3*4*5=120

            Console.WriteLine("Faktöriyeli hesaplanacak sayı:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i; // faktoriyel=faktoriyel*i;
            }

            Console.WriteLine("Sonuç:"+faktoriyel);

            #endregion
        }
    }
}
