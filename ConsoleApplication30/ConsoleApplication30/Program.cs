using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            Autobus autobus1 = new Autobus();
            autobus1.liczbaPasazerow = 55;
            autobus1.nieskopodlogowy = false;
            autobus1.UstawModel("ssd2323");
            autobus1.CenaBiletu(true);
            autobus1.KontrolaBiletu();
        }
    }
}
