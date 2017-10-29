using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Autobus
    {
        private string model;
        public int liczbaPasazerow;
        public bool nieskopodlogowy;

        public double CenaBiletu(bool parametr)
        {
            return 10.2;
        }

        public bool KontrolaBiletu()
        {
            return true;
        }

        public void UstawModel(string model)
        {
            this.model = model;
        }
    }
}
