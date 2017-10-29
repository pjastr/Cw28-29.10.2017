using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {
            var gra1 = new Gra();
            gra1.nazwa = "sasdssd";
            gra1.cena = 3443.333f;
            gra1.UstawPegi(18);

            gra1.Promocja();
            gra1.Kupuje(444);
        }
    }
}
