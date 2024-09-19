namespace _09_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FormatException: rakam yerine karakter
            //DivideByZeroException : bölen sayının 0 olması

            //try
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi / sayi2);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Rakam Giriniz!!");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Bölen 0 Olamaz!!");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Bilinmeyen Hata Oluştu. Lütfen Sistem Yöneticiniz ile Görüşünüz..");
            //}


            //try
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(DateTime.Now +" "+ e);
            //}



            //try
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("HATA!!!");
            //}
            //finally
            //{
            //    Console.WriteLine("Try veya Catch hangisi çalışırsa çalışsın mutlaka FINALLY çalışır.");
            //}


            #region Kullanıcıdan iki sayı alınacak ve toplamı yazdırılacak.
            // Sayı alma işlemi try-catch ile hatalardan arındırılacak.
            // Diyelim ki 1.sayı doğru 2.sayı hatalı tekrar 1.sayı istenmesin
            #endregion
            int sayi1 = 0;
            int sayi2 = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("birinci sayıyı girin:");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("rakam giriniz");

                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("ikinci sayıyı girin:");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("rakam giriniz");

                }
            }

            Console.WriteLine("Toplam:"+(sayi1+sayi2));
        }
    }
}
