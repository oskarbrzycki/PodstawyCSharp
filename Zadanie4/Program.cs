using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód.
            double a, b;
            Console.WriteLine("Podaj A");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj B");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Obwód = {0}", 2*a+2*b);
            Console.WriteLine("Pole = {0}", a*b);
            Console.ReadKey(true);

        }
    }
}
