namespace _16_Class_Object_2_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Buzdolabi> buzdolabis = new List<Buzdolabi>();

            //Ekle overload 1
            //Buzdolabi.Ekle(buzdolabis);          
            //Buzdolabi.Ekle(buzdolabis);
            //Buzdolabi.Ekle(buzdolabis);

            //Ekle overload 2
            buzdolabis.Add(Buzdolabi.Ekle());
            
            var buzdolabi = Buzdolabi.Ekle();
            buzdolabis.Add(buzdolabi);

            //Kaydet overload 1
            //Buzdolabi buzdolabi = new Buzdolabi();
            //overload
            //buzdolabi.Kaydet();
            //buzdolabis.Add(buzdolabi);



            //Kaydet overload 2
            //Buzdolabi buzdolabi = new Buzdolabi();
            //buzdolabi.Kaydet(buzdolabis);



        }
    }
}
