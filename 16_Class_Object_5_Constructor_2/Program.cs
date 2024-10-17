namespace _16_Class_Object_5_Constructor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            Ogrenci ogrenci2 = new Ogrenci("Yasemin", 23);

        }
    }

    class Ogrenci
    {
        internal int Numara;
        internal string AdSoyad;

        #region Constructor
        //public Ogrenci()
        //{
        //    Console.WriteLine("Ad Soyad:");
        //    AdSoyad = Console.ReadLine();
        //    Console.WriteLine("Numara:");
        //    Numara = Convert.ToInt32(Console.ReadLine());
        //}
        //public Ogrenci()
        //{
        //    Kaydet();
        //}

        //public void Kaydet()
        //{
        //    Console.WriteLine("Ad Soyad:");
        //    AdSoyad = Console.ReadLine();
        //    Console.WriteLine("Numara:");
        //    Numara = Convert.ToInt32(Console.ReadLine());
        //}
        #endregion

        public Ogrenci()
        {
            Console.WriteLine("Kurucu Metot Çalıştı!");
        }

        public Ogrenci(string AdSoyad, int Numara)
        {
            this.AdSoyad = AdSoyad;
            this.Numara = Numara;
        }

    }
}
