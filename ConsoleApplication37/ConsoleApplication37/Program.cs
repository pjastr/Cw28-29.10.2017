using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            Bohater bohater1 = new Bohater("Ares", 100);
            Bohater bohater2 = new Bohater("Ork");
            Bohater bohater3 = new Bohater();
            bohater1.zadajCios(10);
            bohater1.zadajCios(15);
            bohater1.zadajCios(17);
            Console.WriteLine(bohater1.Opis());
            Console.ReadKey();
        }
    }
}
