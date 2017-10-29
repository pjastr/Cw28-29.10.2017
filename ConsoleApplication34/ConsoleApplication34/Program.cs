using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Matematyka.ObowdKola(4));
            Console.WriteLine(Matematyka.PoleKola(4));

            Console.ReadKey();
        }
    }

    static class Matematyka
    {
        private static double pi = 3.14;

        public static double PoleKola(int r)
        {
            return pi * r * r;
        }

        public static double ObowdKola(int r)
        {
            return pi * r * 2;
        }
    }
}
