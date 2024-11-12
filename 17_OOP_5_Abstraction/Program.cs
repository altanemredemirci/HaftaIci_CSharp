using System.Linq.Expressions;

namespace _17_OOP_5_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ABSTRACT NEDİR?*/
            /*Abstract class’lar, oluşturulması istenen class’ların sadece base class olarak davranması
             * ve üzerinden bir instance oluşturulmamasının istendiği durumlarda kullanılır. 
             * C#’da bu fonksiyonaliteyi sağlamak için abstract anahtar sözcüğünü kullanmak yeterlidir. */

            //Insan insan = new Insan(); //Abstract tanımlı bir class instance alınamaz.Çünkü tanımlanma amacı BASE CLASS olmaktır.

            Ogrenci ogrenci = new Ogrenci();
            
        }
    }

    abstract class Insan //base class: Proje kullanılan ortak field ları tutan class
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TC { get; set; }

        //Her class'ın çoğunlukla sahip olması gereken metotlar vardır.
        //  *Insert(), Update(), Delete(), List(), Find(id), List(Expression)

        public  void Kayit()
        {
            Console.WriteLine("Adınız:");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyadınız:");
            Console.WriteLine("TC:");
        }

        //Miras alınan bütün class'^ların hepsinde bu metotların olmasını istiyoruz ama metot gövdesini(içini-kodunu) yazmıyoruz. Çünkü türeyen her class bu metotları kendince tanımlayacak.

        public abstract void Insert();
        public abstract void List();
        public abstract void Update();
        public abstract void Delete();
        public abstract void Find();
        public abstract void List(Expression expression);
    }

    class Ogrenci : Insan  //Inheritance - Kalıtım
    {
        public int Numara { get; set; }
        public string Sinif { get; set; }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Find()
        {
            throw new NotImplementedException();
        }

        public override void Insert()
        {
            throw new NotImplementedException();
        }

        public override void List()
        {
            throw new NotImplementedException();
        }

        public override void List(Expression expression)
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }

    class Ogretmen : Insan  //Inheritance - Kalıtım
    {
        public string Brans { get; set; }
        public double Maas { get; set; }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Find()
        {
            throw new NotImplementedException();
        }

        public override void Insert()
        {
            throw new NotImplementedException();
        }

        public override void List()
        {
            throw new NotImplementedException();
        }

        public override void List(Expression expression)
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
