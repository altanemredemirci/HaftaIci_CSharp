namespace _17_OOP_3_Partial_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Partial class fiziksel olarak Personel ve Personel1 adında oluşturulan 2 farklı class'ın adını Personel olarak verip,
            // Partial keyword'ünü kullanarak birleştirip tek bir class gibi davranmalarını sağladı.
            // Her ikisinin de içerisinde bulunan üyeler derleyici tarafında birleştiriliyor.

            Personel personel = new();
            personel.Id = 2;
            personel.Age = 20;
            personel.NameSurname = "Onur Yağız";
            personel.BilgiVer();
            personel.BilgiVer(10);
            personel.Test();
            personel.Deneme();

            Personel personel1 = new Personel("Altan Emre Demirci"); 

        }
    }
}
