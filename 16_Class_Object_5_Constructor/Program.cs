using System.Drawing;

namespace _16_Class_Object_5_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GARBAGE COLLECTOR : Bütün kodlar,değişkenler,methods her yapı RAM Bellek tutulur. Ram bellek belirli bir doluluğa ulaştığında en eski,en az kullanılan veya en kolay tanımlanabilir yapıları siliyor. 

            //CONSTRUCTOR METHOD

            /*
              * Class ile AYNI İSME sahiptir.
              * Herhangi bir dönüş terimi almaz. Void, int, return vb. YOK
              * Default olarak boş şekilde görünmez-gizli tanımlanır.
              * Classtan Instance alındığı an otomatik çalışır.
             */


            Customer customer = new Customer("Altan Emre","Demirci",25);  //Instance - Örneklem 

            #region 1.Yöntem
            //customer.Ad = "Altan";
            //customer.Soyad = "Emre";
            //customer.Yas = 26;
            #endregion


            //2.Yöntem          
            //List<Customer> customers = new List<Customer>();

            //customer.Kaydet(customers);
        }
    }

    class Customer
    {
        internal string Ad;
        internal string Soyad;
        internal int Yas;

        //Gizli-Private 
        //public Customer()
        //{

        //}

        //public Customer()
        //{
        //    Console.WriteLine("Constructor Method Running");
        //}


        public Customer(string ad,string soyad,int yas)
        {
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
        }




        //internal void Kaydet(List<Customer> list)
        //{
        //    Console.WriteLine("Ad:");
        //    Ad = Console.ReadLine();
        //    Console.WriteLine("Soyad:");
        //    Soyad = Console.ReadLine();
        //    Console.WriteLine("Yaş:");
        //    Yas = Convert.ToInt32(Console.ReadLine());

        //    list.Add(this);

        //}
    }
}
