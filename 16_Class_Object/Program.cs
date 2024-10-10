namespace _16_Class_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Description = "açıklama";
            p.Price = 1200;
            p.Rating = 5;
            p.Image = "1.jpg";
            p.CommentCount = 1000;
            p.Id = 1;
            p.Title = "Gömlek";


            Product p2 = new Product();
            p2.Description = "açıklama";
            p2.Price = 1200;
            p2.Rating = 4;
            p2.Image = "2.jpg";
            p2.CommentCount = 2000;
            p2.Id = 2;
            p2.Title = "Laptop";


            Product p3 = new Product()
            {
                Description = "Açıklama",
                Title = "Gözlük",
                Price = 15000
            };

            List<Product> products = new List<Product>();
            products.Add(p);
            products.Add(p2);
            products.Add(p3);


            List<Product> productList = new List<Product>()
            {
                new Product(){Description="Açıklama",Title="Gözlük",Price=15000},
                new Product(){Description="Açıklama",Title="Atkı",Price=15000},
                new Product(){Description="Açıklama",Title="Hırka",Price=15000},
                new Product(){Description="Açıklama",Title="Gömlek",Price=15000},
                new Product(){Description="Açıklama",Title="Etek",Price=15000},
                new Product(){Description="Açıklama",Title="TShirt",Price=15000}
            };


            List<Buzdolabi> buzdolabis = new List<Buzdolabi>()
            {
                new Buzdolabi(){Id=1,Marka="Arçelik",Model="B150",Fiyat=14000,Enerji="E"}
            };
            List<CamasirMakinesi> camasirMakinesis = new List<CamasirMakinesi>()
            {
                new CamasirMakinesi(){Id=2,Marka="Bosch",Model="C108",Fiyat=20000,Kapasite=9}
            };
        }
    }

    class Product
    {
        public int Id;
        public string Title;
        public string Description;
        public int Rating;
        public int CommentCount;
        public double Price;
        public string Image;
    }


    // BeyazEsya:Buzdolabı(Id,Marka,Model,Enerji,Fiyat),Çamaşır Makinesi(Id,Marka,Model,Kapasite,Fiyat)
}
