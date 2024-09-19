namespace _08_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RANDOM Rastgele Sayı Üreten Kütüphane

            //Random r = new Random();
            //Console.WriteLine(r.Next());
            //Console.WriteLine(r.Next(5));
            //Console.WriteLine(r.Next(1,4));
            //Console.WriteLine(r.NextDouble());

            //ÖDEV: sistemin rastgele ürettiği sayıyı kullanıcının bulması için bir kod bloğu yazın, eğer kullanıcının girdiği sayı üretilen sayıdan büyük ise kullanıcının büyük bir sayı girdiğini, küçük ise küçük girdiğini uyarınız ve kullanıcı 1-100 aralığında  bu tahmin oyununda 5 haka sahip olsun

            Random random = new Random();

            int rastgele = random.Next(1, 100);
            Console.WriteLine(rastgele);
            int hak = 5;

            do
            {
                Console.WriteLine("Tahmininiz:");
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if(tahmin<100 && tahmin > 0)
                {
                    hak--;

                    if (tahmin == rastgele)
                    {
                        Console.WriteLine("Tebrikler.");
                        break;
                    }
                    else if (tahmin > rastgele)
                    {
                        Console.WriteLine("Tahmininizi Küçültünüz.");
                    }
                    else
                    {
                        Console.WriteLine("Tahmininizi Büyültünüz.");
                    }
                }           


            } while (hak>0);


        }
    }
}
