using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest
            //dodatnia, ujemna, czy też równa zero.
            int a;
                Console.WriteLine("Podaj A");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0) 
            Console.WriteLine("Liczba {0} to liczba dodatnia", a);
            else if (a < 0)
                Console.WriteLine("Liczba {0} to liczba");
            else
                Console.WriteLine("Liczba {0} jest równa 0", a);
            Console.ReadKey(true);
        }
    }
}
