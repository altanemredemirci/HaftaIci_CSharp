using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_3_Inheritance_5
{
    internal class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public DateTime SGKGirisTarihi { get; set; }

        public Personel()
        {
            SGKGirisTarihi = DateTime.Now;
        }

        internal void Kayit() //NonStatic
        {
            Console.WriteLine("Id:");
            this.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad:");
            this.Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            this.Soyad = Console.ReadLine();
            Console.WriteLine("TC:");
            this.TC = Console.ReadLine();
            
        }


        //internal static void Kayit(Personel p) //NonStatic
        //{
        //    Console.WriteLine("Id:");
        //    p.Id = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Ad:");
        //    p.Ad = Console.ReadLine();
        //    Console.WriteLine("Soyad:");
        //    p.Soyad = Console.ReadLine();
        //    Console.WriteLine("TC:");
        //    p.TC = Console.ReadLine();
        //    p.SGKGirisTarihi = DateTime.Now.Date;
        //}


    }
}
