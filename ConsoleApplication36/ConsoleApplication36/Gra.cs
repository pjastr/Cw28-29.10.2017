using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Gra
    {
        public string nazwa;
        public float cena;
        private int pegi;

        public int Promocja()
        {
            return 10;
        }

        public void Kupuje(int liczba)
        {
            Console.WriteLine("Kupiono {0} sztuk", liczba);
        }

        public void UstawPegi(int pegi)
        {
            this.pegi = pegi;
        }
    }
}
