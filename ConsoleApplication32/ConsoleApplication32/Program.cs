using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            Bohater bohater1 = new Bohater(80, "Ares");
            bohater1.ZadajCios(23);
            Console.WriteLine(bohater1.Opis());
            bohater1.ZadajCios(44);
            bohater1.ZadajCios(22);
            Console.WriteLine("Czy żyje? {0}", bohater1.Stan());
            bohater1.ZadajCios(23);
            bohater1.ZadajCios(44);
            bohater1.ZadajCios(22);

            

            Console.ReadKey();
        
        
        
        
        }
    }
}
