using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{
    class Program
    {
        static void Main(string[] args)
        {

            BiletDoKina kino1 = new BiletDoKina();
            kino1.TrzyD = true;
            BiletDoKina kino2 = new BiletDoKina(34.2, true);
            kino2.TrzyD = false;
            Console.WriteLine(kino1.ObliczCeneDoKina());
            Console.WriteLine(kino2.ObliczCeneDoKina());

            BiletNaBasen basen1 = new BiletNaBasen(15);
            basen1.WyswietlCennikBasen();

            Console.ReadKey();
        }
    }
}
