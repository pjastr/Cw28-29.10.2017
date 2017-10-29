using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Osoba
    {
        private string imie;

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        private string nazwisko;

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        //public Osoba(string imie, string nazwisko)
        //{
        //    this.imie = imie;
        //    this.nazwisko = nazwisko;
        //}
    }
}
