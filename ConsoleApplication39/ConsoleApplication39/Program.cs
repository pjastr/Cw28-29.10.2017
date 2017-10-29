using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {

            Matematyka matma = new Matematyka();
            Console.WriteLine(Matematyka.ObwodKola(5));
            Console.ReadKey();
        }
    }

    static class Matematyka
    {
        static double pi = 3.14;

        public static double PoleKola(int r)
        {
            return pi * r * r;
        }

        public static double ObwodKola(int r)
        {
            return pi * r * 2;
        }
    }
}
