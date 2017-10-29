using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{
    class BiletNaBasen:Bilet
    {
        public void WyswietlCennikBasen()
        {
            Console.WriteLine("Cena normalna {0}", cenaPodstawowa);
            Console.WriteLine("Cena ulgowa {0}", cenaPodstawowa/2);
        }

        public BiletNaBasen(double p1)
        {
            this.cenaPodstawowa = p1;
        }


    }
}
