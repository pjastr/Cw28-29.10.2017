using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    
    
    class Program
    {
        static string OpiszTyp()
        {
            return "Metoda bez argumentów";
        }
        static string OpiszTyp(int x)
        {
            return "Liczba całkowita";
        }
        static string OpiszTyp(string x)
        {
            return "Łańcuch znaków";
        }
        static string OpiszTyp(int x, int y)
        {
            return "Dwie liczby calkowite";
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(OpiszTyp(5));
            Console.WriteLine(OpiszTyp("ssdssd"));
            Console.WriteLine(OpiszTyp(5,-4));
            Console.WriteLine(OpiszTyp());
            Console.ReadKey();
        }
    }
}
