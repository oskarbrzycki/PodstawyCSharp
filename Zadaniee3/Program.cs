using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniee3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą n (n>2) i wypisujący na ekranie wartość sumy
            //1 + 2 +…+n.Do obliczenia wartości sumy użyj pętli for.
            int n;
            int i; int wynik = 0;
            Console.WriteLine("Podaj liczbe n");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                wynik = wynik + i;
            }
            {

            }
            Console.Write("1 + 2 + ... + {0} = {1}", n, wynik);
            Console.ReadKey(true);
        }
    }
}
