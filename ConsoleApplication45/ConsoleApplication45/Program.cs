using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car auto = new Car();
            //auto.UstawMarke("Fiat");
            //auto.UstawPojemnosc(3.3);

            //Car auto2 = new Car("Ford", 4.3);

            Car auto3 = Car.Create("Honda", 5.2);
            //Car.iloscKol = 5;
            //Car.iloscDrzwi = 7;
            Car auto4 = Car.Create("Fiat", 4.2);
        }
    }
}
