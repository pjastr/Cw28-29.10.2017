using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{
    class BiletDoKina:Bilet
    {
        protected bool premiera;
        private bool trzyD;

        public bool TrzyD
        {
            get { return trzyD; }
            set { trzyD = value; }
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
            return 6.2;
        }

    }
}
