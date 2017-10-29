using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car auto = new Car();
            //auto.UstawMarke("Skoda");
            //auto.UstawPojemnosc(5.2);

            //Car auto2 = new Car("Fiat", 4.7);

            Car auto3 = Car.Create("Ford", 4.8);
            //Car.iloscKol = 6;
            //Car.ilscDrzwi = 7;
            Car auto4 = Car.Create("Honda", 4.9);
        }
    }
}
