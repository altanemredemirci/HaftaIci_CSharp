namespace _12_Methods_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rastgele 1-100 arasında 15 değer tutan bir dizideki tek ve çiftleri ayrı ayrı dizilere atayan metot 

            int[] sayilar = new int[15];
            
            int tekBoyut = 0;
            int ciftBoyut = 0;
            DiziDoldur(sayilar,ref tekBoyut,ref ciftBoyut);


            int[] teksayilar = new int[tekBoyut];
            int[] ciftsayilar = new int[ciftBoyut];
            TekCift(sayilar, ref teksayilar, ref ciftsayilar);

            DiziYazdir(sayilar); Console.WriteLine("********");
            DiziYazdir(teksayilar); Console.WriteLine("********");
            DiziYazdir(ciftsayilar);

        }

        static void DiziDoldur(int[] array, ref int tekBoyut, ref int ciftBoyut)
        {
            Random r = new Random();

            for (int i = 0; i < 15; i++)
            {
                int sayi = r.Next(1, 100);
                array[i] = sayi;
                if (sayi % 2 == 0) ciftBoyut++;
                else tekBoyut++;
            }
        }

        static void TekCift(int[] array, ref int[] teksayilar, ref int[] ciftsayilar )
        {
            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    int i = Array.IndexOf(ciftsayilar, 0);
                    ciftsayilar[i] = item;
                }
                else
                {
                    int i = Array.IndexOf(teksayilar, 0);
                    teksayilar[i] = item;
                }
            }
        }

        static void DiziYazdir(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
