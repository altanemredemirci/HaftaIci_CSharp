using System.Runtime.CompilerServices;

namespace _16_Class_Object_this
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen d = new Dikdortgen();
            d.Kaydet(10, 5);
        }
    }
    class Dikdortgen
    {
        public int En;
        public int Boy;

        public void Kaydet(int En,int Boy)
        {
            this.En = En;
            this.Boy = Boy;
        }
    }
}
