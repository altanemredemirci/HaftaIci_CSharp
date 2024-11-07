namespace _17_OOP_4_Polymorphism_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            Tekstil    : Ad,Fiyat,KumasTuru,Beden,UreticiFirma - KDVUygula(%20)
            CepTelefonu: Ad,Fiyat,Ozellikler,Marka - KDVUygula(%120)
            Ekmek      : Ad,Fiyat,EkmekTuru,Gramaj - KDVUygula(%20)

            Nesne ozelliklerini Contructor method ile alın.

            Sepet : Alınan urunleri bir listeye kaydetsin, Toplamtutarı söylesin

             */


           
            Ekmek ekmek = new Ekmek("Çavdar", 150,"ekmek", 100 );
            CepTelefonu cepTelefonu = new CepTelefonu("Bluetooth","Huawei", "Huawei", 30000);

            Sepet s = new Sepet(); //s object 
            s.Ekle(ekmek);
            s.Ekle(cepTelefonu);

            Console.WriteLine(s.ToplamTutar());
        }
    }

    class Urun
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public Urun(string ad, double fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }

        public virtual double KDVUygula()
        {
            return Fiyat * 1.2;
        }
    }


    //Tekstil    : Ad,Fiyat,KumasTuru,Beden,UreticiFirma - KDVUygula(%20)
    class Tekstil : Urun
    {

        public string KumasTuru { get; set; }
        public string Beden { get; set; }
        public string UreticiFirma { get; set; }

        public Tekstil(string kumasTuru, string beden, string ureticiFirma, string Ad, double Fiyat) : base(Ad, Fiyat)
        {
            KumasTuru = kumasTuru;
            Beden = beden;
            UreticiFirma = ureticiFirma;
        }
    }

    //Ekmek      : Ad,Fiyat,EkmekTuru,Gramaj - KDVUygula(%20)
    class Ekmek : Urun
    {
        public string EkmekTuru { get; set; }
        public int Gramaj { get; set; }

        public Ekmek(string ekmekTuru, int gramaj, string Ad, double Fiyat) : base(Ad, Fiyat)
        {
            EkmekTuru = ekmekTuru;
            Gramaj = gramaj;
        }
    }

    //CepTelefonu: Ad,Fiyat,Ozellikler,Marka - KDVUygula(%120)
    class CepTelefonu : Urun
    {
        public string Ozellikler { get; set; }
        public string Marka { get; set; }

        public CepTelefonu(string ozellikler, string marka, string Ad, double Fiyat) : base(Ad, Fiyat)
        {
            Ozellikler = ozellikler;
            Marka = marka;
        }

        public override double KDVUygula()
        {
            return Fiyat * 2.2;
        }

    }

    class Sepet
    {
        private List<Urun> urunler = new List<Urun>();

        public double ToplamTutar()
        {
            double toplamFiyat = 0;
            foreach (Urun item in urunler)
            {
                toplamFiyat += item.Fiyat;
            }

            return toplamFiyat;
        }

        public void Ekle(Urun urun)
        {
            urun.Fiyat = urun.KDVUygula();
            urunler.Add(urun);
        }
    }
}
