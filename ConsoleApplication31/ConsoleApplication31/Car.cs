using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;

        public readonly static int iloscKol;

        public const int ilscDrzwi=4;

        static Car()
        {
            iloscKol = 4;
        }

        public void UstawMarke(string marka)
        {
            this.marka = marka;
        }

        public void UstawPojemnosc(double poj)
        {
            this.pojemnoscSilnika = poj;
        }

        private Car() //konstruktor domyślny
        {

        }

        private Car(string marka, double pojemnoscSilnika)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;
        }

        public static Car Create(string marka, double pojemnoscSilnika)
        {
            Car temp = new Car(marka, pojemnoscSilnika);
            return temp;
        }

        ~Car()
        {
            Console.WriteLine("Zwalniam pamięć");
            Console.ReadKey();
        }
    }
}
