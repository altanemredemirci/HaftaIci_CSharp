namespace _12_Methods_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot 
            //ve 3.ürün almak isterse 3.ürüne %50 indirim uygulayarak metot ile kodlayınız

            Indirim2();
        }

        static double FiyatKontrol()
        {
            Console.WriteLine("Ürün Fiyatı:");
            double fiyat;
            if(double.TryParse(Console.ReadLine(),out fiyat))
            {
                return fiyat;
            }
            Console.WriteLine("Fiyat değerini rakam olarak giriniz!");
            return FiyatKontrol(); //Recursive Method
        }

        static void Indirim2()
        {            
            double fiyat1 = FiyatKontrol();
            double fiyat2 = FiyatKontrol();

            double toplam = fiyat1 > fiyat2 ? (fiyat1 * 0.7) + fiyat2 : (fiyat2 * 0.7) + fiyat1;

            Console.WriteLine("3.Ürün ister misiniz?(E/H");
            string cevap = Console.ReadLine().ToUpper();

            if (cevap == "E")
            {
                double fiyat3 = FiyatKontrol();
                toplam += fiyat3 *0.5;
            }

            Console.WriteLine("Ödemeniz:"+toplam);
        }
    }
}
