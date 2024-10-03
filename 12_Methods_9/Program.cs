using System.Threading.Channels;

namespace _12_Methods_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen değerler arasında rastgele sayı üreten  ve bu değerleri 10 elemanlı bir diziye atayan SayiUret() isimli bir metot yazın.
            //Bu dizinin elemanlarını yazan DiziYazdır() isimli bir metot daha yazarak elemanları listeleyin.
            //Daha sonra bu dizi içerisinde EnBuyukDeger() adında bir metot ile dizinin en büyük değerini bulan,
            //en küçük değerinin bulan EnKucukDeger() adından başka bir metot daha yazınız.
            //EnBuyukDeger ve EnKucukDeger metotlarında dönen değerleri ekranda gösteren programı yazınız
            //kullanıcının bütün hataları kontrol altına alınmalı

            int[] sayilar = new int[10];
            SayiUret(sayilar);
            DiziYazdir(sayilar);
            Console.WriteLine("En Büyük:"+EnBuyukDeger(sayilar));
            Console.WriteLine("En Küçük:"+EnKucukDeger(sayilar));
        }

        static void SayiUret(int[] array)
        {
            Random r = new Random();
            int basla=0;
            int bitis=0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Başlangıç Değeri:");
                    basla = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Bitiş Değeri:");
                    bitis = Convert.ToInt32(Console.ReadLine());

                    if (basla > bitis)
                    {
                        int t = basla;
                        basla = bitis;
                        bitis = t;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Hatalı Giriş!!");
                }
            }
           
           
            for (int i = 0; i < 10; i++)
            {
                array[i] = r.Next(basla, bitis);
            }
        }

        static void DiziYazdir(int[] array)
        {
            Array.ForEach(array, item => Console.WriteLine(item));
            //foreach (int item in array)
            //{
            //    Console.WriteLine(item);
            //}
        }

        static int EnBuyukDeger(int[] array)
        {
            int enBuyuk = array[0];

            foreach (int item in array)
            {
                if (item > enBuyuk)
                    enBuyuk = item;
            }

            return enBuyuk;
        }

        static int EnKucukDeger(int[] array)
        {
            int enKucuk = array[0];

            foreach (int item in array)
            {
                if (item < enKucuk)
                    enKucuk = item;
            }

            return enKucuk;
        }
    }
}
