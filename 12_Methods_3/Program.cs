namespace _12_Methods_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınacak bir ürün fiyatın KDV uygulayarak yeni fiyatı kullanıcıya gösteriniz
            //KDVUygula=>%20


            //KDV();


            Console.WriteLine("ÜRÜN FİYATI");
            int urunFiyati = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(KDVUygula(urunFiyati));

            /*
             Market Projesi
             Bir markette belirli kategorilerde ürünler ve fiyatları bulunacak
                
                Gıda     => Et,Peynir,Süt 
                Giyim    => Gömlek,TShirt,Etek
                Bujiteri => Ruj,Toka,Kolye
             
             Her kategorinin kendine göre Kdv Oranı olacak
                
                Gıda     %20
                Giyim    %18
                Bujiteri %10
             
             Her alışverişte toplam ödeme tutarı 3000 üzerine çıkar ise kategoriye göre ürüne iskonto yapılacak
                
                Gıda     dan kdv oranından %4
                Giyim    dan kdv oranından %3
                Bujiteri dan kdv oranından %2

             Market müdürü ürünlerin adını,fiyatını ve kdv oranlarını ve düzenleyebilsin.(Ekle,Sil,Güncelle) 
                
             */
        }

        internal static void KDV()
        {
            Console.WriteLine("ÜRÜN FİYATI");
            int urunFiyati = Convert.ToInt32(Console.ReadLine());
            double guncelfiyat = urunFiyati * 1.2;
            Console.WriteLine(guncelfiyat);
        }


        internal static double KDVUygula(int fiyat)
        {          
            double guncelfiyat = fiyat * 1.2;
            return guncelfiyat;
        }
    }
}
