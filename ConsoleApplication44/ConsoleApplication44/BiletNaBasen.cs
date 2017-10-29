using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class BiletNaBasen:Bilet
    {
        public void WyswietlCennikBasen()
        {
            Console.WriteLine("Bilet normalny {0}", cenaPodstawowa);
            Console.WriteLine("Bilet ulgowy {0}", cenaPodstawowa / 2);
        }

        public BiletNaBasen(double param)
        {
            this.cenaPodstawowa = param;
        }
    }
}
