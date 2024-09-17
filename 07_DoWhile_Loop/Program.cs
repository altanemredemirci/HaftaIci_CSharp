namespace _07_DoWhile_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int i = 1;

            //while (i < 6)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int j = 1; j < 6; j++)
            //{
            //    Console.WriteLine(j);
            //}


            //int i = 1;

            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i<6);


            // Kullanıcı 0 girene kadar bütün girdiği sayıları toplayan ve 0 girildiğinde döngüyü bitirip toplamı ekrana yazan DOWHILE döngüsü

            int toplam = 0;
            int sayi;

            do
            {
                Console.WriteLine("Sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;

            } while (sayi != 0);

            Console.WriteLine("Toplam:"+toplam);

        }
    }
}
