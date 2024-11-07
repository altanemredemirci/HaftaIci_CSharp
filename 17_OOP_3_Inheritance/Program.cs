namespace _17_OOP_3_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               // INHERITANCE - KALITIM
            // Ortak özelliklere sahip classların tek bir class üzerinden miras alma yöntemi ile ortak olan özellikleri yazılmadan çekmesine ve sadece kendisine özel olan özellikleri tanımlamasına denir.

            *** Her class TEK BİR CLASS'tan miras(inheritance) alabilir.
            *

             */



            //URS HOLDİNG
            //IK  => TC,Ad,Soyad,Adres,PersonelSayisi
            //PAZ => TC,Ad,Soyad,Adres,MusteriSayisi
            //SAT => TC,Ad,Soyad,Adres,TeklifSayisi
            //MUH => TC,Ad,Soyad,Adres,HesapSayisi
            //IT  => TC,Ad,Soyad,Adres,ProgramSayisi

            //IK ik = new IK();
            //ik.Y
        }
    }



    class Personel //Base Class:Birden fazla class'ın ortak özelliklerini barındırır.
    {
        public int TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public int CocukSayisi { get; set; }

        public void Yaz()
        {
            Console.WriteLine(TC+Ad+Soyad+Adres+CocukSayisi);
        }
    }

    class IK:Personel
    {        
        public int PersonelSayisi{ get; set; }
        public new void Yaz()
        {
            Console.WriteLine(TC + Ad + Soyad + Adres + CocukSayisi + PersonelSayisi);
        }

    }
    class PAZ:Personel
    {       
        public int MusteriSayisi { get; set; }
    }
    class MUH : Personel
    {
        public int HesapSayisi { get; set; }
    }

    class IT : Personel
    {
        public int ProgramSayisi { get; set; }
    }
    class SAT : Personel
    {
        public int TeklifSayisi { get; set; }
    }
}
