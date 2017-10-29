using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;
        public readonly static int iloscKol;

        public const int iloscDrzwi=4;

        static Car()
        {
            iloscKol = 4;
        }

        public void UstawPojemnosc(double poj)
        {
            this.pojemnoscSilnika = poj;
        }

        public void UstawMarke(string marka)
        {
            this.marka = marka;
        }

        private Car()
        {

        }

        private Car(string marka, double poj)
        {
            this.marka = marka;
            this.pojemnoscSilnika = poj;
        }

        public static Car Create(string marka, double poj)
        {
            Car temp = new Car(marka, poj);
            return temp;
        }

        ~Car()
        {
            Console.WriteLine("Zwalniam pamięć");
            Console.ReadKey();
        }
    }
}
