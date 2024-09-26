namespace _11_Otomat_Makinesi
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            /* PERŞEMBE

       Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
      Para girişi yapacak. Girilen para seçilen ürünün fiyatını karşılar ise ürün alındı, aksi durumda para ekle seçeneği ile tekrar para girmesi sağlanacak.

       // Admin => Ürün Ekleyecek, Ürün Silecek, Fiyat Güncelleyecek
     
            */

            string[] products = { "Kola", "Fanta", "Ayran" };
            double[] prices = {     15.5,   15,      9.75 };
            double balance = 0;
            while (true)
            {
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"{i}-{products[i]}:{prices[i]}");
                }

                Console.WriteLine("Seçilen Ürün No:");
                int productNo;
                if (int.TryParse(Console.ReadLine(), out productNo))
                {
                   
                    if (productNo >= 0 && productNo < products.Length)
                    {
                        while (true)
                        {
                            Console.WriteLine("Para Giriniz:");
                            balance += Convert.ToDouble(Console.ReadLine());

                            if (balance >= prices[productNo])
                            {
                                Console.WriteLine($"Afiyet Olsun. Para Üstü:{balance - prices[productNo]}");
                                balance = 0;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye!");
                                Console.WriteLine("1-Para Ekle\n2-Çıkış");
                                string result = Console.ReadLine();
                                if (result != "1")
                                {
                                    Console.Clear();
                                    balance = 0;
                                    break;
                                }

                            }
                        }
                      


                    }
                    else if (productNo == -1)
                    {
                        Console.WriteLine("1-Ürün Ekle\n2-Ürün Güncelle\n3-Ürün Sil");
                        string secim = Console.ReadLine();

                        if (secim == "1") 
                        {
                            Console.WriteLine("Ürün Adı:");
                            string urunAd = Console.ReadLine();
                            Console.WriteLine("Ürün Fiyatı:");
                            double fiyat = Convert.ToDouble(Console.ReadLine());

                            int bosIndex=-1;
                            for (int i = 0; i < products.Length; i++)
                            {
                                if (prices[i] == 0) { bosIndex = i; break; }
                            }

                            if (bosIndex != -1)
                            {
                                products[bosIndex] = urunAd;
                                prices[bosIndex] = fiyat;
                            }
                            else
                            {
                                Array.Resize(ref products, products.Length + 1);
                                Array.Resize(ref prices, prices.Length + 1);

                                products[products.Length-1] = urunAd;
                                prices[prices.Length - 1] = fiyat;
                            }
                            Console.Clear();
                        }
                        else if (secim == "2") 
                        {
                            for (int i = 0; i < products.Length; i++)
                            {
                                Console.WriteLine($"{i}-{products[i]}:{prices[i]}");
                            }

                            Console.WriteLine("Seçilen Ürün No:");
                            int index = Convert.ToInt32(Console.ReadLine());

                            if (index >= 0 && index < products.Length)
                            {
                                Console.WriteLine("Yeni Ürün Adı:");
                                string urunAd = Console.ReadLine();
                                Console.WriteLine("Yeni Ürün Fiyatı:");
                                double fiyat = Convert.ToDouble(Console.ReadLine());

                                products[index] = urunAd;
                                prices[index] = fiyat;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Ürün Numarası!");
                            }
                            Console.Clear();
                        }
                        else if (secim == "3") 
                        {
                            for (int i = 0; i < products.Length; i++)
                            {
                                Console.WriteLine($"{i}-{products[i]}:{prices[i]}");
                            }

                            Console.WriteLine("Seçilen Ürün No:");
                            int index = Convert.ToInt32(Console.ReadLine());

                            if(index>=0 && index < products.Length)
                            {
                                Array.Clear(products, index, 1);
                                Array.Clear(prices, index, 1);
                                Console.Clear();
                                Console.WriteLine("Silme Başarılı");
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Ürün Numarası!");
                            }
                          
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Tuşlama!!");
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Hatalı Ürün Numarası!!");
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ürün Numarasını Rakam Giriniz!!");
                }
            }         
        }
    }
}



