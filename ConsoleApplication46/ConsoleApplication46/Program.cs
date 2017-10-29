using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication46
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student("Jan", "Kowalski", 1989, 3, 1, 12345);
            //student1.MiejsceZamieszkania = "Olsztyn";
            //Console.WriteLine(student1.ObliczWiek());
            //Console.ReadKey();

            //Osoba student2 = new Student("Jan", "Kowalski", 1989, 3, 1, 12345);
            //student2.WypiszInfo();

            Student student3 = new Student("Jan", "Kowalski", 1989, 3, 1, 12345);
            Osoba osoba3 = student3;
            Student student4 = (Student)osoba3;
            student4.WypiszInfo();
            Console.ReadKey();


        }
    }
}
