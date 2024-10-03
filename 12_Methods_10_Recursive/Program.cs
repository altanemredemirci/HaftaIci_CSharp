namespace _12_Methods_10_Recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyForm();
        }


        static int sayac = 0;

        static void MyForm()
        {
            Console.WriteLine(sayac);

            sayac++;

            if (sayac < 10)
            {
                MyForm();
            }
        }
    }
}
