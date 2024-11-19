using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_GenericTypes
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

       
    }
}
