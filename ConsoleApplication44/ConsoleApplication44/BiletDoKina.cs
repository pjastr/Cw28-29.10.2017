using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class BiletDoKina:Bilet
    {
        protected bool premiera;
        private bool trzyD;

        public void UstawTrzyD(bool param)
        {
            this.trzyD = param;
        }

        public BiletDoKina()
        {

        }

        public BiletDoKina(double p1, bool p2)
        {
            this.cenaPodstawowa = p1;
            this.premiera = p2;
        }

        public double ObliczCeneDoKina()
        {
            return 5.2;
        }
    }
}
