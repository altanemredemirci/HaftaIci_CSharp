using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Class_Object_2_Methods
{
    internal class Buzdolabi
    {
        public int Id;
        public string Marka;
        public string Model;
        public string Enerji;
        public double Fiyat;

        public static void Ekle(List<Buzdolabi> list)
        {
            Buzdolabi b = new Buzdolabi();
            Console.Write("Marka:");
            b.Marka = Console.ReadLine();
            Console.Write("Model:");
            b.Model = Console.ReadLine();
            Console.Write("Enerji:");
            b.Enerji = Console.ReadLine();
            Console.Write("Fiyat:");
            b.Fiyat =Convert.ToDouble(Console.ReadLine());
            list.Add(b);
        }

        public static Buzdolabi Ekle()
        {
            Buzdolabi b = new Buzdolabi();
            Console.Write("Marka:");
            b.Marka = Console.ReadLine();
            Console.Write("Model:");
            b.Model = Console.ReadLine();
            Console.Write("Enerji:");
            b.Enerji = Console.ReadLine();
            Console.Write("Fiyat:");
            b.Fiyat = Convert.ToDouble(Console.ReadLine());
            return b;
        }
        public void Kaydet()
        {
            Console.Write("Marka:");
            Marka = Console.ReadLine();
            Console.Write("Model:");
            Model = Console.ReadLine();
            Console.Write("Enerji:");
            Enerji = Console.ReadLine();
            Console.Write("Fiyat:");
            Fiyat = Convert.ToDouble(Console.ReadLine());          
        }

        public void Kaydet(List<Buzdolabi> list)
        {
            Console.Write("Marka:");
            Marka = Console.ReadLine();
            Console.Write("Model:");
            Model = Console.ReadLine();
            Console.Write("Enerji:");
            Enerji = Console.ReadLine();
            Console.Write("Fiyat:");
            Fiyat = Convert.ToDouble(Console.ReadLine());
            list.Add(this);
        }       

    }
}
