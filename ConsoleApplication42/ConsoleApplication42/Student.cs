using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Student : Osoba
    {
        private int rok;
        private int numerGrupy;
        private int numerAlbumu;

        public Student()
        {

        }

        public Student(string imie, string nazwisko, int rokUrodzenia, int rok, int numerGrupy, int numerAlbumu)
            //:base(imie,nazwisko,rokUrodzenia)
        {
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            
        }

        public void WypiszlInfo()
        {
            base.WypiszlInfo(); //wywolujemy metody z klasy bazowej
            Console.WriteLine("Rok studiów: {0}", rok);
            Console.WriteLine("Numer grupy: {0}", numerGrupy);
            Console.WriteLine("Numer albumu: {0}", numerAlbumu);
        }
    }
}
