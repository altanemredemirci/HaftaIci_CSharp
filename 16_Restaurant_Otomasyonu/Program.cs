namespace _16_Restaurant_Otomasyonu
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("*********** KARDEŞLER ET LOKANTASINA ***********");
            Console.WriteLine("****************** HOŞGELDİNİZ *****************");

            while (true)
            {
                Console.WriteLine("1-Sipariş Al\n2-Hesap Al\n3-Çıkış\nSeçim:");
                string secim = Console.ReadLine();

                if (secim == "1") 
                {
                    Console.WriteLine("Kaç kişi?");
                    int kisiSayisi = Convert.ToInt32(Console.ReadLine());

                    Masa musteriMasa = Masa.MasaDoldur(kisiSayisi);

                    if (musteriMasa == null)
                    {
                        Console.WriteLine("Bütün masalar dolu!!");
                        continue;
                    }
                    Menu.MenuYaz();
                    Console.WriteLine("Seçiminiz:");
                    int secimYemek = Convert.ToInt32(Console.ReadLine());
                    //Siparişler
                }
                else if (secim == "2") { }
                else if (secim == "3") 
                {
                    Console.WriteLine("Program Kapanıyor...");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
                else 
                {
                    Console.WriteLine("Hatalı Tuşlama!");
                }
            }
        }
    }
}
