namespace _17_OOP_1_Const_ReadOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ConstTest.PiSayisi = 10; // Const alan, değeri değiştirilemez!
            double pi = ConstTest.PiSayisi;

            Console.WriteLine(ConstTest.PiSayisi);
            Console.WriteLine(pi);

            ReadOnlyTest readOnlyTest = new ReadOnlyTest();
            // readOnlyTest.YalnizcaOkunanDeger = 10; // readonly alan, değeri değiştirilemez!
            int sayi = readOnlyTest.YalnizcaOkunanDeger;
            Console.WriteLine(readOnlyTest.YalnizcaOkunanDeger);



        }
    }
}
