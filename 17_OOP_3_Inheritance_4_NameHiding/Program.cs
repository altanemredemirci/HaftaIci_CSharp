using System.Security.Claims;

namespace _17_OOP_3_Inheritance_4_NameHiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Altan Emre";
            student.Surname = "Demirci";
            student.Class = "12-A";

            student.PropertyWrite();
        }
    }

    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void PropertyWrite()
        {
            Console.WriteLine(Name+" "+Surname);
        }

    }

    class Student:Human
    {
        public string Class { get; set; }

        public new void PropertyWrite()
        {
            Console.WriteLine(Name + " " + Surname+" "+Class);
        }
    }

    class Teacher : Human
    {
        public string Branch { get; set; }

        public new void PropertyWrite()
        {
            Console.WriteLine(Name + " " + Surname + " " + Branch);
        }
    }


}
