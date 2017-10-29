using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {
            NaszaKlasa obiekt1 = new NaszaKlasa();
            NaszaKlasa obiekt2 = new NaszaKlasa();
            NaszaKlasa obiekt3 = new NaszaKlasa();
            Console.WriteLine(NaszaKlasa.licznik);
            Console.ReadKey();
        }
    }

    class NaszaKlasa
    {
        public static int licznik = 0;


        public NaszaKlasa()
        {
            licznik++;
        }
    }
}
