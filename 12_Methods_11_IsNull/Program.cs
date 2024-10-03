using System.Diagnostics;

namespace _12_Methods_11_IsNull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string.IsNullOrWhiteSpace()==> string ifade içerisinde boş ya da boşluk karakteri kontrolü için kullanılır
            //string .IsNullOrEmpty() ==>string değerin içerisinde null ya da boşluk kontrolü için kullanılır.

            string isim = string.Empty;

            if (string.IsNullOrEmpty(isim))
            {
                Console.WriteLine("isim boştur");
            }
            if (string.IsNullOrWhiteSpace(isim))
            {
                Console.WriteLine("isim boşluk var");
            }
        }
    }
}
