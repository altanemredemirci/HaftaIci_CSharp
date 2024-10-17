namespace _16_Class_Object_3_Enum
{
    //ENUM: Sabit Veri Tipi
    enum Markalar { Honda=1,Mercedes,BMW,Ford,Renault}
    enum Vitesler { Manuel,Otomatik,YarıOtomatik}
    enum Renkler { Kırmızı,Beyaz,Siyah,Turuncu,Yeşil}

    class Otomobil
    {
        public Markalar Marka;
        public Vitesler Vites;
        public Renkler Renk;
        public int MotorHacmi;
        public int UretimYili;
        public int KapiSayisi;
        public string Model;
        public bool Ceker4;
        public bool ParkSensoru;

        public void OzellikYaz()
        {
            Console.WriteLine(Marka+" "+Vites+" "+Renk+" "+MotorHacmi+" "+Model);
        }
    }
    class Ticari
    {
        public Markalar Marka;
        public Vitesler Vites;
        public Renkler Renk;
        public int MotorHacmi;
        public int UretimYili;
        public int TasimaKapasitesi;
        public int YolcuKapasitesi;
        public bool Ceker4;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Otomobil oto = new Otomobil();
            oto.Marka = Markalar.Ford;
            oto.Vites = Vitesler.Manuel;
            oto.Renk = Renkler.Kırmızı;
            oto.Model = "Kuga";
            oto.KapiSayisi = 4;
            oto.MotorHacmi = 2000;
            oto.ParkSensoru = true;
            oto.UretimYili = 2025;
            oto.Ceker4 = true;

            oto.OzellikYaz();
        }
    }
}
