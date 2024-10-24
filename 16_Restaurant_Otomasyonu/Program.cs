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
                    int i = 1;
                    while (i<=kisiSayisi)
                    {

                        //if (Siparis.SiparisAl(musteriMasa)==false)
                        if (!Siparis.SiparisAl(musteriMasa))
                        {
                            i += 1;
                        }
                        Console.Clear();
                    }
                    
                }
                else if (secim == "2") 
                {
                    foreach (Masa masa in Masa.Masalar)
                    {
                        Console.WriteLine(masa.No+".Masa:"+masa.Hesap);
                    }
                    Console.WriteLine("Masa Numarası:");
                    int masaSecim = Convert.ToInt32(Console.ReadLine());

                    Masa musteriMasasi = Masa.Masalar.FirstOrDefault(i => i.No == masaSecim && i.Hesap>0);
                    if (musteriMasasi != null)
                    {
                        Console.WriteLine("Ödeme:"+musteriMasasi.Hesap+"Lira");
                        Console.WriteLine("Ödendi Mi? E/H");
                        string odeme = Console.ReadLine().ToUpper();
                        if (odeme == "E")
                        {
                            musteriMasasi.Hesap = 0;
                            musteriMasasi.Durum = false;
                            musteriMasasi.Siparisler.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Hesap Ödenmedi. Bulaşığa geçiniz.");
                        }
                    }
                }
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
