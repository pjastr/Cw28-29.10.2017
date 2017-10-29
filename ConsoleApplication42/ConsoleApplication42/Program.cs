using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Program
    {
        static void Main(string[] args)
        {

            //Student student1 = new Student("Jan", "Kowalski", 1991, 2, 3, 12345);
            //Console.WriteLine(student1.ObliczWiek());
            //student1.UstawMiejsceZamieszkania("Olsztyn");

            //Osoba student2 = new Student("Jan", "Kowalski", 1991, 2, 3, 12345);
            //student2.WypiszlInfo();

            Student student3 = new Student();
            Osoba osoba3 = student3;
            Student student4 = (Student)osoba3;
            student4.WypiszlInfo();
            Console.ReadKey();
        }
    }
}
