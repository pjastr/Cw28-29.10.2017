using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Pacjent:Osoba
    {
        private int wiek;

        public Pacjent(string imie, string nazwisko, int wiek)
        {
            this.wiek = wiek;
            this.Imie = imie;
            this.Nazwisko = nazwisko;
        }
    }
}
