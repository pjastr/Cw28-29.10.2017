﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class Program
    {
        static void Main(string[] args)
        {
            BiletDoKina kino1 = new BiletDoKina();
            kino1.UstawTrzyD(true);
            BiletDoKina kino2 = new BiletDoKina(5.9, true);
            kino2.UstawTrzyD(false);

            Console.WriteLine(kino1.ObliczCeneDoKina());
            Console.WriteLine(kino2.ObliczCeneDoKina());

            BiletNaBasen basen1 = new BiletNaBasen(15);
            basen1.WyswietlCennikBasen();
            Console.ReadKey();


        }
    }
}
