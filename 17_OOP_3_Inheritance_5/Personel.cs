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

        internal void Kayit()
        {
            Console.WriteLine("Id:");
            this.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad:");
            this.Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            this.Soyad = Console.ReadLine();
            Console.WriteLine("TC:");
            this.TC = Console.ReadLine();
            this.SGKGirisTarihi = DateTime.Now.Date;
        }

    }
}
