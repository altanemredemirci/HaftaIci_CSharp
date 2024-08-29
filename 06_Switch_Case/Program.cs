namespace _06_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kullanıcıdan haftanın gün sayısını alınız.Girilen rakama göre gün adını ekrana yazdırınız.

            //Console.WriteLine("Haftanın kaçıncı günündeyiz?");
            //int gun = Convert.ToInt32(Console.ReadLine());


            //if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (gun == 7)
            //{
            //    Console.WriteLine("Pazar");
            //}
            //else
            //{
            //    Console.WriteLine("Hafta 7 günden oluşur!!!");
            //}

            //Console.WriteLine("Haftanın kaçıncı günündeyiz?");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //switch (gun) //kontrol edilecek değişken
            //{
            //    case 1:
            //        Console.WriteLine("Pazartesi");                    
            //        break; //kırmak             
            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("Pazar");
            //        break;
            //    default:
            //        Console.WriteLine("Hafta 7 günden oluşur!!!");
            //        break;
            //}
            #endregion

            #region Kullanıcıdan haftanın gün sayısını alınız.Girilen rakama göre gün adını ekrana yazdırınız.


            //Console.WriteLine("Haftanın hangi günündeyiz?");
            //string gun =Console.ReadLine().ToLower();

            //switch (gun) 
            //{
            //    case "pazartesi":
            //        Console.WriteLine(1);
            //        break;           
            //    case "salı":
            //        Console.WriteLine(2);
            //        break;
            //    case "çarşamba":
            //        Console.WriteLine(3);
            //        break;
            //    case "perşembe":
            //        Console.WriteLine(4);
            //        break;
            //    default:
            //        Console.WriteLine("Haftanın hatalı gün bilgisi!!!");
            //        break;
            //}
            #endregion


            //Console.Write("Ay numarasını girin (1-12): ");
            //int monthNumber;
            //bool isValid = int.TryParse(Console.ReadLine(), out monthNumber);

            //if (isValid && monthNumber >= 1 && monthNumber <= 12)
            ////    True                 True                True
            //{
            //    int daysInMonth = monthNumber switch
            //    {
            //        1 => 31,  // Ocak
            //        2 => 28,  // Şubat (artık yıl kontrolü yapılmıyor)
            //        3 => 31,  // Mart
            //        4 => 30,  // Nisan
            //        5 => 31,  // Mayıs
            //        6 => 30,  // Haziran
            //        7 => 31,  // Temmuz
            //        8 => 31,  // Ağustos
            //        9 => 30,  // Eylül
            //        10 => 31, // Ekim
            //        11 => 30, // Kasım
            //        12 => 31, // Aralık
            //        _ => throw new ArgumentOutOfRangeException(nameof(monthNumber), "Geçersiz ay numarası")
            //    };

            //    Console.WriteLine($"Ay {monthNumber} toplam {daysInMonth} gündür.");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz giriş. Lütfen 1 ile 12 arasında bir sayı girin.");
            //}




            //Console.WriteLine("Bir sayı giriniz:");
            //string rakam = Console.ReadLine();
            //int sayi=45;
            //// int.Parse() -> Convert.ToInt32()

            //int.TryParse(rakam, out sayi);

            //Console.WriteLine(sayi);


            #region  Klavyeden iki sayı, bir işlem(+,-,*,/) girilecek. Sayılar girilen işleme göre sonucu ekrana yazdıran switch case.

            //Console.WriteLine("Birinci sayıyı girin: ");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("İkinci sayıyı girin: ");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("İşlemi girin (+, -, *, /): ");
            //string islem = Console.ReadLine();

            //double sonuc;
            //switch (islem)
            //{
            //    case "+": //islem=="+"
            //        sonuc = sayi1 + sayi2;
            //        break;

            //    case "-":
            //        sonuc = sayi1 - sayi2;
            //        break;

            //    case "*":
            //        sonuc = sayi1 * sayi2;
            //        break;

            //    case "/":
            //        if (sayi2 != 0)
            //        {
            //            sonuc = sayi1 / sayi2;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bölme işleminde ikinci sayı sıfır olamaz!");
            //            sonuc = 0; // programı bitir
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz işlem girdiniz!");
            //        sonuc = 0;
            //        break;
            //}

            //Console.WriteLine("Sonuç: " + sonuc);


            #endregion

        }
    }
}
