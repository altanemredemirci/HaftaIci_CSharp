namespace _17_OOP_5_Abstraction_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*AÇIKLAMA*/
            /*
              1- Abstract olarak işaretlenen FiyatHesapla() metodunun gövdesi abstract olarak işaretlendiği sınıfta kodlanamaz.

              2- Abstract olan ElektronikEsya sınıfından türetilen sınıflar, ElektronikEsya’nın abstract üyelerini içermek zorundadır.


              Bir oop tasarımında, sınıf içerisinde abstract üyeler tanımlayarak, bu sınıftan türetilen sınıfları, tanımladığımız abstact üyelerin gövdelerini kodlamaya zorlayabiliriz. 
              Örneğimiz üzerinden bir cümle kuracak olursak bir nevi şunu demiş oluruz: “Eğer sen bir elektronik eşya isen, fiyatını hesaplayabileceğim bir metodu bana sunmak zorundasın.”

              Kaldığımız yerden devam edersek kodun son hali aşağıdaki gibi olacaktır. Bilgisayar fiyatı hesaplanırken ek bir masraf alındığını farz edelim.
            */
        }
    }

    abstract class ElektronikEsya
    {
        public double AlisFiyati { get; set; }
        public double KarYuzdesi { get; set; }

        public abstract double FiyatHesapla();
    }

    class Telefon : ElektronikEsya
    {
        public override double FiyatHesapla()
        {
            return AlisFiyati + (AlisFiyati * KarYuzdesi);
        }
    }

    class Bilgisayar : ElektronikEsya
    {
        public double EkMasraf { get; set; }

        public override double FiyatHesapla()
        {
            return AlisFiyati + (AlisFiyati * KarYuzdesi)+EkMasraf;
        }
    }

    class Tablet:ElektronikEsya
    {
        public double Kilif { get; set; }

        public override double FiyatHesapla()
        {
            return Kilif + AlisFiyati + (AlisFiyati * KarYuzdesi);
        }
    }

}
