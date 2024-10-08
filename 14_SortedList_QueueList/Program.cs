using System.Collections;

namespace _14_SortedList_QueueList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SortedList<Key,Value> mantığında çalışır.

            //SortedList sozluk = new SortedList() {
            //        {"Bugun","Today"},
            //        {"Yarin","Tommorrow"},
            //        {"Hava","Wheather" },
            //        {"Gokyuzu","Sky" },
            //        {"Karli","Snowy" },
            //        {"Gunesli","Sunny" },
            //        {"Bulutlu","Cloudy" },
            //        {"Acik","Clear" },
            //        {"Kapali","Cloudy" },
            //        {"Mahmut",1 },
            //        {"Kamil",2 },
            //        //{3,"HATA" } // HATA Verir. Key tipleri aynı olmalıdır.
            //    };

            //Key verilir, Value alınır.
            //Console.WriteLine(sozluk["Karli"]);

            //foreach (DictionaryEntry item in sozluk)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (string item in sozluk.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in sozluk.Values)
            //{
            //    Console.WriteLine(item);
            //}

            /*
            sözlük uygulaması istenmektedir.Tr - Eng
         sözlük = { "siyah":"black",,,,}
            kullanıcı 4 girene kadar sorulur.
             1 - Arama
             2 - Çıkarma
             3 - Listeleme
             4 - Çıkış

        Kullanıcı 1'e basarsa ->
            - Aranacak olan kelimeyi giriniz:
            -Bu kelime dizide varsa eng karşılığı yazılır.
            -Yoksa uygulamanın gelişmesine yardımcı olmak ister msiniz(E-H):
                -E ise bu kelimenin karşılığı istenir ve sözlüğe eklenir
                -H ise bişey yapılmaz
        Kullanıcı 2'ye basarsa ->
            - Çıkarılmak istenen kelime :
            -Kelime sözlükte varsa çıkartılır
            - Yoksa uyarı verilir.
        Kullanıcı 3'e basarsa ->
            - Tum key value lar listelenir
            -KEY->VALUE
        Kullanıcı 4'e basarsa ->
            - Döngü sonlanır.
             */


            //SortedList<string, string> sozluk = new SortedList<string, string>();
            //sozluk.Add("mavi", "blue");
            //sozluk.Add("beyaz", "white");
            //sozluk.Add("siyah", "black");
            //sozluk.Add("turuncu", "orange");

            //while (true)
            //{
            //    Console.WriteLine("1-Arama\n2-Çıkarma\n3-Listeleme\n4-Çıkış\nSeçiminiz:");
            //    string secim = Console.ReadLine();

            //    if (secim == "1") 
            //    {
            //        Console.WriteLine("Aranacak kelime:");
            //        string kelime = Console.ReadLine();

            //        if (sozluk.ContainsKey(kelime))
            //        {
            //            Console.WriteLine(sozluk[kelime]);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sözlük bulunamadı. Eklemek ister misiniz?(E/H)");
            //            string cevap = Console.ReadLine().ToLower();
            //            if (cevap == "e")
            //            {
            //                Console.WriteLine($"{kelime} kelimesinin ingilizcesini giriniz");
            //                sozluk[kelime] = Console.ReadLine();
            //            }
            //            else
            //            {
            //                Console.WriteLine("Sen Bilirsin!!");
            //            }

            //        }
            //    }
            //    else if (secim == "2") 
            //    {
            //        Console.WriteLine("Çıkarılacak kelime:");
            //        string kelime = Console.ReadLine();
            //        if (sozluk.ContainsKey(kelime))
            //        {
            //            sozluk.Remove(kelime);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Zaten kelime ekli değil!");
            //        }
            //    }
            //    else if (secim == "3") 
            //    {
            //        foreach (KeyValuePair<string,string> item in sozluk)
            //        {
            //            Console.WriteLine(item.Value+" => "+item.Key);
            //        }
            //    }
            //    else if (secim == "4") 
            //    {
            //        break;
            //    }
            //    else 
            //    { Console.WriteLine("Hatalı Seçim!!"); }
            //}

        }
    }
}
