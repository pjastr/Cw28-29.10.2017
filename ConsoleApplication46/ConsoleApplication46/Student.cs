using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication46
{
    class Student:Osoba
    {
        private int rok;
        private int numerGrupy;
        private int numerAlbumu;

        public Student()
        {

        }

        public Student(string imie, string nazwisko, int rokUrodzenia, int rok, int numerGrupy, int numerAlbumu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }

        public void WypiszInfo()
        {
            //Console.WriteLine("Imię i nazwisko: {0} {1}", imie, nazwisko);
            //Console.WriteLine("Rok urodzenia: {0}", rokUrodzenia);
            base.WypiszInfo();
            Console.WriteLine("Rok: {0}", rok);
            Console.WriteLine("Numer grupy: {0}", numerGrupy);
            Console.WriteLine("Numer albumu: {0}", numerAlbumu);
        }


    }
}
